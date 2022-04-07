using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace TesteTAA
{
    public partial class f_teste_touch : Form
    {
        private static System.Timers.Timer aTimer;
        
        public f_teste_touch()
        {
            InitializeComponent();
            
        }

        private void bt_touch1_Click(object sender, EventArgs e)
        {
            bt_touch1.Visible = false;
            bt_touch2.Visible = true;
        }

        private void bt_touch2_Click(object sender, EventArgs e)
        {
            bt_touch2.Visible = false;
            bt_touch3.Visible = true;
        }

        private void bt_touch3_Click(object sender, EventArgs e)
        {
            bt_touch3.Visible = false;
            bt_touch4.Visible = true;
        }

        private void bt_touch4_Click(object sender, EventArgs e)
        {
            bt_touch4.Visible = false;
            bt_touch5.Visible = true;
        }

        private void bt_touch5_Click(object sender, EventArgs e)
        {
            aTimer.Stop();
            Global.touch_ok = true;
            this.Close();
        }

        private void f_teste_touch_Load(object sender, EventArgs e)
        {
            SetTimer();
        }

        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(60000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }


        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            aTimer.Stop();
            aTimer.Dispose();
            aTimer.Enabled = false;
            Global.touch_ok = false;
            Application.Exit();  

        }
        
       
    }
}
