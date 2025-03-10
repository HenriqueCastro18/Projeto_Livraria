using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuluAcademico.Support
{
    public class Repositorio : IDisposable
    {
        private MySqlConnection con;

        public Repositorio()
        {
            con = null;
            con = new MySqlConnection("Persist Security Info=False;server=localhost;database=Biblioteca;uid=root;");
            try
            {
                con.Open();
                Console.WriteLine($"MySQL version : {con.ServerVersion}");
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }

        public void executeScript(string sql)
        {
            //verificva se a conexão esta aberta
            if (con.State == ConnectionState.Open)
            {
                Console.WriteLine("connection Open!");
                var cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
        }


        public void executeQuery(string sql)
        {

            if (con.State == ConnectionState.Open)
            {
                //Console.WriteLine("connection Open!");
                using var cmd = new MySqlCommand(sql, con);
                using MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    for (int i = 0; i < rdr.FieldCount; i++)
                    {
                        Console.Write(rdr[i].ToString() + "\t");

                    }
                    Console.WriteLine("\n");
                }

            }
        }

        public void Dispose()
        {
            if (con != null)
            {
                con.Close();
            }

            con = null;
        }
    }
}
