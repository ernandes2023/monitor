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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void CarregDadosGrm()
        {
            // Sua consulta SQL
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

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btn_inserir_usuario_Click(object sender, EventArgs e)
        {

        }
    }
}
