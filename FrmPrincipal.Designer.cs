
using System.Drawing;
using System.Windows.Forms;

namespace MonitorFinanceiro
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_nome_usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.btnShowPass2 = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnShowPass = new System.Windows.Forms.Button();
            this.lblPass2 = new System.Windows.Forms.Label();
            this.CheckAdm = new System.Windows.Forms.CheckBox();
            this.lblPass1 = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.txtConfPass = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RestoreUser = new System.Windows.Forms.Button();
            this.gbxDeletedUsers = new System.Windows.Forms.GroupBox();
            this.btnExit2 = new System.Windows.Forms.Button();
            this.DgvUserDisabled = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnShowPass4 = new System.Windows.Forms.Button();
            this.btnLogin2 = new System.Windows.Forms.Button();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.txtUser2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DgvLancamentos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.label_id = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.BtnApagar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_categoria = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.DgvMovimentacoes = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbxFrmPag = new System.Windows.Forms.ComboBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_sair = new System.Windows.Forms.Button();
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.btnShowPass3 = new System.Windows.Forms.Button();
            this.txtPassLogin = new System.Windows.Forms.TextBox();
            this.txtEmailLogin = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.LblNameUser = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timerRelogio = new System.Windows.Forms.Timer(this.components);
            this.progressBar2 = new ProgressBarCustomizada();
            this.progressBar1 = new ProgressBarCustomizada();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbxDeletedUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUserDisabled)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.pnlLogin.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLancamentos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMovimentacoes)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.PanelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_nome_usuario
            // 
            this.txt_nome_usuario.Location = new System.Drawing.Point(8, 39);
            this.txt_nome_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nome_usuario.Name = "txt_nome_usuario";
            this.txt_nome_usuario.Size = new System.Drawing.Size(411, 22);
            this.txt_nome_usuario.TabIndex = 0;
            this.txt_nome_usuario.TextChanged += new System.EventHandler(this.txt_nome_usuario_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 1;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(8, 19);
            this.Nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(46, 16);
            this.Nome.TabIndex = 2;
            this.Nome.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "E-mail:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(8, 85);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(411, 22);
            this.txt_email.TabIndex = 3;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Senha:";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(8, 131);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(174, 22);
            this.txtpass.TabIndex = 6;
            this.txtpass.UseSystemPasswordChar = true;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(178, 193);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 25);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Cadastrar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnUnlock);
            this.groupBox1.Controls.Add(this.btnShowPass2);
            this.groupBox1.Controls.Add(this.lblWarning);
            this.groupBox1.Controls.Add(this.btnShowPass);
            this.groupBox1.Controls.Add(this.lblPass2);
            this.groupBox1.Controls.Add(this.progressBar2);
            this.groupBox1.Controls.Add(this.CheckAdm);
            this.groupBox1.Controls.Add(this.lblPass1);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.btn_limpar);
            this.groupBox1.Controls.Add(this.txtConfPass);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_edit);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtpass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.Nome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_nome_usuario);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(427, 280);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de usuário";
            // 
            // btnUnlock
            // 
            this.btnUnlock.Location = new System.Drawing.Point(162, 243);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(102, 25);
            this.btnUnlock.TabIndex = 16;
            this.btnUnlock.Text = "Desbloquear";
            this.btnUnlock.UseVisualStyleBackColor = true;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // btnShowPass2
            // 
            this.btnShowPass2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnShowPass2.Image = global::MonitorFinanceiro.Properties.Resources.olho2;
            this.btnShowPass2.Location = new System.Drawing.Point(397, 131);
            this.btnShowPass2.Name = "btnShowPass2";
            this.btnShowPass2.Size = new System.Drawing.Size(22, 22);
            this.btnShowPass2.TabIndex = 14;
            this.btnShowPass2.UseVisualStyleBackColor = true;
            this.btnShowPass2.Click += new System.EventHandler(this.btnShowPass2_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblWarning.Font = new System.Drawing.Font("Arial", 11.75F);
            this.lblWarning.Location = new System.Drawing.Point(7, 221);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(413, 50);
            this.lblWarning.TabIndex = 14;
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnShowPass
            // 
            this.btnShowPass.BackColor = System.Drawing.Color.Transparent;
            this.btnShowPass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnShowPass.Image = global::MonitorFinanceiro.Properties.Resources.olho2;
            this.btnShowPass.Location = new System.Drawing.Point(188, 131);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(22, 22);
            this.btnShowPass.TabIndex = 13;
            this.btnShowPass.UseVisualStyleBackColor = false;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // lblPass2
            // 
            this.lblPass2.BackColor = System.Drawing.Color.Transparent;
            this.lblPass2.Location = new System.Drawing.Point(217, 173);
            this.lblPass2.Name = "lblPass2";
            this.lblPass2.Size = new System.Drawing.Size(202, 16);
            this.lblPass2.TabIndex = 15;
            // 
            // CheckAdm
            // 
            this.CheckAdm.AutoSize = true;
            this.CheckAdm.Location = new System.Drawing.Point(317, 64);
            this.CheckAdm.Name = "CheckAdm";
            this.CheckAdm.Size = new System.Drawing.Size(104, 20);
            this.CheckAdm.TabIndex = 15;
            this.CheckAdm.Text = "Adminstrador";
            this.CheckAdm.UseVisualStyleBackColor = true;
            // 
            // lblPass1
            // 
            this.lblPass1.BackColor = System.Drawing.Color.Transparent;
            this.lblPass1.Location = new System.Drawing.Point(8, 173);
            this.lblPass1.Name = "lblPass1";
            this.lblPass1.Size = new System.Drawing.Size(202, 16);
            this.lblPass1.TabIndex = 14;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(96, 193);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 25);
            this.btn_limpar.TabIndex = 14;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // txtConfPass
            // 
            this.txtConfPass.Location = new System.Drawing.Point(216, 131);
            this.txtConfPass.Name = "txtConfPass";
            this.txtConfPass.Size = new System.Drawing.Size(175, 22);
            this.txtConfPass.TabIndex = 13;
            this.txtConfPass.UseSystemPasswordChar = true;
            this.txtConfPass.TextChanged += new System.EventHandler(this.txtConfPass_TextChanged);
            this.txtConfPass.Leave += new System.EventHandler(this.txtConfPass_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(215, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 16);
            this.label15.TabIndex = 12;
            this.label15.Text = "Confir. Senha:";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(344, 193);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 25);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Apagar";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(261, 193);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 25);
            this.btn_edit.TabIndex = 10;
            this.btn_edit.Text = "Editar";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(988, 589);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RestoreUser);
            this.tabPage1.Controls.Add(this.gbxDeletedUsers);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.pnlLogin);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(980, 560);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Usuário";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // RestoreUser
            // 
            this.RestoreUser.Location = new System.Drawing.Point(442, 19);
            this.RestoreUser.Name = "RestoreUser";
            this.RestoreUser.Size = new System.Drawing.Size(141, 33);
            this.RestoreUser.TabIndex = 13;
            this.RestoreUser.Text = "Resgatar Usuario";
            this.RestoreUser.UseVisualStyleBackColor = true;
            this.RestoreUser.Click += new System.EventHandler(this.RestoreUser_Click);
            // 
            // gbxDeletedUsers
            // 
            this.gbxDeletedUsers.Controls.Add(this.btnExit2);
            this.gbxDeletedUsers.Controls.Add(this.DgvUserDisabled);
            this.gbxDeletedUsers.Location = new System.Drawing.Point(442, 58);
            this.gbxDeletedUsers.Name = "gbxDeletedUsers";
            this.gbxDeletedUsers.Size = new System.Drawing.Size(531, 231);
            this.gbxDeletedUsers.TabIndex = 14;
            this.gbxDeletedUsers.TabStop = false;
            this.gbxDeletedUsers.Text = "Usuários Apagados:";
            // 
            // btnExit2
            // 
            this.btnExit2.Location = new System.Drawing.Point(450, 202);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(75, 23);
            this.btnExit2.TabIndex = 1;
            this.btnExit2.Text = "Sair";
            this.btnExit2.UseVisualStyleBackColor = true;
            this.btnExit2.Click += new System.EventHandler(this.btnExit2_Click);
            // 
            // DgvUserDisabled
            // 
            this.DgvUserDisabled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUserDisabled.Location = new System.Drawing.Point(6, 21);
            this.DgvUserDisabled.Name = "DgvUserDisabled";
            this.DgvUserDisabled.Size = new System.Drawing.Size(519, 175);
            this.DgvUserDisabled.TabIndex = 0;
            this.DgvUserDisabled.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUserDisabled_CellContentClick);
            this.DgvUserDisabled.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUserDisabled_CellContentDoubleClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvUser);
            this.groupBox5.Location = new System.Drawing.Point(8, 296);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(964, 256);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(8, 23);
            this.dgvUser.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.Size = new System.Drawing.Size(948, 225);
            this.dgvUser.TabIndex = 11;
            this.dgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellContentClick);
            this.dgvUser.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellContentDoubleClick);
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btnShowPass4);
            this.pnlLogin.Controls.Add(this.btnLogin2);
            this.pnlLogin.Controls.Add(this.txtPass2);
            this.pnlLogin.Controls.Add(this.txtUser2);
            this.pnlLogin.Controls.Add(this.label5);
            this.pnlLogin.Controls.Add(this.label3);
            this.pnlLogin.Location = new System.Drawing.Point(549, 94);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(334, 119);
            this.pnlLogin.TabIndex = 15;
            // 
            // btnShowPass4
            // 
            this.btnShowPass4.Location = new System.Drawing.Point(209, 77);
            this.btnShowPass4.Name = "btnShowPass4";
            this.btnShowPass4.Size = new System.Drawing.Size(28, 23);
            this.btnShowPass4.TabIndex = 16;
            this.btnShowPass4.UseVisualStyleBackColor = true;
            this.btnShowPass4.Click += new System.EventHandler(this.btnShowPass4_Click);
            // 
            // btnLogin2
            // 
            this.btnLogin2.Location = new System.Drawing.Point(243, 61);
            this.btnLogin2.Name = "btnLogin2";
            this.btnLogin2.Size = new System.Drawing.Size(88, 38);
            this.btnLogin2.TabIndex = 4;
            this.btnLogin2.Text = "Login";
            this.btnLogin2.UseVisualStyleBackColor = true;
            this.btnLogin2.Click += new System.EventHandler(this.btnLogin2_Click);
            // 
            // txtPass2
            // 
            this.txtPass2.Location = new System.Drawing.Point(3, 77);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.Size = new System.Drawing.Size(200, 22);
            this.txtPass2.TabIndex = 3;
            this.txtPass2.UseSystemPasswordChar = true;
            // 
            // txtUser2
            // 
            this.txtUser2.Location = new System.Drawing.Point(3, 33);
            this.txtUser2.Name = "txtUser2";
            this.txtUser2.Size = new System.Drawing.Size(328, 22);
            this.txtUser2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Usuário:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(980, 560);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lançamentos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DgvLancamentos);
            this.groupBox3.Location = new System.Drawing.Point(393, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(580, 343);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // DgvLancamentos
            // 
            this.DgvLancamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLancamentos.Location = new System.Drawing.Point(7, 22);
            this.DgvLancamentos.Margin = new System.Windows.Forms.Padding(4);
            this.DgvLancamentos.Name = "DgvLancamentos";
            this.DgvLancamentos.Size = new System.Drawing.Size(566, 307);
            this.DgvLancamentos.TabIndex = 8;
            this.DgvLancamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.DgvLancamentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLancamentos_CellDoubleClick_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnLimpar);
            this.groupBox2.Controls.Add(this.label_id);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.BtnApagar);
            this.groupBox2.Controls.Add(this.BtnEditar);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.BtnCadastrar);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_categoria);
            this.groupBox2.Location = new System.Drawing.Point(8, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(362, 342);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entradas e Saídas";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(8, 298);
            this.BtnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(79, 28);
            this.BtnLimpar.TabIndex = 21;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(308, 21);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(42, 16);
            this.label_id.TabIndex = 21;
            this.label_id.Text = "label3";
            this.label_id.Visible = false;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(8, 155);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(55, 20);
            this.checkBox5.TabIndex = 20;
            this.checkBox5.Text = "Ativo";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(8, 127);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(90, 20);
            this.checkBox4.TabIndex = 19;
            this.checkBox4.Text = "Recorrente";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // BtnApagar
            // 
            this.BtnApagar.Location = new System.Drawing.Point(265, 298);
            this.BtnApagar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnApagar.Name = "BtnApagar";
            this.BtnApagar.Size = new System.Drawing.Size(75, 28);
            this.BtnApagar.TabIndex = 10;
            this.BtnApagar.Text = "Apagar";
            this.BtnApagar.UseVisualStyleBackColor = true;
            this.BtnApagar.Click += new System.EventHandler(this.BtnApagar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(183, 298);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 28);
            this.BtnEditar.TabIndex = 9;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(175, 225);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 16);
            this.label18.TabIndex = 18;
            this.label18.Text = "Observações";
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(95, 298);
            this.BtnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(79, 28);
            this.BtnCadastrar.TabIndex = 8;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(178, 245);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(162, 22);
            this.textBox8.TabIndex = 17;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 225);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 16);
            this.label19.TabIndex = 16;
            this.label19.Text = "Data vencimento";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(8, 245);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(162, 22);
            this.textBox9.TabIndex = 15;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(175, 179);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 16);
            this.label17.TabIndex = 14;
            this.label17.Text = "Fornecedor";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(178, 199);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(162, 22);
            this.textBox7.TabIndex = 13;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 179);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 16);
            this.label16.TabIndex = 12;
            this.label16.Text = "Categoria";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(8, 199);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(162, 22);
            this.textBox6.TabIndex = 11;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(8, 99);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(60, 20);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Saída";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 71);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 20);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Entrada";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Descrição";
            // 
            // txt_categoria
            // 
            this.txt_categoria.Location = new System.Drawing.Point(11, 41);
            this.txt_categoria.Margin = new System.Windows.Forms.Padding(4);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(162, 22);
            this.txt_categoria.TabIndex = 0;
            this.txt_categoria.TextChanged += new System.EventHandler(this.txt_categoria_TextChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.DgvMovimentacoes);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(980, 560);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Movimentações";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // DgvMovimentacoes
            // 
            this.DgvMovimentacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvMovimentacoes.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvMovimentacoes.Location = new System.Drawing.Point(14, 137);
            this.DgvMovimentacoes.Margin = new System.Windows.Forms.Padding(4);
            this.DgvMovimentacoes.Name = "DgvMovimentacoes";
            this.DgvMovimentacoes.Size = new System.Drawing.Size(917, 407);
            this.DgvMovimentacoes.TabIndex = 1;
            this.DgvMovimentacoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMovimentacoes_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.checkBox3);
            this.groupBox4.Controls.Add(this.cbxFrmPag);
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Controls.Add(this.button11);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Location = new System.Drawing.Point(4, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(927, 125);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Movimentações";
            // 
            // cbxFrmPag
            // 
            this.cbxFrmPag.FormattingEnabled = true;
            this.cbxFrmPag.Location = new System.Drawing.Point(763, 43);
            this.cbxFrmPag.Margin = new System.Windows.Forms.Padding(4);
            this.cbxFrmPag.Name = "cbxFrmPag";
            this.cbxFrmPag.Size = new System.Drawing.Size(140, 24);
            this.cbxFrmPag.TabIndex = 17;
            this.cbxFrmPag.SelectedIndexChanged += new System.EventHandler(this.cbxFrmPag_SelectedIndexChanged);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(662, 85);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 28);
            this.button9.TabIndex = 16;
            this.button9.Text = "Apagar";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(579, 85);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 28);
            this.button10.TabIndex = 15;
            this.button10.Text = "Editar";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(745, 85);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 28);
            this.button11.TabIndex = 14;
            this.button11.Text = "Cadastrar";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(759, 23);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 16);
            this.label14.TabIndex = 7;
            this.label14.Text = "Forma de pagamento";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(609, 24);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "Valor";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(612, 45);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(143, 22);
            this.textBox5.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(194, 21);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Data e hora";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(197, 45);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(143, 22);
            this.textBox4.TabIndex = 2;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 23);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Selecionar receita ou despesa";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 43);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(183, 24);
            this.comboBox2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(980, 560);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Gráficos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(927, 609);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 25);
            this.btn_sair.TabIndex = 12;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // PanelLogin
            // 
            this.PanelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelLogin.Controls.Add(this.btnShowPass3);
            this.PanelLogin.Controls.Add(this.txtPassLogin);
            this.PanelLogin.Controls.Add(this.txtEmailLogin);
            this.PanelLogin.Controls.Add(this.LblPassword);
            this.PanelLogin.Controls.Add(this.LblEmail);
            this.PanelLogin.Controls.Add(this.btnLogin);
            this.PanelLogin.Location = new System.Drawing.Point(329, 224);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(384, 140);
            this.PanelLogin.TabIndex = 13;
            // 
            // btnShowPass3
            // 
            this.btnShowPass3.Image = global::MonitorFinanceiro.Properties.Resources.olho2;
            this.btnShowPass3.Location = new System.Drawing.Point(217, 85);
            this.btnShowPass3.Name = "btnShowPass3";
            this.btnShowPass3.Size = new System.Drawing.Size(28, 28);
            this.btnShowPass3.TabIndex = 5;
            this.btnShowPass3.UseVisualStyleBackColor = true;
            this.btnShowPass3.Click += new System.EventHandler(this.btnShowPass3_Click);
            // 
            // txtPassLogin
            // 
            this.txtPassLogin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassLogin.Location = new System.Drawing.Point(6, 87);
            this.txtPassLogin.Name = "txtPassLogin";
            this.txtPassLogin.Size = new System.Drawing.Size(205, 25);
            this.txtPassLogin.TabIndex = 4;
            this.txtPassLogin.UseSystemPasswordChar = true;
            // 
            // txtEmailLogin
            // 
            this.txtEmailLogin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailLogin.Location = new System.Drawing.Point(6, 29);
            this.txtEmailLogin.Name = "txtEmailLogin";
            this.txtEmailLogin.Size = new System.Drawing.Size(370, 25);
            this.txtEmailLogin.TabIndex = 3;
            this.txtEmailLogin.TextChanged += new System.EventHandler(this.txtEmailLogin_TextChanged);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(3, 67);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(54, 17);
            this.LblPassword.TabIndex = 2;
            this.LblPassword.Text = "Senha:";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(3, 9);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(49, 17);
            this.LblEmail.TabIndex = 1;
            this.LblEmail.Text = "Email:";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(251, 85);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(125, 27);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LblNameUser
            // 
            this.LblNameUser.Location = new System.Drawing.Point(566, 9);
            this.LblNameUser.Name = "LblNameUser";
            this.LblNameUser.Size = new System.Drawing.Size(437, 21);
            this.LblNameUser.TabIndex = 14;
            this.LblNameUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(329, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(384, 57);
            this.label7.TabIndex = 15;
            this.label7.Text = "label7";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 93);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(85, 20);
            this.checkBox3.TabIndex = 18;
            this.checkBox3.Text = "Parcelado";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(249, 92);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 24);
            this.comboBox1.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 72);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Grupo de parcelas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(95, 74);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Quantidade de parcelas";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 94);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 22);
            this.textBox1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(828, 85);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 23;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(345, 25);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Descrição";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(348, 45);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(254, 22);
            this.textBox2.TabIndex = 24;
            // 
            // timerRelogio
            // 
            this.timerRelogio.Enabled = true;
            this.timerRelogio.Interval = 1000;
            this.timerRelogio.Tick += new System.EventHandler(this.timerRelogio_Tick_1);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(217, 159);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(202, 10);
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 15;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(8, 159);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(202, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 15;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 646);
            this.Controls.Add(this.LblNameUser);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.PanelLogin);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbxDeletedUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUserDisabled)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLancamentos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMovimentacoes)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nome_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnApagar;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_categoria;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView DgvLancamentos;
        private System.Windows.Forms.DataGridView DgvMovimentacoes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cbxFrmPag;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtConfPass;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.CheckBox CheckAdm;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblPass1;
        private ProgressBarCustomizada progressBar1;
        private ProgressBarCustomizada progressBar2;
        private Label lblPass2;
        private Panel PanelLogin;
        private TextBox txtPassLogin;
        private TextBox txtEmailLogin;
        private Label LblPassword;
        private Label LblEmail;
        private Button btnLogin;
        private Label LblNameUser;
        private Button btnShowPass;
        private Button btnShowPass2;
        private Button btnShowPass3;
        private GroupBox groupBox3;
        private Button RestoreUser;
        private GroupBox gbxDeletedUsers;
        private DataGridView DgvUserDisabled;
        private Label label_id;
        private Panel pnlLogin;
        private Button btnLogin2;
        private TextBox txtPass2;
        private TextBox txtUser2;
        private Label label5;
        private Label label3;
        private Button btnShowPass4;
        private Button btnExit2;
        private Label label7;
        private Button btnUnlock;
        private TabPage tabPage3;
        private Label label10;
        private TextBox textBox2;
        private Button button1;
        private ComboBox comboBox1;
        private Label label8;
        private Label label9;
        private TextBox textBox1;
        private CheckBox checkBox3;
        private Timer timerRelogio;
    }
}

