
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
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlAtelier = new System.Windows.Forms.TabControl();
            this.tabPageHoraire = new System.Windows.Forms.TabPage();
            this.lblChoisirAtelier = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHoraireFin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHoraireDebut = new System.Windows.Forms.Label();
            this.lblHoraire1 = new System.Windows.Forms.Label();
            this.lblNomAtelier = new System.Windows.Forms.Label();
            this.lblAtelier = new System.Windows.Forms.Label();
            this.cbxAtelier = new System.Windows.Forms.ComboBox();
            this.tabPageIntervenant = new System.Windows.Forms.TabPage();
            this.lblChoisirAnimateur = new System.Windows.Forms.Label();
            this.lblChoisirIntervenant = new System.Windows.Forms.Label();
            this.lblChoisirAtelierAnimateur = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblAffectation = new System.Windows.Forms.Label();
            this.cbxIntervenant4 = new System.Windows.Forms.ComboBox();
            this.cbxIntervenant3 = new System.Windows.Forms.ComboBox();
            this.cbxIntervenant2 = new System.Windows.Forms.ComboBox();
            this.cbxIntervenant1 = new System.Windows.Forms.ComboBox();
            this.cbxAtelierAnimateur = new System.Windows.Forms.ComboBox();
            this.btnAffecter = new System.Windows.Forms.Button();
            this.cbxAnimateur = new System.Windows.Forms.ComboBox();
            this.tbAfficherAll = new System.Windows.Forms.TabPage();
            this.lblChoisirAtelierAll = new System.Windows.Forms.Label();
            this.dgvTheme = new System.Windows.Forms.DataGridView();
            this.dgvIntervenant = new System.Windows.Forms.DataGridView();
            this.lblTheme = new System.Windows.Forms.Label();
            this.lblntervenant = new System.Windows.Forms.Label();
            this.txbAnimateur = new System.Windows.Forms.TextBox();
            this.lblAnimateur = new System.Windows.Forms.Label();
            this.txbAtelier = new System.Windows.Forms.TextBox();
            this.lblAtelierAll = new System.Windows.Forms.Label();
            this.cbxAtelierAll = new System.Windows.Forms.ComboBox();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.btnHoraire = new System.Windows.Forms.Button();
            this.tabControlAtelier.SuspendLayout();
            this.tabPageHoraire.SuspendLayout();
            this.tabPageIntervenant.SuspendLayout();
            this.tbAfficherAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervenant)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAtelier
            // 
            this.tabControlAtelier.Controls.Add(this.tabPageHoraire);
            this.tabControlAtelier.Controls.Add(this.tabPageIntervenant);
            this.tabControlAtelier.Controls.Add(this.tbAfficherAll);
            this.tabControlAtelier.Location = new System.Drawing.Point(12, 12);
            this.tabControlAtelier.Name = "tabControlAtelier";
            this.tabControlAtelier.SelectedIndex = 0;
            this.tabControlAtelier.Size = new System.Drawing.Size(776, 426);
            this.tabControlAtelier.TabIndex = 0;
            // 
            // tabPageHoraire
            // 
            this.tabPageHoraire.Controls.Add(this.btnHoraire);
            this.tabPageHoraire.Controls.Add(this.dtpFin);
            this.tabPageHoraire.Controls.Add(this.dtpDebut);
            this.tabPageHoraire.Controls.Add(this.lblChoisirAtelier);
            this.tabPageHoraire.Controls.Add(this.label1);
            this.tabPageHoraire.Controls.Add(this.lblHoraireFin);
            this.tabPageHoraire.Controls.Add(this.label3);
            this.tabPageHoraire.Controls.Add(this.lblHoraireDebut);
            this.tabPageHoraire.Controls.Add(this.lblHoraire1);
            this.tabPageHoraire.Controls.Add(this.lblNomAtelier);
            this.tabPageHoraire.Controls.Add(this.lblAtelier);
            this.tabPageHoraire.Controls.Add(this.cbxAtelier);
            this.tabPageHoraire.Location = new System.Drawing.Point(4, 22);
            this.tabPageHoraire.Name = "tabPageHoraire";
            this.tabPageHoraire.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHoraire.Size = new System.Drawing.Size(768, 400);
            this.tabPageHoraire.TabIndex = 0;
            this.tabPageHoraire.Text = "Afficher Horaire";
            this.tabPageHoraire.UseVisualStyleBackColor = true;
            this.tabPageHoraire.Enter += new System.EventHandler(this.tabPageHoraire_Enter);
            // 
            // lblChoisirAtelier
            // 
            this.lblChoisirAtelier.AutoSize = true;
            this.lblChoisirAtelier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblChoisirAtelier.Location = new System.Drawing.Point(161, 129);
            this.lblChoisirAtelier.Name = "lblChoisirAtelier";
            this.lblChoisirAtelier.Size = new System.Drawing.Size(138, 17);
            this.lblChoisirAtelier.TabIndex = 7;
            this.lblChoisirAtelier.Text = "Choisir un Atelier:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(308, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "HORAIRE ATELIER";
            // 
            // lblHoraireFin
            // 
            this.lblHoraireFin.AutoSize = true;
            this.lblHoraireFin.Location = new System.Drawing.Point(399, 243);
            this.lblHoraireFin.Name = "lblHoraireFin";
            this.lblHoraireFin.Size = new System.Drawing.Size(53, 13);
            this.lblHoraireFin.TabIndex = 6;
            this.lblHoraireFin.Text = "horaire fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(299, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Horaire Fin:";
            // 
            // lblHoraireDebut
            // 
            this.lblHoraireDebut.AutoSize = true;
            this.lblHoraireDebut.Location = new System.Drawing.Point(399, 212);
            this.lblHoraireDebut.Name = "lblHoraireDebut";
            this.lblHoraireDebut.Size = new System.Drawing.Size(69, 13);
            this.lblHoraireDebut.TabIndex = 4;
            this.lblHoraireDebut.Text = "horaire debut";
            // 
            // lblHoraire1
            // 
            this.lblHoraire1.AutoSize = true;
            this.lblHoraire1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblHoraire1.Location = new System.Drawing.Point(278, 212);
            this.lblHoraire1.Name = "lblHoraire1";
            this.lblHoraire1.Size = new System.Drawing.Size(115, 17);
            this.lblHoraire1.TabIndex = 3;
            this.lblHoraire1.Text = "Horaire Debut:";
            // 
            // lblNomAtelier
            // 
            this.lblNomAtelier.AutoSize = true;
            this.lblNomAtelier.Location = new System.Drawing.Point(399, 177);
            this.lblNomAtelier.Name = "lblNomAtelier";
            this.lblNomAtelier.Size = new System.Drawing.Size(27, 13);
            this.lblNomAtelier.TabIndex = 2;
            this.lblNomAtelier.Text = "nom";
            // 
            // lblAtelier
            // 
            this.lblAtelier.AutoSize = true;
            this.lblAtelier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAtelier.Location = new System.Drawing.Point(261, 177);
            this.lblAtelier.Name = "lblAtelier";
            this.lblAtelier.Size = new System.Drawing.Size(132, 17);
            this.lblAtelier.TabIndex = 1;
            this.lblAtelier.Text = "Nom de l\'atelier :";
            // 
            // cbxAtelier
            // 
            this.cbxAtelier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAtelier.FormattingEnabled = true;
            this.cbxAtelier.Location = new System.Drawing.Point(305, 125);
            this.cbxAtelier.Name = "cbxAtelier";
            this.cbxAtelier.Size = new System.Drawing.Size(113, 21);
            this.cbxAtelier.TabIndex = 0;
            this.cbxAtelier.SelectedIndexChanged += new System.EventHandler(this.cbxAtelier_SelectedIndexChanged);
            // 
            // tabPageIntervenant
            // 
            this.tabPageIntervenant.Controls.Add(this.lblChoisirAnimateur);
            this.tabPageIntervenant.Controls.Add(this.lblChoisirIntervenant);
            this.tabPageIntervenant.Controls.Add(this.lblChoisirAtelierAnimateur);
            this.tabPageIntervenant.Controls.Add(this.btnAnnuler);
            this.tabPageIntervenant.Controls.Add(this.lblAffectation);
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
            this.tabPageIntervenant.Size = new System.Drawing.Size(768, 400);
            this.tabPageIntervenant.TabIndex = 1;
            this.tabPageIntervenant.Text = "Affecter un animateur";
            this.tabPageIntervenant.UseVisualStyleBackColor = true;
            // 
            // lblChoisirAnimateur
            // 
            this.lblChoisirAnimateur.AutoSize = true;
            this.lblChoisirAnimateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblChoisirAnimateur.Location = new System.Drawing.Point(26, 101);
            this.lblChoisirAnimateur.Name = "lblChoisirAnimateur";
            this.lblChoisirAnimateur.Size = new System.Drawing.Size(164, 17);
            this.lblChoisirAnimateur.TabIndex = 11;
            this.lblChoisirAnimateur.Text = "Choisir un Animateur:";
            // 
            // lblChoisirIntervenant
            // 
            this.lblChoisirIntervenant.AutoSize = true;
            this.lblChoisirIntervenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblChoisirIntervenant.Location = new System.Drawing.Point(6, 143);
            this.lblChoisirIntervenant.Name = "lblChoisirIntervenant";
            this.lblChoisirIntervenant.Size = new System.Drawing.Size(184, 17);
            this.lblChoisirIntervenant.TabIndex = 10;
            this.lblChoisirIntervenant.Text = "Choisir les intervenants:";
            // 
            // lblChoisirAtelierAnimateur
            // 
            this.lblChoisirAtelierAnimateur.AutoSize = true;
            this.lblChoisirAtelierAnimateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblChoisirAtelierAnimateur.Location = new System.Drawing.Point(52, 59);
            this.lblChoisirAtelierAnimateur.Name = "lblChoisirAtelierAnimateur";
            this.lblChoisirAtelierAnimateur.Size = new System.Drawing.Size(138, 17);
            this.lblChoisirAtelierAnimateur.TabIndex = 9;
            this.lblChoisirAtelierAnimateur.Text = "Choisir un Atelier:";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAnnuler.Location = new System.Drawing.Point(407, 224);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(143, 42);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // lblAffectation
            // 
            this.lblAffectation.AutoSize = true;
            this.lblAffectation.Location = new System.Drawing.Point(194, 298);
            this.lblAffectation.Name = "lblAffectation";
            this.lblAffectation.Size = new System.Drawing.Size(0, 13);
            this.lblAffectation.TabIndex = 7;
            // 
            // cbxIntervenant4
            // 
            this.cbxIntervenant4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIntervenant4.FormattingEnabled = true;
            this.cbxIntervenant4.Location = new System.Drawing.Point(589, 143);
            this.cbxIntervenant4.Name = "cbxIntervenant4";
            this.cbxIntervenant4.Size = new System.Drawing.Size(106, 21);
            this.cbxIntervenant4.TabIndex = 6;
            // 
            // cbxIntervenant3
            // 
            this.cbxIntervenant3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIntervenant3.FormattingEnabled = true;
            this.cbxIntervenant3.Location = new System.Drawing.Point(460, 143);
            this.cbxIntervenant3.Name = "cbxIntervenant3";
            this.cbxIntervenant3.Size = new System.Drawing.Size(110, 21);
            this.cbxIntervenant3.TabIndex = 5;
            // 
            // cbxIntervenant2
            // 
            this.cbxIntervenant2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIntervenant2.FormattingEnabled = true;
            this.cbxIntervenant2.Location = new System.Drawing.Point(335, 143);
            this.cbxIntervenant2.Name = "cbxIntervenant2";
            this.cbxIntervenant2.Size = new System.Drawing.Size(109, 21);
            this.cbxIntervenant2.TabIndex = 4;
            // 
            // cbxIntervenant1
            // 
            this.cbxIntervenant1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIntervenant1.FormattingEnabled = true;
            this.cbxIntervenant1.Location = new System.Drawing.Point(197, 143);
            this.cbxIntervenant1.Name = "cbxIntervenant1";
            this.cbxIntervenant1.Size = new System.Drawing.Size(117, 21);
            this.cbxIntervenant1.TabIndex = 3;
            // 
            // cbxAtelierAnimateur
            // 
            this.cbxAtelierAnimateur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAtelierAnimateur.FormattingEnabled = true;
            this.cbxAtelierAnimateur.Location = new System.Drawing.Point(196, 59);
            this.cbxAtelierAnimateur.Name = "cbxAtelierAnimateur";
            this.cbxAtelierAnimateur.Size = new System.Drawing.Size(143, 21);
            this.cbxAtelierAnimateur.TabIndex = 2;
            this.cbxAtelierAnimateur.SelectedIndexChanged += new System.EventHandler(this.cbxAtelierAnimateur_SelectedIndexChanged);
            // 
            // btnAffecter
            // 
            this.btnAffecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAffecter.Location = new System.Drawing.Point(196, 224);
            this.btnAffecter.Name = "btnAffecter";
            this.btnAffecter.Size = new System.Drawing.Size(143, 42);
            this.btnAffecter.TabIndex = 1;
            this.btnAffecter.Text = "Affecter";
            this.btnAffecter.UseVisualStyleBackColor = true;
            this.btnAffecter.Click += new System.EventHandler(this.btnAffecter_Click);
            // 
            // cbxAnimateur
            // 
            this.cbxAnimateur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAnimateur.FormattingEnabled = true;
            this.cbxAnimateur.Location = new System.Drawing.Point(196, 100);
            this.cbxAnimateur.Name = "cbxAnimateur";
            this.cbxAnimateur.Size = new System.Drawing.Size(143, 21);
            this.cbxAnimateur.TabIndex = 0;
            this.cbxAnimateur.SelectedIndexChanged += new System.EventHandler(this.cbxAnimateur_SelectedIndexChanged);
            // 
            // tbAfficherAll
            // 
            this.tbAfficherAll.Controls.Add(this.lblChoisirAtelierAll);
            this.tbAfficherAll.Controls.Add(this.dgvTheme);
            this.tbAfficherAll.Controls.Add(this.dgvIntervenant);
            this.tbAfficherAll.Controls.Add(this.lblTheme);
            this.tbAfficherAll.Controls.Add(this.lblntervenant);
            this.tbAfficherAll.Controls.Add(this.txbAnimateur);
            this.tbAfficherAll.Controls.Add(this.lblAnimateur);
            this.tbAfficherAll.Controls.Add(this.txbAtelier);
            this.tbAfficherAll.Controls.Add(this.lblAtelierAll);
            this.tbAfficherAll.Controls.Add(this.cbxAtelierAll);
            this.tbAfficherAll.Location = new System.Drawing.Point(4, 22);
            this.tbAfficherAll.Name = "tbAfficherAll";
            this.tbAfficherAll.Padding = new System.Windows.Forms.Padding(3);
            this.tbAfficherAll.Size = new System.Drawing.Size(768, 400);
            this.tbAfficherAll.TabIndex = 2;
            this.tbAfficherAll.Text = "Afficher les ateliers";
            this.tbAfficherAll.UseVisualStyleBackColor = true;
            this.tbAfficherAll.Click += new System.EventHandler(this.tbAfficherAll_Click);
            // 
            // lblChoisirAtelierAll
            // 
            this.lblChoisirAtelierAll.AutoSize = true;
            this.lblChoisirAtelierAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblChoisirAtelierAll.Location = new System.Drawing.Point(129, 24);
            this.lblChoisirAtelierAll.Name = "lblChoisirAtelierAll";
            this.lblChoisirAtelierAll.Size = new System.Drawing.Size(138, 17);
            this.lblChoisirAtelierAll.TabIndex = 10;
            this.lblChoisirAtelierAll.Text = "Choisir un Atelier:";
            // 
            // dgvTheme
            // 
            this.dgvTheme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheme.Location = new System.Drawing.Point(534, 103);
            this.dgvTheme.Name = "dgvTheme";
            this.dgvTheme.Size = new System.Drawing.Size(187, 252);
            this.dgvTheme.TabIndex = 8;
            // 
            // dgvIntervenant
            // 
            this.dgvIntervenant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntervenant.Location = new System.Drawing.Point(296, 100);
            this.dgvIntervenant.Name = "dgvIntervenant";
            this.dgvIntervenant.Size = new System.Drawing.Size(187, 255);
            this.dgvIntervenant.TabIndex = 7;
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTheme.Location = new System.Drawing.Point(594, 60);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(75, 17);
            this.lblTheme.TabIndex = 6;
            this.lblTheme.Text = "Themes :";
            // 
            // lblntervenant
            // 
            this.lblntervenant.AutoSize = true;
            this.lblntervenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblntervenant.Location = new System.Drawing.Point(335, 60);
            this.lblntervenant.Name = "lblntervenant";
            this.lblntervenant.Size = new System.Drawing.Size(100, 17);
            this.lblntervenant.TabIndex = 5;
            this.lblntervenant.Text = "Intervenant :";
            // 
            // txbAnimateur
            // 
            this.txbAnimateur.Location = new System.Drawing.Point(104, 160);
            this.txbAnimateur.Name = "txbAnimateur";
            this.txbAnimateur.Size = new System.Drawing.Size(186, 20);
            this.txbAnimateur.TabIndex = 4;
            // 
            // lblAnimateur
            // 
            this.lblAnimateur.AutoSize = true;
            this.lblAnimateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAnimateur.Location = new System.Drawing.Point(7, 160);
            this.lblAnimateur.Name = "lblAnimateur";
            this.lblAnimateur.Size = new System.Drawing.Size(91, 17);
            this.lblAnimateur.TabIndex = 3;
            this.lblAnimateur.Text = "Animateur :";
            // 
            // txbAtelier
            // 
            this.txbAtelier.Location = new System.Drawing.Point(104, 103);
            this.txbAtelier.Name = "txbAtelier";
            this.txbAtelier.Size = new System.Drawing.Size(186, 20);
            this.txbAtelier.TabIndex = 2;
            // 
            // lblAtelierAll
            // 
            this.lblAtelierAll.AutoSize = true;
            this.lblAtelierAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAtelierAll.Location = new System.Drawing.Point(33, 103);
            this.lblAtelierAll.Name = "lblAtelierAll";
            this.lblAtelierAll.Size = new System.Drawing.Size(65, 17);
            this.lblAtelierAll.TabIndex = 1;
            this.lblAtelierAll.Text = "Atelier :";
            // 
            // cbxAtelierAll
            // 
            this.cbxAtelierAll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAtelierAll.FormattingEnabled = true;
            this.cbxAtelierAll.Location = new System.Drawing.Point(104, 56);
            this.cbxAtelierAll.Name = "cbxAtelierAll";
            this.cbxAtelierAll.Size = new System.Drawing.Size(186, 21);
            this.cbxAtelierAll.TabIndex = 0;
            this.cbxAtelierAll.SelectedIndexChanged += new System.EventHandler(this.cbxAtelierAll_SelectedIndexChanged);
            // 
            // dtpDebut
            // 
            this.dtpDebut.CustomFormat = "ddMMMM yyyy  HH:mm";
            this.dtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDebut.Location = new System.Drawing.Point(68, 212);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(187, 20);
            this.dtpDebut.TabIndex = 8;
            // 
            // dtpFin
            // 
            this.dtpFin.CustomFormat = "ddMMMM yyyy  HH:mm";
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFin.Location = new System.Drawing.Point(68, 243);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(187, 20);
            this.dtpFin.TabIndex = 9;
            // 
            // btnHoraire
            // 
            this.btnHoraire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnHoraire.Location = new System.Drawing.Point(68, 299);
            this.btnHoraire.Name = "btnHoraire";
            this.btnHoraire.Size = new System.Drawing.Size(187, 42);
            this.btnHoraire.TabIndex = 10;
            this.btnHoraire.Text = "Affecter Horaire";
            this.btnHoraire.UseVisualStyleBackColor = true;
            this.btnHoraire.Click += new System.EventHandler(this.btnHoraire_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlAtelier);
            this.Name = "main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.main_Load);
            this.tabControlAtelier.ResumeLayout(false);
            this.tabPageHoraire.ResumeLayout(false);
            this.tabPageHoraire.PerformLayout();
            this.tabPageIntervenant.ResumeLayout(false);
            this.tabPageIntervenant.PerformLayout();
            this.tbAfficherAll.ResumeLayout(false);
            this.tbAfficherAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervenant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAtelier;
        private System.Windows.Forms.TabPage tabPageHoraire;
        private System.Windows.Forms.TabPage tabPageIntervenant;
        private System.Windows.Forms.Label lblHoraireFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHoraireDebut;
        private System.Windows.Forms.Label lblHoraire1;
        private System.Windows.Forms.Label lblNomAtelier;
        private System.Windows.Forms.Label lblAtelier;
        private System.Windows.Forms.ComboBox cbxAtelier;
        private System.Windows.Forms.ComboBox cbxAtelierAnimateur;
        private System.Windows.Forms.Button btnAffecter;
        private System.Windows.Forms.ComboBox cbxAnimateur;
        private System.Windows.Forms.ComboBox cbxIntervenant4;
        private System.Windows.Forms.ComboBox cbxIntervenant3;
        private System.Windows.Forms.ComboBox cbxIntervenant2;
        private System.Windows.Forms.ComboBox cbxIntervenant1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAffectation;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TabPage tbAfficherAll;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.Label lblntervenant;
        private System.Windows.Forms.TextBox txbAnimateur;
        private System.Windows.Forms.Label lblAnimateur;
        private System.Windows.Forms.TextBox txbAtelier;
        private System.Windows.Forms.Label lblAtelierAll;
        private System.Windows.Forms.ComboBox cbxAtelierAll;
        private System.Windows.Forms.DataGridView dgvTheme;
        private System.Windows.Forms.DataGridView dgvIntervenant;
        private System.Windows.Forms.Label lblChoisirAtelier;
        private System.Windows.Forms.Label lblChoisirAnimateur;
        private System.Windows.Forms.Label lblChoisirIntervenant;
        private System.Windows.Forms.Label lblChoisirAtelierAnimateur;
        private System.Windows.Forms.Label lblChoisirAtelierAll;
        private System.Windows.Forms.Button btnHoraire;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpDebut;
    }
}

