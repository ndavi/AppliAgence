namespace AppAgenc.Presentation
{
    partial class ConsulterPersonnes
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
            this.cbx_trie = new System.Windows.Forms.ComboBox();
            this.cbx_nomPersonne = new System.Windows.Forms.ComboBox();
            this.dgv_consulvoiture = new System.Windows.Forms.DataGridView();
            this.btn_Fermer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulvoiture)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_trie
            // 
            this.cbx_trie.FormattingEnabled = true;
            this.cbx_trie.Location = new System.Drawing.Point(398, 83);
            this.cbx_trie.Name = "cbx_trie";
            this.cbx_trie.Size = new System.Drawing.Size(121, 21);
            this.cbx_trie.TabIndex = 13;
            // 
            // cbx_nomPersonne
            // 
            this.cbx_nomPersonne.FormattingEnabled = true;
            this.cbx_nomPersonne.Location = new System.Drawing.Point(149, 88);
            this.cbx_nomPersonne.Name = "cbx_nomPersonne";
            this.cbx_nomPersonne.Size = new System.Drawing.Size(121, 21);
            this.cbx_nomPersonne.TabIndex = 12;
            // 
            // dgv_consulvoiture
            // 
            this.dgv_consulvoiture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consulvoiture.Location = new System.Drawing.Point(10, 133);
            this.dgv_consulvoiture.Name = "dgv_consulvoiture";
            this.dgv_consulvoiture.Size = new System.Drawing.Size(613, 229);
            this.dgv_consulvoiture.TabIndex = 11;
            // 
            // btn_Fermer
            // 
            this.btn_Fermer.Location = new System.Drawing.Point(275, 378);
            this.btn_Fermer.Name = "btn_Fermer";
            this.btn_Fermer.Size = new System.Drawing.Size(75, 23);
            this.btn_Fermer.TabIndex = 10;
            this.btn_Fermer.Text = "Fermer";
            this.btn_Fermer.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Trier sur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nom de la personne :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Affichage des personnes";
            // 
            // ConsulterPersonnes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 414);
            this.Controls.Add(this.cbx_trie);
            this.Controls.Add(this.cbx_nomPersonne);
            this.Controls.Add(this.dgv_consulvoiture);
            this.Controls.Add(this.btn_Fermer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConsulterPersonnes";
            this.Text = "ConsulterPersonnes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulvoiture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_trie;
        private System.Windows.Forms.ComboBox cbx_nomPersonne;
        private System.Windows.Forms.DataGridView dgv_consulvoiture;
        private System.Windows.Forms.Button btn_Fermer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}