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
    }
}
