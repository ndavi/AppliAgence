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
    public partial class SupprimerUnePersonne : Form
    {
        public SupprimerUnePersonne()
        {
            InitializeComponent();
        }

        private void btn_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbb_Personnes_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Personne unePersonne in Acceuil.UneAgence.LesPersonnes)
            {
                cbb_Personnes.Items.Add(" " + unePersonne.Nom);
                
            }
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            string saisie = cbb_Personnes.Text;
            //Acceuil.UneAgence.supprimerPersonne(saisie);
        }
    }
}
