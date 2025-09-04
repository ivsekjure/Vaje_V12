namespace FilmiUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PrikazPodatkov = new DataGridView();
            bazaInitBindingSource = new BindingSource(components);
            buttonOsvezi = new Button();
            buttonShrani = new Button();
            groupBoxFilter = new GroupBox();
            label5 = new Label();
            nudDelta = new NumericUpDown();
            label6 = new Label();
            buttonOceni = new Button();
            nudLetnica = new NumericUpDown();
            groupBoxDodajFilm = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            textBoxReziser = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBoxNaslov = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PrikazPodatkov).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bazaInitBindingSource).BeginInit();
            groupBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDelta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLetnica).BeginInit();
            groupBoxDodajFilm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // PrikazPodatkov
            // 
            PrikazPodatkov.AutoGenerateColumns = false;
            PrikazPodatkov.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PrikazPodatkov.DataSource = bazaInitBindingSource;
            PrikazPodatkov.Location = new Point(12, 12);
            PrikazPodatkov.Name = "PrikazPodatkov";
            PrikazPodatkov.Size = new Size(500, 405);
            PrikazPodatkov.TabIndex = 0;
            // 
            // buttonOsvezi
            // 
            buttonOsvezi.Location = new Point(12, 423);
            buttonOsvezi.Name = "buttonOsvezi";
            buttonOsvezi.Size = new Size(75, 23);
            buttonOsvezi.TabIndex = 1;
            buttonOsvezi.Text = "Osvezi";
            buttonOsvezi.UseVisualStyleBackColor = true;
            buttonOsvezi.Click += buttonOsvezi_Click;
            // 
            // buttonShrani
            // 
            buttonShrani.Location = new Point(167, 199);
            buttonShrani.Name = "buttonShrani";
            buttonShrani.Size = new Size(75, 23);
            buttonShrani.TabIndex = 2;
            buttonShrani.Text = "Shrani";
            buttonShrani.UseVisualStyleBackColor = true;
            buttonShrani.Click += buttonShrani_Click;
            // 
            // groupBoxFilter
            // 
            groupBoxFilter.Controls.Add(label5);
            groupBoxFilter.Controls.Add(nudDelta);
            groupBoxFilter.Controls.Add(label6);
            groupBoxFilter.Controls.Add(buttonOceni);
            groupBoxFilter.Controls.Add(nudLetnica);
            groupBoxFilter.Location = new Point(518, 12);
            groupBoxFilter.Name = "groupBoxFilter";
            groupBoxFilter.Size = new Size(254, 166);
            groupBoxFilter.TabIndex = 3;
            groupBoxFilter.TabStop = false;
            groupBoxFilter.Text = "Oceni";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 86);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 9;
            label5.Text = "Ocena";
            // 
            // nudDelta
            // 
            nudDelta.DecimalPlaces = 1;
            nudDelta.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudDelta.Location = new Point(71, 78);
            nudDelta.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudDelta.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            nudDelta.Name = "nudDelta";
            nudDelta.Size = new Size(120, 23);
            nudDelta.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 39);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 8;
            label6.Text = "Leto";
            // 
            // buttonOceni
            // 
            buttonOceni.Location = new Point(173, 137);
            buttonOceni.Name = "buttonOceni";
            buttonOceni.Size = new Size(75, 23);
            buttonOceni.TabIndex = 1;
            buttonOceni.Text = "Oceni";
            buttonOceni.UseVisualStyleBackColor = true;
            buttonOceni.Click += buttonOceni_Click;
            // 
            // nudLetnica
            // 
            nudLetnica.Location = new Point(71, 31);
            nudLetnica.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            nudLetnica.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            nudLetnica.Name = "nudLetnica";
            nudLetnica.Size = new Size(120, 23);
            nudLetnica.TabIndex = 0;
            nudLetnica.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            // 
            // groupBoxDodajFilm
            // 
            groupBoxDodajFilm.Controls.Add(label4);
            groupBoxDodajFilm.Controls.Add(label3);
            groupBoxDodajFilm.Controls.Add(buttonShrani);
            groupBoxDodajFilm.Controls.Add(numericUpDown1);
            groupBoxDodajFilm.Controls.Add(numericUpDown2);
            groupBoxDodajFilm.Controls.Add(textBoxReziser);
            groupBoxDodajFilm.Controls.Add(label2);
            groupBoxDodajFilm.Controls.Add(label1);
            groupBoxDodajFilm.Controls.Add(textBoxNaslov);
            groupBoxDodajFilm.Location = new Point(524, 218);
            groupBoxDodajFilm.Name = "groupBoxDodajFilm";
            groupBoxDodajFilm.Size = new Size(248, 228);
            groupBoxDodajFilm.TabIndex = 4;
            groupBoxDodajFilm.TabStop = false;
            groupBoxDodajFilm.Text = "Dodaj film";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 169);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 7;
            label4.Text = "Ocena";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 122);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 6;
            label3.Text = "Leto";
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 1;
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown1.Location = new Point(65, 161);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(65, 114);
            numericUpDown2.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 4;
            numericUpDown2.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            // 
            // textBoxReziser
            // 
            textBoxReziser.Location = new Point(65, 65);
            textBoxReziser.Name = "textBoxReziser";
            textBoxReziser.Size = new Size(177, 23);
            textBoxReziser.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 73);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Režiser";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Naslov";
            // 
            // textBoxNaslov
            // 
            textBoxNaslov.Location = new Point(65, 22);
            textBoxNaslov.Name = "textBoxNaslov";
            textBoxNaslov.Size = new Size(177, 23);
            textBoxNaslov.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 465);
            Controls.Add(groupBoxDodajFilm);
            Controls.Add(groupBoxFilter);
            Controls.Add(buttonOsvezi);
            Controls.Add(PrikazPodatkov);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PrikazPodatkov).EndInit();
            ((System.ComponentModel.ISupportInitialize)bazaInitBindingSource).EndInit();
            groupBoxFilter.ResumeLayout(false);
            groupBoxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDelta).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLetnica).EndInit();
            groupBoxDodajFilm.ResumeLayout(false);
            groupBoxDodajFilm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView PrikazPodatkov;
        private Button buttonOsvezi;
        private Button buttonShrani;
        private BindingSource bazaInitBindingSource;
        private GroupBox groupBoxFilter;
        private NumericUpDown nudDelta;
        private Button buttonOceni;
        private NumericUpDown nudLetnica;
        private GroupBox groupBoxDodajFilm;
        private TextBox textBoxReziser;
        private Label label2;
        private Label label1;
        private TextBox textBoxNaslov;
        private Label label4;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label5;
        private Label label6;
    }
}
