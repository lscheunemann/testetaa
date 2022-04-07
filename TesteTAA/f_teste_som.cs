using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteTAA
{
    public partial class f_teste_som : Form
    {
        public f_teste_som()
        {
            InitializeComponent();
        }

        private void bt_testarsom_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("teste_som.wav");
            simpleSound.Play();
            lbl_txt.Text = "Reproduzindo som...Aguarde!";
            this.Refresh();
            Thread.Sleep(8000);
            this.Close();
            validacao_som fvs = new validacao_som();
            fvs.Show();
        }
    }
}
