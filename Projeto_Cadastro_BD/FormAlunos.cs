using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Cadastro_BD
{
    public partial class FormAlunos : MaterialForm
    {
        bool isAlteracao = false;
        string conexao = @"server=127.0.0.1;" +
                        "uid=root;" +
                        "pwd=cardoso;" + //esse é o campo de senha do MySQL
                        "database=academico";

        public FormAlunos()
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
                sql = "UPDATE aluno SET " +
                      "matricula = @matricula, " +
                      "dt_nascimento = @dt_nascimento, " +
                      "nome = @nome, " +
                      "endereco = @endereco, " +
                      "bairro = @bairro, " +
                      "cidade = @cidade, " +
                      "estado = @estado, " +
                      "senha = @senha " +
                      "WHERE id = @id";
            }
            else
            {

                sql = "INSERT INTO aluno " +
                   " (matricula, dt_nascimento, nome, endereco, " +
                   " bairro, cidade, estado, senha)" +
                   " VALUES " +
                   " (@matricula, @dt_nascimento, @nome, @endereco, " +
                   " @bairro, @cidade, @estado, @senha)";

            }

            var cmd = new MySqlCommand(sql, con); //é para poder rodar no banco de dados
            cmd.Parameters.AddWithValue("@matricula", txtMatricula.Text);

            DateTime.TryParse(txtDataNascimento.Text, out DateTime dataNascimento);
            cmd.Parameters.AddWithValue("@dt_nascimento", dataNascimento);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
            cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
            cmd.Parameters.AddWithValue("@estado", cboEstado.Text);
            cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
            if (isAlteracao)
                cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
            LimpaCampos();


        }


        private bool ValidaFormulario()
        {
            if (string.IsNullOrEmpty(txtMatricula.Text))
            {
                MessageBox.Show("Matricula obrigatória!");
                txtMatricula.Focus();
                return false;
            }
            if (!DateTime.TryParse(txtDataNascimento.Text, out DateTime _))
            {
                MessageBox.Show("Data de Nascimeno Inválida!", "IFSP",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDataNascimento.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome obrigatório!");
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtEndereco.Text))
            {
                MessageBox.Show("Endereço obrigatório!");
                txtEndereco.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtBairro.Text))
            {
                MessageBox.Show("Bairro obrigatório!");
                txtBairro.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show("Cidade obrigatória!");
                txtCidade.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Senha obrigatória!");
                txtSenha.Focus();
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

        private void btnSalvar_Click(object sender, EventArgs e)
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
            var sql = "SELECT * from aluno";
            var sqlAd = new MySqlDataAdapter(sql, con);
            var dt = new DataTable();
            sqlAd.Fill(dt);
            dataGridViewAluno.DataSource = dt;
            con.Close();
        }

        private void tabPageConsulta_Enter(object sender, EventArgs e)
        {
            carregaListView();
        }

        private void editar()
        {
            if (dataGridViewAluno.SelectedRows.Count > 0)
            {
                isAlteracao = true;
                var linha = dataGridViewAluno.SelectedRows[0];
                txtId.Text = linha.Cells["id"].Value.ToString();
                txtMatricula.Text = linha.Cells["matricula"].Value.ToString();
                txtNome.Text = linha.Cells["nome"].Value.ToString();
                txtDataNascimento.Text = linha.Cells["dt_nascimento"].Value.ToString();
                txtEndereco.Text = linha.Cells["endereco"].Value.ToString();
                txtBairro.Text = linha.Cells["bairro"].Value.ToString();
                txtCidade.Text = linha.Cells["cidade"].Value.ToString();
                cboEstado.Text = linha.Cells["estado"].Value.ToString();
                txtSenha.Text = linha.Cells["senha"].Value.ToString();
                tabControlCadastros.SelectedIndex = 0;
                txtMatricula.Focus();
            }
            else
            {
                MessageBox.Show("Selecione algum aluno!", "IFSP", MessageBoxButtons.OK);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void dataGridViewAluno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editar();
        }


        private void excluir(int id)
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            var sql = "DELETE FROM aluno WHERE id = @id";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewAluno.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir ?", "IFSP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dataGridViewAluno.SelectedRows[0].Cells["id"].Value;
                    excluir(id);
                    carregaListView();
                }
            }
            else
            {
                MessageBox.Show("Selecione algum aluno", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Atenção: Informações não salvas serão perdidas. \n\n" +
            "Deseja cancelar ?", "Pergunta", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                tabControlCadastros.SelectedIndex = 1;

            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            tabControlCadastros.SelectedIndex = 0;
            txtMatricula.Focus();
        }
    }
}
