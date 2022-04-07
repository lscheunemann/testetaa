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
    public partial class validacao_pinpad : Form
    {
        public validacao_pinpad()
        {
            InitializeComponent();
        }

        private void bt_imp_sim_Click(object sender, EventArgs e)
        {
            Global.pinpad_ok = true;
            this.Close();
        }

        private void bt_pinpad_nao_Click(object sender, EventArgs e)
        {
            bt_pinpad_nao.Enabled = false;
            bt_pinpad_sim.Enabled = false;
            gb_pinpad_obs.Visible = true;
            OnScreenKeyboard.Show();
            text_obs_pinpad.Focus();
        }

        private void bt_enviar_imp_Click(object sender, EventArgs e)
        {
            if (OnScreenKeyboard.IsOpened())
            {
                OnScreenKeyboard.Close();
            }
            Global.pinpad_obs = text_obs_pinpad.Text;
            Global.pinpad_ok = false;
            this.Close();
        }
    }
}
