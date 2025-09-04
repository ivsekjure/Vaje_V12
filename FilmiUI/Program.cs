using UstvariINVstaviFilme;

namespace FilmiUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Izberi ENO pot (po želji spremeni)
            string dbPath = @"C:\Users\JureIvsek\Documents\OneDrive - IN516HT D.O.O\Desktop\Faks\Prog3\Vaje_V12\FilmiUI\Filmi.db";

            // Ustvari/posodobi shemo (tudi doda 'ocena', ?e manjka)
            BazaInit.UstvariBazo(dbPath);

            // Posreduj isti dbPath v Form1
            Application.Run(new Form1(dbPath));
        }
    }
}
