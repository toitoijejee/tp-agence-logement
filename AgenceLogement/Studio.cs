using System;

namespace AgenceLogement
{
    public class Studio : Logement
    {
        private bool meuble;

        public Studio(string reference, string adresse, int surface, double loyerBase, bool disponible, bool meuble)
            : base(reference, adresse, surface, loyerBase, disponible)
        {
            this.meuble = meuble;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine($"Type : Studio");
            Console.WriteLine($"Meublé : {(meuble ? "Oui" : "Non")}");
        }

        public override double CalculerLoyer()
        {
            return base.CalculerLoyer() + (meuble ? 50 : 0);
        }
    }
}
