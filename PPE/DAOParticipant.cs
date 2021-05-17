using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    class DAOParticipant
    {
        public static List<Participant> getParticipant()
        {
            List<Participant> lesParticipants = new List<Participant>();
            string req = "Select * from participant";
            DAOFactory db = new DAOFactory();
            db.connecter();

            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                Participant a = new Participant(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(),
                    reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), int.Parse(reader[6].ToString()));
                lesParticipants.Add(a);
            }

            return lesParticipants;
        }
        public static void affecterAnimateurBDD(int idAtelier, int idAnimateur)
        {
            string requete = "update atelier set id_participant=" + idAnimateur + " where id=" + idAtelier;

            DAOFactory db = new DAOFactory();
            db.connecter();
            db.execSQLWrite(requete);
        }
        public static void affecterIntervenantBDD(int idAtelier, int idParticipant)
        {
            //string requete = "insert into intervenant values (" + idParticipant + "," + idAtelier + ")";
            string requete = "If Not Exists(select id, id_atelier from intervenant where id=" + idParticipant + " AND id_atelier=" + idAtelier +") Begin insert into intervenant values (" + idParticipant + "," + idAtelier + ") End";

            DAOFactory db = new DAOFactory();
            db.connecter();
            db.execSQLWrite(requete);
        }
    }
}
