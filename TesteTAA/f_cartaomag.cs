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
    public partial class f_cartaomag : Form
    {
        public f_cartaomag()
        {
            InitializeComponent();
        }

        private void text_cartaomag_Leave(object sender, EventArgs e)
        {
            gb_validacao_cartaomag.Visible = true;
        }

        private void text_cartaomag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                SendKeys.Send("{TAB}");
        }

        private void f_cartaomag_Load(object sender, EventArgs e)
        {
            text_cartaomag.Focus();
        }

        private void bt_leitor_sim_Click(object sender, EventArgs e)
        {
            Global.cartaomag_ok = true;
            this.Close();
        }

        private void bt_leitor_nao_Click(object sender, EventArgs e)
        {
            Global.cartaomag_ok = false;
            bt_leitor_nao.Enabled = false;
            bt_leitor_sim.Enabled = false;
            text_lcm.Visible = true;
            bt_enviar_lcm.Visible = true;
            text_lcm.Focus();
            var processes = Process.GetProcessesByName("TabTip");
            foreach (var p in processes)
                p.Kill();

            Process.Start(new ProcessStartInfo { UseShellExecute = true, FileName = @"C:\Program Files\Common Files\microsoft shared\ink\TabTip.exe" });
        }

        private void bt_enviar_lcm_Click(object sender, EventArgs e)
        {
            Global.cartaomag_obs = text_lcm.Text;
            this.Close();
        }
    }
}
