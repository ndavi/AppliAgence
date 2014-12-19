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
            this.btn_Femer.BackColor = System.Drawing.Color.Red;
            this.btn_Femer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Femer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Femer.Location = new System.Drawing.Point(327, 395);
            this.btn_Femer.Name = "btn_Femer";
            this.btn_Femer.Size = new System.Drawing.Size(75, 23);
            this.btn_Femer.TabIndex = 0;
            this.btn_Femer.Text = "Femer";
            this.btn_Femer.UseVisualStyleBackColor = false;
            this.btn_Femer.Click += new System.EventHandler(this.btn_Femer_Click);
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
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
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
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(709, 429);
            this.Controls.Add(this.dgv);
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
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Immatriculation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn datemiseService;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn louee;
    }
}