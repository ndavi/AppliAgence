namespace AppAgenc.Presentation
{
    partial class SupprimerUneVoiture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_Voitures = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Fermer = new System.Windows.Forms.Button();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supprimer Une Voiture";
            // 
            // cbb_Voitures
            // 
            this.cbb_Voitures.FormattingEnabled = true;
            this.cbb_Voitures.Location = new System.Drawing.Point(192, 122);
            this.cbb_Voitures.Name = "cbb_Voitures";
            this.cbb_Voitures.Size = new System.Drawing.Size(121, 21);
            this.cbb_Voitures.TabIndex = 1;
            this.cbb_Voitures.SelectedIndexChanged += new System.EventHandler(this.cbb_Voitures_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "La Voiture à Supprimer :";
            // 
            // btn_Fermer
            // 
            this.btn_Fermer.Location = new System.Drawing.Point(65, 204);
            this.btn_Fermer.Name = "btn_Fermer";
            this.btn_Fermer.Size = new System.Drawing.Size(75, 23);
            this.btn_Fermer.TabIndex = 3;
            this.btn_Fermer.Text = "Fermer";
            this.btn_Fermer.UseVisualStyleBackColor = true;
            this.btn_Fermer.Click += new System.EventHandler(this.btn_Fermer_Click);
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Location = new System.Drawing.Point(229, 204);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_Ajouter.TabIndex = 4;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            // 
            // SupprimerUneVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 262);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.btn_Fermer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_Voitures);
            this.Controls.Add(this.label1);
            this.Name = "SupprimerUneVoiture";
            this.Text = "Supprimer Une Voiture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_Voitures;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Fermer;
        private System.Windows.Forms.Button btn_Ajouter;
    }
}