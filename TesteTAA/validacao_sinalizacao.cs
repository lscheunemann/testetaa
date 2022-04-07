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
    public partial class validacao_sinalizacao : Form
    {
        public validacao_sinalizacao()
        {
            InitializeComponent();
        }

        private void bt_sin_sim_Click(object sender, EventArgs e)
        {
            Global.sinalizacao_ok = true;
            Global.sinalizacaoPorta = Global.sinalizacaoPortaAux;
            this.Close();
        }

        private void bt_sin_nao_Click(object sender, EventArgs e)
        {
            Global.sinalizacao_ok = false;
            bt_sin_nao.Enabled = false;
            bt_sin_sim.Enabled = false;
            gb_sin_obs.Visible = true;

            text_obs_sin.Focus();

            OnScreenKeyboard.Show();
        }

        private void bt_enviar_sin_Click(object sender, EventArgs e)
        {
            if (OnScreenKeyboard.IsOpened())
            {
                OnScreenKeyboard.Close();
            }
            Global.sinalizacao_obs = text_obs_sin.Text;
            this.Close();
        }
    }
}
