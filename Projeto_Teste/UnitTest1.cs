using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow;

namespace Projeto_Teste
{
    [TestClass]
    public class UnitTest1
    {
        public MySqlConnection GetConnection()
        {
            string c = @"server=127.0.0.1;" +
                        "uid=root;" +
                        "pwd=cardoso;" + //esse é o campo da senha do MySQL, no pc do IF é ifsp, no meu é cardoso
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

            string sql = "INSERT INTO aluno " +
                " (matricula, dt_nascimento, nome, endereco, " +
                " bairro, cidade, estado, senha)" +
                " VALUES " +
                " (@matricula, @dt_nascimento, @nome, @endereco, " +
                " @bairro, @cidade, @estado, @senha)";

            var con = GetConnection();
            con.Open();
            var cmd = new MySqlCommand(sql, con); //é para poder rodar no banco de dados

            //para alimentar os dados
            cmd.Parameters.AddWithValue("@matricula", "BI3017966");
            cmd.Parameters.AddWithValue("@dt_nascimento", new DateTime(2002, 10, 13));
            cmd.Parameters.AddWithValue("@nome", "Alan");
            cmd.Parameters.AddWithValue("@endereco", "rua");
            cmd.Parameters.AddWithValue("@bairro", "fátima");
            cmd.Parameters.AddWithValue("@cidade", "Birigui");
            cmd.Parameters.AddWithValue("@estado", "SP");
            cmd.Parameters.AddWithValue("@senha", "1234");
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void TestSelect()
        {
            var con = GetConnection();
            con.Open();
            var sql = "SELECT * from aluno";
            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand();

            var dt = new DataTable();
            sqlAd.Fill(dt); 

            foreach (DataRow dr in dt.Rows)
            {
                Debug.Write(dr["matricula"] + " ");
                Debug.Write(dr["nome"] + " ");
                Debug.Write(dr["dt_nascimento"] + " ");
                Debug.Write(dr["endereco"] + " ");
                Debug.Write(dr["bairro"] + " ");
                Debug.Write(dr["cidade"] + " ");
                Debug.Write(dr["estado"] + " ");
                Debug.Write(dr["senha"] + " ");
                Debug.WriteLine(" ");
            }

        }


    }
}