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
            this.lblJogador = new System.Windows.Forms.Label();
            this.tmrPrincipal = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblPistola = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblFaca = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEsqueleto = new System.Windows.Forms.Label();
            this.lblTricornio = new System.Windows.Forms.Label();
            this.lblChave = new System.Windows.Forms.Label();
            this.lblGarrafa = new System.Windows.Forms.Label();
            this.pnlTabuleiro = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJogadorAtual
            // 
            this.lblJogadorAtual.AutoSize = true;
            this.lblJogadorAtual.BackColor = System.Drawing.Color.Transparent;
            this.lblJogadorAtual.Location = new System.Drawing.Point(334, 55);
            this.lblJogadorAtual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJogadorAtual.Name = "lblJogadorAtual";
            this.lblJogadorAtual.Size = new System.Drawing.Size(97, 13);
            this.lblJogadorAtual.TabIndex = 0;
            this.lblJogadorAtual.Text = "O Jogador atual é: ";
            // 
            // lblJogador
            // 
            this.lblJogador.AutoSize = true;
            this.lblJogador.BackColor = System.Drawing.Color.Transparent;
            this.lblJogador.Location = new System.Drawing.Point(367, 91);
            this.lblJogador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(35, 13);
            this.lblJogador.TabIndex = 7;
            this.lblJogador.Text = "label1";
            // 
            // tmrPrincipal
            // 
            this.tmrPrincipal.Interval = 10000;
            this.tmrPrincipal.Tick += new System.EventHandler(this.tmrPrincipal_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(437, 205);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(125, 201);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(437, 412);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(125, 201);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(148, 412);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(125, 201);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(293, 412);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(123, 201);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // lblPistola
            // 
            this.lblPistola.AutoSize = true;
            this.lblPistola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPistola.ForeColor = System.Drawing.Color.Transparent;
            this.lblPistola.Location = new System.Drawing.Point(533, 429);
            this.lblPistola.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPistola.Name = "lblPistola";
            this.lblPistola.Size = new System.Drawing.Size(14, 13);
            this.lblPistola.TabIndex = 6;
            this.lblPistola.Text = "P";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(293, 205);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 201);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // lblFaca
            // 
            this.lblFaca.AutoSize = true;
            this.lblFaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFaca.ForeColor = System.Drawing.Color.Transparent;
            this.lblFaca.Location = new System.Drawing.Point(389, 222);
            this.lblFaca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFaca.Name = "lblFaca";
            this.lblFaca.Size = new System.Drawing.Size(13, 13);
            this.lblFaca.TabIndex = 2;
            this.lblFaca.Text = "F";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblEsqueleto
            // 
            this.lblEsqueleto.AutoSize = true;
            this.lblEsqueleto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEsqueleto.ForeColor = System.Drawing.Color.Transparent;
            this.lblEsqueleto.Location = new System.Drawing.Point(244, 222);
            this.lblEsqueleto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEsqueleto.Name = "lblEsqueleto";
            this.lblEsqueleto.Size = new System.Drawing.Size(14, 13);
            this.lblEsqueleto.TabIndex = 1;
            this.lblEsqueleto.Text = "E";
            // 
            // lblTricornio
            // 
            this.lblTricornio.AutoSize = true;
            this.lblTricornio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTricornio.ForeColor = System.Drawing.Color.Transparent;
            this.lblTricornio.Location = new System.Drawing.Point(244, 429);
            this.lblTricornio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTricornio.Name = "lblTricornio";
            this.lblTricornio.Size = new System.Drawing.Size(14, 13);
            this.lblTricornio.TabIndex = 4;
            this.lblTricornio.Text = "T";
            // 
            // lblChave
            // 
            this.lblChave.AutoSize = true;
            this.lblChave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblChave.ForeColor = System.Drawing.Color.Transparent;
            this.lblChave.Location = new System.Drawing.Point(388, 429);
            this.lblChave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChave.Name = "lblChave";
            this.lblChave.Size = new System.Drawing.Size(14, 13);
            this.lblChave.TabIndex = 5;
            this.lblChave.Text = "C";
            // 
            // lblGarrafa
            // 
            this.lblGarrafa.AutoSize = true;
            this.lblGarrafa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGarrafa.ForeColor = System.Drawing.Color.Transparent;
            this.lblGarrafa.Location = new System.Drawing.Point(533, 222);
            this.lblGarrafa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGarrafa.Name = "lblGarrafa";
            this.lblGarrafa.Size = new System.Drawing.Size(15, 13);
            this.lblGarrafa.TabIndex = 3;
            this.lblGarrafa.Text = "G";
            // 
            // pnlTabuleiro
            // 
            this.pnlTabuleiro.BackColor = System.Drawing.Color.Transparent;
            this.pnlTabuleiro.BackgroundImage = global::PICartagena.Properties.Resources.Form2_Panel_BKG;
            this.pnlTabuleiro.Location = new System.Drawing.Point(709, 43);
            this.pnlTabuleiro.Name = "pnlTabuleiro";
            this.pnlTabuleiro.Size = new System.Drawing.Size(634, 766);
            this.pnlTabuleiro.TabIndex = 19;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.BackgroundImage = global::PICartagena.Properties.Resources.FOORRMMMMM_222_BKGGG;
            this.ClientSize = new System.Drawing.Size(1491, 814);
            this.Controls.Add(this.pnlTabuleiro);
            this.Controls.Add(this.lblChave);
            this.Controls.Add(this.lblTricornio);
            this.Controls.Add(this.lblPistola);
            this.Controls.Add(this.lblFaca);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lblEsqueleto);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lblGarrafa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblJogador);
            this.Controls.Add(this.lblJogadorAtual);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblJogador;
        private System.Windows.Forms.Timer tmrPrincipal;
        private System.Windows.Forms.Label lblJogadorAtual;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblPistola;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblFaca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEsqueleto;
        private System.Windows.Forms.Label lblTricornio;
        private System.Windows.Forms.Label lblChave;
        private System.Windows.Forms.Label lblGarrafa;
        private System.Windows.Forms.Panel pnlTabuleiro;
    }
}