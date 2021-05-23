
namespace PPE
{
    partial class main
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlAtelier = new System.Windows.Forms.TabControl();
            this.tabPageHoraire = new System.Windows.Forms.TabPage();
            this.btnHoraire = new System.Windows.Forms.Button();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.lblHoraireFin = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblHoraireDebut = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblNomAtelier = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cbxAtelier = new System.Windows.Forms.ComboBox();
            this.tabPageIntervenant = new System.Windows.Forms.TabPage();
            this.lblAffectation = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.cbxIntervenant4 = new System.Windows.Forms.ComboBox();
            this.cbxIntervenant3 = new System.Windows.Forms.ComboBox();
            this.cbxIntervenant2 = new System.Windows.Forms.ComboBox();
            this.cbxIntervenant1 = new System.Windows.Forms.ComboBox();
            this.cbxAtelierAnimateur = new System.Windows.Forms.ComboBox();
            this.btnAffecter = new System.Windows.Forms.Button();
            this.cbxAnimateur = new System.Windows.Forms.ComboBox();
            this.inscription = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbBenevole = new System.Windows.Forms.ComboBox();
            this.cbbAtelier = new System.Windows.Forms.ComboBox();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbPortable = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbMail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbAdresse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreer = new System.Windows.Forms.Button();
            this.tabParticipant = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.dataParticipants = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atelier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvTheme = new System.Windows.Forms.DataGridView();
            this.dgvIntervenant = new System.Windows.Forms.DataGridView();
            this.lblTheme = new System.Windows.Forms.Label();
            this.lblntervenant = new System.Windows.Forms.Label();
            this.txbAnimateur = new System.Windows.Forms.TextBox();
            this.lblAnimateur = new System.Windows.Forms.Label();
            this.txbAtelier = new System.Windows.Forms.TextBox();
            this.lblAtelierAll = new System.Windows.Forms.Label();
            this.cbxAtelierAll = new System.Windows.Forms.ComboBox();
            this.lblAtelierAnimateur = new System.Windows.Forms.Label();
            this.lblChoisirIntervenant = new System.Windows.Forms.Label();
            this.lblChoisirAnimateur = new System.Windows.Forms.Label();
            this.lblChoisirAtelierAll = new System.Windows.Forms.Label();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.tabControlAtelier.SuspendLayout();
            this.tabPageHoraire.SuspendLayout();
            this.tabPageIntervenant.SuspendLayout();
            this.inscription.SuspendLayout();
            this.tabParticipant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataParticipants)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervenant)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAtelier
            // 
            this.tabControlAtelier.Controls.Add(this.tabPageHoraire);
            this.tabControlAtelier.Controls.Add(this.tabPageIntervenant);
            this.tabControlAtelier.Controls.Add(this.inscription);
            this.tabControlAtelier.Controls.Add(this.tabParticipant);
            this.tabControlAtelier.Controls.Add(this.tabPage1);
            this.tabControlAtelier.Location = new System.Drawing.Point(12, 12);
            this.tabControlAtelier.Name = "tabControlAtelier";
            this.tabControlAtelier.SelectedIndex = 0;
            this.tabControlAtelier.Size = new System.Drawing.Size(758, 392);
            this.tabControlAtelier.TabIndex = 0;
            // 
            // tabPageHoraire
            // 
            this.tabPageHoraire.Controls.Add(this.btnHoraire);
            this.tabPageHoraire.Controls.Add(this.dtpFin);
            this.tabPageHoraire.Controls.Add(this.dtpDebut);
            this.tabPageHoraire.Controls.Add(this.label13);
            this.tabPageHoraire.Controls.Add(this.lblHoraireFin);
            this.tabPageHoraire.Controls.Add(this.label15);
            this.tabPageHoraire.Controls.Add(this.lblHoraireDebut);
            this.tabPageHoraire.Controls.Add(this.label17);
            this.tabPageHoraire.Controls.Add(this.lblNomAtelier);
            this.tabPageHoraire.Controls.Add(this.label19);
            this.tabPageHoraire.Controls.Add(this.cbxAtelier);
            this.tabPageHoraire.Location = new System.Drawing.Point(4, 22);
            this.tabPageHoraire.Name = "tabPageHoraire";
            this.tabPageHoraire.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHoraire.Size = new System.Drawing.Size(750, 366);
            this.tabPageHoraire.TabIndex = 0;
            this.tabPageHoraire.Text = "Afficher Horaire";
            this.tabPageHoraire.UseVisualStyleBackColor = true;
            this.tabPageHoraire.Enter += new System.EventHandler(this.tabPageHoraire_Enter);
            // 
            // btnHoraire
            // 
            this.btnHoraire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnHoraire.Location = new System.Drawing.Point(50, 291);
            this.btnHoraire.Name = "btnHoraire";
            this.btnHoraire.Size = new System.Drawing.Size(187, 42);
            this.btnHoraire.TabIndex = 17;
            this.btnHoraire.Text = "Affecter Horaire";
            this.btnHoraire.UseVisualStyleBackColor = true;
            this.btnHoraire.Click += new System.EventHandler(this.btnHoraire_Click);
            // 
            // dtpFin
            // 
            this.dtpFin.CustomFormat = "ddMMMM yyyy  HH:mm";
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFin.Location = new System.Drawing.Point(50, 235);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(187, 20);
            this.dtpFin.TabIndex = 16;
            this.dtpFin.ValueChanged += new System.EventHandler(this.dtpFin_ValueChanged);
            // 
            // dtpDebut
            // 
            this.dtpDebut.CustomFormat = "ddMMMM yyyy  HH:mm";
            this.dtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDebut.Location = new System.Drawing.Point(50, 204);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(187, 20);
            this.dtpDebut.TabIndex = 15;
            this.dtpDebut.ValueChanged += new System.EventHandler(this.dtpDebut_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(270, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "HORAIRE ATELIER";
            // 
            // lblHoraireFin
            // 
            this.lblHoraireFin.AutoSize = true;
            this.lblHoraireFin.Location = new System.Drawing.Point(370, 212);
            this.lblHoraireFin.Name = "lblHoraireFin";
            this.lblHoraireFin.Size = new System.Drawing.Size(53, 13);
            this.lblHoraireFin.TabIndex = 14;
            this.lblHoraireFin.Text = "horaire fin";
            this.lblHoraireFin.Click += new System.EventHandler(this.lblHoraireFin_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(270, 208);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 17);
            this.label15.TabIndex = 13;
            this.label15.Text = "Horaire Fin:";
            // 
            // lblHoraireDebut
            // 
            this.lblHoraireDebut.AutoSize = true;
            this.lblHoraireDebut.Location = new System.Drawing.Point(370, 181);
            this.lblHoraireDebut.Name = "lblHoraireDebut";
            this.lblHoraireDebut.Size = new System.Drawing.Size(69, 13);
            this.lblHoraireDebut.TabIndex = 12;
            this.lblHoraireDebut.Text = "horaire debut";
            this.lblHoraireDebut.Click += new System.EventHandler(this.lblHoraireDebut_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(249, 181);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 17);
            this.label17.TabIndex = 11;
            this.label17.Text = "Horaire Debut:";
            // 
            // lblNomAtelier
            // 
            this.lblNomAtelier.AutoSize = true;
            this.lblNomAtelier.Location = new System.Drawing.Point(370, 146);
            this.lblNomAtelier.Name = "lblNomAtelier";
            this.lblNomAtelier.Size = new System.Drawing.Size(27, 13);
            this.lblNomAtelier.TabIndex = 10;
            this.lblNomAtelier.Text = "nom";
            this.lblNomAtelier.Click += new System.EventHandler(this.lblNomAtelier_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(232, 146);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(132, 17);
            this.label19.TabIndex = 9;
            this.label19.Text = "Nom de l\'atelier :";
            // 
            // cbxAtelier
            // 
            this.cbxAtelier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAtelier.FormattingEnabled = true;
            this.cbxAtelier.Location = new System.Drawing.Point(276, 94);
            this.cbxAtelier.Name = "cbxAtelier";
            this.cbxAtelier.Size = new System.Drawing.Size(113, 21);
            this.cbxAtelier.TabIndex = 7;
            this.cbxAtelier.SelectedIndexChanged += new System.EventHandler(this.cbxAtelier_SelectedIndexChanged);
            // 
            // tabPageIntervenant
            // 
            this.tabPageIntervenant.Controls.Add(this.lblChoisirAnimateur);
            this.tabPageIntervenant.Controls.Add(this.lblChoisirIntervenant);
            this.tabPageIntervenant.Controls.Add(this.lblAtelierAnimateur);
            this.tabPageIntervenant.Controls.Add(this.lblAffectation);
            this.tabPageIntervenant.Controls.Add(this.btnAnnuler);
            this.tabPageIntervenant.Controls.Add(this.cbxIntervenant4);
            this.tabPageIntervenant.Controls.Add(this.cbxIntervenant3);
            this.tabPageIntervenant.Controls.Add(this.cbxIntervenant2);
            this.tabPageIntervenant.Controls.Add(this.cbxIntervenant1);
            this.tabPageIntervenant.Controls.Add(this.cbxAtelierAnimateur);
            this.tabPageIntervenant.Controls.Add(this.btnAffecter);
            this.tabPageIntervenant.Controls.Add(this.cbxAnimateur);
            this.tabPageIntervenant.Location = new System.Drawing.Point(4, 22);
            this.tabPageIntervenant.Name = "tabPageIntervenant";
            this.tabPageIntervenant.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIntervenant.Size = new System.Drawing.Size(750, 366);
            this.tabPageIntervenant.TabIndex = 1;
            this.tabPageIntervenant.Text = "Affecter un animateur";
            this.tabPageIntervenant.UseVisualStyleBackColor = true;
            // 
            // lblAffectation
            // 
            this.lblAffectation.AutoSize = true;
            this.lblAffectation.Location = new System.Drawing.Point(302, 341);
            this.lblAffectation.Name = "lblAffectation";
            this.lblAffectation.Size = new System.Drawing.Size(0, 13);
            this.lblAffectation.TabIndex = 17;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAnnuler.Location = new System.Drawing.Point(421, 227);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(143, 42);
            this.btnAnnuler.TabIndex = 16;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // cbxIntervenant4
            // 
            this.cbxIntervenant4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIntervenant4.FormattingEnabled = true;
            this.cbxIntervenant4.Location = new System.Drawing.Point(578, 176);
            this.cbxIntervenant4.Name = "cbxIntervenant4";
            this.cbxIntervenant4.Size = new System.Drawing.Size(106, 21);
            this.cbxIntervenant4.TabIndex = 15;
            this.cbxIntervenant4.SelectedIndexChanged += new System.EventHandler(this.cbxIntervenant4_SelectedIndexChanged);
            // 
            // cbxIntervenant3
            // 
            this.cbxIntervenant3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIntervenant3.FormattingEnabled = true;
            this.cbxIntervenant3.Location = new System.Drawing.Point(449, 176);
            this.cbxIntervenant3.Name = "cbxIntervenant3";
            this.cbxIntervenant3.Size = new System.Drawing.Size(110, 21);
            this.cbxIntervenant3.TabIndex = 14;
            this.cbxIntervenant3.SelectedIndexChanged += new System.EventHandler(this.cbxIntervenant3_SelectedIndexChanged);
            // 
            // cbxIntervenant2
            // 
            this.cbxIntervenant2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIntervenant2.FormattingEnabled = true;
            this.cbxIntervenant2.Location = new System.Drawing.Point(324, 176);
            this.cbxIntervenant2.Name = "cbxIntervenant2";
            this.cbxIntervenant2.Size = new System.Drawing.Size(109, 21);
            this.cbxIntervenant2.TabIndex = 13;
            this.cbxIntervenant2.SelectedIndexChanged += new System.EventHandler(this.cbxIntervenant2_SelectedIndexChanged);
            // 
            // cbxIntervenant1
            // 
            this.cbxIntervenant1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIntervenant1.FormattingEnabled = true;
            this.cbxIntervenant1.Location = new System.Drawing.Point(206, 176);
            this.cbxIntervenant1.Name = "cbxIntervenant1";
            this.cbxIntervenant1.Size = new System.Drawing.Size(98, 21);
            this.cbxIntervenant1.TabIndex = 12;
            this.cbxIntervenant1.SelectedIndexChanged += new System.EventHandler(this.cbxIntervenant1_SelectedIndexChanged);
            // 
            // cbxAtelierAnimateur
            // 
            this.cbxAtelierAnimateur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAtelierAnimateur.FormattingEnabled = true;
            this.cbxAtelierAnimateur.Location = new System.Drawing.Point(206, 122);
            this.cbxAtelierAnimateur.Name = "cbxAtelierAnimateur";
            this.cbxAtelierAnimateur.Size = new System.Drawing.Size(143, 21);
            this.cbxAtelierAnimateur.TabIndex = 11;
            this.cbxAtelierAnimateur.SelectedIndexChanged += new System.EventHandler(this.cbxAtelierAnimateur_SelectedIndexChanged_1);
            // 
            // btnAffecter
            // 
            this.btnAffecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAffecter.Location = new System.Drawing.Point(206, 227);
            this.btnAffecter.Name = "btnAffecter";
            this.btnAffecter.Size = new System.Drawing.Size(143, 42);
            this.btnAffecter.TabIndex = 10;
            this.btnAffecter.Text = "Affecter";
            this.btnAffecter.UseVisualStyleBackColor = true;
            this.btnAffecter.Click += new System.EventHandler(this.btnAffecter_Click);
            // 
            // cbxAnimateur
            // 
            this.cbxAnimateur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAnimateur.FormattingEnabled = true;
            this.cbxAnimateur.Location = new System.Drawing.Point(206, 67);
            this.cbxAnimateur.Name = "cbxAnimateur";
            this.cbxAnimateur.Size = new System.Drawing.Size(143, 21);
            this.cbxAnimateur.TabIndex = 9;
            this.cbxAnimateur.SelectedIndexChanged += new System.EventHandler(this.cbxAnimateur_SelectedIndexChanged_1);
            // 
            // inscription
            // 
            this.inscription.Controls.Add(this.btnActualiser);
            this.inscription.Controls.Add(this.label12);
            this.inscription.Controls.Add(this.label11);
            this.inscription.Controls.Add(this.cbbBenevole);
            this.inscription.Controls.Add(this.cbbAtelier);
            this.inscription.Controls.Add(this.cbbType);
            this.inscription.Controls.Add(this.label6);
            this.inscription.Controls.Add(this.label7);
            this.inscription.Controls.Add(this.txbPortable);
            this.inscription.Controls.Add(this.label8);
            this.inscription.Controls.Add(this.txbMail);
            this.inscription.Controls.Add(this.label9);
            this.inscription.Controls.Add(this.txbAdresse);
            this.inscription.Controls.Add(this.label4);
            this.inscription.Controls.Add(this.label5);
            this.inscription.Controls.Add(this.txbPrenom);
            this.inscription.Controls.Add(this.label2);
            this.inscription.Controls.Add(this.txbNom);
            this.inscription.Controls.Add(this.label1);
            this.inscription.Controls.Add(this.btnCreer);
            this.inscription.Location = new System.Drawing.Point(4, 22);
            this.inscription.Name = "inscription";
            this.inscription.Padding = new System.Windows.Forms.Padding(3);
            this.inscription.Size = new System.Drawing.Size(750, 366);
            this.inscription.TabIndex = 2;
            this.inscription.Text = "Inscription participant";
            this.inscription.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(478, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(230, 37);
            this.label12.TabIndex = 21;
            this.label12.Text = "* : Informations obligatoires";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(166, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(313, 40);
            this.label11.TabIndex = 20;
            this.label11.Text = "Inscription des participants";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbBenevole
            // 
            this.cbbBenevole.FormattingEnabled = true;
            this.cbbBenevole.Location = new System.Drawing.Point(327, 205);
            this.cbbBenevole.Name = "cbbBenevole";
            this.cbbBenevole.Size = new System.Drawing.Size(101, 21);
            this.cbbBenevole.TabIndex = 19;
            this.cbbBenevole.SelectedIndexChanged += new System.EventHandler(this.cbbBenevole_SelectedIndexChanged);
            // 
            // cbbAtelier
            // 
            this.cbbAtelier.FormattingEnabled = true;
            this.cbbAtelier.Location = new System.Drawing.Point(221, 205);
            this.cbbAtelier.Name = "cbbAtelier";
            this.cbbAtelier.Size = new System.Drawing.Size(101, 21);
            this.cbbAtelier.TabIndex = 18;
            this.cbbAtelier.SelectedIndexChanged += new System.EventHandler(this.cbbAtelier_SelectedIndexChanged);
            // 
            // cbbType
            // 
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Location = new System.Drawing.Point(378, 69);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(101, 21);
            this.cbbType.TabIndex = 17;
            this.cbbType.SelectedIndexChanged += new System.EventHandler(this.cbbType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(327, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 38);
            this.label6.TabIndex = 15;
            this.label6.Text = "Benevole ?*";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(221, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 38);
            this.label7.TabIndex = 13;
            this.label7.Text = "Atelier*";
            // 
            // txbPortable
            // 
            this.txbPortable.Location = new System.Drawing.Point(378, 144);
            this.txbPortable.Name = "txbPortable";
            this.txbPortable.Size = new System.Drawing.Size(101, 20);
            this.txbPortable.TabIndex = 12;
            this.txbPortable.TextChanged += new System.EventHandler(this.txbPortable_TextChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(378, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 38);
            this.label8.TabIndex = 11;
            this.label8.Text = "Numero de telephone*";
            // 
            // txbMail
            // 
            this.txbMail.Location = new System.Drawing.Point(272, 144);
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(101, 20);
            this.txbMail.TabIndex = 10;
            this.txbMail.TextChanged += new System.EventHandler(this.txbMail_TextChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(272, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 38);
            this.label9.TabIndex = 9;
            this.label9.Text = "Mail*";
            // 
            // txbAdresse
            // 
            this.txbAdresse.Location = new System.Drawing.Point(166, 144);
            this.txbAdresse.Name = "txbAdresse";
            this.txbAdresse.Size = new System.Drawing.Size(101, 20);
            this.txbAdresse.TabIndex = 8;
            this.txbAdresse.TextChanged += new System.EventHandler(this.txbAdresse_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(166, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adresse*";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(378, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 38);
            this.label5.TabIndex = 5;
            this.label5.Text = "Type*";
            // 
            // txbPrenom
            // 
            this.txbPrenom.Location = new System.Drawing.Point(272, 69);
            this.txbPrenom.Name = "txbPrenom";
            this.txbPrenom.Size = new System.Drawing.Size(101, 20);
            this.txbPrenom.TabIndex = 4;
            this.txbPrenom.TextChanged += new System.EventHandler(this.txbPrenom_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prenom*";
            // 
            // txbNom
            // 
            this.txbNom.Location = new System.Drawing.Point(166, 69);
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(101, 20);
            this.txbNom.TabIndex = 2;
            this.txbNom.TextChanged += new System.EventHandler(this.txbNom_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom*";
            // 
            // btnCreer
            // 
            this.btnCreer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreer.Location = new System.Drawing.Point(221, 254);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(207, 55);
            this.btnCreer.TabIndex = 0;
            this.btnCreer.Text = "Ajouter participant";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // tabParticipant
            // 
            this.tabParticipant.Controls.Add(this.label10);
            this.tabParticipant.Controls.Add(this.dataParticipants);
            this.tabParticipant.Location = new System.Drawing.Point(4, 22);
            this.tabParticipant.Name = "tabParticipant";
            this.tabParticipant.Padding = new System.Windows.Forms.Padding(3);
            this.tabParticipant.Size = new System.Drawing.Size(750, 366);
            this.tabParticipant.TabIndex = 3;
            this.tabParticipant.Text = "Liste participants";
            this.tabParticipant.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(256, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "Liste des participants";
            // 
            // dataParticipants
            // 
            this.dataParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataParticipants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Type,
            this.Atelier});
            this.dataParticipants.Location = new System.Drawing.Point(3, 35);
            this.dataParticipants.Name = "dataParticipants";
            this.dataParticipants.Size = new System.Drawing.Size(705, 284);
            this.dataParticipants.TabIndex = 0;
            this.dataParticipants.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataParticipants_CellContentClick);
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.Width = 220;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type participant";
            this.Type.Name = "Type";
            this.Type.Width = 220;
            // 
            // Atelier
            // 
            this.Atelier.HeaderText = "Atelier";
            this.Atelier.Name = "Atelier";
            this.Atelier.Width = 220;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblChoisirAtelierAll);
            this.tabPage1.Controls.Add(this.dgvTheme);
            this.tabPage1.Controls.Add(this.dgvIntervenant);
            this.tabPage1.Controls.Add(this.lblTheme);
            this.tabPage1.Controls.Add(this.lblntervenant);
            this.tabPage1.Controls.Add(this.txbAnimateur);
            this.tabPage1.Controls.Add(this.lblAnimateur);
            this.tabPage1.Controls.Add(this.txbAtelier);
            this.tabPage1.Controls.Add(this.lblAtelierAll);
            this.tabPage1.Controls.Add(this.cbxAtelierAll);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(750, 366);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Afficher les ateliers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvTheme
            // 
            this.dgvTheme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheme.Location = new System.Drawing.Point(533, 80);
            this.dgvTheme.Name = "dgvTheme";
            this.dgvTheme.Size = new System.Drawing.Size(187, 252);
            this.dgvTheme.TabIndex = 17;
            this.dgvTheme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTheme_CellContentClick);
            // 
            // dgvIntervenant
            // 
            this.dgvIntervenant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntervenant.Location = new System.Drawing.Point(295, 77);
            this.dgvIntervenant.Name = "dgvIntervenant";
            this.dgvIntervenant.Size = new System.Drawing.Size(187, 255);
            this.dgvIntervenant.TabIndex = 16;
            this.dgvIntervenant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIntervenant_CellContentClick);
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTheme.Location = new System.Drawing.Point(593, 37);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(75, 17);
            this.lblTheme.TabIndex = 15;
            this.lblTheme.Text = "Themes :";
            // 
            // lblntervenant
            // 
            this.lblntervenant.AutoSize = true;
            this.lblntervenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblntervenant.Location = new System.Drawing.Point(334, 37);
            this.lblntervenant.Name = "lblntervenant";
            this.lblntervenant.Size = new System.Drawing.Size(100, 17);
            this.lblntervenant.TabIndex = 14;
            this.lblntervenant.Text = "Intervenant :";
            // 
            // txbAnimateur
            // 
            this.txbAnimateur.Location = new System.Drawing.Point(103, 237);
            this.txbAnimateur.Name = "txbAnimateur";
            this.txbAnimateur.Size = new System.Drawing.Size(186, 20);
            this.txbAnimateur.TabIndex = 13;
            // 
            // lblAnimateur
            // 
            this.lblAnimateur.AutoSize = true;
            this.lblAnimateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAnimateur.Location = new System.Drawing.Point(6, 237);
            this.lblAnimateur.Name = "lblAnimateur";
            this.lblAnimateur.Size = new System.Drawing.Size(91, 17);
            this.lblAnimateur.TabIndex = 12;
            this.lblAnimateur.Text = "Animateur :";
            // 
            // txbAtelier
            // 
            this.txbAtelier.Location = new System.Drawing.Point(103, 180);
            this.txbAtelier.Name = "txbAtelier";
            this.txbAtelier.Size = new System.Drawing.Size(186, 20);
            this.txbAtelier.TabIndex = 11;
            this.txbAtelier.TextChanged += new System.EventHandler(this.txbAtelier_TextChanged);
            // 
            // lblAtelierAll
            // 
            this.lblAtelierAll.AutoSize = true;
            this.lblAtelierAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAtelierAll.Location = new System.Drawing.Point(32, 180);
            this.lblAtelierAll.Name = "lblAtelierAll";
            this.lblAtelierAll.Size = new System.Drawing.Size(65, 17);
            this.lblAtelierAll.TabIndex = 10;
            this.lblAtelierAll.Text = "Atelier :";
            // 
            // cbxAtelierAll
            // 
            this.cbxAtelierAll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAtelierAll.FormattingEnabled = true;
            this.cbxAtelierAll.Location = new System.Drawing.Point(60, 103);
            this.cbxAtelierAll.Name = "cbxAtelierAll";
            this.cbxAtelierAll.Size = new System.Drawing.Size(186, 21);
            this.cbxAtelierAll.TabIndex = 9;
            this.cbxAtelierAll.SelectedIndexChanged += new System.EventHandler(this.cbxAtelierAll_SelectedIndexChanged);
            // 
            // lblAtelierAnimateur
            // 
            this.lblAtelierAnimateur.AutoSize = true;
            this.lblAtelierAnimateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAtelierAnimateur.Location = new System.Drawing.Point(53, 126);
            this.lblAtelierAnimateur.Name = "lblAtelierAnimateur";
            this.lblAtelierAnimateur.Size = new System.Drawing.Size(142, 17);
            this.lblAtelierAnimateur.TabIndex = 18;
            this.lblAtelierAnimateur.Text = "Choisir un atelier :";
            // 
            // lblChoisirIntervenant
            // 
            this.lblChoisirIntervenant.AutoSize = true;
            this.lblChoisirIntervenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblChoisirIntervenant.Location = new System.Drawing.Point(6, 176);
            this.lblChoisirIntervenant.Name = "lblChoisirIntervenant";
            this.lblChoisirIntervenant.Size = new System.Drawing.Size(189, 17);
            this.lblChoisirIntervenant.TabIndex = 19;
            this.lblChoisirIntervenant.Text = "Choisir les intervenants :";
            // 
            // lblChoisirAnimateur
            // 
            this.lblChoisirAnimateur.AutoSize = true;
            this.lblChoisirAnimateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblChoisirAnimateur.Location = new System.Drawing.Point(27, 71);
            this.lblChoisirAnimateur.Name = "lblChoisirAnimateur";
            this.lblChoisirAnimateur.Size = new System.Drawing.Size(168, 17);
            this.lblChoisirAnimateur.TabIndex = 20;
            this.lblChoisirAnimateur.Text = "Choisir un animateur :";
            // 
            // lblChoisirAtelierAll
            // 
            this.lblChoisirAtelierAll.AutoSize = true;
            this.lblChoisirAtelierAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblChoisirAtelierAll.Location = new System.Drawing.Point(78, 55);
            this.lblChoisirAtelierAll.Name = "lblChoisirAtelierAll";
            this.lblChoisirAtelierAll.Size = new System.Drawing.Size(142, 17);
            this.lblChoisirAtelierAll.TabIndex = 19;
            this.lblChoisirAtelierAll.Text = "Choisir un atelier :";
            // 
            // btnActualiser
            // 
            this.btnActualiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualiser.Location = new System.Drawing.Point(482, 294);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(207, 55);
            this.btnActualiser.TabIndex = 22;
            this.btnActualiser.Text = "Actualiser l\'application";
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 416);
            this.Controls.Add(this.tabControlAtelier);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.Load += new System.EventHandler(this.main_Load);
            this.tabControlAtelier.ResumeLayout(false);
            this.tabPageHoraire.ResumeLayout(false);
            this.tabPageHoraire.PerformLayout();
            this.tabPageIntervenant.ResumeLayout(false);
            this.tabPageIntervenant.PerformLayout();
            this.inscription.ResumeLayout(false);
            this.inscription.PerformLayout();
            this.tabParticipant.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataParticipants)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervenant)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnHoraire;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpDebut;

        private System.Windows.Forms.Label lblAffectation;

        private System.Windows.Forms.DataGridView dgvTheme;
        private System.Windows.Forms.DataGridView dgvIntervenant;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.Label lblntervenant;
        private System.Windows.Forms.TextBox txbAnimateur;
        private System.Windows.Forms.Label lblAnimateur;
        private System.Windows.Forms.TextBox txbAtelier;
        private System.Windows.Forms.Label lblAtelierAll;
        private System.Windows.Forms.ComboBox cbxAtelierAll;

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ComboBox cbxIntervenant4;
        private System.Windows.Forms.ComboBox cbxIntervenant3;
        private System.Windows.Forms.ComboBox cbxIntervenant2;
        private System.Windows.Forms.ComboBox cbxIntervenant1;
        private System.Windows.Forms.Button btnAffecter;

        private System.Windows.Forms.Label lblHoraireFin;

        private System.Windows.Forms.Label lblNomAtelier;
        private System.Windows.Forms.Label lblHoraireDebut;

        private System.Windows.Forms.ComboBox cbxAtelier;

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label13;
        
        private System.Windows.Forms.Label label15;
        
        private System.Windows.Forms.Label label17;
        
        private System.Windows.Forms.Label label19;
        

        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atelier;

        private System.Windows.Forms.DataGridView dataParticipants;

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabParticipant;

        private System.Windows.Forms.Button btnCreer;

        private System.Windows.Forms.ComboBox cbbBenevole;

        private System.Windows.Forms.ComboBox cbbAtelier;

        private System.Windows.Forms.TextBox txbPortable;

        private System.Windows.Forms.TextBox txbMail;

        private System.Windows.Forms.TextBox txbAdresse;

        private System.Windows.Forms.ComboBox cbbType;

        private System.Windows.Forms.TextBox txbNom;
        private System.Windows.Forms.TextBox txbPrenom;

        private System.Windows.Forms.TabPage inscription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;

        #endregion

        private System.Windows.Forms.TabControl tabControlAtelier;
        private System.Windows.Forms.TabPage tabPageHoraire;
        private System.Windows.Forms.TabPage tabPageIntervenant;
        private System.Windows.Forms.ComboBox cbxAtelierAnimateur;
        private System.Windows.Forms.ComboBox cbxAnimateur;
        private System.Windows.Forms.Label lblChoisirAnimateur;
        private System.Windows.Forms.Label lblChoisirIntervenant;
        private System.Windows.Forms.Label lblAtelierAnimateur;
        private System.Windows.Forms.Label lblChoisirAtelierAll;
        private System.Windows.Forms.Button btnActualiser;
    }
}

