namespace AppAgenc.Presentation
{
    partial class LouerVoiture
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Voitures = new System.Windows.Forms.ComboBox();
            this.cb_Personnes = new System.Windows.Forms.ComboBox();
            this.btn_Fermer = new System.Windows.Forms.Button();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Louer une Voiture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Voiture :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Personne :";
            // 
            // cb_Voitures
            // 
            this.cb_Voitures.FormattingEnabled = true;
            this.cb_Voitures.Location = new System.Drawing.Point(161, 114);
            this.cb_Voitures.Name = "cb_Voitures";
            this.cb_Voitures.Size = new System.Drawing.Size(121, 21);
            this.cb_Voitures.TabIndex = 3;
            // 
            // cb_Personnes
            // 
            this.cb_Personnes.FormattingEnabled = true;
            this.cb_Personnes.Location = new System.Drawing.Point(161, 172);
            this.cb_Personnes.Name = "cb_Personnes";
            this.cb_Personnes.Size = new System.Drawing.Size(121, 21);
            this.cb_Personnes.TabIndex = 4;
            // 
            // btn_Fermer
            // 
            this.btn_Fermer.BackColor = System.Drawing.Color.Red;
            this.btn_Fermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fermer.Location = new System.Drawing.Point(90, 246);
            this.btn_Fermer.Name = "btn_Fermer";
            this.btn_Fermer.Size = new System.Drawing.Size(75, 23);
            this.btn_Fermer.TabIndex = 5;
            this.btn_Fermer.Text = "Fermer";
            this.btn_Fermer.UseVisualStyleBackColor = false;
            this.btn_Fermer.Click += new System.EventHandler(this.btn_Fermer_Click);
            // 
            // btn_Valider
            // 
            this.btn_Valider.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_Valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Valider.Location = new System.Drawing.Point(251, 246);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(75, 23);
            this.btn_Valider.TabIndex = 6;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = false;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // LouerVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(404, 296);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.btn_Fermer);
            this.Controls.Add(this.cb_Personnes);
            this.Controls.Add(this.cb_Voitures);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LouerVoiture";
            this.Text = " Location d\'une voiture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Voitures;
        private System.Windows.Forms.ComboBox cb_Personnes;
        private System.Windows.Forms.Button btn_Fermer;
        private System.Windows.Forms.Button btn_Valider;
    }
}