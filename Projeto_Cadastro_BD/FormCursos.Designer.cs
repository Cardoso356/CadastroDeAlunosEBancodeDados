namespace Projeto_Cadastro_BD
{
    partial class FormCursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCursos));
            tabControlCadastros = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastro = new TabPage();
            BotaoSalvar = new ReaLTaiizor.Controls.MaterialButton();
            BotaoCancelar = new ReaLTaiizor.Controls.MaterialButton();
            txtArea = new ReaLTaiizor.Controls.MaterialComboBox();
            txtDuracao = new ReaLTaiizor.Controls.MaterialComboBox();
            txtPeriodo = new ReaLTaiizor.Controls.MaterialComboBox();
            txtNivel = new ReaLTaiizor.Controls.MaterialComboBox();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageConsulta = new TabPage();
            BotaoExcluir = new ReaLTaiizor.Controls.MaterialButton();
            BotaoEditar = new ReaLTaiizor.Controls.MaterialButton();
            BotaoNovo = new ReaLTaiizor.Controls.MaterialButton();
            dataGridViewCurso = new DataGridView();
            imageList1 = new ImageList(components);
            tabControlCadastros.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCurso).BeginInit();
            SuspendLayout();
            // 
            // tabControlCadastros
            // 
            tabControlCadastros.Controls.Add(tabPageCadastro);
            tabControlCadastros.Controls.Add(tabPageConsulta);
            tabControlCadastros.Depth = 0;
            tabControlCadastros.Dock = DockStyle.Fill;
            tabControlCadastros.ImageList = imageList1;
            tabControlCadastros.Location = new Point(3, 64);
            tabControlCadastros.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabControlCadastros.Multiline = true;
            tabControlCadastros.Name = "tabControlCadastros";
            tabControlCadastros.SelectedIndex = 0;
            tabControlCadastros.Size = new Size(794, 430);
            tabControlCadastros.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(BotaoSalvar);
            tabPageCadastro.Controls.Add(BotaoCancelar);
            tabPageCadastro.Controls.Add(txtArea);
            tabPageCadastro.Controls.Add(txtDuracao);
            tabPageCadastro.Controls.Add(txtPeriodo);
            tabPageCadastro.Controls.Add(txtNivel);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.ImageKey = "ImagemConsulta.png";
            tabPageCadastro.Location = new Point(4, 24);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(786, 402);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // BotaoSalvar
            // 
            BotaoSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BotaoSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            BotaoSalvar.Depth = 0;
            BotaoSalvar.HighEmphasis = true;
            BotaoSalvar.Icon = null;
            BotaoSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            BotaoSalvar.Location = new Point(610, 354);
            BotaoSalvar.Margin = new Padding(4, 6, 4, 6);
            BotaoSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            BotaoSalvar.Name = "BotaoSalvar";
            BotaoSalvar.NoAccentTextColor = Color.Empty;
            BotaoSalvar.Size = new Size(76, 36);
            BotaoSalvar.TabIndex = 7;
            BotaoSalvar.Text = "Salvar";
            BotaoSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            BotaoSalvar.UseAccentColor = false;
            BotaoSalvar.UseVisualStyleBackColor = true;
            BotaoSalvar.Click += BotaoSalvar_Click;
            // 
            // BotaoCancelar
            // 
            BotaoCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BotaoCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            BotaoCancelar.Depth = 0;
            BotaoCancelar.HighEmphasis = true;
            BotaoCancelar.Icon = null;
            BotaoCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            BotaoCancelar.Location = new Point(495, 354);
            BotaoCancelar.Margin = new Padding(4, 6, 4, 6);
            BotaoCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            BotaoCancelar.Name = "BotaoCancelar";
            BotaoCancelar.NoAccentTextColor = Color.Empty;
            BotaoCancelar.Size = new Size(96, 36);
            BotaoCancelar.TabIndex = 6;
            BotaoCancelar.Text = "Cancelar";
            BotaoCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            BotaoCancelar.UseAccentColor = false;
            BotaoCancelar.UseVisualStyleBackColor = true;
            BotaoCancelar.Click += BotaoCancelar_Click;
            // 
            // txtArea
            // 
            txtArea.AutoResize = false;
            txtArea.BackColor = Color.FromArgb(255, 255, 255);
            txtArea.Depth = 0;
            txtArea.DrawMode = DrawMode.OwnerDrawVariable;
            txtArea.DropDownHeight = 174;
            txtArea.DropDownStyle = ComboBoxStyle.DropDownList;
            txtArea.DropDownWidth = 121;
            txtArea.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtArea.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtArea.FormattingEnabled = true;
            txtArea.Hint = "Área do Curso";
            txtArea.IntegralHeight = false;
            txtArea.ItemHeight = 43;
            txtArea.Items.AddRange(new object[] { "Licenciatura", "Informática", "Indústria", "Administração" });
            txtArea.Location = new Point(26, 279);
            txtArea.MaxDropDownItems = 4;
            txtArea.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(359, 49);
            txtArea.StartIndex = 0;
            txtArea.TabIndex = 5;
            // 
            // txtDuracao
            // 
            txtDuracao.AutoResize = false;
            txtDuracao.BackColor = Color.FromArgb(255, 255, 255);
            txtDuracao.Depth = 0;
            txtDuracao.DrawMode = DrawMode.OwnerDrawVariable;
            txtDuracao.DropDownHeight = 174;
            txtDuracao.DropDownStyle = ComboBoxStyle.DropDownList;
            txtDuracao.DropDownWidth = 121;
            txtDuracao.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtDuracao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtDuracao.FormattingEnabled = true;
            txtDuracao.Hint = "Duração do Curso";
            txtDuracao.IntegralHeight = false;
            txtDuracao.ItemHeight = 43;
            txtDuracao.Items.AddRange(new object[] { "1 Semestre", "2 Semestres", "3 Semestres", "4 Semestres", "5 Semestres", "6 Semestres", "7 Semestres", "8 Semestres", "9 Semestres", "10 Semestres" });
            txtDuracao.Location = new Point(26, 224);
            txtDuracao.MaxDropDownItems = 4;
            txtDuracao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDuracao.Name = "txtDuracao";
            txtDuracao.Size = new Size(359, 49);
            txtDuracao.StartIndex = 0;
            txtDuracao.TabIndex = 4;
            // 
            // txtPeriodo
            // 
            txtPeriodo.AutoResize = false;
            txtPeriodo.BackColor = Color.FromArgb(255, 255, 255);
            txtPeriodo.Depth = 0;
            txtPeriodo.DrawMode = DrawMode.OwnerDrawVariable;
            txtPeriodo.DropDownHeight = 174;
            txtPeriodo.DropDownStyle = ComboBoxStyle.DropDownList;
            txtPeriodo.DropDownWidth = 121;
            txtPeriodo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtPeriodo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtPeriodo.FormattingEnabled = true;
            txtPeriodo.Hint = "Período";
            txtPeriodo.IntegralHeight = false;
            txtPeriodo.ItemHeight = 43;
            txtPeriodo.Items.AddRange(new object[] { "Matutino", "Vespertino", "Noturno", "Integral" });
            txtPeriodo.Location = new Point(26, 169);
            txtPeriodo.MaxDropDownItems = 4;
            txtPeriodo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPeriodo.Name = "txtPeriodo";
            txtPeriodo.Size = new Size(359, 49);
            txtPeriodo.StartIndex = 0;
            txtPeriodo.TabIndex = 3;
            // 
            // txtNivel
            // 
            txtNivel.AutoResize = false;
            txtNivel.BackColor = Color.FromArgb(255, 255, 255);
            txtNivel.Depth = 0;
            txtNivel.DrawMode = DrawMode.OwnerDrawVariable;
            txtNivel.DropDownHeight = 174;
            txtNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            txtNivel.DropDownWidth = 121;
            txtNivel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtNivel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtNivel.FormattingEnabled = true;
            txtNivel.Hint = "Nível";
            txtNivel.IntegralHeight = false;
            txtNivel.ItemHeight = 43;
            txtNivel.Items.AddRange(new object[] { "Técnico", "Superior" });
            txtNivel.Location = new Point(26, 114);
            txtNivel.MaxDropDownItems = 4;
            txtNivel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNivel.Name = "txtNivel";
            txtNivel.Size = new Size(359, 49);
            txtNivel.StartIndex = 0;
            txtNivel.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome do Curso";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(26, 60);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(660, 48);
            txtNome.TabIndex = 1;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id do Curso";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(26, 6);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = false;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(660, 48);
            txtId.TabIndex = 0;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(BotaoExcluir);
            tabPageConsulta.Controls.Add(BotaoEditar);
            tabPageConsulta.Controls.Add(BotaoNovo);
            tabPageConsulta.Controls.Add(dataGridViewCurso);
            tabPageConsulta.ImageKey = "ImagemLupa.png";
            tabPageConsulta.Location = new Point(4, 24);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(786, 402);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            tabPageConsulta.Enter += tabPageConsulta_Enter;
            // 
            // BotaoExcluir
            // 
            BotaoExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BotaoExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            BotaoExcluir.Depth = 0;
            BotaoExcluir.HighEmphasis = true;
            BotaoExcluir.Icon = null;
            BotaoExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            BotaoExcluir.Location = new Point(585, 351);
            BotaoExcluir.Margin = new Padding(4, 6, 4, 6);
            BotaoExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            BotaoExcluir.Name = "BotaoExcluir";
            BotaoExcluir.NoAccentTextColor = Color.Empty;
            BotaoExcluir.Size = new Size(80, 36);
            BotaoExcluir.TabIndex = 3;
            BotaoExcluir.Text = "Excluir";
            BotaoExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            BotaoExcluir.UseAccentColor = false;
            BotaoExcluir.UseVisualStyleBackColor = true;
            BotaoExcluir.Click += BotaoExcluir_Click;
            // 
            // BotaoEditar
            // 
            BotaoEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BotaoEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            BotaoEditar.Depth = 0;
            BotaoEditar.HighEmphasis = true;
            BotaoEditar.Icon = null;
            BotaoEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            BotaoEditar.Location = new Point(493, 351);
            BotaoEditar.Margin = new Padding(4, 6, 4, 6);
            BotaoEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            BotaoEditar.Name = "BotaoEditar";
            BotaoEditar.NoAccentTextColor = Color.Empty;
            BotaoEditar.Size = new Size(71, 36);
            BotaoEditar.TabIndex = 2;
            BotaoEditar.Text = "Editar";
            BotaoEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            BotaoEditar.UseAccentColor = false;
            BotaoEditar.UseVisualStyleBackColor = true;
            BotaoEditar.Click += BotaoEditar_Click;
            // 
            // BotaoNovo
            // 
            BotaoNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BotaoNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            BotaoNovo.Depth = 0;
            BotaoNovo.HighEmphasis = true;
            BotaoNovo.Icon = null;
            BotaoNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            BotaoNovo.Location = new Point(410, 351);
            BotaoNovo.Margin = new Padding(4, 6, 4, 6);
            BotaoNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            BotaoNovo.Name = "BotaoNovo";
            BotaoNovo.NoAccentTextColor = Color.Empty;
            BotaoNovo.Size = new Size(64, 36);
            BotaoNovo.TabIndex = 1;
            BotaoNovo.Text = "Novo";
            BotaoNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            BotaoNovo.UseAccentColor = false;
            BotaoNovo.UseVisualStyleBackColor = true;
            BotaoNovo.Click += BotaoNovo_Click;
            // 
            // dataGridViewCurso
            // 
            dataGridViewCurso.AllowUserToAddRows = false;
            dataGridViewCurso.AllowUserToDeleteRows = false;
            dataGridViewCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCurso.Location = new Point(0, 0);
            dataGridViewCurso.Name = "dataGridViewCurso";
            dataGridViewCurso.ReadOnly = true;
            dataGridViewCurso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCurso.Size = new Size(777, 347);
            dataGridViewCurso.TabIndex = 0;
            dataGridViewCurso.CellDoubleClick += dataGridViewCurso_CellDoubleClick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "ImagemConsulta.png");
            imageList1.Images.SetKeyName(1, "ImagemLupa.png");
            // 
            // FormCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 497);
            Controls.Add(tabControlCadastros);
            DrawerAutoShow = true;
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = tabControlCadastros;
            Name = "FormCursos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Cursos";
            tabControlCadastros.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCurso).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl tabControlCadastros;
        private TabPage tabPageCadastro;
        private TabPage tabPageConsulta;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialComboBox txtDuracao;
        private ReaLTaiizor.Controls.MaterialComboBox txtPeriodo;
        private ReaLTaiizor.Controls.MaterialComboBox txtNivel;
        private ReaLTaiizor.Controls.MaterialComboBox txtArea;
        private ReaLTaiizor.Controls.MaterialButton BotaoSalvar;
        private ReaLTaiizor.Controls.MaterialButton BotaoCancelar;
        private DataGridView dataGridViewCurso;
        private ReaLTaiizor.Controls.MaterialButton BotaoExcluir;
        private ReaLTaiizor.Controls.MaterialButton BotaoEditar;
        private ReaLTaiizor.Controls.MaterialButton BotaoNovo;
        private ImageList imageList1;
    }
}