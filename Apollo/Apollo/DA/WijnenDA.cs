using Apollo.Helper;
using Apollo.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Apollo.DA
{
    public class WijnenDA
    {
        public static List<Wijn> OphalenWijnen(string LeverancierNummer)
        {
            List<Wijn> wijnen = new List<Wijn>();

            string sql = "SELECT * FROM tblwijnen WHERE Leveranciersnummer = @leveranciernummer";

            MySqlConnection conn = Database.MaakVerbinding();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.AddWithValue("@leveranciernummer", LeverancierNummer);

            MySqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                wijnen.Add(Create(r));
            }
            r.Close();
            conn.Close();
            return wijnen;
        }

        public static Wijn Create(IDataRecord record)
        {
            return new Wijn()
            {
                code = Convert.ToInt32(record["Code"]),
                jaar = Convert.ToInt32(record["Jaar"]),
                omschrijving = record["Omschrijving"].ToString(),
                inhoud = record["Inhoud"].ToString(),
                ppf = Convert.ToDouble(record["PrijsPerFles"]),
                hoeveelheid = Convert.ToInt32(record["HoeveelheidPerVerpakking"]),
                voorraad = Convert.ToInt32(record["Voorraad"])
            };
        }
    }
}
