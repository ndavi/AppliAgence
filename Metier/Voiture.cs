using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    class Voiture
    {
        #region Accesseurs
        private string categorie;
        private DateTime dateMiseService;
        private bool estLouee;
        private string immatriculation;
        private Personne loueur;
        private string nom;
        private double puissance;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Categorie
        {
            get { return categorie; }
            set { categorie = value; }
        }
        public DateTime DateMiseService
        {
            get { return dateMiseService; }
            set { dateMiseService = value; }
        }
        public bool EstLouee
        {
            get { return estLouee; }
            set { estLouee = value; }
        }
        public string Immatriculation
        {
            get { return immatriculation; }
            set { immatriculation = value; }
        }
        internal Personne Loueur
        {
            get { return loueur; }
            set { loueur = value; }
        }
        public double Puissance
        {
            get { return puissance; }
            set { puissance = value; }
        }
        #endregion

        public Voiture()
        {

        }

    }
}
