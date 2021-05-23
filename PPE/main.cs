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
        private List<Atelier> mesAteliers = new List<Atelier>();
        private List<participant> mesParticipants = new List<participant>();
        private List<Intervenant> mesIntervenants = new List<Intervenant>();
        private List<Theme> mesThemes = new List<Theme>();
        private List<AtelierWithAnimateur> lesAteliersWithAnimateur = new List<AtelierWithAnimateur>();
        private List<type> mesType = new List<type>();
        private List<benevole> mesHre = new List<benevole>();
        private List<InfoParticipant> listP = new List<InfoParticipant>();
            public main()
        {
            InitializeComponent();
        }

            public void Reload()
            {
                mesAteliers = DAOAtelier.getAtelier();
                mesParticipants = DAOParticipant.getParticipant();
                lesAteliersWithAnimateur = DAOAtelier.getAtelierWithAnimateur();
                mesType = DAOType.GetInfotypes();
                mesHre = DAOBenevole.GetInfoJ();
            

                foreach (var v in this.mesAteliers)
                {
                    cbxAtelier.Items.Add(v.Libelle);
                    cbxAtelierAnimateur.Items.Add(v.Libelle);
                    cbxAtelierAll.Items.Add(v.Libelle);
                    cbbAtelier.Items.Add(v.Libelle);
                }
                
                foreach (var v in this.lesAteliersWithAnimateur)
                {
                    cbxAtelierAll.Items.Add(v.Libelle);
                }

                foreach (var v in this.mesParticipants)
                {
                    cbxAnimateur.Items.Add(v.Prenom);
                    cbxIntervenant1.Items.Add(v.Prenom);
                    cbxIntervenant2.Items.Add(v.Prenom);
                    cbxIntervenant3.Items.Add(v.Prenom);
                    cbxIntervenant4.Items.Add(v.Prenom);
                }

                foreach (var v in this.mesType)
                {
                    cbbType.Items.Add(v.Libelle);
                }
            
                foreach (var v in this.mesHre)
                {
                    cbbBenevole.Items.Add(v.Demij);
                }


                listP = DAOParticipant.GetInfoPartcipants();
            
                foreach (var v in this.listP)
                {
                    dataParticipants.Rows.Add(v.Nom, v.Atelier, v.Type);
                }

                cbbAtelier.SelectedIndex = 0;
                cbbBenevole.SelectedIndex = 0;
                cbbType.SelectedIndex = 0;
            }
        private void main_Load(object sender, EventArgs e)
        {
            Reload();
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
        
        private void txbNom_TextChanged(object sender, EventArgs e)
        {
        }

        private void txbPrenom_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void txbAdresse_TextChanged(object sender, EventArgs e)
        {
        }


        private void txbMail_TextChanged(object sender, EventArgs e)
        {
        }


        private void txbPortable_TextChanged(object sender, EventArgs e)
        {
        }


        private void cbbAtelier_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void cbbBenevole_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        #endregion

        #region AjouterParticipants

        private void btnCreer_Click(object sender, EventArgs e)
        {
            string nom = txbNom.Text;
            string prenom = txbPrenom.Text;
            int type = cbbType.SelectedIndex;
            string adresse = txbAdresse.Text;
            string mail = txbMail.Text;
            string portable = txbPortable.Text;
            int idAtelier = cbbAtelier.SelectedIndex+1;
            int hreBene = cbbBenevole.SelectedIndex;
            if (txbNom.Text.Length != 0 || txbPrenom.Text.Length != 0 || txbAdresse.Text.Length != 0 || txbMail.Text.Length != 0)
            {
                if (txbPortable.Text.Length == 10)
                {
                    if (cbbType.SelectedIndex == 2)
                    {
                        if (cbbBenevole.SelectedIndex == 1 || cbbBenevole.SelectedIndex == 2)
                        {

                            DAOParticipant.ajouterParticipant(nom, prenom, type, adresse, mail,
                                Convert.ToInt32(portable), idAtelier, hreBene);

                            txbAdresse.Clear();
                            txbMail.Clear();
                            txbNom.Clear();
                            txbPortable.Clear();
                            txbPrenom.Clear();

                            cbbAtelier.SelectedIndex = 0;
                            cbbBenevole.SelectedIndex = 0;
                            cbbType.SelectedIndex = 0;

                            dataParticipants.Rows.Clear();
                            listP = DAOParticipant.GetInfoPartcipants();

                            foreach (var v in this.listP)
                            {
                                dataParticipants.Rows.Add(v.Nom, v.Atelier, v.Type);
                            }

                        }
                        else
                        {
                            MessageBox.Show("ERREURE : Un benevole doit etre assigné a une demi-journée");
                        }
                    }
                    else
                    {
                        if (cbbBenevole.SelectedIndex != 0)
                        {
                            MessageBox.Show(
                                "ERREURE : un licencier ou un intervenant ne peut pas etre assigné a une demi-journée de benevola");
                        }
                        else
                        {
                            if (txbPortable.Text.Length == 10)
                            {
                                DAOParticipant.ajouterParticipant(nom, prenom, type, adresse, mail,
                                    Convert.ToInt32(portable), idAtelier, hreBene);

                                txbAdresse.Clear();
                                txbMail.Clear();
                                txbNom.Clear();
                                txbPortable.Clear();
                                txbPrenom.Clear();
                                
                                cbbAtelier.SelectedIndex = 0;
                                cbbBenevole.SelectedIndex = 0;
                                cbbType.SelectedIndex = 0;

                                dataParticipants.Rows.Clear();
                                listP = DAOParticipant.GetInfoPartcipants();

                                foreach (var v in this.listP)
                                {
                                    dataParticipants.Rows.Add(v.Nom, v.Atelier, v.Type);
                                }
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Un numero de telephone doit contenir 10 chiffres");
                }
                    
            }
            else
            {
                MessageBox.Show("Tout les champs doivent etres remplis !");
            }

        }
        
        #endregion

        #region ListeParticipants
        private void dataParticipants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        #endregion
        
        #region afficherAtelier
        private void cbxAtelier_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cbxAtelier.SelectedIndex;
            Atelier unAtelier;
            unAtelier = mesAteliers.ElementAt(i);

            lblNomAtelier.Text = unAtelier.Libelle;
            lblHoraireDebut.Text = unAtelier.Debut.ToString();
            lblHoraireFin.Text = unAtelier.Fin.ToString();
        }
        private void lblNomAtelier_Click(object sender, EventArgs e)
        {
        }
        private void lblHoraireDebut_Click(object sender, EventArgs e)
        {
        }
        private void lblHoraireFin_Click(object sender, EventArgs e)
        {
        }
        
        #endregion

        #region AffecterAnimateur
        private void cbxAnimateur_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }
        private void cbxAtelierAnimateur_SelectedIndexChanged_1(object sender, EventArgs e)
                {
                }
        private void cbxIntervenant1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void cbxIntervenant2_SelectedIndexChanged(object sender, EventArgs e)
                { }
        private void cbxIntervenant3_SelectedIndexChanged(object sender, EventArgs e)
                {
                }
        private void cbxIntervenant4_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void btnAffecter_Click(object sender, EventArgs e)
        {
            if (cbxAnimateur.Text == "" || cbxAtelierAnimateur.Text == "")
            {
                lblAffectation.Text = "Veuillez choisir un animateur et un atelier";
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
                Reload();
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
        
        #endregion

        #region AfficherAtelier

        private void cbxAtelierAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cbxAtelierAll.SelectedIndex;
            AtelierWithAnimateur unAtelierWithAnimateur;
            unAtelierWithAnimateur = lesAteliersWithAnimateur.ElementAt(i);
            txbAtelier.Text = unAtelierWithAnimateur.Libelle;
            txbAnimateur.Text = unAtelierWithAnimateur.Animateur;


            int idAtelier = cbxAtelierAll.SelectedIndex + 1;
            mesIntervenants = DAOIntervenant.getIntervenantByAtelier(idAtelier);
            dgvIntervenant.DataSource = mesIntervenants;
            dgvIntervenant.AutoResizeColumns();

            mesThemes = DAOTheme.getThemeByAtelier(idAtelier);
            dgvTheme.DataSource = mesThemes;
            dgvTheme.AutoResizeColumns();
        }
        private void txbAtelier_TextChanged(object sender, EventArgs e)
        {
        }
        private void dgvIntervenant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dgvTheme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        
        private void dtpDebut_ValueChanged(object sender, EventArgs e)
        {
        }
        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {
        }
        private void btnHoraire_Click(object sender, EventArgs e)
        {
            if(dtpDebut.Value.Hour < dtpFin.Value.Hour && dtpDebut.Value.Date == dtpFin.Value.Date && cbxAtelier.Text != null)
            {
                int idAtelier = cbxAtelier.SelectedIndex + 1;

                DAOAtelier.affecterHoraire(idAtelier, dtpDebut.Value, dtpFin.Value);

                this.Controls.Clear();
                this.InitializeComponent();
                Reload();

            }
            else
            {
                MessageBox.Show("L'heure de début doit être supérieur à l'heure de fin et la date doit être la même");
            }
        }
        #endregion
        
        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
          Application.Exit();
        }

        
    }
}
