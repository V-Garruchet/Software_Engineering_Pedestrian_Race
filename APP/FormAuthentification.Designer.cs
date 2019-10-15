namespace APP
{
    partial class FormAuthentification
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
            this.lbAuth = new System.Windows.Forms.Label();
            this.lbExplictions = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lbMdp = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAuth
            // 
            this.lbAuth.AutoSize = true;
            this.lbAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuth.Location = new System.Drawing.Point(27, 9);
            this.lbAuth.Name = "lbAuth";
            this.lbAuth.Size = new System.Drawing.Size(229, 32);
            this.lbAuth.TabIndex = 0;
            this.lbAuth.Text = "Authentification";
            // 
            // lbExplictions
            // 
            this.lbExplictions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExplictions.Location = new System.Drawing.Point(30, 41);
            this.lbExplictions.Name = "lbExplictions";
            this.lbExplictions.Size = new System.Drawing.Size(220, 34);
            this.lbExplictions.TabIndex = 1;
            this.lbExplictions.Text = "Une authentification est requise pour l\'édition de données";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(92, 120);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 22);
            this.tbId.TabIndex = 2;
            // 
            // tbMdp
            // 
            this.tbMdp.Location = new System.Drawing.Point(92, 187);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.PasswordChar = '*';
            this.tbMdp.Size = new System.Drawing.Size(100, 22);
            this.tbMdp.TabIndex = 3;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(92, 97);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(77, 17);
            this.lbId.TabIndex = 4;
            this.lbId.Text = "Identifiant :";
            // 
            // lbMdp
            // 
            this.lbMdp.AutoSize = true;
            this.lbMdp.Location = new System.Drawing.Point(89, 162);
            this.lbMdp.Name = "lbMdp";
            this.lbMdp.Size = new System.Drawing.Size(101, 17);
            this.lbMdp.TabIndex = 5;
            this.lbMdp.Text = "Mot de passe :";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(195, 218);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // FormAuthentification
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lbMdp);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbExplictions);
            this.Controls.Add(this.lbAuth);
            this.Name = "FormAuthentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lbAuth;
        private System.Windows.Forms.Label lbExplictions;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbMdp;
        private System.Windows.Forms.Button btnValider;
    }
}