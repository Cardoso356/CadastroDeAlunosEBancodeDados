using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Cadastro_BD
{
    public partial class FormCursos : MaterialForm
    {
        bool isAlteracao = false;
        string conexao = @"server=127.0.0.1;" +
                        "uid=root;" +
                        "pwd=cardoso;" + //esse é o campo de senha do MySQL
                        "database=academico";

        public FormCursos()
        {
            InitializeComponent();
        }

        private void salvar()
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            var sql = "";
            if (isAlteracao)
            {
                sql = "UPDATE curso SET " +
                      "nome = @nome, " +
                      "nivel = @nivel, " +
                      "periodo = @periodo, " +
                      "duracao = @duracao, " +
                      "area = @area " +
                      "WHERE id = @id";
            }
            else
            {

                sql = "INSERT INTO curso " +
                   " (nome, nivel, periodo, duracao, area) " +
                   " VALUES " +
                   " (@nome, @nivel, @periodo, @duracao, @area) ";

            }

            var cmd = new MySqlCommand(sql, con); //é para poder rodar no banco de dados
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@nivel", txtNivel.Text);
            cmd.Parameters.AddWithValue("@periodo", txtPeriodo.Text);
            cmd.Parameters.AddWithValue("@duracao", txtDuracao.Text);
            cmd.Parameters.AddWithValue("@area", txtArea.Text);
            if (isAlteracao)
                cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
            LimpaCampos();


        }

        private bool ValidaFormulario()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome do Curso é obrigatório!");
                txtNome.Focus();
                return false;
            }

            return true;
        }

        private void LimpaCampos()
        {
            isAlteracao = false;
            foreach (var control in tabPageCadastro.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }

        private void BotaoSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario()) //chama a validação
            {
                salvar();
                tabControlCadastros.SelectedIndex = 1;
            }
        }

        private void carregaListView()
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            var sql = "SELECT * from curso";
            var sqlAd = new MySqlDataAdapter(sql, con);
            var dt = new DataTable();
            sqlAd.Fill(dt);
            dataGridViewCurso.DataSource = dt;
            con.Close();
        }

        private void tabPageConsulta_Enter(object sender, EventArgs e)
        {
            carregaListView();
        }


        private void editar()
        {
            if (dataGridViewCurso.SelectedRows.Count > 0)
            {
                isAlteracao = true;
                var linha = dataGridViewCurso.SelectedRows[0];
                txtId.Text = linha.Cells["id"].Value.ToString();
                txtNome.Text = linha.Cells["nome"].Value.ToString();
                txtNivel.Text = linha.Cells["nivel"].Value.ToString();
                txtPeriodo.Text = linha.Cells["periodo"].Value.ToString();
                txtDuracao.Text = linha.Cells["duracao"].Value.ToString();
                txtArea.Text = linha.Cells["area"].Value.ToString();
                tabControlCadastros.SelectedIndex = 0;
                txtNome.Focus();
            }
            else
            {
                MessageBox.Show("Selecione algum curso!", "IFSP", MessageBoxButtons.OK);
            }
        }

        private void BotaoEditar_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void dataGridViewCurso_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editar();
        }

        private void excluir(int id)
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            var sql = "DELETE FROM curso WHERE id = @id";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void BotaoExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewCurso.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir ?", "IFSP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dataGridViewCurso.SelectedRows[0].Cells["id"].Value;
                    excluir(id);
                    carregaListView();
                }
            }
            else
            {
                MessageBox.Show("Selecione algum curso!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Atenção: Informações não salvas serão perdidas. \n\n" +
            "Deseja cancelar ?", "Pergunta", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                tabControlCadastros.SelectedIndex = 1;

            }
        }

        private void BotaoNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            tabControlCadastros.SelectedIndex = 0;
            txtNome.Focus();
        }
    }
}
