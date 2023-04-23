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
    public partial class txtNomeDaPartida : Form
    {
        Partida partida = new Partida();
        Jogador jogador = new Jogador();
        public txtNomeDaPartida()
        {
            InitializeComponent();
            //btnListarPartidas_Click(sender, e); listar partidas automaticamente
        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            lstListarPartidas.Items.Clear();
            string ListarPartidas = Jogo.ListarPartidas("A");

            ListarPartidas = ListarPartidas.Replace("\r", "");

            string[] partidas = ListarPartidas.Split('\n');
            for (int i = 0; i < partidas.Length; i++)
            {
                lstListarPartidas.Items.Add(partidas[i]);
            }
        }

        private void btnSelecionarPartida_Click(object sender, EventArgs e)
        {
            try
            {
                string partidaSelecionada = lstListarPartidas.SelectedItem.ToString();
                string[] itens = partidaSelecionada.Split(',');

                partida.Id = Convert.ToInt32(itens[0]);
                partida.Nome = itens[1];
                partida.Data = itens[2];
                partida.status = itens[3];

                lblPartidaIdeNome.Text = $"id: {partida.Id.ToString()} Nome:{partida.Nome}";

                // Exibe os jogadores ns partida
                lblListaJogadores.Text = Jogo.ListarJogadores(partida.Id);
            }
            catch
            {
                MessageBox.Show("Selecione uma partida");
            }
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string nomePartida = txtNomePartida.Text;
            string senhaPartida = txtSenhaPartida.Text;

            string retorno = Jogo.CriarPartida(nomePartida, senhaPartida);

            if (retorno.StartsWith("ERRO"))
            {
                if (nomePartida == "" || retorno == "ERRO: Partida já existente")
                {
                    MessageBox.Show("Nome da partida ja existente ou vazio!");
                }
                else if(senhaPartida == "")
                {
                    MessageBox.Show("Senha da partida vazia!");
                }
            }
            else
                btnListarPartidas_Click(sender, e);
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            jogador.Nome = txtNomeDoJogador.Text;
            jogador.Senha = txtSenhaPartidaLogar.Text;

            string retorno = Jogo.EntrarPartida(partida.Id, jogador.Nome, jogador.Senha);
         
            if (retorno.StartsWith("ERRO"))
            {
                if (jogador.Nome == "" || retorno == "ERRO:Já existe um jogador com este nome na partida\r\n")
                {
                    MessageBox.Show("Nome da jogador já existente ou vazio!");
                }
                else
                {
                    MessageBox.Show("Senha da partida incorreta!");
                }
            }
            else
            {
                string[] divisãoRetorno = retorno.Split(',');
                jogador.Id = Convert.ToInt32(divisãoRetorno[0]);
                jogador.Senha = divisãoRetorno[1];
                jogador.Cor = divisãoRetorno[2];
            }
            lblListaJogadores.Text = Jogo.ListarJogadores(partida.Id);
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            string jogadorInicial = Jogo.IniciarPartida(Convert.ToInt32(jogador.Id), jogador.Senha);

            if (jogadorInicial.StartsWith("ERRO"))
            {
                MessageBox.Show(jogadorInicial);
                MessageBox.Show("A Partida não foi iniciada");
            }
            else
            {
                partida.status = "J";
                Form f2 = new Form2(partida, jogador);
                f2.ShowDialog();
            }
        }
    }
}
