namespace PICartagena
{
    partial class txtNomeDaPartida
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
            this.lstListarPartidas = new System.Windows.Forms.ListBox();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.lblNomeDaPartida = new System.Windows.Forms.Label();
            this.lblSenhaDaPartida = new System.Windows.Forms.Label();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.lblPartidaSelecionada = new System.Windows.Forms.Label();
            this.lblPartidaIdeNome = new System.Windows.Forms.Label();
            this.btnSelecionarPartida = new System.Windows.Forms.Button();
            this.lblJogadores = new System.Windows.Forms.Label();
            this.lblListaJogadores = new System.Windows.Forms.Label();
            this.txtNomeDoJogador = new System.Windows.Forms.TextBox();
            this.txtSenhaPartidaLogar = new System.Windows.Forms.TextBox();
            this.lblSenhaPartidaSelecionada = new System.Windows.Forms.Label();
            this.lblNomeDoJogador = new System.Windows.Forms.Label();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Location = new System.Drawing.Point(282, 12);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(106, 71);
            this.btnListarPartidas.TabIndex = 0;
            this.btnListarPartidas.Text = "Listar Partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // lstListarPartidas
            // 
            this.lstListarPartidas.FormattingEnabled = true;
            this.lstListarPartidas.ItemHeight = 20;
            this.lstListarPartidas.Location = new System.Drawing.Point(12, 12);
            this.lstListarPartidas.Name = "lstListarPartidas";
            this.lstListarPartidas.Size = new System.Drawing.Size(223, 584);
            this.lstListarPartidas.TabIndex = 1;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(282, 390);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(106, 71);
            this.btnCriarPartida.TabIndex = 2;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // lblNomeDaPartida
            // 
            this.lblNomeDaPartida.AutoSize = true;
            this.lblNomeDaPartida.Location = new System.Drawing.Point(241, 477);
            this.lblNomeDaPartida.Name = "lblNomeDaPartida";
            this.lblNomeDaPartida.Size = new System.Drawing.Size(134, 20);
            this.lblNomeDaPartida.TabIndex = 3;
            this.lblNomeDaPartida.Text = "Nome da partida: ";
            // 
            // lblSenhaDaPartida
            // 
            this.lblSenhaDaPartida.AutoSize = true;
            this.lblSenhaDaPartida.Location = new System.Drawing.Point(241, 542);
            this.lblSenhaDaPartida.Name = "lblSenhaDaPartida";
            this.lblSenhaDaPartida.Size = new System.Drawing.Size(135, 20);
            this.lblSenhaDaPartida.TabIndex = 4;
            this.lblSenhaDaPartida.Text = "Senha da partida:";
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(269, 566);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(129, 26);
            this.txtSenhaPartida.TabIndex = 6;
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(269, 500);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(129, 26);
            this.txtNomePartida.TabIndex = 7;
            // 
            // lblPartidaSelecionada
            // 
            this.lblPartidaSelecionada.AutoSize = true;
            this.lblPartidaSelecionada.Location = new System.Drawing.Point(241, 193);
            this.lblPartidaSelecionada.Name = "lblPartidaSelecionada";
            this.lblPartidaSelecionada.Size = new System.Drawing.Size(155, 20);
            this.lblPartidaSelecionada.TabIndex = 8;
            this.lblPartidaSelecionada.Text = "Partida Selecionada:";
            // 
            // lblPartidaIdeNome
            // 
            this.lblPartidaIdeNome.AutoSize = true;
            this.lblPartidaIdeNome.Location = new System.Drawing.Point(269, 228);
            this.lblPartidaIdeNome.Name = "lblPartidaIdeNome";
            this.lblPartidaIdeNome.Size = new System.Drawing.Size(0, 20);
            this.lblPartidaIdeNome.TabIndex = 9;
            // 
            // btnSelecionarPartida
            // 
            this.btnSelecionarPartida.Location = new System.Drawing.Point(282, 105);
            this.btnSelecionarPartida.Name = "btnSelecionarPartida";
            this.btnSelecionarPartida.Size = new System.Drawing.Size(106, 71);
            this.btnSelecionarPartida.TabIndex = 10;
            this.btnSelecionarPartida.Text = "Selecionar Partida";
            this.btnSelecionarPartida.UseVisualStyleBackColor = true;
            this.btnSelecionarPartida.Click += new System.EventHandler(this.btnSelecionarPartida_Click);
            // 
            // lblJogadores
            // 
            this.lblJogadores.AutoSize = true;
            this.lblJogadores.Location = new System.Drawing.Point(241, 248);
            this.lblJogadores.Name = "lblJogadores";
            this.lblJogadores.Size = new System.Drawing.Size(88, 20);
            this.lblJogadores.TabIndex = 11;
            this.lblJogadores.Text = "Jogadores:";
            // 
            // lblListaJogadores
            // 
            this.lblListaJogadores.AutoSize = true;
            this.lblListaJogadores.Location = new System.Drawing.Point(269, 289);
            this.lblListaJogadores.Name = "lblListaJogadores";
            this.lblListaJogadores.Size = new System.Drawing.Size(0, 20);
            this.lblListaJogadores.TabIndex = 12;
            // 
            // txtNomeDoJogador
            // 
            this.txtNomeDoJogador.Location = new System.Drawing.Point(450, 500);
            this.txtNomeDoJogador.Name = "txtNomeDoJogador";
            this.txtNomeDoJogador.Size = new System.Drawing.Size(129, 26);
            this.txtNomeDoJogador.TabIndex = 17;
            // 
            // txtSenhaPartidaLogar
            // 
            this.txtSenhaPartidaLogar.Location = new System.Drawing.Point(450, 566);
            this.txtSenhaPartidaLogar.Name = "txtSenhaPartidaLogar";
            this.txtSenhaPartidaLogar.Size = new System.Drawing.Size(129, 26);
            this.txtSenhaPartidaLogar.TabIndex = 16;
            // 
            // lblSenhaPartidaSelecionada
            // 
            this.lblSenhaPartidaSelecionada.AutoSize = true;
            this.lblSenhaPartidaSelecionada.Location = new System.Drawing.Point(422, 542);
            this.lblSenhaPartidaSelecionada.Name = "lblSenhaPartidaSelecionada";
            this.lblSenhaPartidaSelecionada.Size = new System.Drawing.Size(135, 20);
            this.lblSenhaPartidaSelecionada.TabIndex = 15;
            this.lblSenhaPartidaSelecionada.Text = "Senha da partida:";
            // 
            // lblNomeDoJogador
            // 
            this.lblNomeDoJogador.AutoSize = true;
            this.lblNomeDoJogador.Location = new System.Drawing.Point(422, 477);
            this.lblNomeDoJogador.Name = "lblNomeDoJogador";
            this.lblNomeDoJogador.Size = new System.Drawing.Size(134, 20);
            this.lblNomeDoJogador.TabIndex = 14;
            this.lblNomeDoJogador.Text = "Nome do jogador:";
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Location = new System.Drawing.Point(463, 390);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(106, 71);
            this.btnEntrarPartida.TabIndex = 13;
            this.btnEntrarPartida.Text = "Entrar Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(463, 105);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(106, 71);
            this.btnIniciarPartida.TabIndex = 18;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // txtNomeDaPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 618);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.txtNomeDoJogador);
            this.Controls.Add(this.txtSenhaPartidaLogar);
            this.Controls.Add(this.lblSenhaPartidaSelecionada);
            this.Controls.Add(this.lblNomeDoJogador);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.lblListaJogadores);
            this.Controls.Add(this.lblJogadores);
            this.Controls.Add(this.btnSelecionarPartida);
            this.Controls.Add(this.lblPartidaIdeNome);
            this.Controls.Add(this.lblPartidaSelecionada);
            this.Controls.Add(this.txtNomePartida);
            this.Controls.Add(this.txtSenhaPartida);
            this.Controls.Add(this.lblSenhaDaPartida);
            this.Controls.Add(this.lblNomeDaPartida);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.lstListarPartidas);
            this.Controls.Add(this.btnListarPartidas);
            this.Name = "txtNomeDaPartida";
            this.Text = "Palmira";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.ListBox lstListarPartidas;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Label lblNomeDaPartida;
        private System.Windows.Forms.Label lblSenhaDaPartida;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.Label lblPartidaSelecionada;
        private System.Windows.Forms.Label lblPartidaIdeNome;
        private System.Windows.Forms.Button btnSelecionarPartida;
        private System.Windows.Forms.Label lblJogadores;
        private System.Windows.Forms.Label lblListaJogadores;
        private System.Windows.Forms.TextBox txtNomeDoJogador;
        private System.Windows.Forms.TextBox txtSenhaPartidaLogar;
        private System.Windows.Forms.Label lblSenhaPartidaSelecionada;
        private System.Windows.Forms.Label lblNomeDoJogador;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.Button btnIniciarPartida;
    }
}

