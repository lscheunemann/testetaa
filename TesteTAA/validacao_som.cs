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
    public partial class validacao_som : Form
    {
        public validacao_som()
        {
            InitializeComponent();
        }

        private void bt_som_sim_Click(object sender, EventArgs e)
        {
            Global.som_ok = true;
            this.Close();
        }

        private void bt_som_nao_Click(object sender, EventArgs e)
        {
            Global.som_ok = false;
            gb_som_obs.Visible = true;
            bt_som_nao.Enabled = false;
            bt_som_sim.Enabled = false;
            OnScreenKeyboard.Show();
            text_som.Focus();

            
        }

        private void bt_som_prix_Click(object sender, EventArgs e)
        {
            if (OnScreenKeyboard.IsOpened())
            {
                OnScreenKeyboard.Close();
            }
            Global.som_obs = text_som.Text;
            this.Close();
        }

        private void text_som_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
