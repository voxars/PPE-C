
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
        public main()
        {
            InitializeComponent();
           
        }

        private void tabInscription_Click(object sender, EventArgs e)
        {

        }

        private void tabAtelier_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
        private void initialiserAtelier()
        {
            monAtelier = new Atelier(10, "test", 50, "21:20", "21:30");

            monAtelier.LesAteliers = Atelier.listeAtelier();
        }


        private void horaireAtelierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {
            initialiserAtelier();
        }
        private void tabPageHoraire_Enter(object sender, EventArgs e)
        {
            foreach (Atelier unCompte in monAtelier.LesAteliers)
            {
                cbxAtelier.Items.Add(unCompte.Libelle);
            }
        }


        private void cbxAtelier_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cbxAtelier.SelectedIndex;
            Atelier unAtelier;

            unAtelier = monAtelier.LesAteliers.ElementAt(i);
            lblAtelier.Text = unAtelier.Libelle;
            lblHoraireDebut.Text = unAtelier.Debut.ToString();
            lblHoraireFin.Text = unAtelier.Fin.ToString();
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

        private void txbTel_TextChanged(object sender, EventArgs e)
        {
        }

        private void txbLogin_TextChanged(object sender, EventArgs e)
        {
        }

        private void txbPass_TextChanged(object sender, EventArgs e)
        {
        }

        private void tabPageStands_Click(object sender, EventArgs e)
        {
        }

        private void tabPageInscription_Click(object sender, EventArgs e)
        {
        }

        private void btnAjouterParticipant_Click(object sender, EventArgs e)
        {
            string nom = txbNom.Text;
            string prenom = txbPrenom.Text;
            string type = cbbType.SelectedText;
            string adresse = txbAdresse.Text;
            string mail = txbMail.Text;
            int portable =  Convert.ToInt32(txbTel.Text.Trim());
            string login = txbLogin.Text;
            string password = txbPass.Text;
            
            DAOParticipants.AjoutParticipant(nom,prenom,type,adresse,mail,portable,login,password);
            MessageBox.Show("Participant ajouter");
        }
    }
}
