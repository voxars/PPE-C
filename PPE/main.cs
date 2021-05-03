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
            lblNomAtelier.Text = unAtelier.Libelle;
            lblHoraireDebut.Text = unAtelier.Debut.ToString();
            lblHoraireFin.Text = unAtelier.Fin.ToString();
        }

    }
}
