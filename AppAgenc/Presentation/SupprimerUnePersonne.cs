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
            foreach (Personne unePersonne in Acceuil.UneAgence.LesPersonnes)
            {
                cbb_Personnes.Items.Add(unePersonne.Nom);
            }
        }

        private void btn_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            Object personneSelected = cbb_Personnes.SelectedItem;
            Personne laPersonne = Acceuil.UneAgence.LesPersonnes.Find(x => x.Nom == Convert.ToString(personneSelected));
            Acceuil.UneAgence.LesPersonnes.Remove(laPersonne);
            this.Close();
        }
    }
}
