using System.Data.SqlClient;

namespace PPE
{
    public class DAOParticipants
    {
        public static void AjoutParticipant(string nom, string prenom, string type, string adresse, string mail, int portable, string login, string password)
        {
            DAOFactory dao = new DAOFactory();
            dao.connecter();
            string requette = "INSERT INTO participant(nom,prenom,type,adresse,mail,numPortable,login,password) VALUES ('" + nom + "', '" + prenom + "', '" + type + "', '" + adresse + "', '" + mail + "', '" + portable + "', '" + login + "', '" + password + "')";

            SqlDataReader lecteur = dao.excecSQLRead(requette);
            
        }
    }
}