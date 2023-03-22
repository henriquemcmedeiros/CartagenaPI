using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartagenaServer;

namespace Cartagena_PI_ofc
{
    public partial class Form1 : Form
    {
        // Inicializa os componentes do formulário
        public Form1()
        {
            InitializeComponent();
        }

        int idPartida;

        //Lista as partidas abertas dentro da ListBox
        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            string ListarPartidas = Jogo.ListarPartidas("T");

            ListarPartidas = ListarPartidas.Replace("\r", "");

            string[] partidas = ListarPartidas.Split('\n');
            for (int i = 0; i < partidas.Length; i++)
            {
                // Lista apenas as partidas abertas
                string[] statusPartida = partidas[i].Split(',');
                if (statusPartida[3] == "A")
                {
                    lstEscolhaPartida.Items.Add(partidas[i]);
                }
            }  
        }

        private void btnSelecionarPartida_Click(object sender, EventArgs e)
        {
            string partida = lstEscolhaPartida.SelectedItem.ToString();
            string[] itens = partida.Split(',');

            idPartida = Convert.ToInt32(itens[0]);
            string nomePartida = itens[1];
            string dataPartida = itens[2];
            string status = itens[3];

            lblEntrarPartida.Text = $"id: {idPartida.ToString()} \nNome:{nomePartida}";

            // Exibe os jogadores ns partida
            lblJogadores.Text = Jogo.ListarJogadores(idPartida);
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string nomePartida = txtNomePartida.Text;
            string senhaPartida = txtSenhaPartida.Text;

            string retorno = Jogo.CriarPartida(nomePartida, senhaPartida);
            lblCriarPartida.Text = retorno;
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            string retorno = Jogo.EntrarPartida(idPartida, usuario, senha);

            if (retorno.StartsWith("ERRO"))
            {
                lblLogar.Text = "Não foi possivel entrar na partida\nVerifique se o usuário já existe e se a senha está correta";
            }
            else
            {
                string[] corJogador = retorno.Split(',');
                lblLogar.Text = $"A cor de {usuario} é {corJogador[2]}";
            }

        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            string[] jogadores = Jogo.ListarJogadores(idPartida).Split('\n');
            string[] idJogador1 = jogadores[1].Split(',');

            if (jogadores.Length >= 2) {
                string jogadorInicial = Jogo.IniciarPartida(Convert.ToInt32(idJogador1[0]), txtSenhaPartida.Text);
                lblIniciar.Text = $"O Jogador: {jogadorInicial} inicia.";
                Form f2 = new Form2();
                f2.ShowDialog();
            }
        }
    }
}
