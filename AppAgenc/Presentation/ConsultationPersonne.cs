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
    public partial class ConsultationPersonne : Form
    {
        public ConsultationPersonne()
        {
            InitializeComponent();
            foreach (Personne unePersonne in Acceuil.UneAgence.LesPersonnes)
            {
                dgv_personne.Rows.Add(unePersonne.Prenom, unePersonne.Nom, unePersonne.Ville);
            }
        }

        private void btn_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
