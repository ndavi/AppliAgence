﻿namespace AppAgenc.Presentation
{
    partial class Acceuil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerUneSauvegardeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderLesDonnéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voituresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUneVoitureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personnesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnePersonneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUnePersonneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rendreUneVoitureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toutesLesVoituresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toutesLesPersonnesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.gérerToolStripMenuItem,
            this.consultationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(410, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chargerUneSauvegardeToolStripMenuItem,
            this.sauvegarderLesDonnéesToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // chargerUneSauvegardeToolStripMenuItem
            // 
            this.chargerUneSauvegardeToolStripMenuItem.Name = "chargerUneSauvegardeToolStripMenuItem";
            this.chargerUneSauvegardeToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.chargerUneSauvegardeToolStripMenuItem.Text = "Charger une Sauvegarde";
            this.chargerUneSauvegardeToolStripMenuItem.Click += new System.EventHandler(this.chargerUneSauvegardeToolStripMenuItem_Click);
            // 
            // sauvegarderLesDonnéesToolStripMenuItem
            // 
            this.sauvegarderLesDonnéesToolStripMenuItem.Name = "sauvegarderLesDonnéesToolStripMenuItem";
            this.sauvegarderLesDonnéesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.sauvegarderLesDonnéesToolStripMenuItem.Text = "Sauvegarder les Données";
            this.sauvegarderLesDonnéesToolStripMenuItem.Click += new System.EventHandler(this.sauvegarderLesDonnéesToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // gérerToolStripMenuItem
            // 
            this.gérerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voituresToolStripMenuItem,
            this.personnesToolStripMenuItem,
            this.locationsToolStripMenuItem});
            this.gérerToolStripMenuItem.Name = "gérerToolStripMenuItem";
            this.gérerToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.gérerToolStripMenuItem.Text = "Gérer";
            // 
            // voituresToolStripMenuItem
            // 
            this.voituresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.supprimerUneVoitureToolStripMenuItem});
            this.voituresToolStripMenuItem.Name = "voituresToolStripMenuItem";
            this.voituresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.voituresToolStripMenuItem.Text = "Voitures";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter une voiture";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // supprimerUneVoitureToolStripMenuItem
            // 
            this.supprimerUneVoitureToolStripMenuItem.Name = "supprimerUneVoitureToolStripMenuItem";
            this.supprimerUneVoitureToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.supprimerUneVoitureToolStripMenuItem.Text = "Supprimer une voiture";
            this.supprimerUneVoitureToolStripMenuItem.Click += new System.EventHandler(this.supprimerUneVoitureToolStripMenuItem_Click);
            // 
            // personnesToolStripMenuItem
            // 
            this.personnesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnePersonneToolStripMenuItem,
            this.supprimerUnePersonneToolStripMenuItem});
            this.personnesToolStripMenuItem.Name = "personnesToolStripMenuItem";
            this.personnesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.personnesToolStripMenuItem.Text = "Personnes";
            // 
            // ajouterUnePersonneToolStripMenuItem
            // 
            this.ajouterUnePersonneToolStripMenuItem.Name = "ajouterUnePersonneToolStripMenuItem";
            this.ajouterUnePersonneToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.ajouterUnePersonneToolStripMenuItem.Text = "Ajouter une personne";
            this.ajouterUnePersonneToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnePersonneToolStripMenuItem_Click);
            // 
            // supprimerUnePersonneToolStripMenuItem
            // 
            this.supprimerUnePersonneToolStripMenuItem.Name = "supprimerUnePersonneToolStripMenuItem";
            this.supprimerUnePersonneToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.supprimerUnePersonneToolStripMenuItem.Text = "Supprimer une personne";
            this.supprimerUnePersonneToolStripMenuItem.Click += new System.EventHandler(this.supprimerUnePersonneToolStripMenuItem_Click);
            // 
            // locationsToolStripMenuItem
            // 
            this.locationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1,
            this.rendreUneVoitureToolStripMenuItem});
            this.locationsToolStripMenuItem.Name = "locationsToolStripMenuItem";
            this.locationsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.locationsToolStripMenuItem.Text = "Locations";
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.ajouterToolStripMenuItem1.Text = "Louer une voiture";
            this.ajouterToolStripMenuItem1.Click += new System.EventHandler(this.ajouterToolStripMenuItem1_Click);
            // 
            // rendreUneVoitureToolStripMenuItem
            // 
            this.rendreUneVoitureToolStripMenuItem.Name = "rendreUneVoitureToolStripMenuItem";
            this.rendreUneVoitureToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.rendreUneVoitureToolStripMenuItem.Text = "Rendre une voiture";
            this.rendreUneVoitureToolStripMenuItem.Click += new System.EventHandler(this.rendreUneVoitureToolStripMenuItem_Click);
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toutesLesVoituresToolStripMenuItem,
            this.toutesLesPersonnesToolStripMenuItem});
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.consultationToolStripMenuItem.Text = "Consultation";
            // 
            // toutesLesVoituresToolStripMenuItem
            // 
            this.toutesLesVoituresToolStripMenuItem.Name = "toutesLesVoituresToolStripMenuItem";
            this.toutesLesVoituresToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.toutesLesVoituresToolStripMenuItem.Text = "Toutes les voitures";
            this.toutesLesVoituresToolStripMenuItem.Click += new System.EventHandler(this.toutesLesVoituresToolStripMenuItem_Click);
            // 
            // toutesLesPersonnesToolStripMenuItem
            // 
            this.toutesLesPersonnesToolStripMenuItem.Name = "toutesLesPersonnesToolStripMenuItem";
            this.toutesLesPersonnesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.toutesLesPersonnesToolStripMenuItem.Text = "Toutes les personnes";
            this.toutesLesPersonnesToolStripMenuItem.Click += new System.EventHandler(this.toutesLesPersonnesToolStripMenuItem_Click);
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Acceuil";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voituresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personnesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUneVoitureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnePersonneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUnePersonneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rendreUneVoitureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toutesLesVoituresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toutesLesPersonnesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chargerUneSauvegardeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderLesDonnéesToolStripMenuItem;
    }
}

