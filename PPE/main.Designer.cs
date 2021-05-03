
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
            this.tabPageInscription = new System.Windows.Forms.TabPage();
            this.btnAjouterParticipant = new System.Windows.Forms.Button();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbTel = new System.Windows.Forms.TextBox();
            this.txbMail = new System.Windows.Forms.TextBox();
            this.txbAdresse = new System.Windows.Forms.TextBox();
            this.txbPrenom = new System.Windows.Forms.TextBox();
            this.txbNom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageStands = new System.Windows.Forms.TabPage();
            this.tabControlAtelier.SuspendLayout();
            this.tabPageHoraire.SuspendLayout();
            this.tabPageInscription.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAtelier
            // 
            this.tabControlAtelier.Controls.Add(this.tabPageHoraire);
            this.tabControlAtelier.Controls.Add(this.tabPageIntervenant);
            this.tabControlAtelier.Controls.Add(this.tabPageInscription);
            this.tabControlAtelier.Controls.Add(this.tabPageStands);
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
            this.tabPageIntervenant.Location = new System.Drawing.Point(4, 22);
            this.tabPageIntervenant.Name = "tabPageIntervenant";
            this.tabPageIntervenant.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIntervenant.Size = new System.Drawing.Size(714, 325);
            this.tabPageIntervenant.TabIndex = 1;
            this.tabPageIntervenant.Text = "Affecter un animateur";
            this.tabPageIntervenant.UseVisualStyleBackColor = true;
            // 
            // tabPageInscription
            // 
            this.tabPageInscription.Controls.Add(this.btnAjouterParticipant);
            this.tabPageInscription.Controls.Add(this.cbbType);
            this.tabPageInscription.Controls.Add(this.label11);
            this.tabPageInscription.Controls.Add(this.label10);
            this.tabPageInscription.Controls.Add(this.txbPass);
            this.tabPageInscription.Controls.Add(this.label8);
            this.tabPageInscription.Controls.Add(this.txbLogin);
            this.tabPageInscription.Controls.Add(this.label9);
            this.tabPageInscription.Controls.Add(this.txbTel);
            this.tabPageInscription.Controls.Add(this.txbMail);
            this.tabPageInscription.Controls.Add(this.txbAdresse);
            this.tabPageInscription.Controls.Add(this.txbPrenom);
            this.tabPageInscription.Controls.Add(this.txbNom);
            this.tabPageInscription.Controls.Add(this.label7);
            this.tabPageInscription.Controls.Add(this.label6);
            this.tabPageInscription.Controls.Add(this.label5);
            this.tabPageInscription.Controls.Add(this.label4);
            this.tabPageInscription.Controls.Add(this.label2);
            this.tabPageInscription.Controls.Add(this.label1);
            this.tabPageInscription.Location = new System.Drawing.Point(4, 22);
            this.tabPageInscription.Name = "tabPageInscription";
            this.tabPageInscription.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInscription.Size = new System.Drawing.Size(714, 325);
            this.tabPageInscription.TabIndex = 2;
            this.tabPageInscription.Text = "Inscription participants";
            this.tabPageInscription.UseVisualStyleBackColor = true;
            this.tabPageInscription.Click += new System.EventHandler(this.tabPageInscription_Click);
            // 
            // btnAjouterParticipant
            // 
            this.btnAjouterParticipant.Location = new System.Drawing.Point(134, 237);
            this.btnAjouterParticipant.Name = "btnAjouterParticipant";
            this.btnAjouterParticipant.Size = new System.Drawing.Size(418, 57);
            this.btnAjouterParticipant.TabIndex = 21;
            this.btnAjouterParticipant.Text = "Ajouter";
            this.btnAjouterParticipant.UseVisualStyleBackColor = true;
            this.btnAjouterParticipant.Click += new System.EventHandler(this.btnAjouterParticipant_Click);
            // 
            // cbbType
            // 
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {"Licencié", "Intervenant", "Benevole"});
            this.cbbType.Location = new System.Drawing.Point(240, 118);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(100, 21);
            this.cbbType.TabIndex = 20;
            this.cbbType.SelectedIndexChanged += new System.EventHandler(this.cbbType_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label11.Location = new System.Drawing.Point(134, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(418, 51);
            this.label11.TabIndex = 19;
            this.label11.Text = "Creation de nouveaux participants";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(28, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 46);
            this.label10.TabIndex = 18;
            this.label10.Text = "Optionnel";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(240, 190);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(100, 20);
            this.txbPass.TabIndex = 17;
            this.txbPass.TextChanged += new System.EventHandler(this.txbPass_TextChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(240, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Password";
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(134, 190);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(100, 20);
            this.txbLogin.TabIndex = 14;
            this.txbLogin.TextChanged += new System.EventHandler(this.txbLogin_TextChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(134, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Login";
            // 
            // txbTel
            // 
            this.txbTel.Location = new System.Drawing.Point(558, 118);
            this.txbTel.Name = "txbTel";
            this.txbTel.Size = new System.Drawing.Size(100, 20);
            this.txbTel.TabIndex = 11;
            this.txbTel.TextChanged += new System.EventHandler(this.txbTel_TextChanged);
            // 
            // txbMail
            // 
            this.txbMail.Location = new System.Drawing.Point(452, 118);
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(100, 20);
            this.txbMail.TabIndex = 10;
            this.txbMail.TextChanged += new System.EventHandler(this.txbMail_TextChanged);
            // 
            // txbAdresse
            // 
            this.txbAdresse.Location = new System.Drawing.Point(346, 118);
            this.txbAdresse.Name = "txbAdresse";
            this.txbAdresse.Size = new System.Drawing.Size(100, 20);
            this.txbAdresse.TabIndex = 9;
            this.txbAdresse.TextChanged += new System.EventHandler(this.txbAdresse_TextChanged);
            // 
            // txbPrenom
            // 
            this.txbPrenom.Location = new System.Drawing.Point(134, 118);
            this.txbPrenom.Name = "txbPrenom";
            this.txbPrenom.Size = new System.Drawing.Size(100, 20);
            this.txbPrenom.TabIndex = 7;
            this.txbPrenom.TextChanged += new System.EventHandler(this.txbPrenom_TextChanged);
            // 
            // txbNom
            // 
            this.txbNom.Location = new System.Drawing.Point(28, 118);
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(100, 20);
            this.txbNom.TabIndex = 6;
            this.txbNom.TextChanged += new System.EventHandler(this.txbNom_TextChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(558, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Telephone";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(452, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "mail";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(346, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Adresse";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(240, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Type";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(134, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // tabPageStands
            // 
            this.tabPageStands.Location = new System.Drawing.Point(4, 22);
            this.tabPageStands.Name = "tabPageStands";
            this.tabPageStands.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStands.Size = new System.Drawing.Size(714, 325);
            this.tabPageStands.TabIndex = 3;
            this.tabPageStands.Text = "Stands";
            this.tabPageStands.UseVisualStyleBackColor = true;
            this.tabPageStands.Click += new System.EventHandler(this.tabPageStands_Click);
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
            this.tabPageInscription.ResumeLayout(false);
            this.tabPageInscription.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAjouterParticipant;

        private System.Windows.Forms.TabPage tabPageStands;

        private System.Windows.Forms.TextBox txbPass;

        private System.Windows.Forms.TextBox txbLogin;

        private System.Windows.Forms.TextBox txbTel;

        private System.Windows.Forms.TextBox txbMail;

        private System.Windows.Forms.TextBox txbAdresse;

        private System.Windows.Forms.TextBox txbPrenom;

        private System.Windows.Forms.TextBox txbNom;

        private System.Windows.Forms.ComboBox cbbType;

 

        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;


        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TabPage tabPageInscription;



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
    }
}

