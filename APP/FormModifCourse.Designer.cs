namespace APP
{
    partial class FormModifCourse
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

        private void InitializeComponent()
        {
            this.lb_longueur = new System.Windows.Forms.Label();
            this.lb_titre = new System.Windows.Forms.Label();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.lb_nom = new System.Windows.Forms.Label();
            this.nup_longueur = new System.Windows.Forms.NumericUpDown();
            this.btn_Valider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nup_longueur)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_longueur
            // 
            this.lb_longueur.AutoSize = true;
            this.lb_longueur.Location = new System.Drawing.Point(87, 158);
            this.lb_longueur.Name = "lb_longueur";
            this.lb_longueur.Size = new System.Drawing.Size(122, 17);
            this.lb_longueur.TabIndex = 21;
            this.lb_longueur.Text = "Longueur (en m) :";
            // 
            // lb_titre
            // 
            this.lb_titre.AutoSize = true;
            this.lb_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titre.Location = new System.Drawing.Point(83, 9);
            this.lb_titre.Name = "lb_titre";
            this.lb_titre.Size = new System.Drawing.Size(322, 38);
            this.lb_titre.TabIndex = 20;
            this.lb_titre.Text = "Modifier une course";
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(90, 119);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(315, 22);
            this.tb_nom.TabIndex = 19;
            // 
            // lb_nom
            // 
            this.lb_nom.AutoSize = true;
            this.lb_nom.Location = new System.Drawing.Point(87, 99);
            this.lb_nom.Name = "lb_nom";
            this.lb_nom.Size = new System.Drawing.Size(45, 17);
            this.lb_nom.TabIndex = 18;
            this.lb_nom.Text = "Nom :";
            // 
            // nup_longueur
            // 
            this.nup_longueur.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nup_longueur.Location = new System.Drawing.Point(90, 178);
            this.nup_longueur.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nup_longueur.Name = "nup_longueur";
            this.nup_longueur.Size = new System.Drawing.Size(315, 22);
            this.nup_longueur.TabIndex = 24;
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(357, 326);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(95, 51);
            this.btn_Valider.TabIndex = 25;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // FormModifCourse
            // 
            this.ClientSize = new System.Drawing.Size(481, 448);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.nup_longueur);
            this.Controls.Add(this.lb_longueur);
            this.Controls.Add(this.lb_titre);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.lb_nom);
            this.Name = "FormModifCourse";
            ((System.ComponentModel.ISupportInitialize)(this.nup_longueur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lb_longueur;
        private System.Windows.Forms.Label lb_titre;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.Label lb_nom;
        private System.Windows.Forms.NumericUpDown nup_longueur;
        private System.Windows.Forms.Button btn_Valider;
    }
}