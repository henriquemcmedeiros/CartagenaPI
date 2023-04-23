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

namespace PICartagena
{
    public partial class Form2 : Form
    {
        Partida partida = new Partida();
        Jogador jogador = new Jogador();
        List<Piratas> piratas = new List<Piratas> { };
        public Form2(Partida partida, Jogador jogador)
        {
            InitializeComponent();

            this.partida = partida;
            this.jogador = jogador;

            jogador.ReceberCartas();
            AtualizarQntCartas();
            IniciarTabuleiro();
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
            Dictionary<int, string> tabuleiro = new Dictionary<int, string>();
            string[] linhas = Jogo.ExibirTabuleiro(partida.Id).Replace("\r", "").Split('\n');

            int i = 0;

            foreach (string linha in linhas)
            {
                if (linha != "")
                {
                    string ultimoElemento = linha[linha.Length - 1].ToString();
                    tabuleiro.Add(i, ultimoElemento);
                }
                i++;
            }
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            string carta = txtCarta.Text;
            string posPirata = txtPosicaoPirata.Text;

            if (posPirata == "")
            {
                piratas = jogador.Jogar(partida, piratas, carta);
            }
            else
            {
                piratas = jogador.Jogar(partida, piratas, carta, Convert.ToInt32(posPirata));
            }
            //for(int i = 0; i < 38*5; i++)
            //{
            //    lblJogadorAtual.Text = piratas[i].ToString();
            //}

            //AtualizarQntCartas();
        }

        private void lblFaca_Click(object sender, EventArgs e)
        {

        }
    }
}
