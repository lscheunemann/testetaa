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
    public partial class f_principal : Form
    {
        private object global;

        public f_principal()
        {
            InitializeComponent();
        }

        private void gb_perifericos_Enter(object sender, EventArgs e)
        {

        }

        private void cb_ingenico_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ingenico.Checked)
            {
                cb_gertec.Checked = false;
            }
        }

        private void cb_diebold_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_diebold.Checked)
            {
                cb_bkt6112.Checked = false;
                cb_bkc310.Checked = false;
                cb_startup900.Checked = false;
                cb_tmt20.Checked = false;
                cb_tmt88.Checked = false;
            }
        }

        private void cb_sinalização_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_1d_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gb_impressora_Enter(object sender, EventArgs e)
        {
            
        }

        private void cb_bkc310_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_bkc310.Checked)
            {
                cb_bkt6112.Checked = false;
                cb_diebold.Checked = false;
                cb_startup900.Checked = false;
                cb_tmt20.Checked = false;
                cb_tmt88.Checked = false;
            }
        }

        private void cb_bkt6112_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_bkt6112.Checked)
            {
                cb_bkc310.Checked = false;
                cb_diebold.Checked = false;
                cb_startup900.Checked = false;
                cb_tmt20.Checked = false;
                cb_tmt88.Checked = false;
            }
        }

        private void cb_startup900_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_startup900.Checked)
            {
                cb_bkt6112.Checked = false;
                cb_diebold.Checked = false;
                cb_bkc310.Checked = false;
                cb_tmt20.Checked = false;
                cb_tmt88.Checked = false;
            }
        }

        private void cb_tmt20_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_tmt20.Checked)
            {
                cb_bkt6112.Checked = false;
                cb_diebold.Checked = false;
                cb_startup900.Checked = false;
                cb_bkc310.Checked = false;
                cb_tmt88.Checked = false;
            }
        }

        private void cb_tmt88_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_tmt88.Checked)
            {
                cb_bkt6112.Checked = false;
                cb_diebold.Checked = false;
                cb_startup900.Checked = false;
                cb_tmt20.Checked = false;
                cb_bkc310.Checked = false;
            }
        }

        private void cb_gertec_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_gertec.Checked)
            {
                cb_ingenico.Checked = false;
            }
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_iniciar_Click(object sender, EventArgs e)
        {
            if (OnScreenKeyboard.IsOpened())
            {
                OnScreenKeyboard.Close();
            }

            if (cb_bkc310.Checked)
            {
                Global.sel_bkc310 = true;
            }
            if (cb_bkt6112.Checked)
            {
                Global.sel_bkt6112 = true;
            }
            if (cb_diebold.Checked)
            {
                Global.sel_it433 = true;
            }
            if (cb_startup900.Checked)
            {
                Global.sel_star = true;
            }
            if (cb_tmt20.Checked)
            {
                Global.sel_tmt20 = true;
            }
            if (cb_tmt88.Checked)
            {
                Global.sel_tmt88 = true;
            }

            if (cb_gertec.Checked)
            {
                Global.sel_gertec = true;
            }
            if (cb_ingenico.Checked)
            {
                Global.sel_ingenico = true;
            }

            if (cb_balmag.Checked)
            {
                Global.sel_bal_mag = true;
            }
            if (cb_prix.Checked)
            {
                Global.sel_bal_prix = true;
            }

            if (cb_2d.Checked)
            {
                Global.sel_cm3680 = true;
            }
            if (cb_1d.Checked)
            {
                Global.sel_feixe1d = true;
            }

            if (cb_magellan.Checked)
            {
                Global.sel_leitor_mag = true;
            }

            if (cb_touch.Checked)
            {
                Global.sel_touch = true;
            }
            if (cb_sinalização.Checked)
            {
                Global.sel_sinalizacao = true;
            }
            if (cb_webcam.Checked)
            {
                Global.sel_webcam = true;
            }
            if (cb_som.Checked)
            {
                Global.sel_som = true;
            }
            if (cb_cartaomag.Checked)
            {
                Global.sel_cartaomag = true;
            }
            
                if (OnScreenKeyboard.IsOpened())
                {
                    OnScreenKeyboard.Close();
                }
                
                bt_iniciar.Enabled = false;
                f_perifericos fperifericos = new f_perifericos();
                fperifericos.Show();
           
            
            

        }

        private void cb_fabrica_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_campo_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void text_ns_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_ns_Click(object sender, EventArgs e)
        {
            OnScreenKeyboard.Show();
        }

        private void text_op_Click(object sender, EventArgs e)
        {
            OnScreenKeyboard.Show();
        }

        private void text_nome_Click(object sender, EventArgs e)
        {
            OnScreenKeyboard.Show();
        }

        private void cb_2d_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
