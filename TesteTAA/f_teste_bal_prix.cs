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
    public partial class f_teste_bal_prix : Form
    {
        public f_teste_bal_prix()
        {
            InitializeComponent();
        }

        private void cb_porta_bal_mag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void f_teste_bal_prix_Load(object sender, EventArgs e)
        {
            int cont = 1;
            while (cont < 20)
            {
                PortaBalPrix.PortName = "COM" + cont;
                try
                {
                    PortaBalPrix.Open();
                    if (PortaBalPrix.IsOpen)
                    {
                        cb_porta_bal_prix.Items.Add("COM" + cont);
                    }
                }
                catch
                {
                    
                }
                PortaBalPrix.Close();
                cont++;
            }
        }

        private void bt_ok_bal_prix_Click(object sender, EventArgs e)
        {
            if (cb_porta_bal_prix.Text != "")
            {
                PortaBalPrix.PortName = cb_porta_bal_prix.Text;
                PortaBalPrix.DataBits = 7;
                PortaBalPrix.BaudRate = 9600;
            }
            else
            {
                MessageBox.Show("Informe a porta que o equipamento está conectado!");
            }
            
        }

        private void bt_pesar_bal_prix_Click(object sender, EventArgs e)
        {
            try
            {
                int intBytes = 6;  //porta.BytesToRead;

                byte[] bytes = new byte[intBytes];

                PortaBalPrix.ReadTimeout = 500;
                PortaBalPrix.Open();
                PortaBalPrix.WriteLine("\x05");
                PortaBalPrix.Read(bytes, 0, intBytes);
                lbl_peso_bal_prix.Text = PortaBalPrix.ReadExisting();
                PortaBalPrix.DiscardOutBuffer();
                PortaBalPrix.DiscardInBuffer();
                PortaBalPrix.Close();
            }
            catch
            {
                PortaBalPrix.Close();
            }
        }

        private void bt_sair_bal_prix_Click(object sender, EventArgs e)
        {
            if (PortaBalPrix.IsOpen)
            {
                PortaBalPrix.Close();
            }
            Global.balMagPortaAux = cb_porta_bal_prix.Text;
            validacao_bal_prix vbp = new validacao_bal_prix();
            vbp.Show();
            this.Close();
        }
    }
}
