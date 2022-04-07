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
    public partial class validacao_bal_prix : Form
    {
        public validacao_bal_prix()
        {
            InitializeComponent();
        }

        private void bt_bal_prix_sim_Click(object sender, EventArgs e)
        {
            Global.balPrix_ok = true;
            Global.balPrixPorta = Global.balPrixPortaAux;
            this.Close();
        }

        private void bt_bal_prix_nao_Click(object sender, EventArgs e)
        {
            Global.balPrix_ok = false;
            gb_bal_prix_obs.Visible = true;
            bt_bal_prix_nao.Enabled = false;
            bt_bal_prix_sim.Enabled = false;

            text_obs_bal_prix.Focus();

            OnScreenKeyboard.Show();
        }

        private void bt_enviar_bal_prix_Click(object sender, EventArgs e)
        {
            if (OnScreenKeyboard.IsOpened())
            {
                OnScreenKeyboard.Close();
            }
            Global.balPrix_obs = text_obs_bal_prix.Text;
            this.Close();
        }

        private void gb_bal_prix_obs_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
