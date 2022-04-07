using Osklib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteTAA
{
    public partial class validacao_bal_mag : Form
    {
        public validacao_bal_mag()
        {
            InitializeComponent();
        }

        private void bt_bal_mag_sim_Click(object sender, EventArgs e)
        {
            Global.balMag_ok = true;
            Global.balMagPorta = Global.balMagPortaAux;
            this.Close();
        }

        private void bt_bal_mag_nao_Click(object sender, EventArgs e)
        {
            Global.balMag_ok = false;
            gb_bal_mag_obs.Visible = true;
            bt_bal_mag_nao.Enabled = false;
            bt_bal_mag_sim.Enabled = false;

            text_obs_bal_mag.Focus();

            OnScreenKeyboard.Show();
        }

        private void bt_enviar_bal_mag_Click(object sender, EventArgs e)
        {
            if (OnScreenKeyboard.IsOpened())
            {
                OnScreenKeyboard.Close();
            }
            Global.balMag_obs = text_obs_bal_mag.Text;
            this.Close();
        }

        private void gb_bal_mag_obs_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
