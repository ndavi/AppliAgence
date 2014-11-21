namespace AppAgenc.Presentation
{
    partial class ConsulterVoiture
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
            this.btn_Femer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_NomPersonne = new System.Windows.Forms.ComboBox();
            this.cbx_TrierPersonne = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Immatriculation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datemiseService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.louee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Femer
            // 
            this.btn_Femer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Femer.Location = new System.Drawing.Point(327, 395);
            this.btn_Femer.Name = "btn_Femer";
            this.btn_Femer.Size = new System.Drawing.Size(75, 23);
            this.btn_Femer.TabIndex = 0;
            this.btn_Femer.Text = "Femer";
            this.btn_Femer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Affichage des voitures";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom de la personne : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Trier sur : ";
            // 
            // cbx_NomPersonne
            // 
            this.cbx_NomPersonne.FormattingEnabled = true;
            this.cbx_NomPersonne.Location = new System.Drawing.Point(165, 91);
            this.cbx_NomPersonne.Name = "cbx_NomPersonne";
            this.cbx_NomPersonne.Size = new System.Drawing.Size(121, 21);
            this.cbx_NomPersonne.TabIndex = 4;
            // 
            // cbx_TrierPersonne
            // 
            this.cbx_TrierPersonne.FormattingEnabled = true;
            this.cbx_TrierPersonne.Location = new System.Drawing.Point(384, 91);
            this.cbx_TrierPersonne.Name = "cbx_TrierPersonne";
            this.cbx_TrierPersonne.Size = new System.Drawing.Size(121, 21);
            this.cbx_TrierPersonne.TabIndex = 5;
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Immatriculation,
            this.Puissance,
            this.datemiseService,
            this.Type,
            this.louee});
            this.dgv.Location = new System.Drawing.Point(12, 131);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(685, 258);
            this.dgv.TabIndex = 6;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Immatriculation
            // 
            this.Immatriculation.HeaderText = "Immatriculation";
            this.Immatriculation.Name = "Immatriculation";
            this.Immatriculation.ReadOnly = true;
            // 
            // Puissance
            // 
            this.Puissance.HeaderText = "Puissance";
            this.Puissance.Name = "Puissance";
            this.Puissance.ReadOnly = true;
            // 
            // datemiseService
            // 
            this.datemiseService.HeaderText = "Date de mise en service";
            this.datemiseService.Name = "datemiseService";
            this.datemiseService.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // louee
            // 
            this.louee.HeaderText = "Louée";
            this.louee.Name = "louee";
            this.louee.ReadOnly = true;
            // 
            // ConsulterVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 429);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.cbx_TrierPersonne);
            this.Controls.Add(this.cbx_NomPersonne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Femer);
            this.Name = "ConsulterVoiture";
            this.Text = "ConsulterVoiture";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Femer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_NomPersonne;
        private System.Windows.Forms.ComboBox cbx_TrierPersonne;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Immatriculation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn datemiseService;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn louee;
    }
}