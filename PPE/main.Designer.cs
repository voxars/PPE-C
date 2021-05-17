
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblHoraireFin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHoraireDebut = new System.Windows.Forms.Label();
            this.lblHoraire1 = new System.Windows.Forms.Label();
            this.lblNomAtelier = new System.Windows.Forms.Label();
            this.lblAtelier = new System.Windows.Forms.Label();
            this.cbxAtelier = new System.Windows.Forms.ComboBox();
            this.tabPageIntervenant = new System.Windows.Forms.TabPage();
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
            this.cbxAtelierAll = new System.Windows.Forms.ComboBox();
            this.lblAtelierAll = new System.Windows.Forms.Label();
            this.txbAtelier = new System.Windows.Forms.TextBox();
            this.lblAnimateur = new System.Windows.Forms.Label();
            this.txbAnimateur = new System.Windows.Forms.TextBox();
            this.lblntervenant = new System.Windows.Forms.Label();
            this.lblTheme = new System.Windows.Forms.Label();
            this.dgvIntervenant = new System.Windows.Forms.DataGridView();
            this.dgvTheme = new System.Windows.Forms.DataGridView();
            this.tabControlAtelier.SuspendLayout();
            this.tabPageHoraire.SuspendLayout();
            this.tabPageIntervenant.SuspendLayout();
            this.tbAfficherAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervenant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheme)).BeginInit();
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
            this.cbxAtelier.FormattingEnabled = true;
            this.cbxAtelier.Location = new System.Drawing.Point(305, 125);
            this.cbxAtelier.Name = "cbxAtelier";
            this.cbxAtelier.Size = new System.Drawing.Size(113, 21);
            this.cbxAtelier.TabIndex = 0;
            this.cbxAtelier.Text = "Choisir un atelier";
            this.cbxAtelier.SelectedIndexChanged += new System.EventHandler(this.cbxAtelier_SelectedIndexChanged);
            // 
            // tabPageIntervenant
            // 
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
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAnnuler.Location = new System.Drawing.Point(396, 145);
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
            this.lblAffectation.Location = new System.Drawing.Point(300, 233);
            this.lblAffectation.Name = "lblAffectation";
            this.lblAffectation.Size = new System.Drawing.Size(0, 13);
            this.lblAffectation.TabIndex = 7;
            // 
            // cbxIntervenant4
            // 
            this.cbxIntervenant4.FormattingEnabled = true;
            this.cbxIntervenant4.Location = new System.Drawing.Point(628, 35);
            this.cbxIntervenant4.Name = "cbxIntervenant4";
            this.cbxIntervenant4.Size = new System.Drawing.Size(106, 21);
            this.cbxIntervenant4.TabIndex = 6;
            this.cbxIntervenant4.Text = "4eme Intervenant";
            // 
            // cbxIntervenant3
            // 
            this.cbxIntervenant3.FormattingEnabled = true;
            this.cbxIntervenant3.Location = new System.Drawing.Point(499, 35);
            this.cbxIntervenant3.Name = "cbxIntervenant3";
            this.cbxIntervenant3.Size = new System.Drawing.Size(110, 21);
            this.cbxIntervenant3.TabIndex = 5;
            this.cbxIntervenant3.Text = "3eme Intervenant";
            // 
            // cbxIntervenant2
            // 
            this.cbxIntervenant2.FormattingEnabled = true;
            this.cbxIntervenant2.Location = new System.Drawing.Point(374, 35);
            this.cbxIntervenant2.Name = "cbxIntervenant2";
            this.cbxIntervenant2.Size = new System.Drawing.Size(109, 21);
            this.cbxIntervenant2.TabIndex = 4;
            this.cbxIntervenant2.Text = "2eme Intervenant";
            // 
            // cbxIntervenant1
            // 
            this.cbxIntervenant1.FormattingEnabled = true;
            this.cbxIntervenant1.Location = new System.Drawing.Point(256, 35);
            this.cbxIntervenant1.Name = "cbxIntervenant1";
            this.cbxIntervenant1.Size = new System.Drawing.Size(98, 21);
            this.cbxIntervenant1.TabIndex = 3;
            this.cbxIntervenant1.Text = "1er Intervenant";
            // 
            // cbxAtelierAnimateur
            // 
            this.cbxAtelierAnimateur.FormattingEnabled = true;
            this.cbxAtelierAnimateur.Location = new System.Drawing.Point(69, 79);
            this.cbxAtelierAnimateur.Name = "cbxAtelierAnimateur";
            this.cbxAtelierAnimateur.Size = new System.Drawing.Size(143, 21);
            this.cbxAtelierAnimateur.TabIndex = 2;
            this.cbxAtelierAnimateur.Text = "Choisir un atelier";
            this.cbxAtelierAnimateur.SelectedIndexChanged += new System.EventHandler(this.cbxAtelierAnimateur_SelectedIndexChanged);
            // 
            // btnAffecter
            // 
            this.btnAffecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAffecter.Location = new System.Drawing.Point(181, 145);
            this.btnAffecter.Name = "btnAffecter";
            this.btnAffecter.Size = new System.Drawing.Size(143, 42);
            this.btnAffecter.TabIndex = 1;
            this.btnAffecter.Text = "Affecter";
            this.btnAffecter.UseVisualStyleBackColor = true;
            this.btnAffecter.Click += new System.EventHandler(this.btnAffecter_Click);
            // 
            // cbxAnimateur
            // 
            this.cbxAnimateur.FormattingEnabled = true;
            this.cbxAnimateur.Location = new System.Drawing.Point(69, 34);
            this.cbxAnimateur.Name = "cbxAnimateur";
            this.cbxAnimateur.Size = new System.Drawing.Size(143, 21);
            this.cbxAnimateur.TabIndex = 0;
            this.cbxAnimateur.Text = "Choisir un animateur";
            this.cbxAnimateur.SelectedIndexChanged += new System.EventHandler(this.cbxAnimateur_SelectedIndexChanged);
            // 
            // tbAfficherAll
            // 
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
            // cbxAtelierAll
            // 
            this.cbxAtelierAll.FormattingEnabled = true;
            this.cbxAtelierAll.Location = new System.Drawing.Point(104, 45);
            this.cbxAtelierAll.Name = "cbxAtelierAll";
            this.cbxAtelierAll.Size = new System.Drawing.Size(186, 21);
            this.cbxAtelierAll.TabIndex = 0;
            this.cbxAtelierAll.Text = "Choisir un atelier";
            this.cbxAtelierAll.SelectedIndexChanged += new System.EventHandler(this.cbxAtelierAll_SelectedIndexChanged);
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
            // txbAtelier
            // 
            this.txbAtelier.Location = new System.Drawing.Point(104, 103);
            this.txbAtelier.Name = "txbAtelier";
            this.txbAtelier.Size = new System.Drawing.Size(186, 20);
            this.txbAtelier.TabIndex = 2;
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
            // txbAnimateur
            // 
            this.txbAnimateur.Location = new System.Drawing.Point(104, 160);
            this.txbAnimateur.Name = "txbAnimateur";
            this.txbAnimateur.Size = new System.Drawing.Size(186, 20);
            this.txbAnimateur.TabIndex = 4;
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
            // dgvIntervenant
            // 
            this.dgvIntervenant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntervenant.Location = new System.Drawing.Point(296, 100);
            this.dgvIntervenant.Name = "dgvIntervenant";
            this.dgvIntervenant.Size = new System.Drawing.Size(187, 255);
            this.dgvIntervenant.TabIndex = 7;
            // 
            // dgvTheme
            // 
            this.dgvTheme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheme.Location = new System.Drawing.Point(534, 103);
            this.dgvTheme.Name = "dgvTheme";
            this.dgvTheme.Size = new System.Drawing.Size(187, 252);
            this.dgvTheme.TabIndex = 8;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervenant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheme)).EndInit();
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
    }
}

