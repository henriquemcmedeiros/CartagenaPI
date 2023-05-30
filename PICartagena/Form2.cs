using CartagenaServer;
using Microsoft.Win32;
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
        List<Pirate> listPiratasDesenhados = new List<Pirate>();
        public Form2(Partida partida, Jogador jogador, List<Jogador> jogadores)
        {
            InitializeComponent();

            this.partida = partida;
            this.jogador = jogador;
            this.jogadores = jogadores;

            tmrPrincipal.Start();

            jogador.ReceberCartas();
            AtualizarQntCartas();

            IniciarTabuleiro();
            exibirTabuleiro();

            //MessageBox.Show(Jogo.VerificarVez(partida.Id));
            lblJogadorAtual.Text = VerificarVezCor(jogadores);
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

            string corAtual = VerificarVezCor(jogadores);

            lblJogadorAtual.Text = "É a vez do jogador: " + corAtual;

            exibirPiratas();
            exibirTabuleiro();

            if (corAtual + "\r\n" == jogador.Cor)
            {
                jogador.Estrategia(partida, piratas);
            }
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

                string retornoPiratas = Jogo.VerificarVez(partida.Id);
                this.piratas = jogador.AtualizarPiratas(piratas, retornoPiratas);

                int b = 0;

                this.picPiratas.Clear();

                for (int i = 0; i < this.panelPosTabuleiro.Count; i++)
                {
                    this.panelPosTabuleiro[i].Controls.Clear();
                }

                listPiratasDesenhados.Clear();

                this.pnlTabuleiro.Controls.Clear();

                for (int i = 0; i < this.tabuleiro.Count; i++)
                {
                    // Posição piratas primeira casa
                    int x0 = 12, y0 = 845;
                    
                    // Posição final dos piratas - Barco
                    int xF = 481, yF = 48;

                    int a = 0;

                    for (int j = 0; j < this.piratas.Count; j++)
                    {
                        for (int k = 0; k < this.jogadores.Count; k++)
                        {
                            if (piratas[j].idJogador == jogadores[k].Id)
                            {
                                for (int l = 0; l < piratas[j].qntPiratas; l++)
                                {
                                    PictureBox p = new PictureBox();

                                    int blue = 0;

                                    // Tamanho dos piratas
                                    p.Width = 30;
                                    p.Height = 30;

                                    // Configurações da imagem dos piratas
                                    p.BackgroundImageLayout = ImageLayout.Stretch;
                                    p.BackgroundImage = this.jogadores[k].ImgPirata;
                                    p.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);

                                    if (piratas[j].PosTabuleiro == 0)
                                    {
                                        p.Location = new System.Drawing.Point(x0, y0);
                                        x0 += 32;

                                        if (a == 11 || a == 23)
                                        {
                                            x0 = 12;
                                            y0 += 32;
                                        }
                                        a++;
                                    }
                                    else if (piratas[j].PosTabuleiro == 37)
                                    {
                                        p.Location = new System.Drawing.Point(xF, yF);
                                        xF += 32;

                                        if (a == 5 || a == 11 || a == 17 || a == 23)
                                        {
                                            xF = 481;
                                            yF += 32;
                                        }
                                    }
                                    else
                                    {
                                        int piratasAqui = 0;
                                        int piratasAquiJogador = 0;

                                        /*if (b == 0)
                                        {
                                            // ----- QntPiratasNaPosição Retorna o total de piratas sem distinção da cor
                                            //piratasAqui = QntPiratasNaPosição(piratas, piratas[j].PosTabuleiro);
                                            piratasAquiJogador = QntPiratasNaPosiçãoJogador(piratas, piratas[j].PosTabuleiro, this.jogadores[k]);
                                            b++;
                                        }*/

                                        int x = CalcPirataX(j);
                                        int y = CalcPirataY(j);

                                        Pirate pirataDesenhado = new Pirate();

                                        pirataDesenhado.x = x;
                                        pirataDesenhado.y = y;

                                        foreach (Pirate pirata in listPiratasDesenhados)
                                        {
                                            if (pirataDesenhado.x == pirata.x && pirataDesenhado.y == pirata.y)
                                            {
                                                pirataDesenhado.y += 32;
                                            }
                                        }

                                        listPiratasDesenhados.Add(pirataDesenhado);

                                        p.Location = new System.Drawing.Point(pirataDesenhado.x, pirataDesenhado.y);
                                    }

                                    if (blue < 6)
                                    {
                                        this.picPiratas.Add(p);
                                        pnlTabuleiro.Controls.Add(p);
                                        blue++;
                                    }
                                }

                                break;
                            }
                        }
                    }

                    listPiratasDesenhados.Clear();
                }
            }
            catch
            {
                MessageBox.Show("ERRO na exibição dos personagens");
            }
        }


        private List<Jogador> atualizarImgPiratas(List<Jogador> jogadores)
        {
            foreach (Jogador jogador in jogadores)
            {
                if (jogador.Cor.Equals("Vermelho"))
                {
                    jogador.ImgPirata = PICartagena.Properties.Resources.vermelho;
                    jogador.colorPirata = System.Drawing.Color.FromArgb(152, 28, 12);
                }

                if (jogador.Cor.Equals("Azul"))
                {
                    jogador.ImgPirata = PICartagena.Properties.Resources.azul;
                    jogador.colorPirata = System.Drawing.Color.FromArgb(12, 135, 152);
                }

                if (jogador.Cor.Equals("Amarelo"))
                {
                    jogador.ImgPirata = PICartagena.Properties.Resources.amarelo;
                    jogador.colorPirata = System.Drawing.Color.FromArgb(228, 220, 36);
                }

                if (jogador.Cor.Equals("Verde"))
                {
                    jogador.ImgPirata = PICartagena.Properties.Resources.verde;
                    jogador.colorPirata = System.Drawing.Color.FromArgb(12, 148, 25);
                }
            }

            return jogadores;
        }

        private int QntPiratasNaPosiçãoJogador(List<Pirata> piratas, int pos, Jogador jogador)
        {
            int qntPiratas = 0;
            foreach (Pirata p in piratas)
            {
                if (p.PosTabuleiro == pos && jogador.Id == p.idJogador)
                {
                    qntPiratas += p.qntPiratas;
                }
            }
            return qntPiratas;
        }

        private string VerificarVezCor(List<Jogador> jogadores)
        {
            string[] VerificaVezETabuleiro = Jogo.VerificarVez(partida.Id).Replace("\r", "").Split('\n');
            string[] PrimeiraLinhaVerificaVez = VerificaVezETabuleiro[0].Split(',');

            string corDoJogadorAtual = "ERRO! Cor não encontrada";

            foreach (Jogador jo in jogadores)
            {
                if (jo.Id == Convert.ToInt32(PrimeiraLinhaVerificaVez[1]))
                {
                    corDoJogadorAtual = jo.Cor;
                }
            }

            return corDoJogadorAtual;
        }

        private int CalcPirataX(int j)
        {
            int x = 501;
            for (int m = 1; m < piratas[j].PosTabuleiro; m++)
            {
                if (piratas[j].PosTabuleiro > 1)
                {
                    if ((m < 3) || (m > 9 && m < 15) || (m > 21 && m < 27) || (m > 33))
                    {
                        x += 128;
                    }
                    else if ((m > 3 && m < 9) || (m > 15 && m < 21) || (m > 27 && m < 33))
                    {
                        x -= 128;
                    }
                }
            }
            return x;
        }
        
        private int CalcPirataY(int j)
        {
            int y = 842;
            for (int m = 1; m < piratas[j].PosTabuleiro; m++)
            {
                if (piratas[j].PosTabuleiro > 1)
                {
                    if ((m == 3) || (m == 9) || (m == 15) || (m == 21) || (m == 27) || (m == 33))
                    {
                        y -= 128;
                    }
                }
            }
            //if (piratasDesenhados != 1)
            //{
            //    if (piratasDesenhados == 2)
            //    {
            //        y += 32;
            //    }
            //    else if (piratasDesenhados == 3)
            //    {
            //        y += 64;
            //    }
            //}

            return y;
        }
    }

}