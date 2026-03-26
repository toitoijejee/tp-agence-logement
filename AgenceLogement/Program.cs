using System;

namespace AgenceLogement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Test du calcul des loyers spécifiques ---");

            try
            {
                Studio studio = new Studio("S001", "10 Rue de la Gare", 20, 450.0, true, true);
                
                Appartement appt = new Appartement("A001", "5 Avenue des Arts", 75, 900.0, true, 3);
                
                Maison maison = new Maison("M001", "2 Chemin du Moulin", 120, 1500.0, true, 200);

                studio.Afficher();
                double loyerStudio = studio.CalculerLoyer();
                Console.WriteLine($"Loyer final : {loyerStudio} €");

                appt.Afficher();
                double loyerAppt = appt.CalculerLoyer();
                Console.WriteLine($"Loyer final : {loyerAppt} €");

                maison.Afficher();
                double loyerMaison = maison.CalculerLoyer();
                Console.WriteLine($"Loyer final : {loyerMaison} €");

                Console.WriteLine($"L'appartement coûte {loyerAppt - loyerStudio} € de plus que le studio.");
                Console.WriteLine($"La maison coûte {loyerMaison - loyerAppt} € de plus que l'appartement.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors des tests : {ex.Message}");
            }
        }
    }
}
