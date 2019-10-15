namespace APP
{
    partial class FormParticipant
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
            this.dgvTableauParticipant = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImpCSV = new System.Windows.Forms.Button();
            this.lbTest = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.ofdChooseCsv = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableauParticipant)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTableauParticipant
            // 
            this.dgvTableauParticipant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTableauParticipant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableauParticipant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nom,
            this.Prenom});
            this.dgvTableauParticipant.Location = new System.Drawing.Point(16, 15);
            this.dgvTableauParticipant.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTableauParticipant.Name = "dgvTableauParticipant";
            this.dgvTableauParticipant.Size = new System.Drawing.Size(1613, 646);
            this.dgvTableauParticipant.TabIndex = 0;
            this.dgvTableauParticipant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTableauParticipant_CellContentClick_1);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "Identifiant";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Prenom
            // 
            this.Prenom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prenom.HeaderText = "Prénom";
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            // 
            // btnImpCSV
            // 
            this.btnImpCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImpCSV.Location = new System.Drawing.Point(763, 698);
            this.btnImpCSV.Margin = new System.Windows.Forms.Padding(4);
            this.btnImpCSV.Name = "btnImpCSV";
            this.btnImpCSV.Size = new System.Drawing.Size(120, 52);
            this.btnImpCSV.TabIndex = 1;
            this.btnImpCSV.Text = "Importer";
            this.btnImpCSV.UseVisualStyleBackColor = true;
            this.btnImpCSV.Click += new System.EventHandler(this.btnImpCSV_Click);
            // 
            // lbTest
            // 
            this.lbTest.AutoSize = true;
            this.lbTest.Location = new System.Drawing.Point(1148, 698);
            this.lbTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTest.Name = "lbTest";
            this.lbTest.Size = new System.Drawing.Size(31, 17);
            this.lbTest.TabIndex = 2;
            this.lbTest.Text = "test";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(1121, 666);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(100, 28);
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.test_btn_Click);
            // 
            // ofdChooseCsv
            // 
            this.ofdChooseCsv.Filter = "Fichiers csv (*.csv)|*.csv";
            this.ofdChooseCsv.Title = "Choisir le csv des participants.";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1645, 784);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lbTest);
            this.Controls.Add(this.btnImpCSV);
            this.Controls.Add(this.dgvTableauParticipant);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormParticipant";
            this.Text = "Participants";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableauParticipant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTableauParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.Button btnImpCSV;
        private System.Windows.Forms.Label lbTest;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.OpenFileDialog ofdChooseCsv;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

