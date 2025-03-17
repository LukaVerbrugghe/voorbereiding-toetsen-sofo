using Apollo.Helper;
using Apollo.Model;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.CRUD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apollo.DA
{
    public class leveranciersDA
    {
        public static List<Leverancier> OphalenLeveranciers()
        {
            List<Leverancier> leveranciers = new List<Leverancier>();
            string sql = "SELECT * FROM tblleveranciers";

            MySqlConnection conn = Database.MaakVerbinding();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;

            MySqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                leveranciers.Add(Create(r));
            }
            r.Close();
            conn.Close();
            return leveranciers;
        }

        public static Leverancier Create(IDataRecord record)
        {
            return new Leverancier()
            {
                id = Convert.ToInt32(record["leveranciernummer"]),
                firmanaam = record["firmanaam"].ToString(),
                adres = record["adres"].ToString(),
                postnr = record["postnr"].ToString(),
                gemeente = record["gemeente"].ToString()
            };
        }
    }
}
