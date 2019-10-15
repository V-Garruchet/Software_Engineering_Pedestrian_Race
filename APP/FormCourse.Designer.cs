namespace APP
{
    partial class FormCourse
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
            this.dvgTableauCourses = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImpCSV = new System.Windows.Forms.Button();
            this.ofdChooseCsv = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTableauCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgTableauCourses
            // 
            this.dvgTableauCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTableauCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nom,
            this.Classement,
            this.Temps});
            this.dvgTableauCourses.Location = new System.Drawing.Point(-33, 13);
            this.dvgTableauCourses.Margin = new System.Windows.Forms.Padding(4);
            this.dvgTableauCourses.Name = "dvgTableauCourses";
            this.dvgTableauCourses.Size = new System.Drawing.Size(1613, 646);
            this.dvgTableauCourses.TabIndex = 0;
            this.dvgTableauCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgTableauCourses_CellContentClick);
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
            // Classement
            // 
            this.Classement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Classement.HeaderText = "Classement";
            this.Classement.Name = "Classement";
            this.Classement.ReadOnly = true;
            // 
            // Temps
            // 
            this.Temps.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Temps.HeaderText = "Temps";
            this.Temps.Name = "Temps";
            this.Temps.ReadOnly = true;
            // 
            // btnImpCSV
            // 
            this.btnImpCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImpCSV.Location = new System.Drawing.Point(773, 698);
            this.btnImpCSV.Margin = new System.Windows.Forms.Padding(4);
            this.btnImpCSV.Name = "btnImpCSV";
            this.btnImpCSV.Size = new System.Drawing.Size(128, 53);
            this.btnImpCSV.TabIndex = 1;
            this.btnImpCSV.Text = "Importer";
            this.btnImpCSV.UseVisualStyleBackColor = true;
            this.btnImpCSV.Click += new System.EventHandler(this.btnImpCSV_Click);
            // 
            // ofdChooseCsv
            // 
            this.ofdChooseCsv.InitialDirectory = "..//..//..//CSV";
            // 
            // FormCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1645, 784);
            this.Controls.Add(this.btnImpCSV);
            this.Controls.Add(this.dvgTableauCourses);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCourse";
            this.Text = "Course";
            ((System.ComponentModel.ISupportInitialize)(this.dvgTableauCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgTableauCourses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temps;
        private System.Windows.Forms.Button btnImpCSV;
        private System.Windows.Forms.OpenFileDialog ofdChooseCsv;
    }
}