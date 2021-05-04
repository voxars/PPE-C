using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PPE
{
    public class DAOParticipant
    {
        public static List<participant> GetPartcipants()
        {
            List<participant> lesPartcipants = new List<participant>();
            string req = "Select * from participant";
            DAOFactory db = new DAOFactory();
            db.connecter();

            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                participant a = new participant(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(),
                    reader[3].ToString(), reader[4].ToString(), int.Parse(reader[5].ToString()), int.Parse(reader[6].ToString()));
                lesPartcipants.Add(a);
            }

            return lesPartcipants;
        }

        public static void ajouterParticipant(string nom, string prenom, string type, string adresse, string mail, int portable, int idAtelier)
        {
            
            string req = "insert into participant(nom, prenom, type, adresse, mail, numPortable, id_Atelier) values('" + nom + "', '" + prenom + "', '" + type + "', '" + adresse + "', '" + mail + "', '" + portable + "', '" + idAtelier + "')";
            DAOFactory db = new DAOFactory();
            db.connecter();

            db.excecSQLRead(req);
            MessageBox.Show("Participant ajouter");

        }
    }
}