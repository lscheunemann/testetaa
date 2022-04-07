using Osklib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Security.Principal;
//using System.ComponentModel;
//using System.IDisposable;



namespace TesteTAA
{


    public partial class f_questionario : Form
    {
        public f_questionario()
        {
            InitializeComponent();
        }

        private void cb_1_sim_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_1_sim.Checked)
            {
                cb_1_nao.Checked = false;
            }
            
        }

        private void cb_1_nao_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_1_nao.Checked)
            {
                cb_1_sim.Checked = false;
            }
            
        }

        private void cb_2_sim_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_2_sim.Checked)
            {
                cb_2_nao.Checked = false;
            }
        }

        private void cb_2_nao_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_2_nao.Checked)
            {
                cb_2_sim.Checked = false;
            }
        }

        private void cb_3_sim_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_3_sim.Checked)
            {
                cb_3_nao.Checked = false;
            }
        }

        private void cb_3_nao_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_3_nao.Checked)
            {
                cb_3_sim.Checked = false;
            }
        }

        private void cb_4_sim_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_4_sim.Checked)
            {
                cb_4_nao.Checked = false;
            }
        }

        private void cb_4_nao_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_4_nao.Checked)
            {
                cb_4_sim.Checked = false;
            }
        }

        private void cb_5_sim_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_5_sim.Checked)
            {
                cb_5_nao.Checked = false;
            }
        }

        private void cb_5_nao_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_5_nao.Checked)
            {
                cb_5_sim.Checked = false;
            }
        }

        private void cb_6_sim_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_6_sim.Checked)
            {
                cb_6_nao.Checked = false;
            }
        }

        private void cb_6_nao_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_6_nao.Checked)
            {
                cb_6_sim.Checked = false;
            }
        }

        private void cb_7_sim_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_7_sim.Checked)
            {
                cb_7_nao.Checked = false;
            }
        }

        private void cb_7_nao_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_7_nao.Checked)
            {
                cb_7_sim.Checked = false;
            }
        }

        private void cb_8_sim_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_8_sim.Checked)
            {
                cb_8_nao.Checked = false;
            }
        }

        private void cb_8_nao_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_8_nao.Checked)
            {
                cb_8_sim.Checked = false;
            }
        }

        private void cb_9_sim_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_9_sim.Checked)
            {
                cb_9_nao.Checked = false;
            }
        }

        private void cb_9_nao_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_9_nao.Checked)
            {
                cb_9_sim.Checked = false;
            }
        }

        private void cb_10_sim_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_10_sim.Checked)
            {
                cb_10_nao.Checked = false;
            }
        }

        private void cb_10_nao_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_10_nao.Checked)
            {
                cb_10_sim.Checked = false;
            }
        }

      

        private void f_questionario_Load(object sender, EventArgs e)
        {

        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            Global.q1 = false;
            Global.q2 = false;
            Global.q3 = false;
            Global.q4 = false;
            Global.q5 = false;
            Global.q6 = false;
            Global.q7 = false;
            Global.q8 = false;
            Global.q9 = false;
            Global.q10 = false;
            Global.obs_final = "";
            this.Close();
        }

        private void text_obs_fim_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_obs_fim_Click(object sender, EventArgs e)
        {
            OnScreenKeyboard.Show();
        }

        void printRel_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var printRel = sender as System.Drawing.Printing.PrintDocument;
            DateTime agora2 = DateTime.Now;
            //// RELATORIO ////////////////////////////////////////////////////////////////////////////
            string textoRel = "";
            /// Variaveis do relatório //////////////////////////////////////////////////////////////////

            string rq1 = "";
            string rq2 = "";
            string rq3 = "";
            string rq4 = "";
            string rq5 = "";
            string rq6 = "";
            string rq7 = "";
            string rq8 = "";
            string rq9 = "";
            string rq10 = "";

            if (Global.q1)
            {
                rq1 = "SIM";
            }
            else
            {
                rq1 = "NÃO";
            }
            if (Global.q2)
            {
                rq2 = "SIM";
            }
            else
            {
                rq2 = "NÃO";
            }
            if (Global.q3)
            {
                rq3 = "SIM";
            }
            else
            {
                rq3 = "NÃO";
            }
            if (Global.q4)
            {
                rq4 = "SIM";
            }
            else
            {
                rq4 = "NÃO";
            }
            if (Global.q5)
            {
                rq5 = "SIM";
            }
            else
            {
                rq5 = "NÃO";
            }
            if (Global.q6)
            {
                rq6 = "SIM";
            }
            else
            {
                rq6 = "NÃO";
            }
            if (Global.q7)
            {
                rq7 = "SIM";
            }
            else
            {
                rq7 = "NÃO";
            }
            if (Global.q8)
            {
                rq8 = "SIM";
            }
            else
            {
                rq8 = "NÃO";
            }
            if (Global.q9)
            {
                rq9 = "SIM";
            }
            else
            {
                rq9 = "NÃO";
            }
            if (Global.q10)
            {
                rq10 = "SIM";
            }
            else
            {
                rq10 = "NÃO";
            }
            /////////////////////////////////////////////////////////////////////////////////////////////



            textoRel += "INSPEÇÃO DE SAÍDA/CAMPO\n";
            textoRel += "NS TAA: " + text_ns.Text + "\n";
            textoRel += "Nº OP: " + text_op.Text + "\n";
            textoRel += "CLIENTE: " + text_cliente.Text + "\n";
            textoRel += "DATA/HORA: " + agora2 + "\n\n\n";
            textoRel += "*** PERIFÉRICOS TESTADOS ***\n";
            if (Global.sel_bkc310 || Global.sel_bkt6112 || Global.sel_it433 || Global.sel_star || Global.sel_tmt20 || Global.sel_tmt88)
            {
                if (Global.impressora_ok)
                {
                    textoRel += "Impressora OK\n";
                }
                else
                {
                    textoRel += "Impressora NÃO OK\n";
                }
            }
            if (Global.sel_gertec)
            {
                if (Global.pinpad_ok)
                {
                    textoRel += "PINPad OK\n";
                }
                else
                {
                    textoRel += "PINPad NÃO OK\n";
                }
            }
            if (Global.sel_cm3680 || Global.sel_feixe1d)
            {
                if (Global.leitor_2d_ok)
                {
                    textoRel += "Leitor de Barras OK\n";
                }
                else
                {
                    textoRel += "Leitor de Barras NÃO OK\n";
                }
            }
            if (Global.sel_leitor_mag)
            {
                if (Global.leitorMag_ok)
                {
                    textoRel += "Leitor Magellan OK\n";
                }
                else
                {
                    textoRel += "Leitor Magellan NÃO OK\n";
                }
            }
            if (Global.sel_bal_mag)
            {
                if (Global.balMag_ok)
                {
                    textoRel += "Balança Magellan OK\n";
                }
                else
                {
                    textoRel += "Balança Magellan NÃO OK\n";
                }
            }
            if (Global.sel_bal_prix)
            {
                if (Global.balPrix_ok)
                {
                    textoRel += "Balança Toledo Prix OK\n";
                }
                else
                {
                    textoRel += "Balança Toledo Prix NÃO OK\n";
                }
            }
            if (Global.sel_touch)
            {
                if (Global.touch_ok)
                {
                    textoRel += "Touchscreen OK\n";
                }
                else
                {
                    textoRel += "Touchscreen NÃO OK\n";
                }
            }
            if (Global.sel_sinalizacao)
            {
                if (Global.sinalizacao_ok)
                {
                    textoRel += "Sinalização OK\n";
                }
                else
                {
                    textoRel += "Sinalização NÃO OK\n";
                }
            }
            if (Global.sel_webcam)
            {
                if (Global.webcam_ok)
                {
                    textoRel += "Web Cam OK\n";
                }
                else
                {
                    textoRel += "Web Cam NÃO OK\n";
                }
            }
            if (Global.sel_som)
            {
                if (Global.som_ok)
                {
                    textoRel += "Som OK\n";
                }
                else
                {
                    textoRel += "Som NÃO OK\n";
                }
            }
            if (Global.sel_cartaomag)
            {
                if (Global.cartaomag_ok)
                {
                    textoRel += "Leitor Cartão OK\n";
                }
                else
                {
                    textoRel += "Leitor Cartão NÃO OK\n";
                }
            }

            textoRel += "\n\n*** QUESTIONÁRIO ***\n";
            textoRel += "1 - A apresentação geral do equipamento está satisfatória (pintura, limpeza, etc)?\n";
            textoRel += "R: " + rq1 + "\n";
            textoRel += "2 - Foi verificado/revisado infraestrutura interna (tomadas, elétrica e lógica)?\n";
            textoRel += "R: " + rq2 + "\n";
            textoRel += "3 - A versão da firmware do PINPad é igual ou superior a 1.08? (marcar não se o totem não possui)\n";
            textoRel += "R: " + rq3 + "\n";
            textoRel += "4 - Foi conferida e testada todas as chaves do equipamento?\n";
            textoRel += "R: " + rq4 + "\n";
            textoRel += "5 - Foi verificado se a bobina está ao alcance do sensor de papel? (válido apenas para SNBC)\n";
            textoRel += "R: " + rq5 + "\n";
            textoRel += "6 - Todos os componentes da placa mãe foram conferidos (pilha da bios, itens desconectados)?\n";
            textoRel += "R: " + rq6 + "\n";
            textoRel += "7 - O terminal ligou e desligou pela chave?\n";
            textoRel += "R: " + rq7 + "\n";
            textoRel += "8 - Foi verificada a integridade do SO (data/hora e drivers da placa)?\n";
            textoRel += "R: " + rq8 + "\n";
            textoRel += "9 - Todos os cabos estão identificados?\n";
            textoRel += "R: " + rq9 + "\n";
            textoRel += "10 - A resolução da tela está adequada?\n";
            textoRel += "R: " + rq10 + "\n\n\n";
            textoRel += "*** OBSERVAÇÕES ***\n";
            if (Global.impressora_obs != "")
            {
                textoRel += "IMPRESSORA: " + Global.impressora_obs + "\n";
            }
            if (Global.pinpad_obs != "")
            {
                textoRel += "PINPAD: " + Global.pinpad_obs + "\n";
            }
            if (Global.leitor_2d_obs != "")
            {
                textoRel += "LEITOR DE BARRAS: " + Global.leitor_2d_obs + "\n";
            }
            if (Global.balMag_obs != "")
            {
                textoRel += "BALANÇA MAGELLAN: " + Global.balMag_obs + "\n";
            }
            if (Global.balPrix_obs != "")
            {
                textoRel += "BALANÇA PRIX: " + Global.balPrix_obs + "\n";
            }
            if (Global.touch_obs != "")
            {
                textoRel += "TOUCHSCREEN: " + Global.touch_obs + "\n";
            }
            if (Global.sinalizacao_obs != "")
            {
                textoRel += "SINALIZAÇÃO: " + Global.sinalizacao_obs + "\n";
            }
            if (Global.webcam_obs != "")
            {
                textoRel += "WEBCAM: " + Global.webcam_obs + "\n";
            }
            if (Global.som_obs != "")
            {
                textoRel += "SOM: " + Global.som_obs + "\n";
            }
            if (Global.cartaomag_obs != "")
            {
                textoRel += "LEITOR CARTÃO: " + Global.cartaomag_obs + "\n";
            }
            if (Global.obs_final != "")
            {
                textoRel += "OBSERVAÇÕES FINAIS: " + Global.obs_final + "\n\n\n";
            }


            textoRel += "\n*** PORTAS ***\n";
            if (Global.sel_leitor_mag)
            {
                textoRel += "Leitor Magellan: " + Global.leitorMagPorta + "\n";
            }
            if (Global.sel_bal_mag)
            {
                textoRel += "Balança Magellan: " + Global.balMagPorta + "\n";
            }
            if (Global.sel_bal_prix)
            {
                textoRel += "Balança Prix: " + Global.balPrixPorta + "\n";
            }
            if (Global.sel_sinalizacao)
            {
                textoRel += "Sinalização: " + Global.sinalizacaoPorta + "\n\n\n";
            }
            textoRel += "*** INFORMAÇÕES DE INSPEÇÃO ***\n";
            textoRel += "Inspecionado por: " + Global.nome + "\n\n\n";
            textoRel += "Ass.:________________________\n\n";
           
                textoRel += "Supervisor produção:\n\n\n";
                textoRel += "Ass.:________________________\n\n\n\n\n...";
            
                textoRel += "\n\n\n\n\n...";
            

            ////////////////////////////////////////////////////////////////////////////////////////////
            if (printRel != null)
            {
                using (var font = new Font("Arial", 11))
                using (var brush = new SolidBrush(Color.Black))
                {
                    e.Graphics.DrawString(
                        textoRel,
                        font,
                        brush,
                        new RectangleF(0, 0, printRel.DefaultPageSettings.PrintableArea.Width, printRel.DefaultPageSettings.PrintableArea.Height));
                }
            }
        }



        private void bt_enviar_Click(object sender, EventArgs e)
        {
            if (OnScreenKeyboard.IsOpened())
            {
                OnScreenKeyboard.Close();
            }
            if ((cb_1_sim.Checked || cb_1_nao.Checked) && (cb_2_sim.Checked || cb_2_nao.Checked) && (cb_3_sim.Checked || cb_3_nao.Checked) && (cb_4_sim.Checked || cb_4_nao.Checked) && (cb_5_sim.Checked || cb_5_nao.Checked) && (cb_6_sim.Checked || cb_6_nao.Checked) && (cb_7_sim.Checked || cb_7_nao.Checked) && (cb_8_sim.Checked || cb_8_nao.Checked) && (cb_9_sim.Checked || cb_9_nao.Checked) && (cb_10_sim.Checked || cb_10_nao.Checked))
            {
                if (cb_1_sim.Checked)
                {
                    Global.q1 = true;
                }
                else
                {
                    Global.q1 = false;
                }
                if (cb_2_sim.Checked)
                {
                    Global.q2 = true;
                }
                else
                {
                    Global.q2 = false;
                }
                if (cb_3_sim.Checked)
                {
                    Global.q3 = true;
                }
                else
                {
                    Global.q3 = false;
                }
                if (cb_4_sim.Checked)
                {
                    Global.q4 = true;
                }
                else
                {
                    Global.q4 = false;
                }
                if (cb_5_sim.Checked)
                {
                    Global.q5 = true;
                }
                else
                {
                    Global.q5 = false;
                }
                if (cb_6_sim.Checked)
                {
                    Global.q6 = true;
                }
                else
                {
                    Global.q6 = false;
                }
                if (cb_7_sim.Checked)
                {
                    Global.q7 = true;
                }
                else
                {
                    Global.q7 = false;
                }
                if (cb_8_sim.Checked)
                {
                    Global.q8 = true;
                }
                else
                {
                    Global.q8 = false;
                }
                if (cb_9_sim.Checked)
                {
                    Global.q9 = true;
                }
                else
                {
                    Global.q9 = false;
                }
                if (cb_10_sim.Checked)
                {
                    Global.q10 = true;
                }
                else
                {
                    Global.q10 = false;
                }
                Global.obs_final = text_obs_fim.Text;
                Global.nome = text_inspecionadopor.Text;


                //////////////////////////////////////////////////////////////////
                if (text_ns.Text == "" || text_op.Text == "" || text_cliente.Text == "" || text_inspecionadopor.Text == "")
                {
                    MessageBox.Show("Inofrmar todos os dados!");
                }
                else
                {
                    ///////relatorios

                    if (Global.contadorbtn == 0)
                    {
                        DateTime agora = DateTime.Now;
                        int ano = agora.Year;
                        int mes = agora.Month;
                        int dia = agora.Day;
                        string nomearquivo = "";
                        int contador = 2;
                        int stop = 0;
                        if (System.IO.File.Exists("log/" + ano + mes + dia + ".txt"))
                        {
                            while (stop == 0)
                            {
                                if (System.IO.File.Exists("log/" + ano + mes + dia + contador + ".txt"))
                                {
                                    contador++;
                                }
                                else
                                {
                                    nomearquivo = "log/" + ano + mes + dia + contador + ".txt";
                                    stop = 1;
                                }
                            }
                        }
                        else
                        {
                            nomearquivo = "log/" + ano + mes + dia + ".txt";
                        }
                        StreamWriter arquivo = new StreamWriter(nomearquivo);

                        /// Variaveis do relatório //////////////////////////////////////////////////////////////////

                        string rq1 = "";
                        string rq2 = "";
                        string rq3 = "";
                        string rq4 = "";
                        string rq5 = "";
                        string rq6 = "";
                        string rq7 = "";
                        string rq8 = "";
                        string rq9 = "";
                        string rq10 = "";

                        if (Global.q1)
                        {
                            rq1 = "SIM";
                        }
                        else
                        {
                            rq1 = "NÃO";
                        }
                        if (Global.q2)
                        {
                            rq2 = "SIM";
                        }
                        else
                        {
                            rq2 = "NÃO";
                        }
                        if (Global.q3)
                        {
                            rq3 = "SIM";
                        }
                        else
                        {
                            rq3 = "NÃO";
                        }
                        if (Global.q4)
                        {
                            rq4 = "SIM";
                        }
                        else
                        {
                            rq4 = "NÃO";
                        }
                        if (Global.q5)
                        {
                            rq5 = "SIM";
                        }
                        else
                        {
                            rq5 = "NÃO";
                        }
                        if (Global.q6)
                        {
                            rq6 = "SIM";
                        }
                        else
                        {
                            rq6 = "NÃO";
                        }
                        if (Global.q7)
                        {
                            rq7 = "SIM";
                        }
                        else
                        {
                            rq7 = "NÃO";
                        }
                        if (Global.q8)
                        {
                            rq8 = "SIM";
                        }
                        else
                        {
                            rq8 = "NÃO";
                        }
                        if (Global.q9)
                        {
                            rq9 = "SIM";
                        }
                        else
                        {
                            rq9 = "NÃO";
                        }
                        if (Global.q10)
                        {
                            rq10 = "SIM";
                        }
                        else
                        {
                            rq10 = "NÃO";
                        }
                        /////////////////////////////////////////////////////////////////////////////////////////////



                        arquivo.WriteLine("INSPEÇÃO DE SAÍDA/CAMPO");
                        arquivo.WriteLine("");
                        arquivo.WriteLine("NS TAA: " + text_ns.Text);
                        arquivo.WriteLine("Nº OP: " + text_op.Text);
                        arquivo.WriteLine("Cliente: " + text_cliente.Text);
                        arquivo.WriteLine("DATA/HORA: " + agora);
                        arquivo.WriteLine("");
                        arquivo.WriteLine("");
                        arquivo.WriteLine("*** PERIFÉRICOS TESTADOS ***");
                        if (Global.sel_bkc310 || Global.sel_bkt6112 || Global.sel_it433 || Global.sel_star || Global.sel_tmt20 || Global.sel_tmt88)
                        {
                            if (Global.impressora_ok)
                            {
                                arquivo.WriteLine("Impressora OK");
                            }
                            else
                            {
                                arquivo.WriteLine("Impressora NÃO OK");
                            }
                        }
                        if (Global.sel_gertec)
                        {
                            if (Global.pinpad_ok)
                            {
                                arquivo.WriteLine("PINPad OK");
                            }
                            else
                            {
                                arquivo.WriteLine("PINPad NÃO OK");
                            }
                        }
                        if (Global.sel_cm3680 || Global.sel_feixe1d)
                        {
                            if (Global.leitor_2d_ok)
                            {
                                arquivo.WriteLine("Leitor de Barras OK");
                            }
                            else
                            {
                                arquivo.WriteLine("Leitor de Barras NÃO OK");
                            }
                        }
                        if (Global.sel_leitor_mag)
                        {
                            if (Global.leitorMag_ok)
                            {
                                arquivo.WriteLine("Leitor Magellan OK");
                            }
                            else
                            {
                                arquivo.WriteLine("Leitor Magellan NÃO OK");
                            }
                        }
                        if (Global.sel_bal_mag)
                        {
                            if (Global.balMag_ok)
                            {
                                arquivo.WriteLine("Balança Magellan OK");
                            }
                            else
                            {
                                arquivo.WriteLine("Balança Magellan NÃO OK");
                            }
                        }
                        if (Global.sel_bal_prix)
                        {
                            if (Global.balPrix_ok)
                            {
                                arquivo.WriteLine("Balança Toledo Prix OK");
                            }
                            else
                            {
                                arquivo.WriteLine("Balança Toledo Prix NÃO OK");
                            }
                        }
                        if (Global.sel_touch)
                        {
                            if (Global.touch_ok)
                            {
                                arquivo.WriteLine("Touchscreen OK");
                            }
                            else
                            {
                                arquivo.WriteLine("Touchscreen NÃO OK");
                            }
                        }
                        if (Global.sel_sinalizacao)
                        {
                            if (Global.sinalizacao_ok)
                            {
                                arquivo.WriteLine("Sinalização OK");
                            }
                            else
                            {
                                arquivo.WriteLine("Sinalização NÃO OK");
                            }
                        }
                        if (Global.sel_webcam)
                        {
                            if (Global.webcam_ok)
                            {
                                arquivo.WriteLine("Web Cam OK");
                            }
                            else
                            {
                                arquivo.WriteLine("Web Cam NÃO OK");
                            }
                        }
                        if (Global.sel_som)
                        {
                            if (Global.som_ok)
                            {
                                arquivo.WriteLine("Som OK");
                            }
                            else
                            {
                                arquivo.WriteLine("Som NÃO OK");
                            }
                        }
                        if (Global.sel_cartaomag)
                        {
                            if (Global.cartaomag_ok)
                            {
                                arquivo.WriteLine("Leitor Cartão OK");
                            }
                            else
                            {
                                arquivo.WriteLine("Leitor Cartão NÃO OK");
                            }
                        }

                        arquivo.WriteLine("");
                        arquivo.WriteLine("");
                        arquivo.WriteLine("*** QUESTIONÁRIO ***");
                        arquivo.WriteLine("1 - A apresentação geral do equipamento está satisfatória (pintura, limpeza, etc)?");
                        arquivo.WriteLine("R: " + rq1);
                        arquivo.WriteLine("2 - Foi verificado/revisado infraestrutura interna (tomadas, elétrica e lógica)?");
                        arquivo.WriteLine("R: " + rq2);
                        arquivo.WriteLine("3 - A versão da firmware do PINPad é igual ou superior a 1.08? (marcar não se o totem não possui)");
                        arquivo.WriteLine("R: " + rq3);
                        arquivo.WriteLine("4 - Foi conferida e testada todas as chaves do equipamento?");
                        arquivo.WriteLine("R: " + rq4);
                        arquivo.WriteLine("5 - Foi verificado se a bobina está ao alcance do sensor de papel? (válido apenas para SNBC)");
                        arquivo.WriteLine("R: " + rq5);
                        arquivo.WriteLine("6 - Todos os componentes da placa mãe foram conferidos (pilha da bios, itens desconectados)?");
                        arquivo.WriteLine("R: " + rq6);
                        arquivo.WriteLine("7 - O terminal ligou e desligou pela chave?");
                        arquivo.WriteLine("R: " + rq7);
                        arquivo.WriteLine("8 - Foi verificada a integridade do SO (data/hora e drivers da placa)?");
                        arquivo.WriteLine("R: " + rq8);
                        arquivo.WriteLine("9 - Todos os cabos estão identificados?");
                        arquivo.WriteLine("R: " + rq9);
                        arquivo.WriteLine("10 - A resolução da tela está adequada?");
                        arquivo.WriteLine("R: " + rq10);
                        arquivo.WriteLine("");
                        arquivo.WriteLine("");
                        arquivo.WriteLine("*** OBSERVAÇÕES ***");
                        if (Global.impressora_obs != "")
                        {
                            arquivo.WriteLine("IMPRESSORA: " + Global.impressora_obs);
                        }
                        if (Global.pinpad_obs != "")
                        {
                            arquivo.WriteLine("PINPAD: " + Global.pinpad_obs);
                        }
                        if (Global.leitor_2d_obs != "")
                        {
                            arquivo.WriteLine("LEITOR DE BARRAS: " + Global.leitor_2d_obs);
                        }
                        if (Global.balMag_obs != "")
                        {
                            arquivo.WriteLine("BALANÇA MAGELLAN: " + Global.balMag_obs);
                        }
                        if (Global.balPrix_obs != "")
                        {
                            arquivo.WriteLine("BALANÇA PRIX: " + Global.balPrix_obs);
                        }
                        if (Global.touch_obs != "")
                        {
                            arquivo.WriteLine("TOUCHSCREEN: " + Global.touch_obs);
                        }
                        if (Global.sinalizacao_obs != "")
                        {
                            arquivo.WriteLine("SINALIZAÇÃO: " + Global.sinalizacao_obs);
                        }
                        if (Global.webcam_obs != "")
                        {
                            arquivo.WriteLine("WEBCAM: " + Global.webcam_obs);
                        }
                        if (Global.som_obs != "")
                        {
                            arquivo.WriteLine("SOM: " + Global.som_obs);
                        }
                        if (Global.cartaomag_obs != "")
                        {
                            arquivo.WriteLine("LEITOR CARTÃO: " + Global.cartaomag_obs);
                        }
                        if (Global.obs_final != "")
                        {
                            arquivo.WriteLine("OBSERVAÇÕES FINAIS: " + Global.obs_final);
                        }


                        arquivo.WriteLine("");
                        arquivo.WriteLine("");
                        arquivo.WriteLine("*** PORTAS ***");
                        if (Global.sel_leitor_mag)
                        {
                            arquivo.WriteLine("Leitor Magellan: " + Global.leitorMagPorta);
                        }
                        if (Global.sel_bal_mag)
                        {
                            arquivo.WriteLine("Balança Magellan: " + Global.balMagPorta);
                        }
                        if (Global.sel_bal_prix)
                        {
                            arquivo.WriteLine("Balança Prix: " + Global.balPrixPorta);
                        }
                        if (Global.sel_sinalizacao)
                        {
                            arquivo.WriteLine("Sinalização: " + Global.sinalizacaoPorta);
                        }
                        arquivo.WriteLine("");
                        arquivo.WriteLine("");
                        arquivo.WriteLine("*** INFORMAÇÕES DE INSPEÇÃO ***");
                        arquivo.WriteLine("Inspecionado por: " + text_inspecionadopor.Text);
                        arquivo.WriteLine("");
                        arquivo.WriteLine("");
                        arquivo.WriteLine("Ass.:____________________________");
                        arquivo.WriteLine("");
                        arquivo.WriteLine("Supervisor produção:");
                        arquivo.WriteLine("");
                        arquivo.WriteLine("");
                        arquivo.WriteLine("Ass.:____________________________");
                        arquivo.WriteLine("");
                        arquivo.WriteLine("");
                        arquivo.WriteLine("");
                        arquivo.WriteLine("");
                        arquivo.Close();

                        /*

                        string pathServer;

                        pathServer = "//sch-erp/Producao/RELATORIOSTAA/" + ano + mes + dia + contador + "_" + text_ns.Text + ".txt";


                        System.IO.File.Copy(nomearquivo, pathServer);
                        */






                        using (var printRel = new System.Drawing.Printing.PrintDocument())
                        {
                            printRel.PrintPage += printRel_PrintPage;
                            printRel.Print();
                            DialogResult confirm = MessageBox.Show("Deseja imprimir segunda via?", "Segunda Via", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                            if (confirm.ToString().ToUpper() == "YES")
                            {
                                printRel.Print();
                            }
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Você deve realizar todos os testes antes de sair!");
                    }
                }




            }
            else
            {
                MessageBox.Show("Por favor, responda todas as questões!");
            }
            

           

            //////////////////////
        }

       
        

        private void textBox1_Click(object sender, EventArgs e)
        {
            OnScreenKeyboard.Show();
        }

        private void text_op_Click(object sender, EventArgs e)
        {
            OnScreenKeyboard.Show();
        }

        private void text_cliente_Click(object sender, EventArgs e)
        {
            OnScreenKeyboard.Show();
        }

        private void text_inspecionadopor_Click(object sender, EventArgs e)
        {
            OnScreenKeyboard.Show();
        }

        private void bt_verso_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winver");
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {

        }
    }
}
