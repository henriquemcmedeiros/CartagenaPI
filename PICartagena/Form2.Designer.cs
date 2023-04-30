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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txtPosicaoPirata = new System.Windows.Forms.TextBox();
            this.lblPosicaoPirata = new System.Windows.Forms.Label();
            this.lblCarta = new System.Windows.Forms.Label();
            this.tmrPrincipal = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJogadorAtual
            // 
            this.lblJogadorAtual.AutoSize = true;
            this.lblJogadorAtual.Location = new System.Drawing.Point(56, 51);
            this.lblJogadorAtual.Name = "lblJogadorAtual";
            this.lblJogadorAtual.Size = new System.Drawing.Size(143, 20);
            this.lblJogadorAtual.TabIndex = 0;
            this.lblJogadorAtual.Text = "O Jogador atual é: ";
            // 
            // lblEsqueleto
            // 
            this.lblEsqueleto.AutoSize = true;
            this.lblEsqueleto.BackColor = System.Drawing.Color.Black;
            this.lblEsqueleto.ForeColor = System.Drawing.Color.Transparent;
            this.lblEsqueleto.Location = new System.Drawing.Point(177, 563);
            this.lblEsqueleto.Name = "lblEsqueleto";
            this.lblEsqueleto.Size = new System.Drawing.Size(20, 20);
            this.lblEsqueleto.TabIndex = 1;
            this.lblEsqueleto.Text = "E";
            // 
            // lblFaca
            // 
            this.lblFaca.AutoSize = true;
            this.lblFaca.BackColor = System.Drawing.Color.Black;
            this.lblFaca.ForeColor = System.Drawing.Color.Transparent;
            this.lblFaca.Location = new System.Drawing.Point(368, 563);
            this.lblFaca.Name = "lblFaca";
            this.lblFaca.Size = new System.Drawing.Size(19, 20);
            this.lblFaca.TabIndex = 2;
            this.lblFaca.Text = "F";
            // 
            // lblGarrafa
            // 
            this.lblGarrafa.AutoSize = true;
            this.lblGarrafa.BackColor = System.Drawing.Color.Black;
            this.lblGarrafa.ForeColor = System.Drawing.Color.Transparent;
            this.lblGarrafa.Location = new System.Drawing.Point(556, 563);
            this.lblGarrafa.Name = "lblGarrafa";
            this.lblGarrafa.Size = new System.Drawing.Size(22, 20);
            this.lblGarrafa.TabIndex = 3;
            this.lblGarrafa.Text = "G";
            // 
            // lblTricornio
            // 
            this.lblTricornio.AutoSize = true;
            this.lblTricornio.BackColor = System.Drawing.Color.Black;
            this.lblTricornio.ForeColor = System.Drawing.Color.Transparent;
            this.lblTricornio.Location = new System.Drawing.Point(182, 825);
            this.lblTricornio.Name = "lblTricornio";
            this.lblTricornio.Size = new System.Drawing.Size(18, 20);
            this.lblTricornio.TabIndex = 4;
            this.lblTricornio.Text = "T";
            // 
            // lblChave
            // 
            this.lblChave.AutoSize = true;
            this.lblChave.BackColor = System.Drawing.Color.Black;
            this.lblChave.ForeColor = System.Drawing.Color.Transparent;
            this.lblChave.Location = new System.Drawing.Point(368, 825);
            this.lblChave.Name = "lblChave";
            this.lblChave.Size = new System.Drawing.Size(20, 20);
            this.lblChave.TabIndex = 5;
            this.lblChave.Text = "C";
            // 
            // lblPistola
            // 
            this.lblPistola.AutoSize = true;
            this.lblPistola.BackColor = System.Drawing.Color.Black;
            this.lblPistola.ForeColor = System.Drawing.Color.Transparent;
            this.lblPistola.Location = new System.Drawing.Point(558, 825);
            this.lblPistola.Name = "lblPistola";
            this.lblPistola.Size = new System.Drawing.Size(19, 20);
            this.lblPistola.TabIndex = 6;
            this.lblPistola.Text = "P";
            // 
            // lblTabuleiro
            // 
            this.lblTabuleiro.AutoSize = true;
            this.lblTabuleiro.Location = new System.Drawing.Point(110, 140);
            this.lblTabuleiro.Name = "lblTabuleiro";
            this.lblTabuleiro.Size = new System.Drawing.Size(51, 20);
            this.lblTabuleiro.TabIndex = 7;
            this.lblTabuleiro.Text = "label1";
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(630, 240);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(129, 42);
            this.btnJogar.TabIndex = 8;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // txtCarta
            // 
            this.txtCarta.Location = new System.Drawing.Point(630, 140);
            this.txtCarta.Name = "txtCarta";
            this.txtCarta.Size = new System.Drawing.Size(128, 26);
            this.txtCarta.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 549);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(237, 549);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 231);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(429, 549);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(164, 231);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(51, 811);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(165, 231);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(238, 811);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(164, 231);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(428, 811);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(165, 231);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // txtPosicaoPirata
            // 
            this.txtPosicaoPirata.Location = new System.Drawing.Point(630, 202);
            this.txtPosicaoPirata.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPosicaoPirata.Name = "txtPosicaoPirata";
            this.txtPosicaoPirata.Size = new System.Drawing.Size(127, 26);
            this.txtPosicaoPirata.TabIndex = 16;
            // 
            // lblPosicaoPirata
            // 
            this.lblPosicaoPirata.AutoSize = true;
            this.lblPosicaoPirata.Location = new System.Drawing.Point(626, 177);
            this.lblPosicaoPirata.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosicaoPirata.Name = "lblPosicaoPirata";
            this.lblPosicaoPirata.Size = new System.Drawing.Size(114, 20);
            this.lblPosicaoPirata.TabIndex = 17;
            this.lblPosicaoPirata.Text = "Posicao Pirata:";
            // 
            // lblCarta
            // 
            this.lblCarta.AutoSize = true;
            this.lblCarta.Location = new System.Drawing.Point(626, 115);
            this.lblCarta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarta.Name = "lblCarta";
            this.lblCarta.Size = new System.Drawing.Size(52, 20);
            this.lblCarta.TabIndex = 18;
            this.lblCarta.Text = "Carta:";
            // 
            // tmrPrincipal
            // 
            this.tmrPrincipal.Interval = 10000;
            this.tmrPrincipal.Tick += new System.EventHandler(this.tmrPrincipal_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(1001, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 976);
            this.panel1.TabIndex = 19;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1881, 1050);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCarta);
            this.Controls.Add(this.lblPosicaoPirata);
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
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox txtPosicaoPirata;
        private System.Windows.Forms.Label lblPosicaoPirata;
        private System.Windows.Forms.Label lblCarta;
        private System.Windows.Forms.Timer tmrPrincipal;
        private System.Windows.Forms.Panel panel1;
    }
}