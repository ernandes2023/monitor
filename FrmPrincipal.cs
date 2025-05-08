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
            UpdateDgvUser();
            CarregLancamentos();
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
        
        private void ClearTextbox()
        {
            txt_nome_usuario.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_senha.Text = string.Empty;
            txt_conf_senha.Text = string.Empty;
            txt_nome_usuario.BackColor = ColorTranslator.FromHtml(default);
            txt_email.BackColor = ColorTranslator.FromHtml(default);
            txt_senha.BackColor = ColorTranslator.FromHtml(default);
            txt_conf_senha.BackColor = ColorTranslator.FromHtml(default);
            CheckAdm.Checked = false;
        }

        private void CarregLancamentos()
        {
            string query = "select nome, categoria, tipo, fornecedor, recorrente, dia_vencimento, observacoes from lancamentos;";

            DataTable tabela = new DataTable(); // Cria o DataTable apenas uma vez

            using (MySqlConnection connection = new MySqlConnection(Program.conexaoBD))
            {
                connection.Open();

                using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query, connection))
                {
                    adaptador.Fill(tabela); // Preenche o DataTable com os dados do banco

                    // Renomear as colunas conforme necessário
                    //tabela.Columns["id_lancamentos"].ColumnName = "Id:";
                    tabela.Columns["nome"].ColumnName = "Lançamento:";
                    tabela.Columns["categoria"].ColumnName = "Categoria:";
                    tabela.Columns["tipo"].ColumnName = "Entrada ou Saída";
                    tabela.Columns["fornecedor"].ColumnName = "Fornecedor";
                    tabela.Columns["recorrente"].ColumnName = "Recorrente:";
                    tabela.Columns["dia_vencimento"].ColumnName = "Data Vencimento:";
                    tabela.Columns["observacoes"].ColumnName = "Observações:";
                    //tabela.Columns["ativo"].ColumnName = "Ativo:";
                }

                DgvLancamentos.DataSource = tabela; // Atribui ao DataGridView depois de renomear
            }
        }

        private void UpdateDgvUser()
        {
            // Sua consulta SQL
            //string query = "SELECT * FROM usuario where is_activated = 1;";
            string query = "SELECT id_user, name_user, email  FROM users";

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

                    // Renomear as colunas conforme necessário
                    tabela.Columns["id_user"].ColumnName = "ID";
                    tabela.Columns["name_user"].ColumnName = "NOME";
                    tabela.Columns["email"].ColumnName = "EMAIL";
                }

                // Atribuir os dados ao DataGridView
                dgvUser.DataSource = tabela;

                // Formata as colunas do DataGridView para o tanho auto ajustavel
                dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }


        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                if (conectar.State != ConnectionState.Open)
                {
                    conectar.Open();
                }
                
                try
                {
                    // Define as queries SQL para verificar o email.
                    string checkEmailQuery = "SELECT COUNT(*) FROM users WHERE email = @Email";

                    // Cria comandos MySQL separados para cada query
                    MySqlCommand checkLoginCmd = new MySqlCommand(checkEmailQuery, conectar);

                    // Adiciona os valores dos parâmetros @Email
                    checkLoginCmd.Parameters.AddWithValue("@Email", txt_email.Text);

                    // Executa as queries e converte o resultado para inteiros
                    int loginExists = Convert.ToInt32(checkLoginCmd.ExecuteScalar());

                    if (loginExists > 0)
                    {
                        MessageBox.Show("Email já cadastrado! \n Por Favor verifique se o email está correto.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                    // int UserId = UserSession.User_id; // Varialvel irá armazenar o id do usuario logado no sistema.
                    int UserId = 5;

                    // Cria um novo comando MySqlCommand para inserir os dados na tabela usuario
                    MySqlCommand register = new MySqlCommand
                        ("INSERT INTO users (name_user, email, password, is_admin, created_by, updated_by)" +
                        "VALUES" +
                        "(@name_user, @email, @password, @is_admin, @created_by, @updated_by);", conectar);

                    // Adiciona parâmetros ao comando
                    register.Parameters.AddWithValue("@name_user", txt_nome_usuario.Text);
                    register.Parameters.AddWithValue("@email", txt_email.Text);
                    register.Parameters.AddWithValue("@password", txt_senha.Text);
                    register.Parameters.AddWithValue("@is_admin", CheckAdm.Checked ? 1 : 0);
                    register.Parameters.AddWithValue("@created_by", UserId);
                    register.Parameters.AddWithValue("@updated_by", UserId);

                    // Executa o comando de inserção
                    register.ExecuteNonQuery();

                    // Exibe uma mensagem de sucesso
                    MessageBox.Show("Dados cadastrado com sucesso!",
                        "Sucesso", MessageBoxButtons.OK);

                    UpdateDgvUser();
                    ClearTextbox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro não foi possível salvar as informações: " + ex.Message);
                }
                finally
                {
                    if (conectar.State != ConnectionState.Closed)
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
            ClearTextbox();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_categoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            // Verifica se todos os campos obrigatórios estão preenchidos
            if (txt_categoria.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox9.Text == "")
            {
                MessageBox.Show("Todos os campos precisam ser preenchidos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_categoria.Select(); // Coloca o foco no campo de nome caso esteja vazio
            }
           
            else
            {
                // Cria uma nova conexão MySqlConnection utilizando a string de conexão definida em Program.conexaoBD
                MySqlConnection conectar = new MySqlConnection(Program.conexaoBD);

                // Abre a conexão com o banco de dados
                conectar.Open();
                try
                {

                    string query = "INSERT INTO lancamentos " +
                         "(nome, categoria, tipo, fornecedor, recorrente, dia_vencimento, observacoes, ativo) " +
                         "VALUES (@nome, @categoria, @tipo, @fornecedor, @recorrente, @dia_vencimento, @observacoes, @ativo);";

                    MySqlCommand cadastrar = new MySqlCommand(query, conectar);

                    // Nome do lançamento (ex: Água, Energia)
                    cadastrar.Parameters.AddWithValue("@nome", txt_categoria.Text);

                    // Categoria geral (ex: Moradia, Saúde)
                    cadastrar.Parameters.AddWithValue("@categoria", textBox6.Text);

                    // Tipo do lançamento (Receita ou Despesa)
                    string tipo = checkBox1.Checked ? "Receita" :
                                  checkBox2.Checked ? "Despesa" : "Despesa"; // padrão se nenhum marcado
                    cadastrar.Parameters.AddWithValue("@tipo", tipo);

                    // Nome do fornecedor (opcional)
                    cadastrar.Parameters.AddWithValue("@fornecedor", textBox7.Text);

                    // Se é recorrente (fixa todo mês)
                    cadastrar.Parameters.AddWithValue("@recorrente", checkBox4.Checked);

                    // Dia do vencimento (ex: 10)
                    cadastrar.Parameters.AddWithValue("@dia_vencimento", Convert.ToInt32(textBox9.Text));

                    // Observações adicionais
                    cadastrar.Parameters.AddWithValue("@observacoes", textBox8.Text); // se houver

                    // Se o lançamento está ativo
                    cadastrar.Parameters.AddWithValue("@ativo", checkBox5.Checked);

                    // Executa o comando no banco
                    cadastrar.ExecuteNonQuery();


                    // Exibe uma mensagem de sucesso
                    MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK);

                    // Limpa campos de texto
                    txt_categoria.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox9.Text = "";
                    textBox8.Text = "";

                    // Desmarca os checkboxes
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                    checkBox5.Checked = false;

                    // (Opcional) Coloca o cursor no primeiro campo
                    txt_categoria.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro não foi possivel Salvar informações: " + ex.Message);
                }
                finally
                {
                    conectar.Close();
                }

                
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
