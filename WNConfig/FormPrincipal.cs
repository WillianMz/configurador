using System.Security.Cryptography;
using System.Text.Json;

namespace WNConfig
{
    public partial class FormPrincipal : Form
    {
        private string arquivo = string.Empty;
        private string arqJson = string.Empty;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void BtnGerarChave_Click(object sender, EventArgs e)
        {
            TxtChave.Text = GenerateRandomKeyString(32);
        }

        private static string GenerateRandomKeyString(int size)
        {
            byte[] key = new byte[size];
            RandomNumberGenerator.Fill(key);
            return Convert.ToBase64String(key);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string key = TxtChave.Text;
            if (key.Length == 0)
            {
                if (TxtChave.Text == string.Empty)
                    TxtChave.BackColor = Color.Yellow;

                MessageBox.Show("Informe a chave que será utilizada para criptografar os dados!");
            }
            else
            {
                Configuracao configuracao = new()
                {
                    StringDeConexaoBD = Criptografia.Criptografar(TxtStringConexao.Text, key),
                    DbServerVersionMaior = Convert.ToInt32(TxtBdVersao.Text),
                    DbServerVersionMenor = Convert.ToInt32(TxtBdVersaoMenor.Text),
                    DbServerVersionBuild = Convert.ToInt32(TxtBdBuild.Text),
                    EmailHost = Criptografia.Criptografar(TxtEmailHost.Text, key),
                    EmailPort = Criptografia.Criptografar(Convert.ToString(TxtEmailPorta.Text), key),
                    EmailUseSsl = CkbEmailSSL.Checked,
                    EmailUserName = Criptografia.Criptografar(TxtEmailUserName.Text, key),
                    EmailPassword = Criptografia.Criptografar(TxtEmailPassword.Text, key)
                };

                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(configuracao, options);

                saveFileDlg.FileName = "config.json";
                saveFileDlg.InitialDirectory = "c:\\";
                saveFileDlg.Filter = "Arquivo (*.json) | *.json";
                saveFileDlg.FilterIndex = 2;
                saveFileDlg.RestoreDirectory = true;

                if (saveFileDlg.ShowDialog() == DialogResult.OK)
                {
                    arqJson = saveFileDlg.FileName;
                }

                File.WriteAllText(arqJson, jsonString);
                MessageBox.Show("Arquivo JSON salvo com sucesso!");
            }
        }

        private void BtnCarregarArquivo_Click(object sender, EventArgs e)
        {
            openFileDlg.FileName = string.Empty;
            openFileDlg.InitialDirectory = "c:\\";
            openFileDlg.Filter = "Arquivo json (*.json) | *.json;";
            openFileDlg.FilterIndex = 2;
            openFileDlg.RestoreDirectory = true;

            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                arquivo = openFileDlg.FileName;
            }

            string key = TxtChave.Text;
            if (key.Length == 0)
            {
                if (TxtChave.Text == string.Empty)
                    TxtChave.BackColor = Color.Yellow;

                MessageBox.Show("Informe a chave que será utilizada para descriptografar os dados!");
            }
            else
            {
                try
                {
                    string jsonString = File.ReadAllText(arquivo);
                    Configuracao config = JsonSerializer.Deserialize<Configuracao>(jsonString)!;

                    TxtStringConexao.Text = Criptografia.Descriptografar(config.StringDeConexaoBD, key);
                    TxtBdVersao.Text = Convert.ToString(config.DbServerVersionMaior);
                    TxtBdVersaoMenor.Text = Convert.ToString(config.DbServerVersionMenor);
                    TxtBdBuild.Text = Convert.ToString(config.DbServerVersionBuild);
                    TxtEmailHost.Text = Criptografia.Descriptografar(config.EmailHost, key);
                    TxtEmailPorta.Text = Criptografia.Descriptografar(config.EmailPort, key);
                    CkbEmailSSL.Checked = config.EmailUseSsl;
                    TxtEmailUserName.Text = Criptografia.Descriptografar(config.EmailUserName, key);
                    TxtEmailPassword.Text = Criptografia.Descriptografar(config.EmailPassword, key);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao descriptografar arquivo.\n" +
                        $"Sugestão: Verifique se a chave informada é a mesma utilizada para criptografar o arquivo!" +
                        $"\n {ex.Message}");
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnExibirSenha_Click(object sender, EventArgs e)
        {
            if (TxtEmailPassword.PasswordChar == '*')
                TxtEmailPassword.PasswordChar = '\0';
            else
                TxtEmailPassword.PasswordChar = '*';

        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            if(TxtChave.Text != string.Empty)
            {
                Clipboard.SetText(TxtChave.Text);
                MessageBox.Show("Chave copiada para área de transferência");
            }
        }
    }
}
