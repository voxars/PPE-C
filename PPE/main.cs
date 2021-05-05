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

        public main()
        {
            InitializeComponent();
        }

        #region initialisation des données
        private void initialiserAtelier()
        {
            monAtelier = new Atelier(10, "test", 50, "21:20", "21:30");

            monAtelier.LesAteliers = Atelier.listeAtelier();
        }
        private void initialiserAnimateur()
        {
            monAnimateur = new Animateur(1, "testAnimateur", "", "", "","",1);

            monAnimateur.LesAnimateurs = Animateur.listeAnimateur();
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
            }

            foreach (Animateur unAnimateur in monAnimateur.LesAnimateurs)
            {
                cbxAnimateur.Items.Add(unAnimateur.Prenom);
                cbxIntervenant1.Items.Add(unAnimateur.Prenom);
                cbxIntervenant2.Items.Add(unAnimateur.Prenom);
                cbxIntervenant3.Items.Add(unAnimateur.Prenom);
                cbxIntervenant4.Items.Add(unAnimateur.Prenom);
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
    }
}
