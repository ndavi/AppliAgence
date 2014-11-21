using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace Metier
{
    public class Voiture
    {
        #region Accesseurs
        private string categorie;
        private DateTime dateMiseService;
        private bool estLouee;
        private string immatriculation;
        private Personne loueur;
        private string nom;
        private double puissance;

        [DataMember]
        [XmlElement("Nom")]
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        [DataMember]
        [XmlElement("Categorie")]
        public string Categorie
        {
            get { return categorie; }
            set { categorie = value; }
        }
        [DataMember]
        [XmlElement("DateMiseService")]
        public DateTime DateMiseService
        {
            get { return dateMiseService; }
            set { dateMiseService = value; }
        }
        [DataMember]
        [XmlElement("EstLouee")]
        public bool EstLouee
        {
            get { return estLouee; }
            set { estLouee = value; }
        }
        [DataMember]
        [XmlElement("Immatriculation")]
        public string Immatriculation
        {
            get { return immatriculation; }
            set { immatriculation = value; }
        }
        [DataMember]
        [XmlElement("Loueur",typeof(Personne))]
        internal Personne Loueur
        {
            get { return loueur; }
            set { loueur = value; }
        }
        [DataMember]
        [XmlElement("Puissance")]
        public double Puissance
        {
            get { return puissance; }
            set { puissance = value; }
        }
        #endregion

        public Voiture()
        {

        }
        public Voiture(String nom,String categorie,Double puissance,String immatriculation,Boolean estLouee,DateTime dateMiseEnService)
        {
            this.nom = nom;
            this.categorie = categorie;
            this.puissance = puissance;
            this.immatriculation = immatriculation;
            this.estLouee = estLouee;
            this.Loueur = new Personne();
            this.dateMiseService = dateMiseEnService;

        }

    }
}
