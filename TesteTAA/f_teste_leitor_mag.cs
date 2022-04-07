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
    public partial class f_teste_leitor_mag : Form
    {
        public f_teste_leitor_mag()
        {
            InitializeComponent();
        }

        private void f_teste_leitor_mag_Load(object sender, EventArgs e)
        {
            int cont = 1;
            while (cont < 20)
            {
                PortaLeitorMag.PortName = "COM" + cont;
                try
                {
                    PortaLeitorMag.Open();
                    if (PortaLeitorMag.IsOpen)
                    {
                        cb_porta_leitor_mag.Items.Add("COM" + cont);
                    }
                }
                catch
                {

                }
                PortaLeitorMag.Close();
                cont++;
            }
        }

        private void bt_ok_leitor_mag_Click(object sender, EventArgs e)
        {
            try
            {
                PortaLeitorMag.PortName = cb_porta_leitor_mag.Text;

                PortaLeitorMag.DataBits = 8;
                PortaLeitorMag.BaudRate = 9600;

                PortaLeitorMag.Open();

                lbl_texto.Text = "Passe um código de barras no leitor";

                PortaLeitorMag.ReadByte();
                lbl_leitor_ok.Text = PortaLeitorMag.ReadExisting();

                PortaLeitorMag.Close();

                if (lbl_leitor_ok.Text != "")
                {
                    lbl_leitor_ok.Text = "Leitor OK!";
                }
                else
                {
                    lbl_leitor_ok.Text = "Leitor NÃO OK!";
                }
            }
            catch
            {

            }
        }

        private void bt_bal_prix_Click(object sender, EventArgs e)
        {
            if (PortaLeitorMag.IsOpen)
            {
                PortaLeitorMag.Close();
            }
            if (lbl_leitor_ok.Text == "Leitor OK!")
            {
                Global.leitorMag_ok = true;
                Global.leitorMagPorta = cb_porta_leitor_mag.Text;
                this.Close();
            }
            else
            {
                Global.leitorMag_ok = false;
                this.Close();
            }
        }
    }
}
