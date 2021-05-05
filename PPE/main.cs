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
        private Animateur monAnimateur;
        private List<InfoParticipant> listP = new List<InfoParticipant>();
            public main()
        {
            InitializeComponent();
        }

        #region initialisation des données
        private void initialiserAtelier()
        {
            monAtelier = new Atelier(10, "test", 50, "21:20", "21:30");

            monAtelier.LesAteliers = DAOAtelier.getAtelier();
        }
        private void initialiserAnimateur()
        {
            monAnimateur = new Animateur(1, "testAnimateur", "", "", "","",1);

            monAnimateur.LesAnimateurs = DAOAnimateur.getAnimateur();
        }
        #endregion


        private void main_Load(object sender, EventArgs e)
        {
            initialiserAtelier();
            initialiserAnimateur();

            foreach (Atelier unAtelier in monAtelier.LesAteliers)
            {
                cbxAtelier.Items.Add(unAtelier.Libelle);
                cbxAtelierAnimateur.Items.Add(unAtelier.Libelle);
                cbbAtelier.Items.Add(unAtelier.Libelle);
            }

            foreach (Animateur unAnimateur in monAnimateur.LesAnimateurs)
            {
                cbxAnimateur.Items.Add(unAnimateur.Prenom);
            }

            cbbType.Items.Add("Licencié");
            cbbType.Items.Add("Intervenant");
            cbbType.Items.Add("Benevole");

            cbbBenevole.Items.Add("Matin");
            cbbBenevole.Items.Add("Apres-midi");

            
            listP = DAOParticipant.GetInfoPartcipants();
            
            foreach (var v in this.listP)
            {
                dataParticipants.Rows.Add(v.Nom, v.Atelier, v.Type);
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

        #region participants

        private void btnCreer_Click(object sender, EventArgs e)
        {
            string nom = txbNom.Text;
            string prenom = txbPrenom.Text;
            int type = cbbType.SelectedIndex+1;
            string adresse = txbAdresse.Text;
            string mail = txbMail.Text;
            int portable = Int32.Parse(txbPortable.Text);
            int idAtelier = cbbAtelier.SelectedIndex+1;
            int hreBene = cbbBenevole.SelectedIndex+1;
            

            DAOParticipant.ajouterParticipant(nom, prenom, type, adresse, mail, portable,idAtelier, hreBene);
            
            txbAdresse.Clear();
            txbMail.Clear();
            txbNom.Clear();
            txbPortable.Clear();
            txbPrenom.Clear();
            cbbAtelier.ResetText();
            cbbBenevole.ResetText();
            cbbType.ResetText();
        }
        
        #endregion

        #region Liste
        private void dataParticipants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        #endregion
    }
}
