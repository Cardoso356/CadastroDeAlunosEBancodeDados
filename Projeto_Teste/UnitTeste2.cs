using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Teste
{
    [TestClass]
    public class UnitTeste2
    {
        public MySqlConnection GetConnection()
        {
            string c = @"server=127.0.0.1;" +
                        "uid=root;" +
                        "pwd=cardoso;" + //esse cardoso é a senha do meu MySQL
                        "database=academico";
            return new MySqlConnection(c);
        }

        [TestMethod]
        public void TestConnect()
        {

            var con = GetConnection();
            con.Open();
            Assert.IsTrue(con.State == System.Data.ConnectionState.Open);
        }

        [TestMethod]
        public void TestInsert()
        {
            string sql = "INSERT INTO curso " +
                "(nome, nivel, periodo, duracao, area)" +
                "VALUES " +
                "(@nome, @nivel, @periodo, @duracao, @area)";

            var con = GetConnection();
            con.Open();
            var cmd = new MySqlCommand(sql, con); //é para poder rodar no banco de dados

            //para alimentar os dados
            cmd.Parameters.AddWithValue("@nome", "Engenharia da Computação");
            cmd.Parameters.AddWithValue("@nivel", "Técnico");
            cmd.Parameters.AddWithValue("@periodo", "Noturno");
            cmd.Parameters.AddWithValue("@duracao", "10 Semestres");
            cmd.Parameters.AddWithValue("@area", "Indústria");
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void TestSelect()
        {
            var con = GetConnection();
            con.Open();
            var sql = "SELECT * from curso";
            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand();

            var dt = new DataTable();
            sqlAd.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                Debug.Write(dr["nome"] + " ");
                Debug.Write(dr["nivel"] + " ");
                Debug.Write(dr["periodo"] + " ");
                Debug.Write(dr["duracao"] + " ");
                Debug.Write(dr["area"] + " ");
                Debug.WriteLine(" ");
            }

        }


    }
    

}
