using System;
using System.Data;
using System.Data.SqlClient;

namespace GeneticAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            string constring = "Data Source=DEV-STAVROU\\SQLEXPRESS;Initial Catalog=GeneticAlgorithms;Integrated Security=True";
            Console.WriteLine("Hello World!");

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(constring))
            {
                
                SqlCommand cmd = new SqlCommand("SELECT * FROM Test WHERE NAME = 'Test'", con);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.SelectCommand.CommandTimeout = 300;
                con.Open();
                adapter.Fill(dt);
                con.Close();
            }
            
        }
    }
}
