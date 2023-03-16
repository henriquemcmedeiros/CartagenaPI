namespace Exemplo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNome = new System.Windows.Forms.Button();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnFecharPedido = new System.Windows.Forms.Button();
            this.lstBebidas = new System.Windows.Forms.ListBox();
            this.chkViagem = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNome
            // 
            this.btnNome.Location = new System.Drawing.Point(231, 13);
            this.btnNome.Name = "btnNome";
            this.btnNome.Size = new System.Drawing.Size(194, 116);
            this.btnNome.TabIndex = 0;
            this.btnNome.Text = "ola mundo";
            this.btnNome.UseVisualStyleBackColor = true;
            this.btnNome.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtComida
            // 
            this.txtComida.Location = new System.Drawing.Point(12, 62);
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(181, 20);
            this.txtComida.TabIndex = 2;
            this.txtComida.Text = "caixa de texto";
            this.txtComida.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "biriri",
            "pororo",
            "papapa",
            "vavava",
            "valoreco"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnFecharPedido
            // 
            this.btnFecharPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFecharPedido.Location = new System.Drawing.Point(520, 483);
            this.btnFecharPedido.Name = "btnFecharPedido";
            this.btnFecharPedido.Size = new System.Drawing.Size(156, 42);
            this.btnFecharPedido.TabIndex = 4;
            this.btnFecharPedido.Text = "fechar pedido";
            this.btnFecharPedido.UseVisualStyleBackColor = true;
            this.btnFecharPedido.Click += new System.EventHandler(this.btnFecharPedido_Click);
            // 
            // lstBebidas
            // 
            this.lstBebidas.FormattingEnabled = true;
            this.lstBebidas.Items.AddRange(new object[] {
            "coca",
            "pepsi",
            "pspspspsp",
            "miau"});
            this.lstBebidas.Location = new System.Drawing.Point(12, 106);
            this.lstBebidas.Name = "lstBebidas";
            this.lstBebidas.Size = new System.Drawing.Size(120, 95);
            this.lstBebidas.TabIndex = 5;
            // 
            // chkViagem
            // 
            this.chkViagem.AutoSize = true;
            this.chkViagem.BackColor = System.Drawing.Color.Transparent;
            this.chkViagem.Location = new System.Drawing.Point(557, 460);
            this.chkViagem.Name = "chkViagem";
            this.chkViagem.Size = new System.Drawing.Size(80, 17);
            this.chkViagem.TabIndex = 6;
            this.chkViagem.Text = "checkBox1";
            this.chkViagem.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(42, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Pix \r";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Credito";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 72);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(56, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Debito";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(82, 93);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pagamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(308, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(311, 273);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 12;
            this.btnAbrir.Text = "abrakadabra";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(688, 597);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkViagem);
            this.Controls.Add(this.lstBebidas);
            this.Controls.Add(this.btnFecharPedido);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtComida);
            this.Controls.Add(this.btnNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNome;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnFecharPedido;
        private System.Windows.Forms.ListBox lstBebidas;
        private System.Windows.Forms.CheckBox chkViagem;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbrir;
    }
}

