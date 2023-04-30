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
        string[] tabuleiro = new string[38];

        List<Pirata> piratas = new List<Pirata> { };
        List<Panel> panelPosTabuleiro;
        public Form2(Partida partida, Jogador jogador)
        {
            InitializeComponent();

            this.partida = partida;
            this.jogador = jogador;

            tmrPrincipal.Start();

            jogador.ReceberCartas();
            AtualizarQntCartas();

            IniciarTabuleiro();

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
                    string ultimoElemento = linha[linha.Length - 1].ToString();
                    tabuleiro[i] =  ultimoElemento;
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
                int x = 284, y = 586;
               
                this.tabuleiro = atualizarImgPosicoes(this.tabuleiro);

                for (int i = 0; i < this.panelPosTabuleiro.Count; i++)
                {
                    panelTabuleiro.Controls.Remove(this.panelPosTabuleiro[i]);
                }

                this.panelPosTabuleiro.Clear();
                for (int i = 0; i < this.tabuleiro.Count; i++)
                {
                    this.tabuleiro[i].X = x;
                    this.tabuleiro[i].Y = y;

                    if (i == 0)
                    {
                        this.tabuleiro[i].X = 3;
                        this.tabuleiro[i].Y = 569;
                    }

                    Panel p = new Panel();

                    p.Location = new System.Drawing.Point(this.tabuleiro[i].X, this.tabuleiro[i].Y);
                    p.Width = this.tabuleiro[i].W;
                    p.Height = this.tabuleiro[i].H;
                    p.BackgroundImage = this.tabuleiro[i].Img;

                    if (i == 0)
                    {
                        p.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        p.BackgroundImageLayout = ImageLayout.Zoom;
                    }

                    this.panelPosTabuleiro.Add(p);

                    if (i >= 1)
                    {
                        if (i < 3)
                        {
                            x += 89;
                        }

                        if (i > 3 && i < 9)
                        {
                            x -= 89;
                        }

                        if (i > 9 && i < 15)
                        {
                            x += 89;
                        }

                        if (i > 15 && i < 21)
                        {
                            x -= 89;
                        }

                        if (i > 21 && i < 27)
                        {
                            x += 89;
                        }

                        if (i > 27 && i < 33)
                        {
                            x -= 89;
                        }

                        if (i > 33)
                        {
                            x += 89;
                        }

                        if (i == 36)
                        {
                            y = 0;
                        }

                        if (i == 3 || i == 9 || i == 15 || i == 21 || i == 27 || i == 33)
                        {
                            y -= 94;
                        }
                    }
                }

                for (int i = 0; i < this.panelPosTabuleiro.Count; i++)
                {
                    panelTabuleiro.Controls.Add(this.panelPosTabuleiro[i]);
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
                t.W = 53;
                t.H = 53;

                if (t.Posicao == 0)
                {
                    t.W = 259;
                    t.H = 88;
                    t.Img = Cartagena.Properties.Resources.areia;
                }

                if (t.Posicao == 37)
                {
                    t.W = 255;
                    t.H = 95;
                    t.Img = Cartagena.Properties.Resources.barco;
                }

                if (t.Simbolo == "P")
                {
                    t.Img = Cartagena.Properties.Resources.pistola;
                }

                if (t.Simbolo == "E")
                {
                    t.Img = Cartagena.Properties.Resources.esqueleto;
                }

                if (t.Simbolo == "C")
                {
                    t.Img = Cartagena.Properties.Resources.chave;
                }

                if (t.Simbolo == "F")
                {
                    t.Img = Cartagena.Properties.Resources.faca;
                }

                if (t.Simbolo == "G")
                {
                    t.Img = Cartagena.Properties.Resources.garrafa;
                }

                if (t.Simbolo == "T")
                {
                    t.Img = Cartagena.Properties.Resources.tricornio;
                }
            }

            return l;
        }

    }
}
