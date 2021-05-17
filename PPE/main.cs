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
        private List<type> mesType = new List<type>();
        private List<benevole> mesHre = new List<benevole>();
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
            mesType = DAOType.GetInfotypes();
            mesHre = DAOBenevole.GetInfoJ();

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
            int type = null;
            type = cbbType.SelectedIndex;
            string adresse = txbAdresse.Text;
            string mail = txbMail.Text;
            int portable = Int32.Parse(txbPortable.Text);
            int idAtelier = cbbAtelier.SelectedIndex;
            int hreBene = cbbBenevole.SelectedIndex;
            if (nom != null || prenom != null  || adresse != null || mail != null ||  Atelier != null || portable.ToString() != null )
            {
                if (cbbType.SelectedText == "Benevole")
                {
                    if (cbbBenevole.SelectedIndex != 0)
                    {
                        
            

                        DAOParticipant.ajouterParticipant(nom, prenom, type, adresse, mail, portable,idAtelier, hreBene);
            
                        txbAdresse.Clear();
                        txbMail.Clear();
                        txbNom.Clear();
                        txbPortable.Clear();
                        txbPrenom.Clear();
                        cbbAtelier.ResetText();
                        cbbBenevole.ResetText();
                        cbbType.ResetText();
            
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
                else if (cbbType.SelectedIndex == 1 || cbbType.SelectedIndex == 2)
                {
                    if (cbbBenevole.SelectedIndex != 0)
                    {
                        MessageBox.Show("ERREURE : un licencier ou un intervenant ne peut pas etre assigné a une demi-journée de benevola");
                    }
                    else
                    {
                      DAOParticipant.ajouterParticipant(nom, prenom, type, adresse, mail, portable,idAtelier, hreBene);
            
                        txbAdresse.Clear();
                        txbMail.Clear();
                        txbNom.Clear();
                        txbPortable.Clear();
                        txbPrenom.Clear();
                        cbbAtelier.ResetText();
                        cbbBenevole.ResetText();
                        cbbType.ResetText();
            
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
        
        #endregion

        #region Liste
        private void dataParticipants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        #endregion

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
