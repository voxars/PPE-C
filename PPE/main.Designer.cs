
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
            this.lblHoraireFin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHoraireDebut = new System.Windows.Forms.Label();
            this.lblHoraire1 = new System.Windows.Forms.Label();
            this.lblNomAtelier = new System.Windows.Forms.Label();
            this.lblAtelier = new System.Windows.Forms.Label();
            this.cbxAtelier = new System.Windows.Forms.ComboBox();
            this.tabPageIntervenant = new System.Windows.Forms.TabPage();
            this.cbxAtelierAnimateur = new System.Windows.Forms.ComboBox();
            this.btnAffecter = new System.Windows.Forms.Button();
            this.cbxAnimateur = new System.Windows.Forms.ComboBox();
            this.cbxIntervenant1 = new System.Windows.Forms.ComboBox();
            this.cbxIntervenant2 = new System.Windows.Forms.ComboBox();
            this.cbxIntervenant3 = new System.Windows.Forms.ComboBox();
            this.cbxIntervenant4 = new System.Windows.Forms.ComboBox();
            this.tabControlAtelier.SuspendLayout();
            this.tabPageHoraire.SuspendLayout();
            this.tabPageIntervenant.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAtelier
            // 
            this.tabControlAtelier.Controls.Add(this.tabPageHoraire);
            this.tabControlAtelier.Controls.Add(this.tabPageIntervenant);
            this.tabControlAtelier.Location = new System.Drawing.Point(12, 12);
            this.tabControlAtelier.Name = "tabControlAtelier";
            this.tabControlAtelier.SelectedIndex = 0;
            this.tabControlAtelier.Size = new System.Drawing.Size(776, 426);
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
            this.btnAffecter.Location = new System.Drawing.Point(303, 140);
            this.btnAffecter.Name = "btnAffecter";
            this.btnAffecter.Size = new System.Drawing.Size(143, 42);
            this.btnAffecter.TabIndex = 1;
            this.btnAffecter.Text = "Affecter";
            this.btnAffecter.UseVisualStyleBackColor = true;
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
            // cbxIntervenant1
            // 
            this.cbxIntervenant1.FormattingEnabled = true;
            this.cbxIntervenant1.Location = new System.Drawing.Point(256, 35);
            this.cbxIntervenant1.Name = "cbxIntervenant1";
            this.cbxIntervenant1.Size = new System.Drawing.Size(98, 21);
            this.cbxIntervenant1.TabIndex = 3;
            this.cbxIntervenant1.Text = "1er Intervenant";
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
            // cbxIntervenant3
            // 
            this.cbxIntervenant3.FormattingEnabled = true;
            this.cbxIntervenant3.Location = new System.Drawing.Point(499, 35);
            this.cbxIntervenant3.Name = "cbxIntervenant3";
            this.cbxIntervenant3.Size = new System.Drawing.Size(110, 21);
            this.cbxIntervenant3.TabIndex = 5;
            this.cbxIntervenant3.Text = "3eme Intervenant";
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
    }
}

