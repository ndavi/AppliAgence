namespace AppAgenc.Presentation
{
    partial class ConsulterVoitures
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
            this.btn_Fermer = new System.Windows.Forms.Button();
            this.dgv_consulvoiture = new System.Windows.Forms.DataGridView();
            this.cbx_nomPersonne = new System.Windows.Forms.ComboBox();
            this.cbx_trie = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulvoiture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Affichage des voitures";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom de la personne :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(331, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trier sur :";
            // 
            // btn_Fermer
            // 
            this.btn_Fermer.Location = new System.Drawing.Point(277, 388);
            this.btn_Fermer.Name = "btn_Fermer";
            this.btn_Fermer.Size = new System.Drawing.Size(75, 23);
            this.btn_Fermer.TabIndex = 3;
            this.btn_Fermer.Text = "Fermer";
            this.btn_Fermer.UseVisualStyleBackColor = true;
            // 
            // dgv_consulvoiture
            // 
            this.dgv_consulvoiture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consulvoiture.Location = new System.Drawing.Point(12, 143);
            this.dgv_consulvoiture.Name = "dgv_consulvoiture";
            this.dgv_consulvoiture.Size = new System.Drawing.Size(613, 229);
            this.dgv_consulvoiture.TabIndex = 4;
            // 
            // cbx_nomPersonne
            // 
            this.cbx_nomPersonne.FormattingEnabled = true;
            this.cbx_nomPersonne.Location = new System.Drawing.Point(151, 98);
            this.cbx_nomPersonne.Name = "cbx_nomPersonne";
            this.cbx_nomPersonne.Size = new System.Drawing.Size(121, 21);
            this.cbx_nomPersonne.TabIndex = 5;
            // 
            // cbx_trie
            // 
            this.cbx_trie.FormattingEnabled = true;
            this.cbx_trie.Location = new System.Drawing.Point(400, 93);
            this.cbx_trie.Name = "cbx_trie";
            this.cbx_trie.Size = new System.Drawing.Size(121, 21);
            this.cbx_trie.TabIndex = 6;
            // 
            // ConsulterVoitures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 422);
            this.Controls.Add(this.cbx_trie);
            this.Controls.Add(this.cbx_nomPersonne);
            this.Controls.Add(this.dgv_consulvoiture);
            this.Controls.Add(this.btn_Fermer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConsulterVoitures";
            this.Text = "ConsulterVoitures";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulvoiture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Fermer;
        private System.Windows.Forms.DataGridView dgv_consulvoiture;
        private System.Windows.Forms.ComboBox cbx_nomPersonne;
        private System.Windows.Forms.ComboBox cbx_trie;
    }
}