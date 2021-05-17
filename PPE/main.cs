using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE
{
    public partial class main : Form
    {
        private Atelier monAtelier;
        private Participant monParticipant;
        private Intervenant monIntervenant;
        private Theme monTheme;

        public main()
        {
            InitializeComponent();
        }

        #region initialisation des données
        private void initialiserAtelier()
        {
            monAtelier = new Atelier(10, "test", 50, "21:20", "21:30", "animateurTest");

            monAtelier.LesAteliers = Atelier.listeAtelier();
        }
        private void initialiserParticipant()
        {
            monParticipant = new Participant(1, "testAnimateur", "", "", "","",1);

            monParticipant.LesParticipants = Participant.listeParticipant();
        }
        private void initialiserIntervenant(int idAtelier)
        {
            monIntervenant = new Intervenant(1, "test");

            monIntervenant.LesIntervenants = Intervenant.listeIntervenant(idAtelier);
        }
        private void initialiserTheme(int idAtelier)
        {
            monTheme = new Theme(1, "test");

            monTheme.LesThemes = Theme.listeTheme(idAtelier);
        }


        #endregion


        private void main_Load(object sender, EventArgs e)
        {
            initialiserAtelier();
            initialiserParticipant();

            foreach (Atelier unAtelier in monAtelier.LesAteliers)
            {
                cbxAtelier.Items.Add(unAtelier.Libelle);
                cbxAtelierAnimateur.Items.Add(unAtelier.Libelle);
                cbxAtelierAll.Items.Add(unAtelier.Libelle);
            }

            foreach (Participant unParticipant in monParticipant.LesParticipants)
            {
                cbxAnimateur.Items.Add(unParticipant.Prenom);
                cbxIntervenant1.Items.Add(unParticipant.Prenom);
                cbxIntervenant2.Items.Add(unParticipant.Prenom);
                cbxIntervenant3.Items.Add(unParticipant.Prenom);
                cbxIntervenant4.Items.Add(unParticipant.Prenom);
            }
        }

        private void cbxAtelier_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cbxAtelier.SelectedIndex;
            Atelier unAtelier;
            unAtelier = monAtelier.LesAteliers.ElementAt(i);

            lblNomAtelier.Text = unAtelier.Libelle;
            lblHoraireDebut.Text = unAtelier.Debut.ToString();
            lblHoraireFin.Text = unAtelier.Fin.ToString();
        }

        #region not use
        private void cbxAtelierAnimateur_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxAnimateur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void horaireAtelierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void tabPageHoraire_Enter(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnAffecter_Click(object sender, EventArgs e)
        {
            if (cbxAnimateur.Text == "Choisir un animateur" || cbxAtelierAnimateur.Text == "Choisir un atelier")
            {
                lblAffectation.Text = "Veuillez choisir un animateur, un atelier";
                lblAffectation.ForeColor = Color.Red;
            }
            else
            {
                int idAtelier = cbxAtelierAnimateur.SelectedIndex + 1;
                int idAnimateur = cbxAnimateur.SelectedIndex + 1;

                DAOParticipant.affecterAnimateurBDD(idAtelier, idAnimateur);

                if (cbxIntervenant1.Text != "1er Intervenant")
                {
                    int idParticipant = cbxIntervenant1.SelectedIndex + 1;

                    DAOParticipant.affecterIntervenantBDD(idAtelier, idParticipant);
                }

                if (cbxIntervenant2.Text != "2eme Intervenant")
                {
                    int idParticipant = cbxIntervenant2.SelectedIndex + 1;

                    DAOParticipant.affecterIntervenantBDD(idAtelier, idParticipant);
                }

                if (cbxIntervenant3.Text != "3eme Intervenant")
                {
                    int idParticipant = cbxIntervenant3.SelectedIndex + 1;

                    DAOParticipant.affecterIntervenantBDD(idAtelier, idParticipant);
                }

                if (cbxIntervenant4.Text != "4eme Intervenant")
                {
                    int idParticipant = cbxIntervenant4.SelectedIndex + 1;

                    DAOParticipant.affecterIntervenantBDD(idAtelier, idParticipant);
                }

                lblAffectation.Text = "Animateur et intervenant(s) bien affecté(s)";
                lblAffectation.ForeColor = Color.Green;
            }

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            cbxAtelierAnimateur.Text = "Choisir un atelier";
            cbxAnimateur.Text = "Choisir un animateur";
            cbxIntervenant1.Text = "1er Intervenant";
            cbxIntervenant2.Text = "2eme Intervenant";
            cbxIntervenant3.Text = "3eme Intervenant";
            cbxIntervenant4.Text = "4eme Intervenant";
        }

        private void tbAfficherAll_Click(object sender, EventArgs e)
        {
            
        }

        private void cbxAtelierAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cbxAtelierAll.SelectedIndex;
            Atelier unAtelier;
            unAtelier = monAtelier.LesAteliers.ElementAt(i);
            txbAtelier.Text = unAtelier.Libelle;
            txbAnimateur.Text = unAtelier.Animateur;

            int idAtelier = cbxAtelierAll.SelectedIndex + 1;
            initialiserIntervenant(idAtelier);
            dgvIntervenant.DataSource = null;
            dgvIntervenant.DataSource = monIntervenant.LesIntervenants;
            dgvIntervenant.AutoResizeColumns();

            initialiserTheme(idAtelier);
            dgvTheme.DataSource = null;
            dgvTheme.DataSource = monTheme.LesThemes;
            dgvTheme.AutoResizeColumns();

        }
    }
}
