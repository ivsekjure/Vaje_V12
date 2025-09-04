using System.Data.SQLite;

namespace UstvariINVstaviFilme
{
    public class BazaInit
    {
        public static void UstvariBazo(string pot_baza)
        {
            if (!File.Exists(pot_baza)) File.Create(pot_baza).Close();

            using var pov = new SQLiteConnection($"Data Source={pot_baza}");
            pov.Open();

            // Tabela z 'ocena'
            using (var cmd = pov.CreateCommand())
            {
                cmd.CommandText = @"
                   CREATE TABLE IF NOT EXISTS filmi (
				      id INTEGER PRIMARY KEY AUTOINCREMENT, 
                      reziser TEXT,
                      naslov  TEXT NOT NULL,
                      leto    INTEGER NOT NULL,
                      ocena   REAL DEFAULT 0
                   );";
                cmd.ExecuteNonQuery();
            }

            // Če je stara tabela brez 'ocena', jo dodaj
            using (var cmd = pov.CreateCommand())
            {
                cmd.CommandText = "PRAGMA table_info(filmi);";
                using var r = cmd.ExecuteReader();
                bool hasOcena = false;
                while (r.Read())
                    if (r.GetString(1).Equals("ocena", StringComparison.OrdinalIgnoreCase))
                        hasOcena = true;

                if (!hasOcena)
                {
                    using var alter = pov.CreateCommand();
                    alter.CommandText = "ALTER TABLE filmi ADD COLUMN ocena REAL DEFAULT 0;";
                    alter.ExecuteNonQuery();
                }
            }

            // Seed, če prazno
            using (var cmd = pov.CreateCommand())
            {
                cmd.CommandText = "SELECT COUNT(*) FROM filmi;";
                long c = (long)cmd.ExecuteScalar();
                if (c == 0)
                {
                    cmd.CommandText = @"
                        INSERT INTO filmi (reziser, naslov, leto) VALUES 
                        ('Christopher Nolan', 'Inception', 2010),
                        ('Peter Jackson', 'The Lord of the Rings: The Fellowship of the Ring', 2001),
                        ('Bong Joon-ho', 'Parasite', 2019),
                        ('Francis Ford Coppola', 'The Godfather', 1972),
                        ('Quentin Tarantino', 'Pulp Fiction', 1994),
                        ('Steven Spielberg', 'Schindler''s List', 1993),
                        ('James Cameron', 'Titanic', 1997),
                        ('Ridley Scott', 'Gladiator', 2000),
                        ('Martin Scorsese', 'The Departed', 2006),
                        ('Denis Villeneuve', 'Dune', 2021),
                        ('Christopher Nolan', 'Oppenheimer', 2023),
                        ('Greta Gerwig', 'Barbie', 2023),
                        ('Denis Villeneuve', 'Dune: Part Two', 2024),
                        ('Edward Berger', 'All Quiet on the Western Front', 2022),
                        ('Daniel Kwan & Daniel Scheinert', 'Everything Everywhere All at Once', 2022)";
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}