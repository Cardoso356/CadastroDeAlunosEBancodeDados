using ReaLTaiizor.Forms;

namespace Projeto_Cadastro_BD
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlunos formAlunos = new FormAlunos();
            formAlunos.MdiParent = this;
            formAlunos.Show();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCursos formCursos = new FormCursos();
            formCursos.MdiParent = this;
            formCursos.Show();
        }
    }
}
