using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Metier
{
    public class Personne
    {
        #region Attributs
        private int id;
        private string nom, prenom, ville;
        #endregion

        #region Getteur and setteur
        [DataMember]
        [XmlElement("Id")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [DataMember]
        [XmlElement("Ville")]

        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }
        [DataMember]
        [XmlElement("Prenom")]
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        [DataMember]
        [XmlElement("Nom")]
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        #endregion

        #region Contructeur
        public Personne()
        {

        }
        /// <summary>
        /// Instancie une nouvelle personne
        /// </summary>
        /// <param name="nom">Nom de la personne</param>
        /// <param name="prenom">Prénom de la personne</param>
        /// <param name="ville">Ville de la personne</param>
        public Personne(string nom, string prenom, string ville)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.ville = ville;
        }
        #endregion 
    }
}
