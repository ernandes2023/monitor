using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using Mysqlx.Prepare;
using Org.BouncyCastle.Utilities.Collections;

namespace MonitorFinanceiro
{
    public partial class FrmPrincipal : Form
    {
        private bool senhaVisivel = false;
        int idUser;

        public FrmPrincipal()
        {
            InitializeComponent();
            CarregarLancamentos();
            ClearTextbox();
            Load_FrmPag();
            UpdateDgvUser();
            LimparCampos();

            tabControl1.Visible = false;
            pnlLogin.Visible = false;
            gbxDeletedUsers.Visible = false;
            btnShowPass4.Image = Properties.Resources.olho2;
        }

        private void LimparCampos()
        {
            txt_categoria.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;

            label_id.Text = "";
            txt_categoria.Focus();
        }

        private void DgvLancamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DgvLancamentos.Rows[e.RowIndex];

                label_id.Text = row.Cells["id"].Value.ToString(); // Oculto, mas essencial

                txt_categoria.Text = row.Cells["Lançamento:"].Value.ToString();
                textBox6.Text = row.Cells["Categoria:"].Value.ToString();
                string tipo = row.Cells["Entrada ou Saída"].Value.ToString();
                checkBox1.Checked = tipo == "Receita";
                checkBox2.Checked = tipo == "Despesa";
                textBox7.Text = row.Cells["Fornecedor"].Value.ToString();
                checkBox4.Checked = Convert.ToBoolean(row.Cells["Recorrente:"].Value);
                textBox9.Text = row.Cells["Data Vencimento:"].Value.ToString();
                textBox8.Text = row.Cells["Observações:"].Value.ToString();
            }
        }

        private void AtualizarBotaoVisualizarSenha()
        {
            if (senhaVisivel)
            {
                // Se a senha estiver visível, mostra a imagem de olho fechado
                btnShowPass.Image = Properties.Resources.olho1;
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                // Se a senha estiver oculta, mostra a imagem de olho aberto
                btnShowPass.Image = Properties.Resources.olho2;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            // Alterna a visibilidade da senha
            senhaVisivel = !senhaVisivel;
            AtualizarBotaoVisualizarSenha();
        }

        private void AtualizarBotaoVisualizarSenha2()
        {
            if (senhaVisivel)
            {
                // Se a senha estiver visível, mostra a imagem de olho fechado
                btnShowPass2.Image = Properties.Resources.olho1;
                txtConfPass.UseSystemPasswordChar = false;
            }
            else
            {
                // Se a senha estiver oculta, mostra a imagem de olho aberto
                btnShowPass2.Image = Properties.Resources.olho2;
                txtConfPass.UseSystemPasswordChar = true;
            }
        }

        private void btnShowPass2_Click(object sender, EventArgs e)
        {
            // Alterna a visibilidade da senha
            senhaVisivel = !senhaVisivel;
            AtualizarBotaoVisualizarSenha2();
        }

        private void AtualizarBotaoVisualizarSenha3()
        {
            if (senhaVisivel)
            {
                // Se a senha estiver visível, mostra a imagem de olho fechado
                btnShowPass3.Image = Properties.Resources.olho1;
                txtPassLogin.UseSystemPasswordChar = false;
            }
            else
            {
                // Se a senha estiver oculta, mostra a imagem de olho aberto
                btnShowPass3.Image = Properties.Resources.olho2;
                txtPassLogin.UseSystemPasswordChar = true;
            }
        }

        private void btnShowPass3_Click(object sender, EventArgs e)
        {
            // Alterna a visibilidade da senha
            senhaVisivel = !senhaVisivel;
            AtualizarBotaoVisualizarSenha3();
        }

        private void AtualizarBotaoVisualizarSenha4()
        {
            if (senhaVisivel)
            {
                // Se a senha estiver visível, mostra a imagem de olho fechado
                btnShowPass4.Image = Properties.Resources.olho1;
                txtPass2.UseSystemPasswordChar = false;
            }
            else
            {
                // Se a senha estiver oculta, mostra a imagem de olho aberto
                btnShowPass4.Image = Properties.Resources.olho2;
                txtPass2.UseSystemPasswordChar = true;
            }
        }

        private void btnShowPass4_Click(object sender, EventArgs e)
        {
            // Alterna a visibilidade da senha
            senhaVisivel = !senhaVisivel;
            AtualizarBotaoVisualizarSenha4();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ClearTextbox()
        {
            txt_nome_usuario.Text = string.Empty;
            txt_email.Text = string.Empty;
            txtpass.Text = string.Empty;
            txtConfPass.Text = string.Empty;
            lblPass1.Text = string.Empty;
            lblPass2.Text = string.Empty;
            lblWarning.Text = string.Empty;
            txt_nome_usuario.BackColor = ColorTranslator.FromHtml(default);
            txt_email.BackColor = ColorTranslator.FromHtml(default);
            txtpass.BackColor = ColorTranslator.FromHtml(default);
            txtConfPass.BackColor = ColorTranslator.FromHtml(default);
            CheckAdm.Checked = false;

        }

   

        private void Load_FrmPag()
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

        private void UpdateDgvUser()
        {
            // Sua consulta SQL
            string query = "SELECT id_user, name_user, email  FROM users WHERE is_activated = 1;";
            //string query = "SELECT id_user, name_user, email  FROM users";

            // Criar um DataTable para armazenar os dados
            DataTable tabela = new DataTable();

            // Conectar ao banco
            using (MySqlConnection connection = new MySqlConnection(Program.conexaoBD))
            {
                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

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
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro, não foi possível estabeler conexão com o banco de dados: " + ex.Message);
                }
                finally
                {
                    if (connection.State != ConnectionState.Closed)
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void UpdateDgvUserDisabled()
        {
            // Sua consulta SQL
            string query = "SELECT id_user, name_user, email  FROM users WHERE is_activated = 0;";

            // Criar um DataTable para armazenar os dados
            DataTable tabela = new DataTable();

            // Conectar ao banco
            using (MySqlConnection connection = new MySqlConnection(Program.conexaoBD))
            {
                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

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
                    DgvUserDisabled.DataSource = tabela;

                    // Formata as colunas do DataGridView para o tanho auto ajustavel
                    DgvUserDisabled.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro, não foi possível estabeler conexão com o banco de dados: " + ex.Message);
                }
                finally
                {
                    if (connection.State != ConnectionState.Closed)
                    {
                        connection.Close();
                    }
                }
            }
        }

        public bool CheckSecurePassword(string senha)
        {
            if (senha.Length < 8)
            {
                lblWarning.Text = "A senha deve ter pelo menos 8 caracteres.";
                lblWarning.ForeColor = ColorTranslator.FromHtml("#FF7575");
                //MessageBox.Show("A senha deve ter pelo menos 8 caracteres.");
                return false;
            }

            if (!Regex.IsMatch(senha, @"[A-Z]"))
            {
                lblWarning.Text = "A senha deve conter pelo menos uma letra maiúscula.";
                lblWarning.ForeColor = ColorTranslator.FromHtml("#FF7575");
                //MessageBox.Show("A senha deve conter pelo menos uma letra maiúscula.");
                return false;
            }

            if (!Regex.IsMatch(senha, @"[a-z]"))
            {
                lblWarning.Text = "A senha deve conter pelo menos uma letra minúscula.";
                lblWarning.ForeColor = ColorTranslator.FromHtml("#FF7575");
                //MessageBox.Show("A senha deve conter pelo menos uma letra minúscula.");
                return false;
            }

            if (!Regex.IsMatch(senha, @"[0-9]"))
            {
                lblWarning.Text = "A senha deve conter pelo menos um número.";
                lblWarning.ForeColor = ColorTranslator.FromHtml("#FF7575");
                //MessageBox.Show("A senha deve conter pelo menos um número.");
                return false;
            }

            if (!Regex.IsMatch(senha, @"[!@#$%^&*(),.?"":{}|<>]"))
            {
                lblWarning.Text = "A senha deve conter pelo menos um caractere especial.";
                lblWarning.ForeColor = ColorTranslator.FromHtml("#FF7575");
                //MessageBox.Show("A senha deve conter pelo menos um caractere especial.");
                return false;
            }

            lblWarning.Text = ("Senha segura!");
            lblWarning.ForeColor = ColorTranslator.FromHtml("#3C8123");

            //MessageBox.Show("Senha segura!");
            return true;
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUser_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idUser = Convert.ToInt32(dgvUser.Rows[e.RowIndex].Cells[0].Value);
            txt_nome_usuario.Text = dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_email.Text = dgvUser.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void txt_nome_usuario_TextChanged(object sender, EventArgs e)
        {
            txt_nome_usuario.BackColor = ColorTranslator.FromHtml(default);
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            txt_email.BackColor = ColorTranslator.FromHtml(default);
        }

        private int CalcularForcaSenha(string senha)
        {
            int pontuacao = 0;

            if (senha.Length >= 8)
                pontuacao += 20;
            if (Regex.IsMatch(senha, @"[a-z]"))
                pontuacao += 20;
            if (Regex.IsMatch(senha, @"[A-Z]"))
                pontuacao += 20;
            if (Regex.IsMatch(senha, @"[0-9]"))
                pontuacao += 20;
            if (Regex.IsMatch(senha, @"[\W_]"))
                pontuacao += 20;

            return pontuacao;
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            txtpass.BackColor = ColorTranslator.FromHtml(default);

            string senha = txtpass.Text;
            int forca = CalcularForcaSenha(senha);

            progressBar1.Value = forca;
            progressBar1.Invalidate();  // Força a atualização da barra de progresso

            // Muda cor da barra — você precisa criar uma ProgressBar customizada, pois a padrão não permite mudar cor diretamente.

            if (forca == 0)
            {
                progressBar1.ForeColor = Color.Red;
                lblPass1.Text = "";
                lblWarning.Text = string.Empty;
            }
            else if (forca <= 40)
            {
                progressBar1.ForeColor = Color.Red;
                lblPass1.Text = "Senha fraca";
            }
            else if (forca <= 80)
            {
                progressBar1.ForeColor = Color.Orange;
                lblPass1.Text = "Senha média";
            }
            else
            {
                progressBar1.ForeColor = Color.Green;
                lblPass1.Text = "Senha forte";
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text != "")
            {
                // Chama a função para verificar a segurança da senha
                string senha = txtpass.Text;
                bool senhaSegura = CheckSecurePassword(senha);
            }
            return;
        }

        private void txtConfPass_TextChanged(object sender, EventArgs e)
        {
            txtConfPass.BackColor = ColorTranslator.FromHtml(default);

            string senha = txtConfPass.Text;
            int forca = CalcularForcaSenha(senha);

            progressBar2.Value = forca;
            progressBar2.Invalidate();  // Força a atualização da barra de progresso

            // Muda cor da barra
            if (forca == 0)
            {
                progressBar1.ForeColor = Color.Red;
                lblPass2.Text = "";
                lblWarning.Text = string.Empty;
            }
            else if (forca <= 40)
            {
                progressBar2.ForeColor = Color.Red;
                lblPass2.Text = "Senha fraca";
            }
            else if (forca <= 80)
            {
                progressBar2.ForeColor = Color.Orange;
                lblPass2.Text = "Senha média";
            }
            else
            {
                progressBar2.ForeColor = Color.Green;
                lblPass2.Text = "Senha forte";
            }
        }

        private void txtConfPass_Leave(object sender, EventArgs e)
        {
            if (txtConfPass.Text != string.Empty || txtpass.Text != string.Empty)
            {
                if (txtConfPass.Text != txtpass.Text)
                {
                    lblWarning.Text = "As senhas não coincidem. Por favor, verifique.";
                    lblWarning.ForeColor = ColorTranslator.FromHtml("#FF7575");
                }
                else
                {
                    lblWarning.Text = "Tudo Certo!";
                    lblWarning.ForeColor = ColorTranslator.FromHtml("#3C8123");
                }
            }
        }

        private bool ValidarCamposObrigatorios(Dictionary<Control, string> campos, out string mensagemErro)
        {
            mensagemErro = "";
            foreach (var item in campos)
            {
                var campo = item.Key;
                var nomeCampo = item.Value;

                // Resetar cor do campo
                campo.BackColor = SystemColors.Window;

                // Verificar se está vazio
                if (string.IsNullOrWhiteSpace(campo.Text))
                {
                    mensagemErro += $"• {nomeCampo}\n";
                    campo.BackColor = ColorTranslator.FromHtml("#FEC6C6");
                }
            }

            return string.IsNullOrEmpty(mensagemErro);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var campos = new Dictionary<Control, string>
            {
                { txt_nome_usuario, "Nome" },
                { txt_email, "Email" },
                { txtpass, "Senha" },
                { txtConfPass, "Confirmar Senha" }
            };

            if (!ValidarCamposObrigatorios(campos, out string erros))
            {
                MessageBox.Show("Os seguintes campos são obrigatórios:\n\n" + erros,
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MySqlConnection conn = new MySqlConnection(Program.conexaoBD);

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                try
                {
                    MySqlCommand insertDB = new MySqlCommand
                        ("UPDATE users SET name_user=@name_user, email=@email, password=@password, is_admin=@is_admin, updated_by=@Updated_by WHERE id_user=@IdUser", conn);

                    insertDB.Parameters.Add("@name_user", MySqlDbType.VarChar).Value = txt_nome_usuario.Text;
                    insertDB.Parameters.Add("@email", MySqlDbType.VarChar).Value = txt_email.Text;
                    insertDB.Parameters.Add("@password", MySqlDbType.VarChar).Value = BCrypt.Net.BCrypt.HashPassword(txtpass.Text);
                    insertDB.Parameters.Add("@is_admin", MySqlDbType.VarChar).Value = CheckAdm.Checked ? 1 : 0;
                    insertDB.Parameters.Add("@Updated_by", MySqlDbType.Int32).Value = UserId;
                    insertDB.Parameters.Add("@IdUser", MySqlDbType.Int32).Value = Convert.ToInt32(idUser);

                    // Executa o comando de inserção
                    insertDB.ExecuteNonQuery();

                    // Exibe uma mensagem de sucesso
                    MessageBox.Show("Dados cadastrado com sucesso!",
                        "Sucesso", MessageBoxButtons.OK);

                    UpdateDgvUser();
                    ClearTextbox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao editar as informações: " + ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente excluir este usuário?",
                "Excluir Usuário.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                MySqlConnection conn = new MySqlConnection(Program.conexaoBD);

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                try
                {
                    string valueActive = "0";

                    MySqlCommand insertDB = new MySqlCommand
                        ("UPDATE users SET is_activated=@IsActivated WHERE id_user=@IdUser", conn);

                    insertDB.Parameters.Add("@IsActivated", MySqlDbType.Int32).Value = valueActive;
                    insertDB.Parameters.Add("@IdUser", MySqlDbType.Int32).Value = Convert.ToInt32(idUser);

                    // Executa o comando de inserção
                    insertDB.ExecuteNonQuery();

                    // Exibe uma mensagem de sucesso
                    MessageBox.Show("Dados excluidos com sucesso!",
                        "Sucesso", MessageBoxButtons.OK);

                    UpdateDgvUser();
                    ClearTextbox();
                    UpdateDgvUserDisabled();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao apagar as informações: " + ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                }
            }
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

            if (string.IsNullOrWhiteSpace(txtpass.Text))
            {
                errorMessage += "Senha: \n";
                txtpass.BackColor = ColorTranslator.FromHtml("#FEC6C6");
            }

            if (string.IsNullOrWhiteSpace(txtConfPass.Text))
            {
                errorMessage += "Conf. Senha: \n";
                txtConfPass.BackColor = ColorTranslator.FromHtml("#FEC6C6");
            }

            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show($"Os seguintes campos são obrigatórios:\n\n{errorMessage}",
                    "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Cria uma nova conexão MySqlConnection utilizando a string de conexão definida em Program.conexaoBD
                MySqlConnection conn = new MySqlConnection(Program.conexaoBD);

                // Abre a conexão com o banco de dados
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                try
                {
                    // Define as queries SQL para verificar o email.
                    string checkEmailQuery = "SELECT COUNT(*) FROM users WHERE email = @Email";

                    // Cria comandos MySQL separados para cada query
                    MySqlCommand checkLoginCmd = new MySqlCommand(checkEmailQuery, conn);

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
                    if (txtpass.Text != txtConfPass.Text)
                    {
                        txtConfPass.BackColor = ColorTranslator.FromHtml("#FEC6C6");
                        MessageBox.Show("As Senhas digitadas São diferentes! \n Por Favor digite a senha novamente.",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtConfPass.Select();
                        return;
                    }

                    // int UserId = UserSession.User_id; // Varialvel irá armazenar o id do usuario logado no sistema.


                    // Cria um novo comando MySqlCommand para inserir os dados na tabela usuario
                    MySqlCommand insertDB = new MySqlCommand
                        ("INSERT INTO users (name_user, email, password, is_admin, created_by, updated_by)" +
                        "VALUES" +
                        "(@name_user, @email, @password, @is_admin, @created_by, @updated_by);", conn);

                    insertDB.Parameters.Add("@name_user", MySqlDbType.VarChar).Value = txt_nome_usuario.Text;
                    insertDB.Parameters.Add("@email", MySqlDbType.VarChar).Value = txt_email.Text;
                    insertDB.Parameters.Add("@password", MySqlDbType.VarChar).Value = BCrypt.Net.BCrypt.HashPassword(txtpass.Text);
                    insertDB.Parameters.Add("@is_admin", MySqlDbType.VarChar).Value = CheckAdm.Checked ? 1 : 0;
                    insertDB.Parameters.Add("@Created_by", MySqlDbType.Int32).Value = UserId;
                    insertDB.Parameters.Add("@Updated_by", MySqlDbType.Int32).Value = UserId;

                    // Executa o comando de inserção
                    insertDB.ExecuteNonQuery();

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
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
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
            LimparCampos();
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

                    CarregarLancamentos();// atualiza as informações para a dgv
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
                // Verifica se o ID está preenchido (ou seja, se foi selecionado um item)
                if (string.IsNullOrWhiteSpace(label_id.Text))
                {
                    MessageBox.Show("Selecione um item para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verifica se todos os campos obrigatórios estão preenchidos
                if (txt_categoria.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox9.Text == "")
                {
                    MessageBox.Show("Todos os campos precisam ser preenchidos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_categoria.Select();
                    return;
                }

                MySqlConnection conectar = new MySqlConnection(Program.conexaoBD);
                conectar.Open();

                try
                {
                    string query = "UPDATE lancamentos SET " +
                                   "nome = @nome, " +
                                   "categoria = @categoria, " +
                                   "tipo = @tipo, " +
                                   "fornecedor = @fornecedor, " +
                                   "recorrente = @recorrente, " +
                                   "dia_vencimento = @dia_vencimento, " +
                                   "observacoes = @observacoes, " +
                                   "ativo = @ativo " +
                                   "WHERE id_lancamentos = @id;";

                    MySqlCommand editar = new MySqlCommand(query, conectar);

                    editar.Parameters.AddWithValue("@nome", txt_categoria.Text);
                    editar.Parameters.AddWithValue("@categoria", textBox6.Text);

                    string tipo = checkBox1.Checked ? "Receita" :
                                  checkBox2.Checked ? "Despesa" : "Despesa";
                    editar.Parameters.AddWithValue("@tipo", tipo);

                    editar.Parameters.AddWithValue("@fornecedor", textBox7.Text);
                    editar.Parameters.AddWithValue("@recorrente", checkBox4.Checked);
                    editar.Parameters.AddWithValue("@dia_vencimento", Convert.ToInt32(textBox9.Text));
                    editar.Parameters.AddWithValue("@observacoes", textBox8.Text);
                    editar.Parameters.AddWithValue("@ativo", checkBox5.Checked);

                    editar.Parameters.AddWithValue("@id", Convert.ToInt32(label_id.Text));

                    editar.ExecuteNonQuery();

                    MessageBox.Show("Informações atualizadas com sucesso!", "Sucesso", MessageBoxButtons.OK);

                    // Limpar campos e ID
                    txt_categoria.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox9.Text = "";
                    textBox8.Text = "";
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                    checkBox5.Checked = false;
                    label_id.Text = "";

                    // Atualiza o DataGridView
                    CarregarLancamentos(); // Crie esse método se ainda não tiver
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar as informações: " + ex.Message);
                }
                finally
                {
                    conectar.Close();
                }
            
        }

      
        private void CarregarLancamentos()
        {
            string query = "SELECT id_lancamentos, nome, categoria, tipo, fornecedor, recorrente, dia_vencimento, observacoes FROM lancamentos;";


            DataTable tabela = new DataTable(); // Cria o DataTable apenas uma vez

            using (MySqlConnection connection = new MySqlConnection(Program.conexaoBD))
            {
                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

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
                    DgvLancamentos.Columns["id_lancamentos"].Visible = false; // não mostra o ID na dgv
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro, não foi possível estabeler conexão com o banco de dados: " + ex.Message);

                }
                finally
                {
                    if (connection.State != ConnectionState.Closed)
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        int UserId; // Variavel para armazenar o id do usuario logado no sistema.

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtEmailLogin.Text.Trim();
            string senhaDigitada = txtPassLogin.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senhaDigitada))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(Program.conexaoBD))
                {
                    conn.Open();

                    string query = "SELECT id_user, name_user, password FROM users WHERE email = @Email";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", usuario);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                UserId = reader.GetInt32("id_user");
                                string nameUser = reader.GetString("name_user");
                                string hashSalvo = reader.GetString("password");

                                bool senhaCorreta = BCrypt.Net.BCrypt.Verify(senhaDigitada, hashSalvo);

                                if (senhaCorreta)
                                {
                                    MessageBox.Show("Login Bem-sucedido! \n Seja bem vindo " + UserId + " - " + nameUser + ".", "Sucesso",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Exemplo: abrir tela principal
                                    //new user_regist().Show();
                                    //this.Hide();
                                    tabControl1.Visible = true;
                                    LblNameUser.Text = $"Olá seja bem vindo {nameUser}.";
                                }
                                else
                                {
                                    MessageBox.Show("Senha incorreta.", "Erro",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Usuário não encontrado.", "Erro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RestoreUser_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Está operação pode somente ser execultada por um usuário Administrador. \n" +
                "Deseja Continhar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.No)
            {
                return;
            }
            else
            {
                pnlLogin.Visible = true;
            }
        }

        private void DgvUserDisabled_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvUserDisabled_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int     txtIdUser = Convert.ToInt32(DgvUserDisabled.Rows[e.RowIndex].Cells[0].Value);
            string  txtNameUser = DgvUserDisabled.Rows[e.RowIndex].Cells[1].Value.ToString();
            string  txtEmail = DgvUserDisabled.Rows[e.RowIndex].Cells[2].Value.ToString();

            DialogResult result = MessageBox.Show($"Deseja realmente regatar este usuário?" +
                $"\nId: {txtIdUser} \nNome: {txtNameUser} \nEmail:{txtEmail}",
                "Restaurar Usuário.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                MySqlConnection conn = new MySqlConnection(Program.conexaoBD);

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                try
                {
                    string valueActive = "1";

                    MySqlCommand insertDB = new MySqlCommand
                        ("UPDATE users SET is_activated=@IsActivated WHERE id_user=@IdUser", conn);

                    insertDB.Parameters.Add("@IsActivated", MySqlDbType.Int32).Value = valueActive;
                    insertDB.Parameters.Add("@IdUser", MySqlDbType.Int32).Value = Convert.ToInt32(txtIdUser);

                    // Executa o comando de inserção
                    insertDB.ExecuteNonQuery();

                    // Exibe uma mensagem de sucesso
                    MessageBox.Show("Usuário resgatado com sucesso!",
                        "Sucesso", MessageBoxButtons.OK);

                    UpdateDgvUser();
                    ClearTextbox();
                    UpdateDgvUserDisabled();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao editar as informações: " + ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void DgvLancamentos_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Evita clicar no cabeçalho
            {
                // Pega a linha selecionada
                DataGridViewRow linha = DgvLancamentos.Rows[e.RowIndex];

                // Pega o valor do ID da linha (ajuste o nome da coluna conforme seu DB)
                label_id.Text = linha.Cells["id_lancamentos"].Value.ToString();

                // Pega os valores e joga nos campos para editar
                txt_categoria.Text = linha.Cells["Lançamento:"].Value.ToString();
                textBox6.Text = linha.Cells["Categoria:"].Value.ToString();
                string tipo = linha.Cells["Entrada ou Saída"].Value.ToString();

                checkBox1.Checked = (tipo == "Receita");
                checkBox2.Checked = (tipo == "Despesa");

                textBox7.Text = linha.Cells["Fornecedor"].Value.ToString();
                checkBox4.Checked = Convert.ToBoolean(linha.Cells["Recorrente:"].Value);
                textBox9.Text = linha.Cells["Data Vencimento:"].Value.ToString();
                textBox8.Text = linha.Cells["Observações:"].Value.ToString();

                // Aqui, se tiver um checkbox ativo, ajuste conforme necessário
                // Exemplo:
                // checkBox5.Checked = Convert.ToBoolean(linha.Cells["Ativo:"].Value);
            }
        }

        private void btnLogin2_Click(object sender, EventArgs e)
        {
            string usuario = txtUser2.Text.Trim();
            string senhaDigitada = txtPass2.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senhaDigitada))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(Program.conexaoBD))
                {
                    conn.Open();

                    string query = "SELECT id_user, name_user, password FROM users WHERE email = @Email";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", usuario);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                UserId = reader.GetInt32("id_user");
                                string nameUser = reader.GetString("name_user");
                                string hashSalvo = reader.GetString("password");

                                bool senhaCorreta = BCrypt.Net.BCrypt.Verify(senhaDigitada, hashSalvo);

                                if (senhaCorreta)
                                {
                                    UpdateDgvUserDisabled();
                                    gbxDeletedUsers.Visible = true;
                                }
                                else
                                {
                                    MessageBox.Show("Usuário ou Senha estão incorretos. \n Por favor, tente novamente.",
                                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                                txtUser2.Text = string.Empty;
                                txtPass2.Text = string.Empty;
                                pnlLogin.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("Usuário não encontrado.", "Erro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            gbxDeletedUsers.Visible = false;
        }
    }
}
