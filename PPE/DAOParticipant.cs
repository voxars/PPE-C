using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PPE
{
    public class DAOParticipant
    {
        public static List<InfoParticipant> GetInfoPartcipants()
        {
            List<InfoParticipant> lesInfoPartcipants = new List<InfoParticipant>();
            string req = "Select nom, t.libelle,a.libelle from participant p inner join atelier a on p.id_atelierParticipant = a.id inner join typeParticipant t on p.type = t.id";
            DAOFactory db = new DAOFactory();
            db.connecter();

            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                InfoParticipant a = new InfoParticipant(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
                lesInfoPartcipants.Add(a);
            }

            //MessageBox.Show("participants recuperes");
            return lesInfoPartcipants;
        }

        public static void ajouterParticipant(string nom, string prenom, int type, string adresse, string mail, int portable, int idAtelier, int hreBenevole)
        {
            
            string req = "insert into participant(nom, prenom, adresse, mail, numPortable, id_atelierParticipant, hreBenevole, type) values('" + nom + "', '" + prenom + "', '" + adresse + "', '" + mail + "', '" + portable + "', '" + idAtelier + "', '" + hreBenevole + "', '" + type + "')";
            DAOFactory db = new DAOFactory();
            db.connecter();

            db.excecSQLRead(req);
            MessageBox.Show("Participant ajouter");

        }
        
         public static List<participant> getParticipant()
        {
            List<participant> lesParticipants = new List<participant>();
            string req = "Select * from participant";
            DAOFactory db = new DAOFactory();
            db.connecter();

            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                participant a = new participant(Convert.ToInt32(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),reader[4].ToString(), Convert.ToInt32(reader[0].ToString()),Convert.ToInt32(reader[0].ToString()), Convert.ToInt32(reader[0].ToString()), Convert.ToInt32(reader[0].ToString()));
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