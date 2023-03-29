namespace Cartagena_PI_ofc
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCartas = new System.Windows.Forms.Label();
            this.btnConsultarCartas = new System.Windows.Forms.Button();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.txtJogarCarta = new System.Windows.Forms.TextBox();
            this.btnJogarCarta = new System.Windows.Forms.Button();
            this.lblTabuleiro = new System.Windows.Forms.Label();
            this.nmbPirataEscolhido = new System.Windows.Forms.NumericUpDown();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmbPirataEscolhido)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCartas
            // 
            this.lblCartas.AutoSize = true;
            this.lblCartas.Location = new System.Drawing.Point(103, 179);
            this.lblCartas.Name = "lblCartas";
            this.lblCartas.Size = new System.Drawing.Size(51, 20);
            this.lblCartas.TabIndex = 0;
            this.lblCartas.Text = "label1";
            // 
            // btnConsultarCartas
            // 
            this.btnConsultarCartas.Location = new System.Drawing.Point(33, 94);
            this.btnConsultarCartas.Name = "btnConsultarCartas";
            this.btnConsultarCartas.Size = new System.Drawing.Size(192, 55);
            this.btnConsultarCartas.TabIndex = 1;
            this.btnConsultarCartas.Text = "Listar Cartas";
            this.btnConsultarCartas.UseVisualStyleBackColor = true;
            this.btnConsultarCartas.Click += new System.EventHandler(this.btnConsultarCartas_Click);
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Location = new System.Drawing.Point(103, 35);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(51, 20);
            this.lblNomeJogador.TabIndex = 2;
            this.lblNomeJogador.Text = "label1";
            // 
            // txtJogarCarta
            // 
            this.txtJogarCarta.Location = new System.Drawing.Point(322, 50);
            this.txtJogarCarta.Name = "txtJogarCarta";
            this.txtJogarCarta.Size = new System.Drawing.Size(120, 26);
            this.txtJogarCarta.TabIndex = 3;
            // 
            // btnJogarCarta
            // 
            this.btnJogarCarta.Location = new System.Drawing.Point(349, 162);
            this.btnJogarCarta.Name = "btnJogarCarta";
            this.btnJogarCarta.Size = new System.Drawing.Size(75, 55);
            this.btnJogarCarta.TabIndex = 4;
            this.btnJogarCarta.Text = "Jogar Carta";
            this.btnJogarCarta.UseVisualStyleBackColor = true;
            this.btnJogarCarta.Click += new System.EventHandler(this.btnJogarCarta_Click);
            // 
            // lblTabuleiro
            // 
            this.lblTabuleiro.AutoSize = true;
            this.lblTabuleiro.Location = new System.Drawing.Point(618, 24);
            this.lblTabuleiro.Name = "lblTabuleiro";
            this.lblTabuleiro.Size = new System.Drawing.Size(51, 20);
            this.lblTabuleiro.TabIndex = 5;
            this.lblTabuleiro.Text = "label1";
            // 
            // nmbPirataEscolhido
            // 
            this.nmbPirataEscolhido.Location = new System.Drawing.Point(322, 94);
            this.nmbPirataEscolhido.Name = "nmbPirataEscolhido";
            this.nmbPirataEscolhido.Size = new System.Drawing.Size(120, 26);
            this.nmbPirataEscolhido.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(355, 265);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 20);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.nmbPirataEscolhido);
            this.Controls.Add(this.lblTabuleiro);
            this.Controls.Add(this.btnJogarCarta);
            this.Controls.Add(this.txtJogarCarta);
            this.Controls.Add(this.lblNomeJogador);
            this.Controls.Add(this.btnConsultarCartas);
            this.Controls.Add(this.lblCartas);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.nmbPirataEscolhido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCartas;
        private System.Windows.Forms.Button btnConsultarCartas;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.TextBox txtJogarCarta;
        private System.Windows.Forms.Button btnJogarCarta;
        private System.Windows.Forms.Label lblTabuleiro;
        private System.Windows.Forms.NumericUpDown nmbPirataEscolhido;
        private System.Windows.Forms.Label lblStatus;
    }
}