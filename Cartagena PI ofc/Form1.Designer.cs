namespace Cartagena_PI_ofc
{
    partial class Form1
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
            this.btnListarPartidas = new System.Windows.Forms.Button();
            this.lstEscolhaPartida = new System.Windows.Forms.ListBox();
            this.btnSelecionarPartida = new System.Windows.Forms.Button();
            this.lblEntrarPartida = new System.Windows.Forms.Label();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.lblCriarPartida = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.lblLogar = new System.Windows.Forms.Label();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.lblJogadores = new System.Windows.Forms.Label();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.lblIniciar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Location = new System.Drawing.Point(341, 46);
            this.btnListarPartidas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(148, 35);
            this.btnListarPartidas.TabIndex = 0;
            this.btnListarPartidas.Text = "Listar Partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // lstEscolhaPartida
            // 
            this.lstEscolhaPartida.FormattingEnabled = true;
            this.lstEscolhaPartida.ItemHeight = 20;
            this.lstEscolhaPartida.Location = new System.Drawing.Point(301, 91);
            this.lstEscolhaPartida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstEscolhaPartida.Name = "lstEscolhaPartida";
            this.lstEscolhaPartida.Size = new System.Drawing.Size(223, 384);
            this.lstEscolhaPartida.TabIndex = 2;
            // 
            // btnSelecionarPartida
            // 
            this.btnSelecionarPartida.Location = new System.Drawing.Point(689, 46);
            this.btnSelecionarPartida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelecionarPartida.Name = "btnSelecionarPartida";
            this.btnSelecionarPartida.Size = new System.Drawing.Size(112, 60);
            this.btnSelecionarPartida.TabIndex = 3;
            this.btnSelecionarPartida.Text = "Selecionar Partida";
            this.btnSelecionarPartida.UseVisualStyleBackColor = true;
            this.btnSelecionarPartida.Click += new System.EventHandler(this.btnSelecionarPartida_Click);
            // 
            // lblEntrarPartida
            // 
            this.lblEntrarPartida.AutoSize = true;
            this.lblEntrarPartida.Location = new System.Drawing.Point(617, 121);
            this.lblEntrarPartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntrarPartida.Name = "lblEntrarPartida";
            this.lblEntrarPartida.Size = new System.Drawing.Size(51, 20);
            this.lblEntrarPartida.TabIndex = 4;
            this.lblEntrarPartida.Text = "label1";
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(88, 91);
            this.btnCriarPartida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(112, 35);
            this.btnCriarPartida.TabIndex = 5;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // lblCriarPartida
            // 
            this.lblCriarPartida.AutoSize = true;
            this.lblCriarPartida.Location = new System.Drawing.Point(60, 155);
            this.lblCriarPartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCriarPartida.Name = "lblCriarPartida";
            this.lblCriarPartida.Size = new System.Drawing.Size(51, 20);
            this.lblCriarPartida.TabIndex = 6;
            this.lblCriarPartida.Text = "label1";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(597, 215);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(148, 26);
            this.txtUsuario.TabIndex = 7;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(597, 283);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(148, 26);
            this.txtSenha.TabIndex = 8;
            // 
            // btnLogar
            // 
            this.btnLogar.Location = new System.Drawing.Point(777, 215);
            this.btnLogar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(112, 74);
            this.btnLogar.TabIndex = 9;
            this.btnLogar.Text = "Entrar na partida";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // lblLogar
            // 
            this.lblLogar.AutoSize = true;
            this.lblLogar.Location = new System.Drawing.Point(773, 305);
            this.lblLogar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogar.Name = "lblLogar";
            this.lblLogar.Size = new System.Drawing.Size(51, 20);
            this.lblLogar.TabIndex = 10;
            this.lblLogar.Text = "label1";
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(64, 215);
            this.txtNomePartida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(148, 26);
            this.txtNomePartida.TabIndex = 11;
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(65, 269);
            this.txtSenhaPartida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(145, 26);
            this.txtSenhaPartida.TabIndex = 12;
            // 
            // lblJogadores
            // 
            this.lblJogadores.AutoSize = true;
            this.lblJogadores.Location = new System.Drawing.Point(768, 121);
            this.lblJogadores.Name = "lblJogadores";
            this.lblJogadores.Size = new System.Drawing.Size(51, 20);
            this.lblJogadores.TabIndex = 13;
            this.lblJogadores.Text = "label1";
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(633, 362);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(135, 102);
            this.btnIniciarPartida.TabIndex = 14;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // lblIniciar
            // 
            this.lblIniciar.AutoSize = true;
            this.lblIniciar.Location = new System.Drawing.Point(821, 403);
            this.lblIniciar.Name = "lblIniciar";
            this.lblIniciar.Size = new System.Drawing.Size(51, 20);
            this.lblIniciar.TabIndex = 15;
            this.lblIniciar.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 548);
            this.Controls.Add(this.lblIniciar);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.lblJogadores);
            this.Controls.Add(this.txtSenhaPartida);
            this.Controls.Add(this.txtNomePartida);
            this.Controls.Add(this.lblLogar);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblCriarPartida);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.lblEntrarPartida);
            this.Controls.Add(this.btnSelecionarPartida);
            this.Controls.Add(this.lstEscolhaPartida);
            this.Controls.Add(this.btnListarPartidas);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.ListBox lstEscolhaPartida;
        private System.Windows.Forms.Button btnSelecionarPartida;
        private System.Windows.Forms.Label lblEntrarPartida;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Label lblCriarPartida;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Label lblLogar;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.Label lblJogadores;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Label lblIniciar;
    }
}

