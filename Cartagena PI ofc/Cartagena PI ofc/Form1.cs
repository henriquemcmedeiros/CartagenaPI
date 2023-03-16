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
        public Form1()
        {
            InitializeComponent();
        }

        int idPartida;

        private void button1_Click(object sender, EventArgs e)
        {
            string ListarPartidas = Jogo.ListarPartidas("T");
            lblListarPartidas.Text = ListarPartidas;

            ListarPartidas = ListarPartidas.Replace("\r", "");

            string[] partidas = ListarPartidas.Split('\n');
            for (int i = 0; i < partidas.Length; i++)
            {
                lstEscolhaPartida.Items.Add(partidas[i]);
            }  
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            string partida = lstEscolhaPartida.SelectedItem.ToString();
            string[] itens = partida.Split(',');

            idPartida = Convert.ToInt32(itens[0]);
            string nomePartida = itens[1];
            string dataPartida = itens[2];
            string status = itens[3];

            lblEntrarPartida.Text = $"id: {idPartida.ToString()} \nNome:{nomePartida}";        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string nomePartida = txtNomePartida.Text;
            string senhaPartida = txtSenhaPartida.Text;

            string retorno = Jogo.CriarPartida(nomePartida, "123");
            lblCriarPartida.Text = retorno;
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            string retorno = Jogo.EntrarPartida(idPartida, usuario, senha);
            lblLogar.Text = retorno;

        }
    }
}
