﻿using System.Data.SqlClient;

namespace PPE
{
    public class log
    {
        public static bool testLogin(string log, string pass)
        {
            DAOFactory dao = new DAOFactory();
            dao.connecter();
            string requette = "SELECT * FROM utilisateur WHERE login = '" + log + "' AND password = '" + pass + "';";

            SqlDataReader lecteur = dao.excecSQLRead(requette);

            int count = 0;
            while (lecteur.Read())
            {
                count++;
            }

            if (count != 0)
            {
                return true;
            }

            return false;


        }
    }
}