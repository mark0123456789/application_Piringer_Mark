using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace application_Piringer_Mark
{
    internal class dataBaseSatemantes
    {
        public class Felhasznalo
        {
            public int Id { get; set; }
            public string Username { get; set; }
        }
        public static class DataBaseMentes
        {
            public static bool Login(string user, string pass)
            {
                using var conn = Connect.GetConnection();
                var cmd = new MySqlCommand("SELECT COUNT(*) FROM felhasznalok WHERE username=@u AND password=@p", conn);
                cmd.Parameters.AddWithValue("@u", user);
                cmd.Parameters.AddWithValue("@p", pass);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }

            public static bool Register(string user, string pass)
            {
                using var conn = Connect.GetConnection();
                var cmd = new MySqlCommand("INSERT INTO felhasznalok (username,password) VALUES (@u,@p)", conn);
                cmd.Parameters.AddWithValue("@u", user);
                cmd.Parameters.AddWithValue("@p", pass);
                return cmd.ExecuteNonQuery() > 0;
            }

            public static List<Felhasznalo> GetAllFelhasznalok()
            {
                List<Felhasznalo> lista = new();
                using var conn = Connect.GetConnection();
                var cmd = new MySqlCommand("SELECT * FROM felhasznalok", conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                    lista.Add(new Felhasznalo { Id = reader.GetInt32(0), Username = reader.GetString(1) });
                return lista;
            }

            public static void DeleteFelhasznalo(int id)
            {
                using var conn = Connect.GetConnection();
                var cmd = new MySqlCommand("DELETE FROM felhasznalok WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
