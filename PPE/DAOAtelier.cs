using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    class DAOAtelier
    {
        public static List<AtelierWithAnimateur> getAtelierWithAnimateur()
        {
            List<AtelierWithAnimateur> lesAteliers = new List<AtelierWithAnimateur>();
            string req = "select a.id, libelle, capaciteMax, debut, fin, prenom from atelier a join participant p on a.id_participant=p.id";
            DAOFactory db = new DAOFactory();
            db.connecter();

            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                AtelierWithAnimateur a = new AtelierWithAnimateur(int.Parse(reader[0].ToString()), reader[1].ToString(), int.Parse(reader[2].ToString()), 
                    DateTime.Parse(reader[3].ToString()), DateTime.Parse(reader[4].ToString()), reader[5].ToString());
                lesAteliers.Add(a);
            }
            return lesAteliers;
        }
        public static List<Atelier> getAtelier()
        {
            List<Atelier> lesAteliers = new List<Atelier>();
            string req = "select id, libelle, capaciteMax, debut, fin from atelier";
            DAOFactory db = new DAOFactory();
            db.connecter();

            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                Atelier a = new Atelier(int.Parse(reader[0].ToString()), reader[1].ToString(), int.Parse(reader[2].ToString()),
                    DateTime.Parse(reader[3].ToString()), DateTime.Parse(reader[4].ToString()));
                lesAteliers.Add(a);
            }
            return lesAteliers;
        }

    }
}
