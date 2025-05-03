using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MonitorFinanceiro
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            CarregDadosGrm();
        }

        private void FormaPAg()
        {
            var values = Enum.GetValues(typeof(AppEnums1.tipoPag)).Cast<AppEnums1.tipoPag>();

            foreach (var value in values)
            {
                string description = EnumHelper.GetDescription(value);
                cbxFrmPag.Items.Add(new { Text = description, Value = value });
            }
            cbxFrmPag.DisplayMember = "Text";
            cbxFrmPag.ValueMember = "Value";
            cbxFrmPag.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormaPAg();
        }
        private void CarregDadosGrm()
        {
            // Sua consulta SQL
            //string query = "SELECT * FROM usuario where is_activated = 1;";
            string query = "SELECT * FROM usuario";

            // Criar um DataTable para armazenar os dados
            DataTable tabela = new DataTable();

            // Conectar ao banco
            using (MySqlConnection connection = new MySqlConnection(Program.conexaoBD))
            {
                // Abrir conexão
                connection.Open();

                // Adaptador para preencher o DataTable com os resultados da query
                using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query, connection))
                {
                    adaptador.Fill(tabela); // Preenche a tabela com os dados do banco
                }

                // Atribuir os dados ao DataGridView
                Dgv_usuario.DataSource = tabela;
            }
        }


        private void Dgv_usuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_nome_usuario_TextChanged(object sender, EventArgs e)
        {
            txt_nome_usuario.BackColor = ColorTranslator.FromHtml(default);
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            txt_email.BackColor = ColorTranslator.FromHtml(default);
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {
            txt_senha.BackColor = ColorTranslator.FromHtml(default);
        }

        private void txt_conf_senha_TextChanged(object sender, EventArgs e)
        {
            txt_conf_senha.BackColor= ColorTranslator.FromHtml(default);
        }

        private void txt_conf_senha_Leave(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(txt_nome_usuario.Text))
            {
                errorMessage += "Nome: \n";
                txt_nome_usuario.BackColor = ColorTranslator.FromHtml("#FEC6C6");
            }
            
            if (string.IsNullOrWhiteSpace(txt_email.Text))
            {
                errorMessage += "Email: \n";
                txt_email.BackColor = ColorTranslator.FromHtml("#FEC6C6");
            }

            if(string.IsNullOrWhiteSpace (txt_senha.Text))
            {
                errorMessage += "Senha: \n";
                txt_senha.BackColor = ColorTranslator.FromHtml("#FEC6C6");
            }

            if (string.IsNullOrWhiteSpace(txt_conf_senha.Text)) 
            {
                errorMessage += "Conf. Senha: \n";
                txt_conf_senha.BackColor = ColorTranslator.FromHtml("#FEC6C6");
            }


            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show($"Os seguintes campos são obrigatórios:\n\n{errorMessage}",
                    "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Cria uma nova conexão MySqlConnection utilizando a string de conexão definida em Program.conexaoBD
                MySqlConnection conectar = new MySqlConnection(Program.conexaoBD);

                // Abre a conexão com o banco de dados
                conectar.Open();
                try
                {
                    // Define as queries SQL para verificar o email.
                    string checkEmailQuery = "SELECT COUNT(*) FROM usuario WHERE email = @Email";

                    // Cria comandos MySQL separados para cada query
                    MySqlCommand checkLoginCmd = new MySqlCommand(checkEmailQuery, conectar);

                    // Adiciona os valores dos parâmetros @Email
                    checkLoginCmd.Parameters.AddWithValue("@Email", txt_email.Text);

                    // Executa as queries e converte o resultado para inteiros
                    int loginExists = Convert.ToInt32(checkLoginCmd.ExecuteScalar());

                    if (loginExists > 0)
                    {
                        MessageBox.Show("Email já cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Verifica se o campo senha e cofirmação da senha são diferentes
                    if (txt_senha.Text != txt_conf_senha.Text)
                    {
                        txt_conf_senha.BackColor = ColorTranslator.FromHtml("#FEC6C6");
                        MessageBox.Show("As Senhas digitadas São diferentes! \n Por Favor digite a senha novamente.",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_conf_senha.Select();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro não foi possível salvar as informações: " + ex.Message);
                }
                finally
                {
                    if (conectar != null)
                    {
                        conectar.Close();
                    }
                }
            }
        }
        private void cbxFrmPag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome_usuario.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_senha.Text = string.Empty;
            txt_conf_senha.Text = string.Empty;
            txt_nome_usuario.BackColor = ColorTranslator.FromHtml(default);
            txt_email.BackColor = ColorTranslator.FromHtml(default);
            txt_senha.BackColor = ColorTranslator.FromHtml(default);
            txt_conf_senha.BackColor = ColorTranslator.FromHtml(default);

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
