using CartagenaServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PICartagena
{
    public partial class Form2 : Form
    {
        Partida partida = new Partida();
        Jogador jogador = new Jogador();

        List<Elemento> tabuleiro = new List<Elemento>();
        List<Pirata> piratas = new List<Pirata> { };
        List<Panel> panelPosTabuleiro = new List<Panel>();
        List<Jogador> jogadores = new List<Jogador>();
        List<PictureBox> picPiratas = new List<PictureBox>();
        public Form2(Partida partida, Jogador jogador)
        {
            InitializeComponent();

            this.partida = partida;
            this.jogador = jogador;

            tmrPrincipal.Start();

            jogador.ReceberCartas();
            AtualizarQntCartas();

            IniciarTabuleiro();
            exibirTabuleiro();

            //MessageBox.Show(Jogo.VerificarVez(partida.Id));
        }

        public void AtualizarQntCartas()
        {
            lblChave.Text = jogador.cartasMao.chaveQnt.ToString();
            lblEsqueleto.Text = jogador.cartasMao.esqueletoQnt.ToString();
            lblFaca.Text = jogador.cartasMao.facaQnt.ToString();
            lblGarrafa.Text = jogador.cartasMao.garrafaQnt.ToString();
            lblPistola.Text = jogador.cartasMao.pistolaQnt.ToString();
            lblTricornio.Text = jogador.cartasMao.tricornioQnt.ToString();
        }

        public void IniciarTabuleiro()
        {
            string[] linhas = Jogo.ExibirTabuleiro(partida.Id).Replace("\r", "").Split('\n');

            int i = 0;

            foreach (string linha in linhas)
            {
                if (linha != "")
                {
                    Elemento auxiliar = new Elemento();
                    string ultimoElemento = linha[linha.Length - 1].ToString();
                    auxiliar.Simbolo = ultimoElemento;
                    tabuleiro.Add(auxiliar);
                }
                i++;
            }
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            string carta = txtCarta.Text;
            string posPirata = txtPosicaoPirata.Text;

            if (carta == "" &&  posPirata == "")
            {
                // Pular vez
                piratas = jogador.Jogar(partida, piratas);
            }
            else if (posPirata == "")
            {
                // Voltar pirata
                piratas = jogador.Jogar(partida, piratas, carta);
            }
            else
            {
                // Avançar pirata
                piratas = jogador.Jogar(partida, piratas, carta, Convert.ToInt32(posPirata));
            }
        }

        private void tmrPrincipal_Tick(object sender, EventArgs e)
        {
            jogador.ReceberCartas();
            AtualizarQntCartas();
        }

        private void exibirTabuleiro()
        {
            try
            {
                // X e Y da posição 1
                int x = 439, y = 865;
               
                this.tabuleiro = atualizarImgPosicoes(this.tabuleiro);

                for (int i = 0; i < this.panelPosTabuleiro.Count; i++)
                {
                    pnlTabuleiro.Controls.Remove(this.panelPosTabuleiro[i]);
                }

                this.panelPosTabuleiro.Clear();

                for (int i = 1; i < this.tabuleiro.Count - 1; i++)
                {
                    this.tabuleiro[i].X = x;
                    this.tabuleiro[i].Y = y;

                    // Posição 0 do tabuleiro

                   /* if (i == 0)
                    {
                        this.tabuleiro[i].X = 3;
                        this.tabuleiro[i].Y = 569;
                    } */

                    Panel p = new Panel();

                    p.Location = new System.Drawing.Point(this.tabuleiro[i].X, this.tabuleiro[i].Y);
                    p.Width = this.tabuleiro[i].W;
                    p.Height = this.tabuleiro[i].H;
                    p.BackgroundImage = this.tabuleiro[i].Img;

                    p.BackgroundImageLayout = ImageLayout.Zoom;

                    this.panelPosTabuleiro.Add(p);

                    if (i >= 1)
                    {
                        if (i < 3 || (i > 9 && i < 15) || (i > 21 && i < 27) || i > 33)
                        {
                            x += 128;
                        }

                        if ((i > 3 && i < 9) || (i > 15 && i < 21) || (i > 27 && i < 33))
                        {
                            x -= 128;
                        }

                        if (i == 3 || i == 9 || i == 15 || i == 21 || i == 27 || i == 33)
                        {
                            y -= 128;
                        }
                    }
                }

                for (int i = 0; i < this.panelPosTabuleiro.Count; i++)
                {
                    pnlTabuleiro.Controls.Add(this.panelPosTabuleiro[i]);
                }
            }
            catch
            {
                MessageBox.Show("DEU N");
            }
        }
        private List<Elemento> atualizarImgPosicoes(List<Elemento> l)
        {
            foreach (Elemento t in l)
            {
                t.W = 72;
                t.H = 72;

                if (t.Simbolo == "C")
                {
                    t.Img = PICartagena.Properties.Resources.ChaveE;
                }

                if (t.Simbolo == "E")
                {
                    t.Img = PICartagena.Properties.Resources.EsqueletoE;
                }

                if (t.Simbolo == "F")
                {
                    t.Img = PICartagena.Properties.Resources.FacaE;
                }

                if (t.Simbolo == "T")
                {
                    t.Img = PICartagena.Properties.Resources.TricorinioE;
                }

                if (t.Simbolo == "P")
                {
                    t.Img = PICartagena.Properties.Resources.PistolaE;
                }

                if (t.Simbolo == "G")
                {
                    t.Img = PICartagena.Properties.Resources.GarrafaE;
                }
            }

            return l;
        }

        private void exibirPiratas()
        {
            try
            {
                this.jogadores = atualizarImgPiratas(this.jogadores);

                this.picPiratas.Clear();

                for (int i = 0; i < this.panelPosTabuleiro.Count; i++)
                {
                    this.panelPosTabuleiro[i].Controls.Clear();
                }

                for (int i = 0; i < this.tabuleiro.Count; i++)
                {
                    int x = 25, y = 0;
                    int x0 = 4, y0 = 18;
                    int xF = 57, yF = 0;

                    for (int j = 0; j < this.piratas.Count; j++)
                    {
                        PictureBox p = new PictureBox();
                        p.Width = 18;
                        p.Height = 18;
                        p.BackgroundImageLayout = ImageLayout.Stretch;
                        p.BackgroundImage = this.tabuleiro[i].Piratas[j].Jogador.ImgPirata;

                        if (i == 0)
                        {
                            p.Location = new System.Drawing.Point(x0, y0);
                            x0 += 20;

                            if (j == 11 || j == 23)
                            {
                                x0 = 4;
                                y0 += 22;
                            }
                        }
                        else if (i == 37)
                        {
                            p.Location = new System.Drawing.Point(xF, yF);
                            xF += 20;

                            if (j == 5 || j == 11 || j == 17 || j == 23)
                            {
                                xF = 57;
                                yF += 18;
                            }
                        }
                        else
                        {
                            p.Location = new System.Drawing.Point(x, y);
                            y += 18;
                        }

                        this.picPiratas.Add(p);
                        panelPosTabuleiro[i].Controls.Add(p);
                    }

                }

            }
            catch
            {
                MessageBox.Show("ERRO na exibição dos personagens");
            }
        }


        private List<Jogador> atualizarImgPiratas(List<Jogador> j)
        {
            foreach (Jogador jo in j)
            {
                if (jo.Cor.Equals("Vermelho"))
                {
                    jo.ImgPirata = Cartagena.Properties.Resources.vermelho;
                    jo.ColorPirata = System.Drawing.Color.FromArgb(152, 28, 12);
                }

                if (jo.Cor.Equals("Azul"))
                {
                    jo.ImgPirata = Cartagena.Properties.Resources.azul;
                    jo.ColorPirata = System.Drawing.Color.FromArgb(12, 135, 152);
                }

                if (jo.Cor.Equals("Amarelo"))
                {
                    jo.ImgPirata = Cartagena.Properties.Resources.amarelo;
                    jo.ColorPirata = System.Drawing.Color.FromArgb(228, 220, 36);
                }

                if (jo.Cor.Equals("Verde"))
                {
                    jo.ImgPirata = Cartagena.Properties.Resources.verde;
                    jo.ColorPirata = System.Drawing.Color.FromArgb(12, 148, 25);
                }

                if (jo.Cor.Equals("Marrom"))
                {
                    jo.ImgPirata = Properties.Resources.marrom;
                    jo.ColorPirata = System.Drawing.Color.FromArgb(76, 4, 4);
                }
            }

            return j;
        }
    }
}
