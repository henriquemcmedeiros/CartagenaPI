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

namespace Cartagena_PI_ofc
{
    public partial class Form2 : Form
    {
        public Globals globais;
        int[] posisaoPirata = { 0, 0, 0, 0, 0, 0 };
        int[] voltarPirata = { 0, 0, 0, 0, 0, 0 };
        public Form2(Globals globais)
        {
            InitializeComponent();
            this.globais = globais;
        }
        private void btnConsultarCartas_Click(object sender, EventArgs e)
        {
            globais.cartas = Jogo.ConsultarMao(Convert.ToInt32(globais.Jogador[0]), globais.Jogador[1]);
            lblCartas.Text = globais.cartas;
            lblNomeJogador.Text = globais.Jogador[2].Replace("\r\n", "");
            lblTabuleiro.Text = Jogo.ExibirTabuleiro(globais.idPartida);

            //MessageBox.Show(Jogo.ExibirTabuleiro(globais.idPartida));
        }

        private void btnJogarCarta_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Jogo.VerificarVez(globais.idPartida));
            string[] verificarPartida = Jogo.VerificarVez(globais.idPartida).Split(',');

            //if ()


            string cartaJogada = txtJogarCarta.Text;
            string[] tabuleiro = Jogo.ExibirTabuleiro(globais.idPartida).Split('\n');
            int pirataEscolhido = Convert.ToInt32(nmbPirataEscolhido.Value);

            string[] VARIAVELLEGAL = Jogo.ExibirTabuleiro(globais.idPartida).Replace("\n", "").Split('\r');
            string posiçãoDoPirataJogado = "0";
            string position;

            if (cartaJogada == "" && pirataEscolhido == 0)
            {
                // Pular a vez
                Jogo.Jogar(Convert.ToInt32(globais.Jogador[0]), globais.Jogador[1]);
                lblStatus.Text = "Você pulou a vez";
            }
            else
            {
                if (cartaJogada == "")
                {
                    // Voltar pirata
                    Jogo.Jogar(Convert.ToInt32(globais.Jogador[0]), globais.Jogador[1], posisaoPirata[pirataEscolhido]);

                    for (int i = 0; i < posisaoPirata.Length; i++)
                    {
                        if (posisaoPirata[i] < posisaoPirata[pirataEscolhido])
                        {
                            voltarPirata[i] = posisaoPirata[i];
                        }
                    }
                    int pirataAnterior = voltarPirata.Max(i => i);

                    posisaoPirata[pirataEscolhido] = pirataAnterior;

                    lblStatus.Text = $"Você voltou o pirata para a posição {posisaoPirata[pirataEscolhido]}";
                }
                else
                {
                    // Jogar Carta
                    Jogo.Jogar(Convert.ToInt32(globais.Jogador[0]), globais.Jogador[1], posisaoPirata[pirataEscolhido], cartaJogada);

                    for (int i = 0; i + posisaoPirata[pirataEscolhido] < VARIAVELLEGAL.Length; i++)
                    {
                        if (VARIAVELLEGAL[i].EndsWith(cartaJogada))
                        {
                            posiçãoDoPirataJogado = VARIAVELLEGAL[i];
                            break;
                        }
                    }

                    position = posiçãoDoPirataJogado.Substring(0, 1);

                    posisaoPirata[pirataEscolhido] = Convert.ToInt32(position);
                    lblStatus.Text = $"Você jogou a carta {cartaJogada} na posição {posisaoPirata[pirataEscolhido]}";
                }
                lblTabuleiro.Text = Jogo.ExibirTabuleiro(globais.idPartida);
            }
        }
    }
}
