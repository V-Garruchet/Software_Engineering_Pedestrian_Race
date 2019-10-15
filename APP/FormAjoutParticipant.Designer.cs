namespace APP
{
    partial class FormAjoutParticipant
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
            this.lb_nom = new System.Windows.Forms.Label();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.lb_titre = new System.Windows.Forms.Label();
            this.lb_prenom = new System.Windows.Forms.Label();
            this.lb_sexe = new System.Windows.Forms.Label();
            this.dtp_naissance = new System.Windows.Forms.DateTimePicker();
            this.lb_naissance = new System.Windows.Forms.Label();
            this.lb_mail = new System.Windows.Forms.Label();
            this.lb_license = new System.Windows.Forms.Label();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.tb_license = new System.Windows.Forms.TextBox();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.lb_asterix = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_F = new System.Windows.Forms.RadioButton();
            this.rb_H = new System.Windows.Forms.RadioButton();
            this.lb_indication = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_nom
            // 
            this.lb_nom.AutoSize = true;
            this.lb_nom.Location = new System.Drawing.Point(142, 85);
            this.lb_nom.Name = "lb_nom";
            this.lb_nom.Size = new System.Drawing.Size(45, 17);
            this.lb_nom.TabIndex = 0;
            this.lb_nom.Text = "Nom :";
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(145, 105);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(210, 22);
            this.tb_nom.TabIndex = 1;
            // 
            // lb_titre
            // 
            this.lb_titre.AutoSize = true;
            this.lb_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titre.Location = new System.Drawing.Point(122, 9);
            this.lb_titre.Name = "lb_titre";
            this.lb_titre.Size = new System.Drawing.Size(346, 38);
            this.lb_titre.TabIndex = 2;
            this.lb_titre.Text = "Ajouter un participant";
            // 
            // lb_prenom
            // 
            this.lb_prenom.AutoSize = true;
            this.lb_prenom.Location = new System.Drawing.Point(142, 144);
            this.lb_prenom.Name = "lb_prenom";
            this.lb_prenom.Size = new System.Drawing.Size(65, 17);
            this.lb_prenom.TabIndex = 3;
            this.lb_prenom.Text = "Prénom :";
            // 
            // lb_sexe
            // 
            this.lb_sexe.AutoSize = true;
            this.lb_sexe.Location = new System.Drawing.Point(142, 197);
            this.lb_sexe.Name = "lb_sexe";
            this.lb_sexe.Size = new System.Drawing.Size(39, 17);
            this.lb_sexe.TabIndex = 5;
            this.lb_sexe.Text = "Sexe";
            // 
            // dtp_naissance
            // 
            this.dtp_naissance.Location = new System.Drawing.Point(145, 275);
            this.dtp_naissance.Name = "dtp_naissance";
            this.dtp_naissance.Size = new System.Drawing.Size(210, 22);
            this.dtp_naissance.TabIndex = 7;
            // 
            // lb_naissance
            // 
            this.lb_naissance.AutoSize = true;
            this.lb_naissance.Location = new System.Drawing.Point(142, 255);
            this.lb_naissance.Name = "lb_naissance";
            this.lb_naissance.Size = new System.Drawing.Size(126, 17);
            this.lb_naissance.TabIndex = 8;
            this.lb_naissance.Text = "Date de naissance";
            // 
            // lb_mail
            // 
            this.lb_mail.AutoSize = true;
            this.lb_mail.Location = new System.Drawing.Point(142, 380);
            this.lb_mail.Name = "lb_mail";
            this.lb_mail.Size = new System.Drawing.Size(97, 17);
            this.lb_mail.TabIndex = 9;
            this.lb_mail.Text = "Adresse mail :";
            // 
            // lb_license
            // 
            this.lb_license.AutoSize = true;
            this.lb_license.Location = new System.Drawing.Point(142, 319);
            this.lb_license.Name = "lb_license";
            this.lb_license.Size = new System.Drawing.Size(72, 17);
            this.lb_license.TabIndex = 10;
            this.lb_license.Text = "N° licence";
            // 
            // tb_prenom
            // 
            this.tb_prenom.Location = new System.Drawing.Point(145, 164);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(210, 22);
            this.tb_prenom.TabIndex = 11;
            // 
            // tb_license
            // 
            this.tb_license.Location = new System.Drawing.Point(145, 339);
            this.tb_license.Name = "tb_license";
            this.tb_license.Size = new System.Drawing.Size(210, 22);
            this.tb_license.TabIndex = 13;
            // 
            // tb_mail
            // 
            this.tb_mail.Location = new System.Drawing.Point(145, 400);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(210, 22);
            this.tb_mail.TabIndex = 14;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(454, 393);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(100, 84);
            this.btn_ajouter.TabIndex = 15;
            this.btn_ajouter.Text = "Ajouter à la course";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // lb_asterix
            // 
            this.lb_asterix.AutoSize = true;
            this.lb_asterix.ForeColor = System.Drawing.Color.Red;
            this.lb_asterix.Location = new System.Drawing.Point(126, 110);
            this.lb_asterix.Name = "lb_asterix";
            this.lb_asterix.Size = new System.Drawing.Size(13, 17);
            this.lb_asterix.TabIndex = 16;
            this.lb_asterix.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(126, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(126, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(123, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "*";
            // 
            // rb_F
            // 
            this.rb_F.AutoSize = true;
            this.rb_F.Location = new System.Drawing.Point(145, 216);
            this.rb_F.Name = "rb_F";
            this.rb_F.Size = new System.Drawing.Size(75, 21);
            this.rb_F.TabIndex = 20;
            this.rb_F.TabStop = true;
            this.rb_F.Text = "Femme";
            this.rb_F.UseVisualStyleBackColor = true;
            // 
            // rb_H
            // 
            this.rb_H.AutoSize = true;
            this.rb_H.Location = new System.Drawing.Point(278, 220);
            this.rb_H.Name = "rb_H";
            this.rb_H.Size = new System.Drawing.Size(77, 21);
            this.rb_H.TabIndex = 21;
            this.rb_H.TabStop = true;
            this.rb_H.Text = "Homme";
            this.rb_H.UseVisualStyleBackColor = true;
            // 
            // lb_indication
            // 
            this.lb_indication.AutoSize = true;
            this.lb_indication.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_indication.Location = new System.Drawing.Point(123, 444);
            this.lb_indication.Name = "lb_indication";
            this.lb_indication.Size = new System.Drawing.Size(291, 17);
            this.lb_indication.TabIndex = 22;
            this.lb_indication.Text = "Les champs marqués d\'un * sont obligatoires";
            // 
            // FormAjoutParticipant
            // 
            this.ClientSize = new System.Drawing.Size(577, 502);
            this.Controls.Add(this.lb_indication);
            this.Controls.Add(this.rb_H);
            this.Controls.Add(this.rb_F);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_asterix);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(this.tb_license);
            this.Controls.Add(this.tb_prenom);
            this.Controls.Add(this.lb_license);
            this.Controls.Add(this.lb_mail);
            this.Controls.Add(this.lb_naissance);
            this.Controls.Add(this.dtp_naissance);
            this.Controls.Add(this.lb_sexe);
            this.Controls.Add(this.lb_prenom);
            this.Controls.Add(this.lb_titre);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.lb_nom);
            this.Name = "FormAjoutParticipant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lb_nom;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.Label lb_titre;
        private System.Windows.Forms.Label lb_prenom;
        private System.Windows.Forms.Label lb_sexe;
        private System.Windows.Forms.DateTimePicker dtp_naissance;
        private System.Windows.Forms.Label lb_naissance;
        private System.Windows.Forms.Label lb_mail;
        private System.Windows.Forms.Label lb_license;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.TextBox tb_license;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Label lb_asterix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_F;
        private System.Windows.Forms.RadioButton rb_H;
        private System.Windows.Forms.Label lb_indication;
    }
}