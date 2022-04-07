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
    public partial class f_teste_leitor_2d : Form
    {
        public f_teste_leitor_2d()
        {
            InitializeComponent();
        }

        private void f_teste_leitor_2d_Load(object sender, EventArgs e)
        {
            text_codigo_2d.Focus();
        }

        private void text_codigo_2d_Leave(object sender, EventArgs e)
        {
            gb_validacao_leitor_2d.Visible = true;
        }

        private void text_codigo_2d_Enter(object sender, EventArgs e)
        {
           
        }

        private void gb_validacao_leitor_2d_Enter(object sender, EventArgs e)
        {

        }

        private void text_codigo_2d_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                SendKeys.Send("{TAB}");
        }

        private void bt_bal_mag_sim_Click(object sender, EventArgs e)
        {
            Global.leitor_2d_ok = true;
            this.Close();
        }

        private void bt_bal_mag_nao_Click(object sender, EventArgs e)
        {
            Global.leitor_2d_ok = false;
            bt_bal_ldd_nao.Enabled = false;
            bt_bal_ldd_sim.Enabled = false;
            text_ldd.Visible = true;
            bt_enviar_ldd.Visible = true;
            text_ldd.Focus();
            var processes = Process.GetProcessesByName("TabTip");
            foreach (var p in processes)
                p.Kill();

            Process.Start(new ProcessStartInfo { UseShellExecute = true, FileName = @"C:\Program Files\Common Files\microsoft shared\ink\TabTip.exe" });
        }

        private void bt_enviar_ldd_Click(object sender, EventArgs e)
        {
            Global.leitor_2d_obs = text_ldd.Text;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
