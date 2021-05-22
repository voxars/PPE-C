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
        private List<Atelier> lesAteliers = new List<Atelier>();
        private List<AtelierWithAnimateur> lesAteliersWithAnimateur = new List<AtelierWithAnimateur>();
        private List<Participant> lesParticipants = new List<Participant>();
        private List<Intervenant> lesIntervenants = new List<Intervenant>();
        private List<Theme> lesThemes = new List<Theme>();

        public main()
        {
            InitializeComponent();
        }

        public void ReLoad()
        {
            lesAteliers = DAOAtelier.getAtelier();
            lesAteliersWithAnimateur = DAOAtelier.getAtelierWithAnimateur();
            lesParticipants = DAOParticipant.getParticipant();

            foreach (var v in this.lesAteliers)
            {
                cbxAtelier.Items.Add(v.Libelle);
                cbxAtelierAnimateur.Items.Add(v.Libelle);
            }

            foreach (var v in this.lesAteliersWithAnimateur)
            {
                cbxAtelierAll.Items.Add(v.Libelle);
            }

            foreach (var v in this.lesParticipants)
            {
                cbxAnimateur.Items.Add(v.Prenom);
                cbxIntervenant1.Items.Add(v.Prenom);
                cbxIntervenant2.Items.Add(v.Prenom);
                cbxIntervenant3.Items.Add(v.Prenom);
                cbxIntervenant4.Items.Add(v.Prenom);
            }
        }
        private void main_Load(object sender, EventArgs e)
        {
            ReLoad();
        }

        private void cbxAtelier_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cbxAtelier.SelectedIndex;
            Atelier unAtelier;
            unAtelier = lesAteliers.ElementAt(i);

            lblNomAtelier.Text = unAtelier.Libelle;
            lblHoraireDebut.Text = unAtelier.Debut.ToString();
            lblHoraireFin.Text = unAtelier.Fin.ToString();
        }

        #region not use
        private void cbxAtelierAnimateur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void tbAfficherAll_Click(object sender, EventArgs e)
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
            if (cbxAnimateur.Text == "" || cbxAtelierAnimateur.Text == "")
            {
                lblAffectation.Text = "Veuillez choisir un animateur, un atelier";
                lblAffectation.ForeColor = Color.Red;
            }
            else
            {
                int idAtelier = cbxAtelierAnimateur.SelectedIndex + 1;
                int idAnimateur = cbxAnimateur.SelectedIndex + 1;

                DAOParticipant.affecterAnimateurBDD(idAtelier, idAnimateur);

                if (cbxIntervenant1.Text != "")
                {
                    int idParticipant = cbxIntervenant1.SelectedIndex + 1;

                    DAOParticipant.affecterIntervenantBDD(idAtelier, idParticipant);
                }

                if (cbxIntervenant2.Text != "")
                {
                    int idParticipant = cbxIntervenant2.SelectedIndex + 1;

                    DAOParticipant.affecterIntervenantBDD(idAtelier, idParticipant);
                }

                if (cbxIntervenant3.Text != "")
                {
                    int idParticipant = cbxIntervenant3.SelectedIndex + 1;

                    DAOParticipant.affecterIntervenantBDD(idAtelier, idParticipant);
                }

                if (cbxIntervenant4.Text != "")
                {
                    int idParticipant = cbxIntervenant4.SelectedIndex + 1;

                    DAOParticipant.affecterIntervenantBDD(idAtelier, idParticipant);
                }

                this.Controls.Clear();
                this.InitializeComponent();

                ReLoad();

            }

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            cbxAtelierAnimateur.SelectedIndex = -1;
            cbxAnimateur.SelectedIndex = -1;
            cbxIntervenant1.SelectedIndex = -1;
            cbxIntervenant2.SelectedIndex = -1;
            cbxIntervenant3.SelectedIndex = -1;
            cbxIntervenant4.SelectedIndex = -1;
        }


        private void cbxAtelierAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cbxAtelierAll.SelectedIndex;
            AtelierWithAnimateur unAtelierWithAnimateur;
            unAtelierWithAnimateur = lesAteliersWithAnimateur.ElementAt(i);
            txbAtelier.Text = unAtelierWithAnimateur.Libelle;
            txbAnimateur.Text = unAtelierWithAnimateur.Animateur;


            int idAtelier = cbxAtelierAll.SelectedIndex + 1;
            lesIntervenants = DAOIntervenant.getIntervenantByAtelier(idAtelier);
            dgvIntervenant.DataSource = lesIntervenants;
            dgvIntervenant.AutoResizeColumns();

            lesThemes = DAOTheme.getThemeByAtelier(idAtelier);
            dgvTheme.DataSource = lesThemes;
            dgvTheme.AutoResizeColumns();
        }
    }
}
