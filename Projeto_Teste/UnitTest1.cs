using MySql.Data.MySqlClient;

namespace Projeto_Teste
{
    [TestClass]
    public class UnitTest1
    {
        public MySqlConnection GetConnection()
        {
            string c = @"server=127.0.0.1;" +
                        "uid=root;" +
                        "pwd=ifsp;" +
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

        }
    }
}