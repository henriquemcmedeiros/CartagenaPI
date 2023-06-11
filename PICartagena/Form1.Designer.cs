namespace PICartagena
{
    partial class frmIniciar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIniciar));
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
            this.tmrEntrarPartida = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.BackColor = System.Drawing.Color.Transparent;
            this.btnListarPartidas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnListarPartidas.BackgroundImage")));
            this.btnListarPartidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarPartidas.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPartidas.ForeColor = System.Drawing.Color.White;
            this.btnListarPartidas.Location = new System.Drawing.Point(309, 31);
            this.btnListarPartidas.Margin = new System.Windows.Forms.Padding(2);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(104, 55);
            this.btnListarPartidas.TabIndex = 0;
            this.btnListarPartidas.Text = "Listar Partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = false;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // lstListarPartidas
            // 
            this.lstListarPartidas.FormattingEnabled = true;
            this.lstListarPartidas.Location = new System.Drawing.Point(429, 31);
            this.lstListarPartidas.Margin = new System.Windows.Forms.Padding(2);
            this.lstListarPartidas.Name = "lstListarPartidas";
            this.lstListarPartidas.Size = new System.Drawing.Size(150, 381);
            this.lstListarPartidas.TabIndex = 1;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnCriarPartida.BackgroundImage = global::PICartagena.Properties.Resources.button_bkg;
            this.btnCriarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarPartida.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPartida.ForeColor = System.Drawing.Color.White;
            this.btnCriarPartida.Location = new System.Drawing.Point(170, 252);
            this.btnCriarPartida.Margin = new System.Windows.Forms.Padding(2);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(98, 55);
            this.btnCriarPartida.TabIndex = 2;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = false;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // lblNomeDaPartida
            // 
            this.lblNomeDaPartida.AutoSize = true;
            this.lblNomeDaPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeDaPartida.Location = new System.Drawing.Point(167, 324);
            this.lblNomeDaPartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeDaPartida.Name = "lblNomeDaPartida";
            this.lblNomeDaPartida.Size = new System.Drawing.Size(91, 13);
            this.lblNomeDaPartida.TabIndex = 3;
            this.lblNomeDaPartida.Text = "Nome da partida: ";
            // 
            // lblSenhaDaPartida
            // 
            this.lblSenhaDaPartida.AutoSize = true;
            this.lblSenhaDaPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaDaPartida.Location = new System.Drawing.Point(167, 366);
            this.lblSenhaDaPartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenhaDaPartida.Name = "lblSenhaDaPartida";
            this.lblSenhaDaPartida.Size = new System.Drawing.Size(91, 13);
            this.lblSenhaDaPartida.TabIndex = 4;
            this.lblSenhaDaPartida.Text = "Senha da partida:";
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(185, 382);
            this.txtSenhaPartida.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(87, 20);
            this.txtSenhaPartida.TabIndex = 6;
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(185, 339);
            this.txtNomePartida.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(87, 20);
            this.txtNomePartida.TabIndex = 7;
            // 
            // lblPartidaSelecionada
            // 
            this.lblPartidaSelecionada.BackColor = System.Drawing.Color.Transparent;
            this.lblPartidaSelecionada.Location = new System.Drawing.Point(588, 52);
            this.lblPartidaSelecionada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPartidaSelecionada.Name = "lblPartidaSelecionada";
            this.lblPartidaSelecionada.Size = new System.Drawing.Size(113, 13);
            this.lblPartidaSelecionada.TabIndex = 8;
            this.lblPartidaSelecionada.Text = "Partida Selecionada:";
            // 
            // lblPartidaIdeNome
            // 
            this.lblPartidaIdeNome.AutoSize = true;
            this.lblPartidaIdeNome.BackColor = System.Drawing.Color.Transparent;
            this.lblPartidaIdeNome.Location = new System.Drawing.Point(600, 73);
            this.lblPartidaIdeNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPartidaIdeNome.Name = "lblPartidaIdeNome";
            this.lblPartidaIdeNome.Size = new System.Drawing.Size(0, 13);
            this.lblPartidaIdeNome.TabIndex = 9;
            // 
            // btnSelecionarPartida
            // 
            this.btnSelecionarPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnSelecionarPartida.BackgroundImage = global::PICartagena.Properties.Resources.button_bkg;
            this.btnSelecionarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarPartida.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarPartida.ForeColor = System.Drawing.Color.White;
            this.btnSelecionarPartida.Location = new System.Drawing.Point(309, 109);
            this.btnSelecionarPartida.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelecionarPartida.Name = "btnSelecionarPartida";
            this.btnSelecionarPartida.Size = new System.Drawing.Size(104, 55);
            this.btnSelecionarPartida.TabIndex = 10;
            this.btnSelecionarPartida.Text = "Selecionar Partida";
            this.btnSelecionarPartida.UseVisualStyleBackColor = false;
            this.btnSelecionarPartida.Click += new System.EventHandler(this.btnSelecionarPartida_Click);
            // 
            // lblJogadores
            // 
            this.lblJogadores.BackColor = System.Drawing.Color.Transparent;
            this.lblJogadores.Location = new System.Drawing.Point(588, 109);
            this.lblJogadores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJogadores.Name = "lblJogadores";
            this.lblJogadores.Size = new System.Drawing.Size(63, 13);
            this.lblJogadores.TabIndex = 11;
            this.lblJogadores.Text = "Jogadores:";
            // 
            // lblListaJogadores
            // 
            this.lblListaJogadores.AutoSize = true;
            this.lblListaJogadores.BackColor = System.Drawing.Color.Transparent;
            this.lblListaJogadores.Location = new System.Drawing.Point(600, 130);
            this.lblListaJogadores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListaJogadores.Name = "lblListaJogadores";
            this.lblListaJogadores.Size = new System.Drawing.Size(0, 13);
            this.lblListaJogadores.TabIndex = 12;
            // 
            // txtNomeDoJogador
            // 
            this.txtNomeDoJogador.Location = new System.Drawing.Point(320, 339);
            this.txtNomeDoJogador.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeDoJogador.Name = "txtNomeDoJogador";
            this.txtNomeDoJogador.Size = new System.Drawing.Size(87, 20);
            this.txtNomeDoJogador.TabIndex = 17;
            // 
            // txtSenhaPartidaLogar
            // 
            this.txtSenhaPartidaLogar.Location = new System.Drawing.Point(320, 382);
            this.txtSenhaPartidaLogar.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenhaPartidaLogar.Name = "txtSenhaPartidaLogar";
            this.txtSenhaPartidaLogar.Size = new System.Drawing.Size(87, 20);
            this.txtSenhaPartidaLogar.TabIndex = 16;
            // 
            // lblSenhaPartidaSelecionada
            // 
            this.lblSenhaPartidaSelecionada.AutoSize = true;
            this.lblSenhaPartidaSelecionada.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaPartidaSelecionada.Location = new System.Drawing.Point(301, 366);
            this.lblSenhaPartidaSelecionada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenhaPartidaSelecionada.Name = "lblSenhaPartidaSelecionada";
            this.lblSenhaPartidaSelecionada.Size = new System.Drawing.Size(91, 13);
            this.lblSenhaPartidaSelecionada.TabIndex = 15;
            this.lblSenhaPartidaSelecionada.Text = "Senha da partida:";
            // 
            // lblNomeDoJogador
            // 
            this.lblNomeDoJogador.AutoSize = true;
            this.lblNomeDoJogador.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeDoJogador.Location = new System.Drawing.Point(301, 324);
            this.lblNomeDoJogador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeDoJogador.Name = "lblNomeDoJogador";
            this.lblNomeDoJogador.Size = new System.Drawing.Size(91, 13);
            this.lblNomeDoJogador.TabIndex = 14;
            this.lblNomeDoJogador.Text = "Nome do jogador:";
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrarPartida.BackgroundImage = global::PICartagena.Properties.Resources.button_bkg;
            this.btnEntrarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrarPartida.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarPartida.ForeColor = System.Drawing.Color.White;
            this.btnEntrarPartida.Location = new System.Drawing.Point(304, 252);
            this.btnEntrarPartida.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(98, 55);
            this.btnEntrarPartida.TabIndex = 13;
            this.btnEntrarPartida.Text = "Entrar Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = false;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciarPartida.BackgroundImage = global::PICartagena.Properties.Resources.button_bkg;
            this.btnIniciarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarPartida.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPartida.ForeColor = System.Drawing.Color.White;
            this.btnIniciarPartida.Location = new System.Drawing.Point(591, 297);
            this.btnIniciarPartida.Margin = new System.Windows.Forms.Padding(2);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(98, 55);
            this.btnIniciarPartida.TabIndex = 18;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = false;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // tmrEntrarPartida
            // 
            this.tmrEntrarPartida.Interval = 5000;
            this.tmrEntrarPartida.Tick += new System.EventHandler(this.tmrEntrarPartida_Tick);
            // 
            // frmIniciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(712, 446);
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
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmIniciar";
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
        private System.Windows.Forms.Timer tmrEntrarPartida;
    }
}

