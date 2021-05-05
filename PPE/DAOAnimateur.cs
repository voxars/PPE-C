using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    class DAOAnimateur
    {
        public static List<Animateur> getAnimateur()
        {
            List<Animateur> lesAnimateurs = new List<Animateur>();
            string req = "Select * from participant";
            DAOFactory db = new DAOFactory();
            db.connecter();

            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                Animateur a = new Animateur(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(),
                    reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), int.Parse(reader[6].ToString()));
                lesAnimateurs.Add(a);
            }

            return lesAnimateurs;
        }
        public static void affecterAnimateurBDD(Atelier unAtelier, Animateur unAnimateur)
        {
            string requete = "update atelier set id_participant=" + unAnimateur.Id + " where id=" + unAtelier.Id ;

            DAOFactory db = new DAOFactory();
            db.connecter();
            db.execSQLWrite(requete);
        }
    }
}
