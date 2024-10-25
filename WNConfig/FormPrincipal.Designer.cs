namespace WNConfig
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PnlTitulo = new Panel();
            LblTitulo = new Label();
            PnlRodape = new Panel();
            LblMensagem = new Label();
            BtnCarregarArquivo = new Button();
            BtnCancelar = new Button();
            BtnSalvar = new Button();
            Tab = new TabControl();
            TabPrincipal = new TabPage();
            BtnGerarChave = new Button();
            groupBox2 = new GroupBox();
            BtnExibirSenha = new Button();
            CkbEmailSSL = new CheckBox();
            label9 = new Label();
            TxtEmailPassword = new TextBox();
            label8 = new Label();
            TxtEmailUserName = new TextBox();
            label7 = new Label();
            TxtEmailPorta = new TextBox();
            label3 = new Label();
            TxtEmailHost = new TextBox();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            TxtBdBuild = new TextBox();
            TxtBdVersaoMenor = new TextBox();
            TxtBdVersao = new TextBox();
            TxtStringConexao = new TextBox();
            label2 = new Label();
            TxtChave = new TextBox();
            label1 = new Label();
            openFileDlg = new OpenFileDialog();
            saveFileDlg = new SaveFileDialog();
            BtnCopiar = new Button();
            PnlTitulo.SuspendLayout();
            PnlRodape.SuspendLayout();
            Tab.SuspendLayout();
            TabPrincipal.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // PnlTitulo
            // 
            PnlTitulo.Controls.Add(LblTitulo);
            PnlTitulo.Dock = DockStyle.Top;
            PnlTitulo.Location = new Point(0, 0);
            PnlTitulo.Name = "PnlTitulo";
            PnlTitulo.Size = new Size(740, 46);
            PnlTitulo.TabIndex = 0;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.Location = new Point(9, 10);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(409, 25);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "Gerar arquivo de configuração para sistemas";
            // 
            // PnlRodape
            // 
            PnlRodape.Controls.Add(LblMensagem);
            PnlRodape.Controls.Add(BtnCarregarArquivo);
            PnlRodape.Controls.Add(BtnCancelar);
            PnlRodape.Controls.Add(BtnSalvar);
            PnlRodape.Dock = DockStyle.Bottom;
            PnlRodape.Location = new Point(0, 321);
            PnlRodape.Name = "PnlRodape";
            PnlRodape.Size = new Size(740, 50);
            PnlRodape.TabIndex = 1;
            // 
            // LblMensagem
            // 
            LblMensagem.AutoSize = true;
            LblMensagem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblMensagem.Location = new Point(12, 19);
            LblMensagem.Name = "LblMensagem";
            LblMensagem.Size = new Size(77, 15);
            LblMensagem.TabIndex = 3;
            LblMensagem.Text = "</WILLIAN>";
            // 
            // BtnCarregarArquivo
            // 
            BtnCarregarArquivo.Location = new Point(462, 15);
            BtnCarregarArquivo.Name = "BtnCarregarArquivo";
            BtnCarregarArquivo.Size = new Size(104, 23);
            BtnCarregarArquivo.TabIndex = 2;
            BtnCarregarArquivo.Text = "Ler Arquivo";
            BtnCarregarArquivo.UseVisualStyleBackColor = true;
            BtnCarregarArquivo.Click += BtnCarregarArquivo_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(653, 15);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 1;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(572, 15);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(75, 23);
            BtnSalvar.TabIndex = 0;
            BtnSalvar.Text = "F5 | Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // Tab
            // 
            Tab.Controls.Add(TabPrincipal);
            Tab.Dock = DockStyle.Fill;
            Tab.Location = new Point(0, 46);
            Tab.Name = "Tab";
            Tab.SelectedIndex = 0;
            Tab.Size = new Size(740, 275);
            Tab.TabIndex = 0;
            // 
            // TabPrincipal
            // 
            TabPrincipal.Controls.Add(BtnCopiar);
            TabPrincipal.Controls.Add(BtnGerarChave);
            TabPrincipal.Controls.Add(groupBox2);
            TabPrincipal.Controls.Add(groupBox1);
            TabPrincipal.Controls.Add(TxtStringConexao);
            TabPrincipal.Controls.Add(label2);
            TabPrincipal.Controls.Add(TxtChave);
            TabPrincipal.Controls.Add(label1);
            TabPrincipal.Location = new Point(4, 24);
            TabPrincipal.Name = "TabPrincipal";
            TabPrincipal.Padding = new Padding(3);
            TabPrincipal.Size = new Size(732, 247);
            TabPrincipal.TabIndex = 0;
            TabPrincipal.Text = "Principal";
            TabPrincipal.UseVisualStyleBackColor = true;
            // 
            // BtnGerarChave
            // 
            BtnGerarChave.Location = new Point(584, 33);
            BtnGerarChave.Name = "BtnGerarChave";
            BtnGerarChave.Size = new Size(140, 23);
            BtnGerarChave.TabIndex = 2;
            BtnGerarChave.Text = "Gerar Chave Aleatória";
            BtnGerarChave.UseVisualStyleBackColor = true;
            BtnGerarChave.Click += BtnGerarChave_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnExibirSenha);
            groupBox2.Controls.Add(CkbEmailSSL);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(TxtEmailPassword);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(TxtEmailUserName);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(TxtEmailPorta);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(TxtEmailHost);
            groupBox2.Location = new Point(196, 106);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(530, 126);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Servidor de Email";
            // 
            // BtnExibirSenha
            // 
            BtnExibirSenha.Location = new Point(288, 81);
            BtnExibirSenha.Name = "BtnExibirSenha";
            BtnExibirSenha.Size = new Size(44, 23);
            BtnExibirSenha.TabIndex = 9;
            BtnExibirSenha.Text = "Ver";
            BtnExibirSenha.UseVisualStyleBackColor = true;
            BtnExibirSenha.Click += BtnExibirSenha_Click;
            // 
            // CkbEmailSSL
            // 
            CkbEmailSSL.AutoSize = true;
            CkbEmailSSL.Location = new Point(432, 24);
            CkbEmailSSL.Name = "CkbEmailSSL";
            CkbEmailSSL.Size = new Size(70, 19);
            CkbEmailSSL.TabIndex = 2;
            CkbEmailSSL.Text = "Usar SSL";
            CkbEmailSSL.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 85);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 7;
            label9.Text = "Password";
            // 
            // TxtEmailPassword
            // 
            TxtEmailPassword.Location = new Point(76, 80);
            TxtEmailPassword.Name = "TxtEmailPassword";
            TxtEmailPassword.PasswordChar = '*';
            TxtEmailPassword.Size = new Size(206, 23);
            TxtEmailPassword.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 56);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 5;
            label8.Text = "UserName";
            // 
            // TxtEmailUserName
            // 
            TxtEmailUserName.Location = new Point(76, 51);
            TxtEmailUserName.Name = "TxtEmailUserName";
            TxtEmailUserName.Size = new Size(206, 23);
            TxtEmailUserName.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(288, 27);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 3;
            label7.Text = "Porta";
            // 
            // TxtEmailPorta
            // 
            TxtEmailPorta.Location = new Point(326, 22);
            TxtEmailPorta.Name = "TxtEmailPorta";
            TxtEmailPorta.Size = new Size(100, 23);
            TxtEmailPorta.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 27);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 1;
            label3.Text = "Host";
            // 
            // TxtEmailHost
            // 
            TxtEmailHost.Location = new Point(76, 22);
            TxtEmailHost.Name = "TxtEmailHost";
            TxtEmailHost.Size = new Size(206, 23);
            TxtEmailHost.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtBdBuild);
            groupBox1.Controls.Add(TxtBdVersaoMenor);
            groupBox1.Controls.Add(TxtBdVersao);
            groupBox1.Location = new Point(8, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(180, 126);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Servidor de banco de dados";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 85);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 16;
            label6.Text = "Build";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 54);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 15;
            label5.Text = "Versão Menor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 25);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 14;
            label4.Text = "Versão Principal";
            // 
            // TxtBdBuild
            // 
            TxtBdBuild.Location = new Point(103, 82);
            TxtBdBuild.Name = "TxtBdBuild";
            TxtBdBuild.Size = new Size(49, 23);
            TxtBdBuild.TabIndex = 2;
            // 
            // TxtBdVersaoMenor
            // 
            TxtBdVersaoMenor.Location = new Point(103, 51);
            TxtBdVersaoMenor.Name = "TxtBdVersaoMenor";
            TxtBdVersaoMenor.Size = new Size(49, 23);
            TxtBdVersaoMenor.TabIndex = 1;
            // 
            // TxtBdVersao
            // 
            TxtBdVersao.Location = new Point(103, 22);
            TxtBdVersao.Name = "TxtBdVersao";
            TxtBdVersao.Size = new Size(49, 23);
            TxtBdVersao.TabIndex = 0;
            // 
            // TxtStringConexao
            // 
            TxtStringConexao.Location = new Point(8, 77);
            TxtStringConexao.Name = "TxtStringConexao";
            TxtStringConexao.Size = new Size(716, 23);
            TxtStringConexao.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 59);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 2;
            label2.Text = "String de Conexão";
            // 
            // TxtChave
            // 
            TxtChave.Location = new Point(8, 33);
            TxtChave.Name = "TxtChave";
            TxtChave.Size = new Size(508, 23);
            TxtChave.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 15);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Chave (Key)";
            // 
            // openFileDlg
            // 
            openFileDlg.FileName = "openFileDialog1";
            // 
            // BtnCopiar
            // 
            BtnCopiar.Location = new Point(522, 33);
            BtnCopiar.Name = "BtnCopiar";
            BtnCopiar.Size = new Size(56, 23);
            BtnCopiar.TabIndex = 1;
            BtnCopiar.Text = "Copiar";
            BtnCopiar.UseVisualStyleBackColor = true;
            BtnCopiar.Click += BtnCopiar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 371);
            Controls.Add(Tab);
            Controls.Add(PnlRodape);
            Controls.Add(PnlTitulo);
            KeyPreview = true;
            MaximizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WN Configurador v1.0";
            PnlTitulo.ResumeLayout(false);
            PnlTitulo.PerformLayout();
            PnlRodape.ResumeLayout(false);
            PnlRodape.PerformLayout();
            Tab.ResumeLayout(false);
            TabPrincipal.ResumeLayout(false);
            TabPrincipal.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlTitulo;
        private Panel PnlRodape;
        private TabControl Tab;
        private TabPage TabPrincipal;
        private TextBox TxtChave;
        private Label label1;
        private TextBox TxtStringConexao;
        private Label label2;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox TxtBdBuild;
        private TextBox TxtBdVersaoMenor;
        private TextBox TxtBdVersao;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox TxtEmailHost;
        private Label label8;
        private TextBox TxtEmailUserName;
        private Label label7;
        private TextBox TxtEmailPorta;
        private Label label9;
        private TextBox TxtEmailPassword;
        private Button BtnExibirSenha;
        private CheckBox CkbEmailSSL;
        private Button BtnGerarChave;
        private Label LblTitulo;
        private Button BtnSalvar;
        private Button BtnCarregarArquivo;
        private Button BtnCancelar;
        private OpenFileDialog openFileDlg;
        private SaveFileDialog saveFileDlg;
        private Label LblMensagem;
        private Button BtnCopiar;
    }
}
