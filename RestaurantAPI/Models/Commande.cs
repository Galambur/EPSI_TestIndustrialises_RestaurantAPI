using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantAPI.Controllers
{
    public class Commande
    {
        public double montant { get; set; }
        public IList<Plat> listePlat { get; set; }

        public static readonly string[] _nomsPlats = new[]
        {
            "Hamburger", "Salade cesar", "Hot dog", "Empanadas", "Nouilles", "Pizza", "Boeuf"
        };/*

        public Commande(double montant)
        {
            var rng = new Random();
            this.montant = montant;
            this.listePlat = Enumerable.Range(1, 3).Select(index => new Plat { 
                Nom = _nomsPlats[rng.Next(_nomsPlats.Length)],
                Prix = rng.Next(0, 25) + rng.NextDouble()
            }).ToArray();
        } */
    }
}
