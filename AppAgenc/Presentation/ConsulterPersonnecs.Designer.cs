namespace AppAgenc.Presentation
{
    partial class ConsulterPersonnecs
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbx_TrierPersonne = new System.Windows.Forms.ComboBox();
            this.cbx_NomVoiture = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Femer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-27, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(638, 258);
            this.dataGridView1.TabIndex = 13;
            // 
            // cbx_TrierPersonne
            // 
            this.cbx_TrierPersonne.FormattingEnabled = true;
            this.cbx_TrierPersonne.Location = new System.Drawing.Point(345, 67);
            this.cbx_TrierPersonne.Name = "cbx_TrierPersonne";
            this.cbx_TrierPersonne.Size = new System.Drawing.Size(121, 21);
            this.cbx_TrierPersonne.TabIndex = 12;
            // 
            // cbx_NomVoiture
            // 
            this.cbx_NomVoiture.FormattingEnabled = true;
            this.cbx_NomVoiture.Location = new System.Drawing.Point(126, 67);
            this.cbx_NomVoiture.Name = "cbx_NomVoiture";
            this.cbx_NomVoiture.Size = new System.Drawing.Size(121, 21);
            this.cbx_NomVoiture.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Trier sur : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nom de voiture  : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Affichage des personnes";
            // 
            // btn_Femer
            // 
            this.btn_Femer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Femer.Location = new System.Drawing.Point(288, 371);
            this.btn_Femer.Name = "btn_Femer";
            this.btn_Femer.Size = new System.Drawing.Size(75, 23);
            this.btn_Femer.TabIndex = 7;
            this.btn_Femer.Text = "Femer";
            this.btn_Femer.UseVisualStyleBackColor = true;
            // 
            // ConsulterPersonnecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 402);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbx_TrierPersonne);
            this.Controls.Add(this.cbx_NomVoiture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Femer);
            this.Name = "ConsulterPersonnecs";
            this.Text = "ConsulterPersonnecs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbx_TrierPersonne;
        private System.Windows.Forms.ComboBox cbx_NomVoiture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Femer;
    }
}