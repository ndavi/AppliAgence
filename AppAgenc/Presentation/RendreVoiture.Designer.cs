namespace AppAgenc.Presentation
{
    partial class RendreVoiture
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
            this.btn_Fermer = new System.Windows.Forms.Button();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.cb_Voitures = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rendre Une Voiture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Voitre à Rendre :";
            // 
            // btn_Fermer
            // 
            this.btn_Fermer.Location = new System.Drawing.Point(87, 210);
            this.btn_Fermer.Name = "btn_Fermer";
            this.btn_Fermer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Fermer.Size = new System.Drawing.Size(75, 23);
            this.btn_Fermer.TabIndex = 2;
            this.btn_Fermer.Text = "Fermer";
            this.btn_Fermer.UseVisualStyleBackColor = true;
            this.btn_Fermer.Click += new System.EventHandler(this.btn_Fermer_Click);
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(245, 210);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(75, 23);
            this.btn_Valider.TabIndex = 3;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // cb_Voitures
            // 
            this.cb_Voitures.FormattingEnabled = true;
            this.cb_Voitures.Location = new System.Drawing.Point(220, 126);
            this.cb_Voitures.Name = "cb_Voitures";
            this.cb_Voitures.Size = new System.Drawing.Size(121, 21);
            this.cb_Voitures.TabIndex = 4;
            // 
            // RendreVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 262);
            this.Controls.Add(this.cb_Voitures);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.btn_Fermer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RendreVoiture";
            this.Text = "RendreVoiture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Fermer;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.ComboBox cb_Voitures;
    }
}