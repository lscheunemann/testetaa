using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTAA
{
    class Global
    {
        /// Variáveis para checkar quais periféricos foram selecionados ///
        public static bool sel_bkc310;
        public static bool sel_bkt6112;
        public static bool sel_it433;
        public static bool sel_star;
        public static bool sel_tmt20;
        public static bool sel_tmt88;
        public static bool clic_impressora;
        public static bool sel_gertec;
        public static bool sel_ingenico;
        public static bool clic_pinpad;
        public static bool sel_bal_mag;
        public static bool clic_bal_mag;
        public static bool sel_bal_prix;
        public static bool clic_bal_prix;
        public static bool sel_cm3680;
        public static bool clic_leitor;
        public static bool sel_feixe1d;
        public static bool sel_leitor_mag;
        public static bool clic_leitor_mag;
        public static bool sel_touch;
        public static bool clic_touch;
        public static bool sel_sinalizacao;
        public static bool clic_sinalizacao;
        public static bool sel_webcam;
        public static bool clic_webcam;
        public static bool sel_som;
        public static bool clic_som;
        public static bool sel_fabrica;
        public static bool sel_campo;
        public static bool clic_questionario;
        public static bool sel_cartaomag;
        public static bool clic_cartaomag;
        ///////////////////////////////////////////////////////////////////

        /// Variáveis de identificação ////////////////////////////////////
        public static string numSerie;
        public static string numOP;
        public static string nome;
        /////////////////////////////////////////////////////////////////// 

        /// Variáveis que armazena os resultados dos testes //////////////////////
        public static bool impressora_ok;
        public static string impressora_obs = "";
        public static bool pinpad_ok;
        public static string pinpad_obs = "";
        public static bool balMag_ok;
        public static string balMag_obs = "";
        public static string balMagPorta = "";
        public static string balMagPortaAux = "";
        public static bool balPrix_ok;
        public static string balPrix_obs = "";
        public static string balPrixPorta = "";
        public static string balPrixPortaAux = "";
        public static bool leitor_2d_ok;
        public static string leitor_2d_obs = "";
        public static bool leitorMag_ok;
        public static string leitorMag_obs = "";
        public static string leitorMagPorta = "";
        public static bool touch_ok;
        public static string touch_obs = "";
        public static bool sinalizacao_ok;
        public static string sinalizacao_obs = "";
        public static string sinalizacaoPortaAux = "";
        public static string sinalizacaoPorta = "";
        public static bool webcam_ok;
        public static string webcam_obs = "";
        public static bool som_ok;
        public static string som_obs = "";
        public static bool cartaomag_ok;
        public static string cartaomag_obs = "";
        public static bool q1;
        public static bool q2;
        public static bool q3;
        public static bool q4;
        public static bool q5;
        public static bool q6;
        public static bool q7;
        public static bool q8;
        public static bool q9;
        public static bool q10;
        public static string obs_final = "";
        ///////////////////////////////////////////////////////////////////
        /// Contadores e verificadores ////////////////////////////////////
        public static int contadorbtn = 0;
        public static bool vImpressora;
        public static bool vPinpad;
        public static bool vBalMag;
        public static bool vBalPrix;
        public static bool vLeitor2d;
        public static bool vLeitor1d;
        public static bool vLeitorMag;
        public static bool vTouch;
        public static bool vSinalizacao;
        public static bool vWebcam;
        public static bool vSom;
        public static bool vCartaomag;
        public static bool vQuestionario;
        ///////////////////////////////////////////////////////////////////

    }
}
