using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier;

namespace AppAgenc.Presentation
{
    public partial class AjouterUneVoiture : Form
    {
        public AjouterUneVoiture()
        {
            InitializeComponent();
        }

        private void btn_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            object test = txt_dateMiseEnService.Value.Date;
            Voiture voiture = new Voiture(txt_NomVoiture.Text, txt_Categorie.Text,
                Convert.ToDouble(txt_Puissance.Text), txt_Immatriculation.Text,
                rb_Oui.Checked,txt_dateMiseEnService.Value.Date);
            Acceuil.UneAgence.AjouterVoiture(voiture);
            this.Close();
        }
        /// <summary>
        /// Vérification d'une entrée en chiffre
        /// </summary>
        /// <param name="e"></param>
        /// <param name="tbx"></param>
        private void verificationTbx_digit(KeyPressEventArgs e, TextBox tbx)
        {
            if (((e.KeyChar == Convert.ToChar(".")) || (e.KeyChar == Convert.ToChar(","))) &&
                (tbx.Text.Contains(".") || tbx.Text.Contains(",")))
            {
                e.Handled = true;
                ToolTip tooltipTaux = new ToolTip();
                tooltipTaux.RemoveAll();
                tooltipTaux.Show("Vous avez déjà saisi une virgule", tbx);
            }
            else if (e.KeyChar == Convert.ToChar("."))
                e.KeyChar = Convert.ToChar(",");
            else if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && Convert.ToChar(",") != e.KeyChar)
            {
                e.Handled = true;
            }
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
        private void txt_Categorie_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.verificationTbx(e, txt_Categorie);
        }

        private void txt_Puissance_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.verificationTbx_digit(e, txt_Puissance);
        }

        private void txt_Immatriculation_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this.verificationTbx(e, txt_Immatriculation);
        }

        private void txt_NomVoiture_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.verificationTbx(e, txt_NomVoiture);
        }
    }
}
