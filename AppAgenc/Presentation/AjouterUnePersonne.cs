﻿using System;
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
    }
}