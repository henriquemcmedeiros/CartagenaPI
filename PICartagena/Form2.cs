using CartagenaServer;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

            lblJogador.Text = "A sua cor é: " + jogador.Cor;
            lblJogadorAtual.Text = "É a vez do jogador: " + VerificarVezCor(jogadores);
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
                for (int i = 0; i < 3 ; i++)
                {
                    jogador.Estrategia(partida, piratas);
                }
            }
        }

        private void exibirTabuleiro()
        {
            try
            {
                // X e Y da posição 1
                int x = 329, y = 674;
               
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
                    p.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);

                    p.BackgroundImageLayout = ImageLayout.Zoom;

                    this.panelPosTabuleiro.Add(p);

                    if (i >= 1)
                    {
                        if (i < 3 || (i > 9 && i < 15) || (i > 21 && i < 27) || i > 33)
                        {
                            x += 97;
                        }

                        if ((i > 3 && i < 9) || (i > 15 && i < 21) || (i > 27 && i < 33))
                        {
                            x -= 97;
                        }

                        if (i == 3 || i == 9 || i == 15 || i == 21 || i == 27 || i == 33)
                        {
                            y -= 100;
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
                MessageBox.Show("NãO FOI POSSÍVEL EXIBIR O TABULEIRO");
            }
        }
        private List<Elemento> atualizarImgPosicoes(List<Elemento> l)
        {
            foreach (Elemento t in l)
            {
                t.W = 64;
                t.H = 64;

                if (t.Simbolo == "C")
                {
                    t.Img = PICartagena.Properties.Resources.ElementoCHA;
                }

                if (t.Simbolo == "E")
                {
                    t.Img = PICartagena.Properties.Resources.ElementoESQ;
                }

                if (t.Simbolo == "F")
                {
                    t.Img = PICartagena.Properties.Resources.ElementoFAC;
                }

                if (t.Simbolo == "T")
                {
                    t.Img = PICartagena.Properties.Resources.ElementoTRI ;
                }

                if (t.Simbolo == "P")
                {
                    t.Img = PICartagena.Properties.Resources.ElementoPIS;
                }

                if (t.Simbolo == "G")
                {
                    t.Img = PICartagena.Properties.Resources.ElementoGAR;
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

                this.picPiratas.Clear();

                for (int i = 0; i < this.panelPosTabuleiro.Count; i++)
                {
                    this.panelPosTabuleiro[i].Controls.Clear();
                }

                listPiratasDesenhados.Clear();

                this.pnlTabuleiro.Controls.Clear();

                for (int i = 0; i < this.tabuleiro.Count; i++)
                {
                    // Posição inicial dos piratas - Caverna
                    int x0 = 100, y0 = 655;
                    
                    // Posição final dos piratas - Barco
                    int xF = 381, yF = 48;

                    int countPiratasPos = 0;

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
                                    p.Width = 22;
                                    p.Height = 22;

                                    // Configurações da imagem dos piratas
                                    p.BackgroundImageLayout = ImageLayout.Stretch;
                                    p.BackgroundImage = this.jogadores[k].ImgPirata;
                                    p.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);

                                    if (piratas[j].PosTabuleiro == 0)
                                    {
                                        p.Location = new System.Drawing.Point(x0, y0);
                                        x0 += p.Width + 2;

                                        if (countPiratasPos == 11 || countPiratasPos == 23)
                                        {
                                            x0 = 100;
                                            y0 += p.Width + 10;
                                        }
                                        countPiratasPos++;
                                    }
                                    else if (piratas[j].PosTabuleiro == 37)
                                    {
                                        p.Location = new System.Drawing.Point(xF, yF);
                                        xF += p.Width + 10;

                                        if (countPiratasPos == 5 || countPiratasPos == 11 || countPiratasPos == 17 || countPiratasPos == 23)
                                        {
                                            xF = 48;
                                            yF += p.Width + 10;
                                        }
                                        countPiratasPos++;
                                    }
                                    else
                                    {
                                        int x = CalcPirataX(j);
                                        int y = CalcPirataY(j);

                                        Pirate pirataDesenhado = new Pirate();

                                        pirataDesenhado.x = x;
                                        pirataDesenhado.y = y;

                                        foreach (Pirate pirata in listPiratasDesenhados)
                                        {
                                            if (pirataDesenhado.x == pirata.x && pirataDesenhado.y == pirata.y)
                                            {
                                                pirataDesenhado.y += p.Width + 10;
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
            int x = 392;
            for (int m = 1; m < piratas[j].PosTabuleiro; m++)
            {
                if (piratas[j].PosTabuleiro > 1)
                {
                    if ((m < 3) || (m > 9 && m < 15) || (m > 21 && m < 27) || (m > 33))
                    {
                        x += 98;
                    }
                    else if ((m > 3 && m < 9) || (m > 15 && m < 21) || (m > 27 && m < 33))
                    {
                        x -= 98;
                    }
                }
            }
            return x;
        }
        
        private int CalcPirataY(int j)
        {
            int y = 655;
            for (int m = 1; m < piratas[j].PosTabuleiro; m++)
            {
                if (piratas[j].PosTabuleiro > 1)
                {
                    if ((m == 3) || (m == 9) || (m == 15) || (m == 21) || (m == 27) || (m == 33))
                    {
                        y -= 98;
                    }
                }
            }

            return y;
        }
    }

}