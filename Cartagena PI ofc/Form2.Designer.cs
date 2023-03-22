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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNomeJogador);
            this.Controls.Add(this.btnConsultarCartas);
            this.Controls.Add(this.lblCartas);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCartas;
        private System.Windows.Forms.Button btnConsultarCartas;
        private System.Windows.Forms.Label lblNomeJogador;
    }
}