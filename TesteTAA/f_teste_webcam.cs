using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace TesteTAA
{
    public partial class f_teste_webcam : Form
    {
        AForge.Video.DirectShow.VideoCaptureDevice videoSource;
        private FilterInfoCollection videoDevices;

        public f_teste_webcam()
        {
            

            InitializeComponent();
            


        }

        private void f_teste_webcam_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in videoDevices)
            {
                cb_dispositivos.Items.Add(device.Name);
            }

        
      
        
    }

        private void bt_testeok_Click(object sender, EventArgs e)
        {
            try
            {
                videoSource.Stop();
            }
            catch
            {

            }
            
             
            
            Global.webcam_ok = true;
            this.Close();
        }

        private void bt_testenaook_Click(object sender, EventArgs e)
        {
            videoSource.Stop();
            Global.webcam_ok = false;
            gb_webcam_obs.Visible = true;
            bt_testenaook.Enabled = false;
            bt_testeok.Enabled = false;
        }

        private void bt_enviar_webcam_Click(object sender, EventArgs e)
        {
            Global.webcam_obs = text_obs_webcam.Text;
            this.Close();
        }

       

        private void bt_ok_Click(object sender, EventArgs e)
        {
            try
            {
                AForge.Video.DirectShow.FilterInfoCollection videosources = new AForge.Video.DirectShow.FilterInfoCollection(AForge.Video.DirectShow.FilterCategory.VideoInputDevice);


                videoSource = new AForge.Video.DirectShow.VideoCaptureDevice(videosources[cb_dispositivos.SelectedIndex].MonikerString);
                videoSource.NewFrame += (object s, NewFrameEventArgs z) =>
                {
                    Bitmap image = (Bitmap)z.Frame.Clone();
                    if (pb_webcam.Image != null)
                    {
                        pb_webcam.Image.Dispose();
                    }

                    pb_webcam.Image = (Bitmap)z.Frame.Clone();
                };
                videoSource.Start();
                bt_ok.Enabled = false;
                cb_dispositivos.Enabled = false;
            }
            catch
            {
                MessageBox.Show("SELECIONE UM DISPOSITIVO");
            }

        }

        private void text_obs_webcam_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
