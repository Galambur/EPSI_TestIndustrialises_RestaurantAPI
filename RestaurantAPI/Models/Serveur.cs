using System.Collections.Generic;

namespace RestaurantAPI.Controllers
{
    public class Serveur
    {
        public IList<Commande> commandes { get; set; }

        /*public Serveur()
        {
            this.commandes = new List<Commande>();
        }

        public Serveur(IList<Commande> commandes)
        {
            this.commandes = commandes;
        }

        public double getChiffreDAffaire()
        {
            double chiffreDaffaire = 0;
            foreach(var commande in commandes)
            {
                chiffreDaffaire = chiffreDaffaire + commande.montant;
            }
            return chiffreDaffaire;
        }

        public void PrendCommande(Commande commande)
        {
            this.commandes.Add(commande);
        }

        public IList<Commande> GetCommandes()
        {
            return commandes;
        }*/
    }
}
