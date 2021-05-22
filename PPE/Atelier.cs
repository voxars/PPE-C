using PPE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    public class Atelier
    {
        private int id;
        private string libelle;
        private int capaciteMax;
        private DateTime debut;
        private DateTime fin;

        public Atelier(int id, string libelle, int capaciteMax, DateTime debut, DateTime fin)
        {
            this.Id = id;
            this.Libelle = libelle;
            this.CapaciteMax = capaciteMax;
            this.Debut = debut;
            this.Fin = fin;
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
        public DateTime Fin { get => fin; set => fin = value; }
        public DateTime Debut { get => debut; set => debut = value; }
    }
        
        #endregion


    class AtelierWithAnimateur : Atelier
    {
        private string animateur;

        public AtelierWithAnimateur(int id, string libelle, int capaciteMax, DateTime debut, DateTime fin, string animateur) : base(id, libelle, capaciteMax, debut, fin)
        {
            this.Animateur = animateur;
        }

        #region Getter Setter
        public string Animateur { get => animateur; set => animateur = value; }

        #endregion

    }

}
