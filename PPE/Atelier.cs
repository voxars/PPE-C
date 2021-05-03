using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    class Atelier
    {
        private int id;
        private string libelle;
        private int capaciteMax;
        private string debut;
        private string fin;
        private List<Atelier> lesAteliers;

        public Atelier(int id, string libelle, int capaciteMax, string debut, string fin)
        {
            this.Id = id;
            this.Libelle = libelle;
            this.CapaciteMax = capaciteMax;
            this.Debut = debut;
            this.Fin = fin;
            lesAteliers = new List<Atelier>();
        }

        #region Getter Setter
        public int Id 
        { 
            get => id; 
            set => id = value; 
        }

        public string Libelle 
        { 
            get => libelle; 
            set => libelle = value; 
        }
        public int CapaciteMax 
        { 
            get => capaciteMax;
            set => capaciteMax = value; 
        }
        public string Debut 
        {
            get => debut; 
            set => debut = value; 
        }
        public string Fin 
        { 
            get => fin; 
            set => fin = value; 
        }
        internal List<Atelier> LesAteliers 
        {
            get => lesAteliers; 
            set => lesAteliers = value; 
        }
        #endregion

        public static List<Atelier> listeAtelier()
        {
            return DAOAtelier.getAtelier();
        }

    }
}
