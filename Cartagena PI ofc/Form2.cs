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
        public Form2(Globals globais)
        {
            InitializeComponent();
            this.globais = globais;
        }
        private void btnConsultarCartas_Click(object sender, EventArgs e)
        {
            string cartas = Jogo.ConsultarMao(Convert.ToInt32(globais.Jogador[0]), globais.Jogador[1]);
            lblCartas.Text = cartas;
            lblNomeJogador.Text = globais.Jogador[2].Replace("\r\n", "");
        }
    }
}
