using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metier;
using System.Windows.Forms;

namespace AppAgenc.Presentation
{
    public partial class AjouterUnePersonne : Form
    {
        private Metier.Personne unePer ;
        public AjouterUnePersonne()
        {
            InitializeComponent();
        }

        private void btn_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Ajoute une personne dans la collection d'agence en récupérant les valeurs du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            Personne unePersonne = new Personne(txt_Nom.Text, txt_Prenom.Text, txt_Ville.Text);
            Acceuil.UneAgence.AjouterPersonne(unePersonne);
            this.Close();
        }
        /// <summary>
        /// Vérification d'une entrée en lettre
        /// </summary>
        /// <param name="e"></param>
        /// <param name="tbx"></param>
        private void verificationTbx(KeyPressEventArgs e, TextBox tbx)
        {
            if (!char.IsControl(e.KeyChar)
                && char.IsDigit(e.KeyChar)
                && Convert.ToChar(",") != e.KeyChar)
            {
                e.Handled = true;
            }
        }

        private void txt_Nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.verificationTbx(e, txt_Nom);
        }

        private void txt_Prenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.verificationTbx(e, txt_Prenom);
        }

        private void txt_Ville_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.verificationTbx(e, txt_Ville);
        }
    }
}
