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
    public partial class f_teste_bal_mag : Form
    {
        public f_teste_bal_mag()
        {
            InitializeComponent();
        }

        private void f_teste_bal_mag_Load(object sender, EventArgs e)
        {
            int cont = 1;
            while (cont < 20)
            {
                PortaBalMag.PortName = "COM" + cont;
                try
                {
                    PortaBalMag.Open();
                    if (PortaBalMag.IsOpen)
                    {
                        cb_porta_bal_mag.Items.Add("COM" + cont);
                    }
                }
                catch
                {

                }
                PortaBalMag.Close();
                cont++;
            }
        }

        private void bt_sair_bal_mag_Click(object sender, EventArgs e)
        {
            if (PortaBalMag.IsOpen)
            {
                PortaBalMag.Close();
            }
            Global.balMagPortaAux = cb_porta_bal_mag.Text;
            validacao_bal_mag vbm = new validacao_bal_mag();
            vbm.Show();
            this.Close();
        }

        private void bt_ok_bal_mag_Click(object sender, EventArgs e)
        {
            if (cb_porta_bal_mag.Text != "")
            {
                PortaBalMag.PortName = cb_porta_bal_mag.Text;
                PortaBalMag.DataBits = 7;
                PortaBalMag.BaudRate = 9600;
                PortaBalMag.Parity = System.IO.Ports.Parity.Even;
            }
            else
            {
                MessageBox.Show("Informa a porta que o equipamento está conectado!");
            }
            
        }

        private void cb_porta_bal_mag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_pesar_bal_mag_Click(object sender, EventArgs e)
        {
            try
            {
                int intBytes = 6;  //porta.BytesToRead;

                byte[] bytes = new byte[intBytes];

                PortaBalMag.ReadTimeout = 500;
                PortaBalMag.Open();
                PortaBalMag.WriteLine("\x57");
                PortaBalMag.Read(bytes, 0, intBytes);
                lbl_peso_bal_mag.Text = PortaBalMag.ReadExisting();
                PortaBalMag.DiscardOutBuffer();
                PortaBalMag.DiscardInBuffer();
                PortaBalMag.Close();
            }
            catch
            {
                PortaBalMag.Close();
            }
        }
    }
}
