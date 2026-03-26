using System;

namespace AgenceLogement
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Logement log1 = new Logement("L001", "123 Rue de la Paix", 50, 600.0, true);
                log1.Afficher();
                Console.WriteLine($"Loyer calculé : {log1.CalculerLoyer()} €");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur Logement : {ex.Message}");
            }


            try
            {
                Studio studio = new Studio("S001", "10 Rue de la Gare", 20, 450.0, true, true);
                studio.Afficher();
                Console.WriteLine($"Loyer calculé : {studio.CalculerLoyer()} €");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur Studio : {ex.Message}");
            }

            try
            {
                Appartement appt = new Appartement("A001", "5 Avenue des Arts", 75, 900.0, true, 3);
                appt.Afficher();
                Console.WriteLine($"Loyer calculé : {appt.CalculerLoyer()} €");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur Appartement : {ex.Message}");
            }

            try
            {
                Maison maison = new Maison("M001", "2 Chemin du Moulin", 120, 1500.0, true, 200);
                maison.Afficher();
                Console.WriteLine($"Loyer calculé : {maison.CalculerLoyer()} €");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur Maison : {ex.Message}");
            }


            try
            {
                Logement logInvalide = new Logement("LXXX", "Inconnu", -10, 500.0, true);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erreur (attendu) : {ex.Message}");
            }

            try
            {
                Appartement apptInvalide = new Appartement("A999", "Inconnu", 50, 500.0, true, 0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erreur (attendu) : {ex.Message}");
            }

            try
            {
                Maison maisonInvalide = new Maison("M999", "Inconnu", 100, 1000.0, true, -50);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erreur (attendu) : {ex.Message}");
            }
        }
    }
}
