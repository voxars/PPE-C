
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
            this.lblHoraireFin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHoraireDebut = new System.Windows.Forms.Label();
            this.lblHoraire1 = new System.Windows.Forms.Label();
            this.lblNomAtelier = new System.Windows.Forms.Label();
            this.lblAtelier = new System.Windows.Forms.Label();
            this.cbxAtelier = new System.Windows.Forms.ComboBox();
            this.tabPageIntervenant = new System.Windows.Forms.TabPage();
            this.cbxAtelierAnimateur = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxAnimateur = new System.Windows.Forms.ComboBox();
            this.inscription = new System.Windows.Forms.TabPage();
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
            this.Atelier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlAtelier.SuspendLayout();
            this.tabPageHoraire.SuspendLayout();
            this.tabPageIntervenant.SuspendLayout();
            this.inscription.SuspendLayout();
            this.tabParticipant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataParticipants)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAtelier
            // 
            this.tabControlAtelier.Controls.Add(this.tabPageHoraire);
            this.tabControlAtelier.Controls.Add(this.tabPageIntervenant);
            this.tabControlAtelier.Controls.Add(this.inscription);
            this.tabControlAtelier.Controls.Add(this.tabParticipant);
            this.tabControlAtelier.Location = new System.Drawing.Point(32, 28);
            this.tabControlAtelier.Name = "tabControlAtelier";
            this.tabControlAtelier.SelectedIndex = 0;
            this.tabControlAtelier.Size = new System.Drawing.Size(722, 351);
            this.tabControlAtelier.TabIndex = 0;
            // 
            // tabPageHoraire
            // 
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
            this.tabPageHoraire.Size = new System.Drawing.Size(714, 325);
            this.tabPageHoraire.TabIndex = 0;
            this.tabPageHoraire.Text = "Afficher Horaire";
            this.tabPageHoraire.UseVisualStyleBackColor = true;
            this.tabPageHoraire.Enter += new System.EventHandler(this.tabPageHoraire_Enter);
            // 
            // lblHoraireFin
            // 
            this.lblHoraireFin.AutoSize = true;
            this.lblHoraireFin.Location = new System.Drawing.Point(108, 143);
            this.lblHoraireFin.Name = "lblHoraireFin";
            this.lblHoraireFin.Size = new System.Drawing.Size(53, 13);
            this.lblHoraireFin.TabIndex = 6;
            this.lblHoraireFin.Text = "horaire fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Horaire Fin:";
            // 
            // lblHoraireDebut
            // 
            this.lblHoraireDebut.AutoSize = true;
            this.lblHoraireDebut.Location = new System.Drawing.Point(123, 116);
            this.lblHoraireDebut.Name = "lblHoraireDebut";
            this.lblHoraireDebut.Size = new System.Drawing.Size(69, 13);
            this.lblHoraireDebut.TabIndex = 4;
            this.lblHoraireDebut.Text = "horaire debut";
            // 
            // lblHoraire1
            // 
            this.lblHoraire1.AutoSize = true;
            this.lblHoraire1.Location = new System.Drawing.Point(41, 116);
            this.lblHoraire1.Name = "lblHoraire1";
            this.lblHoraire1.Size = new System.Drawing.Size(76, 13);
            this.lblHoraire1.TabIndex = 3;
            this.lblHoraire1.Text = "Horaire Debut:";
            // 
            // lblNomAtelier
            // 
            this.lblNomAtelier.AutoSize = true;
            this.lblNomAtelier.Location = new System.Drawing.Point(132, 81);
            this.lblNomAtelier.Name = "lblNomAtelier";
            this.lblNomAtelier.Size = new System.Drawing.Size(27, 13);
            this.lblNomAtelier.TabIndex = 2;
            this.lblNomAtelier.Text = "nom";
            // 
            // lblAtelier
            // 
            this.lblAtelier.AutoSize = true;
            this.lblAtelier.Location = new System.Drawing.Point(41, 81);
            this.lblAtelier.Name = "lblAtelier";
            this.lblAtelier.Size = new System.Drawing.Size(85, 13);
            this.lblAtelier.TabIndex = 1;
            this.lblAtelier.Text = "Nom de l\'atelier :";
            // 
            // cbxAtelier
            // 
            this.cbxAtelier.FormattingEnabled = true;
            this.cbxAtelier.Location = new System.Drawing.Point(38, 29);
            this.cbxAtelier.Name = "cbxAtelier";
            this.cbxAtelier.Size = new System.Drawing.Size(113, 21);
            this.cbxAtelier.TabIndex = 0;
            this.cbxAtelier.Text = "Choisir un atelier";
            this.cbxAtelier.SelectedIndexChanged += new System.EventHandler(this.cbxAtelier_SelectedIndexChanged);
            // 
            // tabPageIntervenant
            // 
            this.tabPageIntervenant.Controls.Add(this.cbxAtelierAnimateur);
            this.tabPageIntervenant.Controls.Add(this.button1);
            this.tabPageIntervenant.Controls.Add(this.cbxAnimateur);
            this.tabPageIntervenant.Location = new System.Drawing.Point(4, 22);
            this.tabPageIntervenant.Name = "tabPageIntervenant";
            this.tabPageIntervenant.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIntervenant.Size = new System.Drawing.Size(714, 325);
            this.tabPageIntervenant.TabIndex = 1;
            this.tabPageIntervenant.Text = "Affecter un animateur";
            this.tabPageIntervenant.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            // inscription
            // 
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
            this.inscription.Size = new System.Drawing.Size(714, 325);
            this.inscription.TabIndex = 2;
            this.inscription.Text = "Inscription participant";
            this.inscription.UseVisualStyleBackColor = true;
            // 
            // cbbBenevole
            // 
            this.cbbBenevole.FormattingEnabled = true;
            this.cbbBenevole.Location = new System.Drawing.Point(327, 205);
            this.cbbBenevole.Name = "cbbBenevole";
            this.cbbBenevole.Size = new System.Drawing.Size(100, 21);
            this.cbbBenevole.TabIndex = 19;
            this.cbbBenevole.SelectedIndexChanged += new System.EventHandler(this.cbbBenevole_SelectedIndexChanged);
            // 
            // cbbAtelier
            // 
            this.cbbAtelier.FormattingEnabled = true;
            this.cbbAtelier.Location = new System.Drawing.Point(221, 205);
            this.cbbAtelier.Name = "cbbAtelier";
            this.cbbAtelier.Size = new System.Drawing.Size(100, 21);
            this.cbbAtelier.TabIndex = 18;
            this.cbbAtelier.SelectedIndexChanged += new System.EventHandler(this.cbbAtelier_SelectedIndexChanged);
            // 
            // cbbType
            // 
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Location = new System.Drawing.Point(378, 69);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(100, 21);
            this.cbbType.TabIndex = 17;
            this.cbbType.SelectedIndexChanged += new System.EventHandler(this.cbbType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(327, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Si benevole";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(221, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Atelier";
            // 
            // txbPortable
            // 
            this.txbPortable.Location = new System.Drawing.Point(378, 144);
            this.txbPortable.Name = "txbPortable";
            this.txbPortable.Size = new System.Drawing.Size(100, 20);
            this.txbPortable.TabIndex = 12;
            this.txbPortable.TextChanged += new System.EventHandler(this.txbPortable_TextChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(378, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Numero de telephone";
            // 
            // txbMail
            // 
            this.txbMail.Location = new System.Drawing.Point(272, 144);
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(100, 20);
            this.txbMail.TabIndex = 10;
            this.txbMail.TextChanged += new System.EventHandler(this.txbMail_TextChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(272, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "Mail";
            // 
            // txbAdresse
            // 
            this.txbAdresse.Location = new System.Drawing.Point(166, 144);
            this.txbAdresse.Name = "txbAdresse";
            this.txbAdresse.Size = new System.Drawing.Size(100, 20);
            this.txbAdresse.TabIndex = 8;
            this.txbAdresse.TextChanged += new System.EventHandler(this.txbAdresse_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(166, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adresse";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(378, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Type";
            // 
            // txbPrenom
            // 
            this.txbPrenom.Location = new System.Drawing.Point(272, 69);
            this.txbPrenom.Name = "txbPrenom";
            this.txbPrenom.Size = new System.Drawing.Size(100, 20);
            this.txbPrenom.TabIndex = 4;
            this.txbPrenom.TextChanged += new System.EventHandler(this.txbPrenom_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(272, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prenom";
            // 
            // txbNom
            // 
            this.txbNom.Location = new System.Drawing.Point(166, 69);
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(100, 20);
            this.txbNom.TabIndex = 2;
            this.txbNom.TextChanged += new System.EventHandler(this.txbNom_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(166, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom";
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(221, 254);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(206, 40);
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
            this.tabParticipant.Size = new System.Drawing.Size(714, 325);
            this.tabParticipant.TabIndex = 3;
            this.tabParticipant.Text = "Liste participants";
            this.tabParticipant.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label10.Location = new System.Drawing.Point(256, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "Liste des participants";
            // 
            // dataParticipants
            // 
            this.dataParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataParticipants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.Nom, this.Atelier, this.Type});
            this.dataParticipants.Location = new System.Drawing.Point(3, 35);
            this.dataParticipants.Name = "dataParticipants";
            this.dataParticipants.Size = new System.Drawing.Size(705, 284);
            this.dataParticipants.TabIndex = 0;
            this.dataParticipants.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataParticipants_CellContentClick);
            // 
            // Nom
            // 
            this.Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nom.Width = 54;
            // 
            // Atelier
            // 
            this.Atelier.HeaderText = "Atelier";
            this.Atelier.Name = "Atelier";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
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
            this.inscription.ResumeLayout(false);
            this.inscription.PerformLayout();
            this.tabParticipant.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataParticipants)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataParticipants;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atelier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        
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
        private System.Windows.Forms.Label lblHoraireFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHoraireDebut;
        private System.Windows.Forms.Label lblHoraire1;
        private System.Windows.Forms.Label lblNomAtelier;
        private System.Windows.Forms.Label lblAtelier;
        private System.Windows.Forms.ComboBox cbxAtelier;
        private System.Windows.Forms.ComboBox cbxAtelierAnimateur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxAnimateur;
    }
}

