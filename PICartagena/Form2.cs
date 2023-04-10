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
        Dictionary<int, int> piratas;
        public Form2(Partida partida, Jogador jogador)
        {
            InitializeComponent();

            this.partida = partida;
            this.jogador = jogador;

            jogador.ReceberCartas();
            AtualizarQntCartas();
            IniciarTabuleiro();

            InicializarPiratas();

            MessageBox.Show(Jogo.VerificarVez(partida.Id));
        }

        public void InicializarPiratas() {
            for (int i = 0; i < 6; i++) 
            {
                piratas.Add(i, 0);
            }
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

            jogador.Jogar(partida, piratas, carta, 0);
        }
    }
}
