namespace APP
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabControl_participants = new System.Windows.Forms.TabPage();
            this.dgvParticipants = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateNaissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Licence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl_resultats = new System.Windows.Forms.TabPage();
            this.dgvResultats = new System.Windows.Forms.DataGridView();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.lbCourse = new System.Windows.Forms.Label();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.ofdChooseCsv = new System.Windows.Forms.OpenFileDialog();
            this.cbRecherche = new System.Windows.Forms.ComboBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.gbRecherche = new System.Windows.Forms.GroupBox();
            this.btnRechercherAge = new System.Windows.Forms.Button();
            this.tbAgeMax = new System.Windows.Forms.TextBox();
            this.tbAgeMini = new System.Windows.Forms.TextBox();
            this.lbAgeMax = new System.Windows.Forms.Label();
            this.lbAgeMini = new System.Windows.Forms.Label();
            this.lbTrancheAge = new System.Windows.Forms.Label();
            this.lbNomDossard = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnModifierCourse = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.Classement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumDossard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VitMoy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllureMoy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabControl_participants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).BeginInit();
            this.tabControl_resultats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultats)).BeginInit();
            this.gbRecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabControl_participants);
            this.tabControl.Controls.Add(this.tabControl_resultats);
            this.tabControl.Location = new System.Drawing.Point(90, 107);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1533, 665);
            this.tabControl.TabIndex = 0;
            // 
            // tabControl_participants
            // 
            this.tabControl_participants.Controls.Add(this.dgvParticipants);
            this.tabControl_participants.Location = new System.Drawing.Point(4, 22);
            this.tabControl_participants.Name = "tabControl_participants";
            this.tabControl_participants.Padding = new System.Windows.Forms.Padding(3);
            this.tabControl_participants.Size = new System.Drawing.Size(1525, 639);
            this.tabControl_participants.TabIndex = 0;
            this.tabControl_participants.Text = "Participants";
            this.tabControl_participants.UseVisualStyleBackColor = true;
            // 
            // dgvParticipants
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvParticipants.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParticipants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Prenom,
            this.Sexe,
            this.DateNaissance,
            this.Mail,
            this.Licence});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParticipants.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvParticipants.Location = new System.Drawing.Point(0, 0);
            this.dgvParticipants.Margin = new System.Windows.Forms.Padding(4);
            this.dgvParticipants.MultiSelect = false;
            this.dgvParticipants.Name = "dgvParticipants";
            this.dgvParticipants.ReadOnly = true;
            this.dgvParticipants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvParticipants.Size = new System.Drawing.Size(1497, 630);
            this.dgvParticipants.TabIndex = 1;
            this.dgvParticipants.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParticipants_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Numéro Dossard";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Prenom
            // 
            this.Prenom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prenom.HeaderText = "Prénom";
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            // 
            // Sexe
            // 
            this.Sexe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sexe.HeaderText = "Sexe";
            this.Sexe.Name = "Sexe";
            this.Sexe.ReadOnly = true;
            // 
            // DateNaissance
            // 
            this.DateNaissance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateNaissance.HeaderText = "Date de Naissance";
            this.DateNaissance.Name = "DateNaissance";
            this.DateNaissance.ReadOnly = true;
            // 
            // Mail
            // 
            this.Mail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            // 
            // Licence
            // 
            this.Licence.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Licence.HeaderText = "Licence";
            this.Licence.Name = "Licence";
            this.Licence.ReadOnly = true;
            // 
            // tabControl_resultats
            // 
            this.tabControl_resultats.Controls.Add(this.dgvResultats);
            this.tabControl_resultats.Location = new System.Drawing.Point(4, 22);
            this.tabControl_resultats.Name = "tabControl_resultats";
            this.tabControl_resultats.Padding = new System.Windows.Forms.Padding(3);
            this.tabControl_resultats.Size = new System.Drawing.Size(1525, 639);
            this.tabControl_resultats.TabIndex = 1;
            this.tabControl_resultats.Text = "Résultats";
            this.tabControl_resultats.UseVisualStyleBackColor = true;
            // 
            // dgvResultats
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvResultats.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvResultats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Classement,
            this.Nom,
            this.NumDossard,
            this.Temps,
            this.VitMoy,
            this.AllureMoy});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResultats.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvResultats.Location = new System.Drawing.Point(0, 0);
            this.dgvResultats.Margin = new System.Windows.Forms.Padding(4);
            this.dgvResultats.Name = "dgvResultats";
            this.dgvResultats.Size = new System.Drawing.Size(1497, 654);
            this.dgvResultats.TabIndex = 1;
            this.dgvResultats.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultats_CellContentClick);
            // 
            // cbCourse
            // 
            this.cbCourse.BackColor = System.Drawing.Color.White;
            this.cbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Location = new System.Drawing.Point(80, 10);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(309, 21);
            this.cbCourse.Sorted = true;
            this.cbCourse.TabIndex = 1;
            this.cbCourse.SelectedIndexChanged += new System.EventHandler(this.cbCourse_SelectedIndexChanged);
            // 
            // lbCourse
            // 
            this.lbCourse.AutoSize = true;
            this.lbCourse.Location = new System.Drawing.Point(13, 13);
            this.lbCourse.Name = "lbCourse";
            this.lbCourse.Size = new System.Drawing.Size(46, 13);
            this.lbCourse.TabIndex = 2;
            this.lbCourse.Text = "Course :";
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Location = new System.Drawing.Point(405, 2);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(100, 39);
            this.btnDeleteCourse.TabIndex = 3;
            this.btnDeleteCourse.Text = "Supprimer";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            this.btnDeleteCourse.Visible = false;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // btnImport
            // 
            this.btnImport.Enabled = false;
            this.btnImport.Location = new System.Drawing.Point(1389, 38);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(122, 51);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Importer";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // ofdChooseCsv
            // 
            this.ofdChooseCsv.InitialDirectory = "../../CSV";
            // 
            // cbRecherche
            // 
            this.cbRecherche.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbRecherche.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbRecherche.FormattingEnabled = true;
            this.cbRecherche.Location = new System.Drawing.Point(207, 19);
            this.cbRecherche.Name = "cbRecherche";
            this.cbRecherche.Size = new System.Drawing.Size(283, 21);
            this.cbRecherche.TabIndex = 6;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Enabled = false;
            this.btnRechercher.Location = new System.Drawing.Point(496, 17);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 8;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // gbRecherche
            // 
            this.gbRecherche.Controls.Add(this.btnRechercherAge);
            this.gbRecherche.Controls.Add(this.tbAgeMax);
            this.gbRecherche.Controls.Add(this.tbAgeMini);
            this.gbRecherche.Controls.Add(this.lbAgeMax);
            this.gbRecherche.Controls.Add(this.lbAgeMini);
            this.gbRecherche.Controls.Add(this.lbTrancheAge);
            this.gbRecherche.Controls.Add(this.lbNomDossard);
            this.gbRecherche.Controls.Add(this.btnRechercher);
            this.gbRecherche.Controls.Add(this.cbRecherche);
            this.gbRecherche.Location = new System.Drawing.Point(761, 10);
            this.gbRecherche.Name = "gbRecherche";
            this.gbRecherche.Size = new System.Drawing.Size(580, 91);
            this.gbRecherche.TabIndex = 9;
            this.gbRecherche.TabStop = false;
            this.gbRecherche.Text = "Rechercher";
            // 
            // btnRechercherAge
            // 
            this.btnRechercherAge.Enabled = false;
            this.btnRechercherAge.Location = new System.Drawing.Point(496, 57);
            this.btnRechercherAge.Name = "btnRechercherAge";
            this.btnRechercherAge.Size = new System.Drawing.Size(75, 23);
            this.btnRechercherAge.TabIndex = 10;
            this.btnRechercherAge.Text = "Rechercher";
            this.btnRechercherAge.UseVisualStyleBackColor = true;
            this.btnRechercherAge.Click += new System.EventHandler(this.btnRechercherAge_Click);
            // 
            // tbAgeMax
            // 
            this.tbAgeMax.Location = new System.Drawing.Point(390, 59);
            this.tbAgeMax.Name = "tbAgeMax";
            this.tbAgeMax.ReadOnly = true;
            this.tbAgeMax.Size = new System.Drawing.Size(100, 20);
            this.tbAgeMax.TabIndex = 14;
            // 
            // tbAgeMini
            // 
            this.tbAgeMini.Location = new System.Drawing.Point(207, 59);
            this.tbAgeMini.Name = "tbAgeMini";
            this.tbAgeMini.Size = new System.Drawing.Size(100, 20);
            this.tbAgeMini.TabIndex = 13;
            // 
            // lbAgeMax
            // 
            this.lbAgeMax.AutoSize = true;
            this.lbAgeMax.Location = new System.Drawing.Point(313, 62);
            this.lbAgeMax.Name = "lbAgeMax";
            this.lbAgeMax.Size = new System.Drawing.Size(78, 13);
            this.lbAgeMax.TabIndex = 12;
            this.lbAgeMax.Text = "Age maximum :";
            // 
            // lbAgeMini
            // 
            this.lbAgeMini.AutoSize = true;
            this.lbAgeMini.Location = new System.Drawing.Point(126, 62);
            this.lbAgeMini.Name = "lbAgeMini";
            this.lbAgeMini.Size = new System.Drawing.Size(75, 13);
            this.lbAgeMini.TabIndex = 11;
            this.lbAgeMini.Text = "Age minimum :";
            // 
            // lbTrancheAge
            // 
            this.lbTrancheAge.AutoSize = true;
            this.lbTrancheAge.Location = new System.Drawing.Point(6, 62);
            this.lbTrancheAge.Name = "lbTrancheAge";
            this.lbTrancheAge.Size = new System.Drawing.Size(103, 13);
            this.lbTrancheAge.TabIndex = 10;
            this.lbTrancheAge.Text = "Tranche de 10 ans :";
            // 
            // lbNomDossard
            // 
            this.lbNomDossard.AutoSize = true;
            this.lbNomDossard.Location = new System.Drawing.Point(111, 22);
            this.lbNomDossard.Name = "lbNomDossard";
            this.lbNomDossard.Size = new System.Drawing.Size(90, 13);
            this.lbNomDossard.TabIndex = 9;
            this.lbNomDossard.Text = "Nom ou dossard :";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Enabled = false;
            this.btn_ajouter.Location = new System.Drawing.Point(4, 107);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(84, 47);
            this.btn_ajouter.TabIndex = 10;
            this.btn_ajouter.Text = "Nouveau participant";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Visible = false;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(4, 160);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 40);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edition";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnModifierCourse
            // 
            this.btnModifierCourse.Location = new System.Drawing.Point(511, 2);
            this.btnModifierCourse.Name = "btnModifierCourse";
            this.btnModifierCourse.Size = new System.Drawing.Size(86, 39);
            this.btnModifierCourse.TabIndex = 12;
            this.btnModifierCourse.Text = "Modifier";
            this.btnModifierCourse.UseVisualStyleBackColor = true;
            this.btnModifierCourse.Visible = false;
            this.btnModifierCourse.Click += new System.EventHandler(this.btnModifierCourse_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(4, 52);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 40);
            this.btnConnect.TabIndex = 13;
            this.btnConnect.Text = "Connexion";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Classement
            // 
            this.Classement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Classement.HeaderText = "Classement";
            this.Classement.Name = "Classement";
            this.Classement.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // NumDossard
            // 
            this.NumDossard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumDossard.HeaderText = "Numéro Dossard";
            this.NumDossard.Name = "NumDossard";
            this.NumDossard.ReadOnly = true;
            // 
            // Temps
            // 
            this.Temps.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Temps.HeaderText = "Temps";
            this.Temps.Name = "Temps";
            this.Temps.ReadOnly = true;
            // 
            // VitMoy
            // 
            this.VitMoy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VitMoy.HeaderText = "Vitesse moyenne (km/h)";
            this.VitMoy.Name = "VitMoy";
            this.VitMoy.ReadOnly = true;
            // 
            // AllureMoy
            // 
            this.AllureMoy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AllureMoy.HeaderText = "Allure moyenne (min/km)";
            this.AllureMoy.Name = "AllureMoy";
            this.AllureMoy.ReadOnly = true;
            // 
            // FormMenu
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1604, 784);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnModifierCourse);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnDeleteCourse);
            this.Controls.Add(this.lbCourse);
            this.Controls.Add(this.cbCourse);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.gbRecherche);
            this.Name = "FormMenu";
            this.tabControl.ResumeLayout(false);
            this.tabControl_participants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).EndInit();
            this.tabControl_resultats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultats)).EndInit();
            this.gbRecherche.ResumeLayout(false);
            this.gbRecherche.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabControl_participants;
        private System.Windows.Forms.TabPage tabControl_resultats;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.Label lbCourse;
        private System.Windows.Forms.DataGridView dgvResultats;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.OpenFileDialog ofdChooseCsv;
        private System.Windows.Forms.ComboBox cbRecherche;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.GroupBox gbRecherche;
        private System.Windows.Forms.Button btnRechercherAge;
        private System.Windows.Forms.TextBox tbAgeMax;
        private System.Windows.Forms.TextBox tbAgeMini;
        private System.Windows.Forms.Label lbAgeMax;
        private System.Windows.Forms.Label lbAgeMini;
        private System.Windows.Forms.Label lbTrancheAge;
        private System.Windows.Forms.Label lbNomDossard;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgvParticipants;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateNaissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Licence;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnModifierCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumDossard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temps;
        private System.Windows.Forms.DataGridViewTextBoxColumn VitMoy;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllureMoy;
    }
}