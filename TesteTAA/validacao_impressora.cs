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
    public partial class validacao_impressora : Form
    {
        public validacao_impressora()
        {
            InitializeComponent();
        }

        private void bt_imp_nao_Click(object sender, EventArgs e)
        {
            bt_imp_nao.Enabled = false;
            bt_imp_sim.Enabled = false;
            gb_imp_obs.Visible = true;

            OnScreenKeyboard.Show();

            text_obs_imp.Focus();
        }

        private void bt_imp_sim_Click(object sender, EventArgs e)
        {
            Global.impressora_ok = true;
            this.Close();
        }

        private void bt_enviar_imp_Click(object sender, EventArgs e)
        {
            if (OnScreenKeyboard.IsOpened())
            {
                OnScreenKeyboard.Close();
            }
            Global.impressora_obs = text_obs_imp.Text;
            Global.pinpad_ok = false;
            this.Close();
        }

        private void gb_imp_obs_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void text_obs_imp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
