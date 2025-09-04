using System.Data;
using System.Data.SQLite;
using UstvariINVstaviFilme;

namespace FilmiUI
{
    public partial class Form1 : Form
    {
        private readonly string dbPath;

        private SQLiteConnection conn = default!;
        private SQLiteDataAdapter da = default!;
        private DataTable dt = default!;
        private SQLiteCommandBuilder cmd = default!;

        public Form1(string dbPath)
        {
            InitializeComponent();
            this.dbPath = dbPath;

            // dogodke lahko vezes tukaj ali v Designerju
            buttonOsvezi.Click += buttonOsvezi_Click;

            try
            {
                BazaInit.UstvariBazo(dbPath);
                InitAdapter("SELECT id, reziser, naslov, leto, ocena FROM filmi ORDER BY leto DESC, naslov;");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Napaka pri nalaganju");
            }
        }

        /// <summary>
        /// Vzpostavi povezavo in SQLAdapter za podani SELECT stavek. Napolni DataTable in jo veže na DataGridView za prikaz podatkov.
        /// </summary>
        /// <param name="selectSql"></param>
        private void InitAdapter(string selectSql)
        {
            conn = new SQLiteConnection($"Data Source={dbPath}");
            da = new SQLiteDataAdapter(selectSql, conn);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            cmd = new SQLiteCommandBuilder(da);

            dt = new DataTable();
            da.Fill(dt);

            PrikazPodatkov.AutoGenerateColumns = true;
            PrikazPodatkov.DataSource = dt;


            if (PrikazPodatkov.Columns["id"] != null)
            {
                PrikazPodatkov.Columns["id"].Visible = false;
            }
        }


        /// <summary>
        /// Osvezi DataGridView z klicem metode InitAdapter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOsvezi_Click(object sender, EventArgs e)
        {
            InitAdapter("SELECT id, reziser, naslov, leto, ocena FROM filmi ORDER BY leto DESC, naslov;");
        }

        /// <summary>
        /// Shrani spremembe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Shrani()
        {
            try
            {
                da.Update(dt);
                MessageBox.Show("Spremembe shranjene.", "OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka pri shranjevanju: " + ex.Message, "Napaka");
            }
        }

        /// <summary>
        /// Povecaj/zmanjsaj ocene vsem filmom iz izbrane letnice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOceni_Click(object sender, EventArgs e)
        {
            int leto = (int)nudLetnica.Value;
            double delta = (double)nudDelta.Value;

            var rows = dt.Select($"leto = {leto}");
            if (rows.Length == 0)
            {
                MessageBox.Show("Ni filmov za izbrano letnico.");
                return;
            }

            foreach (var r in rows)
            {
                double oc = r["ocena"] == DBNull.Value ? 0 : Convert.ToDouble(r["ocena"]);
                r["ocena"] = oc + delta;
            }
        }

        /// <summary>
        /// Doda nov film v bazo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShrani_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNaslov.Text))
            {
                MessageBox.Show("Naslov je obvezen.");
                return;
            }

            var r = dt.NewRow();
            r["naslov"] = textBoxNaslov.Text.Trim();
            r["reziser"] = textBoxReziser.Text.Trim();
            r["leto"] = (int)nudLetnica.Value;
            r["ocena"] = (double)nudDelta.Value;
            dt.Rows.Add(r);

            textBoxNaslov.Clear();
            textBoxReziser.Clear();
            nudLetnica.Value = DateTime.Now.Year;
            nudDelta.Value = 0;

            Shrani();
        }
    }
}
