using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteTAA
{
    public partial class f_teste_sinalizacao : Form
    {
        public f_teste_sinalizacao()
        {
            InitializeComponent();
        }

        private void f_teste_sinalizacao_Load(object sender, EventArgs e)
        {
            int cont = 1;
            while (cont < 20)
            {
                PortaSinalizacao.PortName = "COM" + cont;
                try
                {
                    PortaSinalizacao.Open();
                    if (PortaSinalizacao.IsOpen)
                    {
                        cb_porta_sin.Items.Add("COM" + cont);
                    }
                }
                catch
                {

                }
                PortaSinalizacao.Close();
                cont++;
            }
        }

        private void bt_ok_sin_Click(object sender, EventArgs e)
        {
            PortaSinalizacao.PortName = cb_porta_sin.Text;

        }

        private void bt_verde_Click(object sender, EventArgs e)
        {
            try
            {
                PortaSinalizacao.Open();
                if (bt_verde.Text == "LIGAR")
                {
                    PortaSinalizacao.Write("\x02\x43\x36\x31\x31\x30\x30\x30\x30\x03");
                    bt_verde.Text = "DESLIGAR";
                    bt_piscaverde.Enabled = false;
                }
                else
                {
                    PortaSinalizacao.Write("\x02\x43\x36\x31\x30\x30\x30\x30\x30\x03");
                    bt_verde.Text = "LIGAR";
                    bt_piscaverde.Enabled = true;
                }

                PortaSinalizacao.Close();
            }
            catch
            {
                MessageBox.Show("Porta inválida!", "Erro");

            }
        }

        private void bt_amarelo_Click(object sender, EventArgs e)
        {
            try
            {
                PortaSinalizacao.Open();
                if (bt_amarelo.Text == "LIGAR")
                {
                    PortaSinalizacao.Write("\x02\x43\x36\x32\x31\x30\x30\x30\x30\x03");
                    bt_amarelo.Text = "DESLIGAR";
                    bt_piscaamarelo.Enabled = false;
                }
                else
                {
                    PortaSinalizacao.Write("\x02\x43\x36\x32\x30\x30\x30\x30\x30\x03");
                    bt_amarelo.Text = "LIGAR";
                    bt_piscaamarelo.Enabled = true;
                }

                PortaSinalizacao.Close();
            }
            catch
            {
                MessageBox.Show("Porta inválida!", "Erro");

            }
        }

        private void bt_vermelho_Click(object sender, EventArgs e)
        {
            try
            {

                PortaSinalizacao.Open();
                if (bt_vermelho.Text == "LIGAR")
                {
                    PortaSinalizacao.Write("\x02\x43\x36\x33\x31\x30\x30\x30\x30\x03");
                    bt_vermelho.Text = "DESLIGAR";
                    bt_piscavermelho.Enabled = false;
                }
                else
                {
                    PortaSinalizacao.Write("\x02\x43\x36\x33\x30\x30\x30\x30\x30\x03");
                    bt_vermelho.Text = "LIGAR";
                    bt_piscavermelho.Enabled = true;
                }

                PortaSinalizacao.Close();
            }
            catch
            {
                MessageBox.Show("Porta inválida!", "Erro");

            }
        }

        private void bt_piscaverde_Click(object sender, EventArgs e)
        {
            try
            {
                PortaSinalizacao.Open();
                if (bt_piscaverde.Text == "PISCAR")
                {
                    PortaSinalizacao.Write("\x02\x43\x36\x31\x32\x30\x31\x30\x30\x03");
                    bt_piscaverde.Text = "DESLIGAR";
                    bt_verde.Enabled = false;
                }
                else
                {
                    PortaSinalizacao.Write("\x02\x43\x36\x31\x30\x30\x30\x30\x30\x03");
                    bt_piscaverde.Text = "PISCAR";
                    bt_verde.Enabled = true;
                }

                PortaSinalizacao.Close();
            }
            catch
            {
                MessageBox.Show("Porta inválida!", "Erro");

            }
        }

        private void bt_piscaamarelo_Click(object sender, EventArgs e)
        {
            try
            {
                PortaSinalizacao.Open();
                if (bt_piscaamarelo.Text == "PISCAR")
                {
                    PortaSinalizacao.Write("\x02\x43\x36\x32\x32\x30\x31\x30\x30\x03");
                    bt_piscaamarelo.Text = "DESLIGAR";
                    bt_amarelo.Enabled = false;
                }
                else
                {
                    PortaSinalizacao.Write("\x02\x43\x36\x32\x30\x30\x30\x30\x30\x03");
                    bt_piscaamarelo.Text = "PISCAR";
                    bt_amarelo.Enabled = true;
                }

                PortaSinalizacao.Close();
            }
            catch
            {
                MessageBox.Show("Porta inválida!", "Erro");

            }
        }

        private void bt_piscavermelho_Click(object sender, EventArgs e)
        {
            try
            {
                PortaSinalizacao.Open();
                if (bt_piscavermelho.Text == "PISCAR")
                {
                    PortaSinalizacao.Write("\x02\x43\x36\x33\x32\x30\x31\x30\x30\x03");
                    bt_piscavermelho.Text = "DESLIGAR";
                    bt_vermelho.Enabled = false;
                }
                else
                {
                    PortaSinalizacao.Write("\x02\x43\x36\x33\x30\x30\x30\x30\x30\x03");
                    bt_piscavermelho.Text = "PISCAR";
                    bt_vermelho.Enabled = true;
                }

                PortaSinalizacao.Close();
            }
            catch
            {
                MessageBox.Show("Porta inválida!", "Erro");

            }
        }

        private void bt_sair_sin_Click(object sender, EventArgs e)
        {
            if (cb_porta_sin.Text != "")
            {
                PortaSinalizacao.Open();
                PortaSinalizacao.Write("\x02\x43\x36\x31\x30\x30\x30\x30\x30\x03");
                System.Threading.Thread.Sleep(800);
                PortaSinalizacao.Write("\x02\x43\x36\x32\x30\x30\x30\x30\x30\x03");
                System.Threading.Thread.Sleep(800);
                PortaSinalizacao.Write("\x02\x43\x36\x33\x30\x30\x30\x30\x30\x03");
                PortaSinalizacao.Close();
            }
            Global.sinalizacaoPortaAux = cb_porta_sin.Text;
            validacao_sinalizacao vs = new validacao_sinalizacao();
            vs.Show();
            this.Close();
        }
    }
}
