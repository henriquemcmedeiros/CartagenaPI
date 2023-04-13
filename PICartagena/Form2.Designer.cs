namespace PICartagena
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
            this.lblJogadorAtual = new System.Windows.Forms.Label();
            this.lblEsqueleto = new System.Windows.Forms.Label();
            this.lblFaca = new System.Windows.Forms.Label();
            this.lblGarrafa = new System.Windows.Forms.Label();
            this.lblTricornio = new System.Windows.Forms.Label();
            this.lblChave = new System.Windows.Forms.Label();
            this.lblPistola = new System.Windows.Forms.Label();
            this.lblTabuleiro = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.txtCarta = new System.Windows.Forms.TextBox();
            this.txtPosicaoPirata = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblJogadorAtual
            // 
            this.lblJogadorAtual.AutoSize = true;
            this.lblJogadorAtual.Location = new System.Drawing.Point(55, 51);
            this.lblJogadorAtual.Name = "lblJogadorAtual";
            this.lblJogadorAtual.Size = new System.Drawing.Size(143, 20);
            this.lblJogadorAtual.TabIndex = 0;
            this.lblJogadorAtual.Text = "O Jogador atual é: ";
            // 
            // lblEsqueleto
            // 
            this.lblEsqueleto.AutoSize = true;
            this.lblEsqueleto.Location = new System.Drawing.Point(74, 243);
            this.lblEsqueleto.Name = "lblEsqueleto";
            this.lblEsqueleto.Size = new System.Drawing.Size(51, 20);
            this.lblEsqueleto.TabIndex = 1;
            this.lblEsqueleto.Text = "label1";
            // 
            // lblFaca
            // 
            this.lblFaca.AutoSize = true;
            this.lblFaca.Location = new System.Drawing.Point(146, 243);
            this.lblFaca.Name = "lblFaca";
            this.lblFaca.Size = new System.Drawing.Size(51, 20);
            this.lblFaca.TabIndex = 2;
            this.lblFaca.Text = "label2";
            // 
            // lblGarrafa
            // 
            this.lblGarrafa.AutoSize = true;
            this.lblGarrafa.Location = new System.Drawing.Point(221, 243);
            this.lblGarrafa.Name = "lblGarrafa";
            this.lblGarrafa.Size = new System.Drawing.Size(51, 20);
            this.lblGarrafa.TabIndex = 3;
            this.lblGarrafa.Text = "label3";
            // 
            // lblTricornio
            // 
            this.lblTricornio.AutoSize = true;
            this.lblTricornio.Location = new System.Drawing.Point(300, 243);
            this.lblTricornio.Name = "lblTricornio";
            this.lblTricornio.Size = new System.Drawing.Size(51, 20);
            this.lblTricornio.TabIndex = 4;
            this.lblTricornio.Text = "label4";
            // 
            // lblChave
            // 
            this.lblChave.AutoSize = true;
            this.lblChave.Location = new System.Drawing.Point(372, 243);
            this.lblChave.Name = "lblChave";
            this.lblChave.Size = new System.Drawing.Size(51, 20);
            this.lblChave.TabIndex = 5;
            this.lblChave.Text = "label5";
            // 
            // lblPistola
            // 
            this.lblPistola.AutoSize = true;
            this.lblPistola.Location = new System.Drawing.Point(447, 243);
            this.lblPistola.Name = "lblPistola";
            this.lblPistola.Size = new System.Drawing.Size(51, 20);
            this.lblPistola.TabIndex = 6;
            this.lblPistola.Text = "label6";
            // 
            // lblTabuleiro
            // 
            this.lblTabuleiro.AutoSize = true;
            this.lblTabuleiro.Location = new System.Drawing.Point(584, 51);
            this.lblTabuleiro.Name = "lblTabuleiro";
            this.lblTabuleiro.Size = new System.Drawing.Size(51, 20);
            this.lblTabuleiro.TabIndex = 7;
            this.lblTabuleiro.Text = "label1";
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(748, 233);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(129, 41);
            this.btnJogar.TabIndex = 8;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // txtCarta
            // 
            this.txtCarta.Location = new System.Drawing.Point(748, 302);
            this.txtCarta.Name = "txtCarta";
            this.txtCarta.Size = new System.Drawing.Size(129, 26);
            this.txtCarta.TabIndex = 9;
            // 
            // txtPosicaoPirata
            // 
            this.txtPosicaoPirata.Location = new System.Drawing.Point(748, 344);
            this.txtPosicaoPirata.Name = "txtPosicaoPirata";
            this.txtPosicaoPirata.Size = new System.Drawing.Size(129, 26);
            this.txtPosicaoPirata.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 514);
            this.Controls.Add(this.txtPosicaoPirata);
            this.Controls.Add(this.txtCarta);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.lblTabuleiro);
            this.Controls.Add(this.lblPistola);
            this.Controls.Add(this.lblChave);
            this.Controls.Add(this.lblTricornio);
            this.Controls.Add(this.lblGarrafa);
            this.Controls.Add(this.lblFaca);
            this.Controls.Add(this.lblEsqueleto);
            this.Controls.Add(this.lblJogadorAtual);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJogadorAtual;
        private System.Windows.Forms.Label lblEsqueleto;
        private System.Windows.Forms.Label lblFaca;
        private System.Windows.Forms.Label lblGarrafa;
        private System.Windows.Forms.Label lblTricornio;
        private System.Windows.Forms.Label lblChave;
        private System.Windows.Forms.Label lblPistola;
        private System.Windows.Forms.Label lblTabuleiro;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.TextBox txtCarta;
        private System.Windows.Forms.TextBox txtPosicaoPirata;
    }
}