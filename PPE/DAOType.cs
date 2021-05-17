using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PPE
{
    public class DAOType
    {
        public static List<type> GetInfotypes()
        {
            List<type> infotype = new List<type>();
            string req = "Select * from typeParticipant";
            DAOFactory db = new DAOFactory();
            db.connecter();

            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                type a = new type(Convert.ToInt32(reader[0].ToString()), reader[1].ToString());
                infotype.Add(a);
            }

            //MessageBox.Show("participants recuperes");
            return infotype;
        }
    }
}