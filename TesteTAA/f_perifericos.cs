using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteTAA
{
    public partial class f_perifericos : Form
    {
        public f_perifericos()
        {
            InitializeComponent();
        }

        private void f_perifericos_Load(object sender, EventArgs e)
        {
            Global.contadorbtn = 0;
            if (Global.sel_bkc310 || Global.sel_bkt6112 || Global.sel_it433 || Global.sel_star || Global.sel_tmt20 || Global.sel_tmt88)
            {
                bt_impressora.Enabled = true;
                bt_impressora.Visible = true;
                Global.contadorbtn++;
            }

            if (Global.sel_gertec || Global.sel_ingenico)
            {
                bt_pinpad.Enabled = true;
                bt_pinpad.Visible = true;
                Global.contadorbtn++;
            }

            if (Global.sel_bal_mag)
            {
                bt_bal_mag.Enabled = true;
                bt_bal_mag.Visible = true;
                Global.contadorbtn++;
            }

            if (Global.sel_bal_prix)
            {
                bt_bal_prix.Enabled = true;
                bt_bal_prix.Visible = true;
                Global.contadorbtn++;
            }

            if (Global.sel_cm3680)
            {
                bt_leitor_2d.Enabled = true;
                bt_leitor_2d.Visible = true;
                Global.contadorbtn++;
            }

            if (Global.sel_feixe1d)
            {
                bt_leitor_1d.Enabled = true;
                bt_leitor_1d.Visible = true;
                Global.contadorbtn++;
            }

            if (Global.sel_leitor_mag)
            {
                bt_leitor_mag.Enabled = true;
                bt_leitor_mag.Visible = true;
                Global.contadorbtn++;
            }

            if (Global.sel_touch)
            {
                bt_touch.Enabled = true;
                bt_touch.Visible = true;
                Global.contadorbtn++;
            }

            if (Global.sel_sinalizacao)
            {
                bt_sinalizacao.Enabled = true;
                bt_sinalizacao.Visible = true;
                Global.contadorbtn++;
            }

            if (Global.sel_webcam)
            {
                bt_webcam.Enabled = true;
                bt_webcam.Visible = true;
                Global.contadorbtn++;
            }

            if (Global.sel_som)
            {
                bt_som.Enabled = true;
                bt_som.Visible = true;
                Global.contadorbtn++;
            }

            if (Global.sel_cartaomag)
            {
                bt_cartaomag.Enabled = true;
                bt_cartaomag.Visible = true;
                Global.contadorbtn++;
            }
            
        }

        private void bt_fim_Click(object sender, EventArgs e)
        {
            if (Global.vSom == false)
            {
                Global.contadorbtn--;
            }
            bt_som.BackColor = Color.SkyBlue;
            Global.vSom = true;
            Global.clic_som = true;
            f_teste_som fts = new f_teste_som();
            fts.Show();
        }

        private void bt_impressora_Click(object sender, EventArgs e)
        {
            if (Global.vImpressora == false)
            {
                Global.contadorbtn--;
            }
            using (var printDocument = new System.Drawing.Printing.PrintDocument())
            {
                printDocument.PrintPage += printDocument_PrintPage;
                printDocument.Print();
                printDocument.Print();
                printDocument.Print();
                printDocument.Print();
                printDocument.Print();
                Thread.Sleep(10000);
            }

            bt_impressora.BackColor = Color.SkyBlue;
            Global.vImpressora = true;
            Global.clic_impressora = true;
            validacao_impressora vi = new validacao_impressora();
            vi.Show();

        }

        void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            /// Verifica qual a impressora selecionada ////////////////////
            string nomeImpressora = "0";
            if (Global.sel_bkc310)
            {
                nomeImpressora = "SNBC BK-C310";
            }
            if (Global.sel_bkt6112)
            {
                nomeImpressora = "SNBC BK-T6112";
            }
            if (Global.sel_it433)
            {
                nomeImpressora = "Diebold IT-433";
            }
            if (Global.sel_star)
            {
                nomeImpressora = "StarTUP 900";
            }
            if (Global.sel_tmt20)
            {
                nomeImpressora = "Epson TM-T20";
            }
            if (Global.sel_tmt88)
            {
                nomeImpressora = "Epson TM-T88V";
            }
            ///////////////////////////////////////////////////////////////



            var printDocument = sender as System.Drawing.Printing.PrintDocument;
            DateTime agora = DateTime.Now;
            string texto = "TESTE IMPRESSORA\nModelo: " + nomeImpressora + " \n" + agora + "\n\n0123456789\nabcdefghijklmnopqrstuvxywz\nABCDEFGHIJKLMNOPQRSTUVXYWZ\n'!@#$%¨&*()_-=+:<>,.^~{}[]`´ªº\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n################################################################################################################################################################################################################################################################\n****************************************************************************************************************************************************************************************\n\n\n\n\n fim do teste";
            if (printDocument != null)
            {
                using (var font = new Font("Arial", 12))
                using (var brush = new SolidBrush(Color.Black))
                {
                    e.Graphics.DrawString(
                        texto,
                        font,
                        brush,
                        new RectangleF(0, 0, printDocument.DefaultPageSettings.PrintableArea.Width, printDocument.DefaultPageSettings.PrintableArea.Height));
                }
            }
        }

        

        private void bt_pinpad_Click(object sender, EventArgs e)
        {
            if (Global.vPinpad == false)
            {
                Global.contadorbtn--;
            }
            bt_pinpad.BackColor = Color.SkyBlue;
            Global.vPinpad = true;
            Global.clic_pinpad = true;

            if (Global.sel_gertec)
            {
                System.Diagnostics.Process.Start("SAGAT");
                validacao_pinpad vp = new validacao_pinpad();
                vp.Show();
            }
            else
            {
                MessageBox.Show("Módulo em desenvolvimento");
            }

        }

        private void bt_bal_mag_Click(object sender, EventArgs e)
        {
            if (Global.vBalMag == false)
            {
                Global.contadorbtn--;
            }
            bt_bal_mag.BackColor = Color.SkyBlue;
            Global.vBalMag = true;
            Global.clic_bal_mag = true;
            f_teste_bal_mag bm = new f_teste_bal_mag();
            bm.Show();
        }

        private void bt_bal_prix_Click(object sender, EventArgs e)
        {
            if (Global.vBalPrix == false)
            {
                Global.contadorbtn--;
            }
            bt_bal_prix.BackColor = Color.SkyBlue;
            Global.vBalPrix = true;
            Global.clic_bal_prix = true;
            f_teste_bal_prix bp = new f_teste_bal_prix();
            bp.Show();
        }

        private void bt_leitor_2d_Click(object sender, EventArgs e)
        {
            if (Global.vLeitor2d == false)
            {
                Global.contadorbtn--;
            }
            bt_leitor_2d.BackColor = Color.SkyBlue;
            Global.vLeitor2d = true;
            Global.clic_leitor = true;
            f_teste_leitor_2d ldd = new f_teste_leitor_2d();
            ldd.Show();
        }

        private void bt_leitor_1d_Click(object sender, EventArgs e)
        {
            if (Global.vLeitor1d == false)
            {
                Global.contadorbtn--;
            }
            bt_leitor_1d.BackColor = Color.SkyBlue;
            Global.vLeitor1d = true;
            Global.clic_leitor = true;
            f_teste_leitor_2d lud = new f_teste_leitor_2d();
            lud.Show();
        }

        private void bt_leitor_mag_Click(object sender, EventArgs e)
        {
            if (Global.vLeitorMag == false)
            {
                Global.contadorbtn--;
            }
            bt_leitor_mag.BackColor = Color.SkyBlue;
            Global.vLeitorMag = true;
            Global.clic_leitor_mag = true;
            f_teste_leitor_mag tlm = new f_teste_leitor_mag();
            tlm.Show();
        }

        private void bt_touch_Click(object sender, EventArgs e)
        {
            if (Global.vTouch == false)
            {
                Global.contadorbtn--;
            }
            bt_touch.BackColor = Color.SkyBlue;
            Global.vTouch = true;
            Global.clic_touch = true;
            f_teste_touch tt = new f_teste_touch();
            tt.Show();
        }

        private void bt_sinalizacao_Click(object sender, EventArgs e)
        {
            if (Global.vSinalizacao == false)
            {
                Global.contadorbtn--;
            }
            bt_sinalizacao.BackColor = Color.SkyBlue;
            Global.vSinalizacao = true;
            Global.clic_sinalizacao = true;
            f_teste_sinalizacao ts = new f_teste_sinalizacao();
            ts.Show();
        }

        private void bt_webcam_Click(object sender, EventArgs e)
        {
            if (Global.vWebcam == false)
            {
                Global.contadorbtn--;
            }
            bt_webcam.BackColor = Color.SkyBlue;
            Global.vWebcam = true;
            Global.clic_webcam = true;
            f_teste_webcam twb = new f_teste_webcam();
            twb.Show();
        }

        private void bt_questionario_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            f_questionario fq = new f_questionario();
            fq.Show();
                        
       
        }

        private void system(string v)
        {
            throw new NotImplementedException();
        }

        private void bt_cartaomag_Click(object sender, EventArgs e)
        {
            if (Global.vCartaomag == false)
            {
                Global.contadorbtn--;
            }
            bt_cartaomag.BackColor = Color.SkyBlue;
            Global.vCartaomag = true;
            Global.clic_cartaomag = true;
            f_cartaomag fcm = new f_cartaomag();
            fcm.Show();
        }

        private void bt_finalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
