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
            this.button1 = new System.Windows.Forms.Button();
            this.lblListarPartidas = new System.Windows.Forms.Label();
            this.lstEscolhaPartida = new System.Windows.Forms.ListBox();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.lblEntrarPartida = new System.Windows.Forms.Label();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.lblCriarPartida = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.lblLogar = new System.Windows.Forms.Label();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Listar Partidas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblListarPartidas
            // 
            this.lblListarPartidas.AutoSize = true;
            this.lblListarPartidas.Location = new System.Drawing.Point(28, 111);
            this.lblListarPartidas.Name = "lblListarPartidas";
            this.lblListarPartidas.Size = new System.Drawing.Size(35, 13);
            this.lblListarPartidas.TabIndex = 1;
            this.lblListarPartidas.Text = "label1";
            // 
            // lstEscolhaPartida
            // 
            this.lstEscolhaPartida.FormattingEnabled = true;
            this.lstEscolhaPartida.Location = new System.Drawing.Point(161, 61);
            this.lstEscolhaPartida.Name = "lstEscolhaPartida";
            this.lstEscolhaPartida.Size = new System.Drawing.Size(120, 95);
            this.lstEscolhaPartida.TabIndex = 2;
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Location = new System.Drawing.Point(327, 61);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(75, 39);
            this.btnEntrarPartida.TabIndex = 3;
            this.btnEntrarPartida.Text = "Selecionar Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // lblEntrarPartida
            // 
            this.lblEntrarPartida.AutoSize = true;
            this.lblEntrarPartida.Location = new System.Drawing.Point(324, 111);
            this.lblEntrarPartida.Name = "lblEntrarPartida";
            this.lblEntrarPartida.Size = new System.Drawing.Size(35, 13);
            this.lblEntrarPartida.TabIndex = 4;
            this.lblEntrarPartida.Text = "label1";
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(645, 58);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(75, 23);
            this.btnCriarPartida.TabIndex = 5;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // lblCriarPartida
            // 
            this.lblCriarPartida.AutoSize = true;
            this.lblCriarPartida.Location = new System.Drawing.Point(649, 96);
            this.lblCriarPartida.Name = "lblCriarPartida";
            this.lblCriarPartida.Size = new System.Drawing.Size(35, 13);
            this.lblCriarPartida.TabIndex = 6;
            this.lblCriarPartida.Text = "label1";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(495, 223);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 7;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(495, 267);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 8;
            // 
            // btnLogar
            // 
            this.btnLogar.Location = new System.Drawing.Point(645, 223);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(75, 48);
            this.btnLogar.TabIndex = 9;
            this.btnLogar.Text = "Entrar na partida";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // lblLogar
            // 
            this.lblLogar.AutoSize = true;
            this.lblLogar.Location = new System.Drawing.Point(640, 288);
            this.lblLogar.Name = "lblLogar";
            this.lblLogar.Size = new System.Drawing.Size(35, 13);
            this.lblLogar.TabIndex = 10;
            this.lblLogar.Text = "label1";
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(494, 61);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(100, 20);
            this.txtNomePartida.TabIndex = 11;
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(495, 96);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(98, 20);
            this.txtSenhaPartida.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSenhaPartida);
            this.Controls.Add(this.txtNomePartida);
            this.Controls.Add(this.lblLogar);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblCriarPartida);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.lblEntrarPartida);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.lstEscolhaPartida);
            this.Controls.Add(this.lblListarPartidas);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblListarPartidas;
        private System.Windows.Forms.ListBox lstEscolhaPartida;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.Label lblEntrarPartida;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Label lblCriarPartida;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Label lblLogar;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.TextBox txtSenhaPartida;
    }
}

