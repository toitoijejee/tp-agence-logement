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
                Console.WriteLine($"Erreur inattendue : {ex.Message}");
            }

            try
            {
                Logement log2 = new Logement("L002", "456 Rue des Lilas", -10, 500.0, true);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erreur (attendu) : {ex.Message}");
            }

            try
            {
                Logement log3 = new Logement("L003", "789 Avenue Foch", 30, -100.0, true);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erreur (attendu) : {ex.Message}");
            }
        }
    }
}
