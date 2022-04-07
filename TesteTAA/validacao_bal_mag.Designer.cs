namespace TesteTAA
{
    partial class validacao_bal_mag
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_bal_mag_obs = new System.Windows.Forms.GroupBox();
            this.bt_enviar_bal_mag = new System.Windows.Forms.Button();
            this.text_obs_bal_mag = new System.Windows.Forms.TextBox();
            this.bt_bal_mag_nao = new System.Windows.Forms.Button();
            this.bt_bal_mag_sim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_bal_mag_obs.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_bal_mag_obs
            // 
            this.gb_bal_mag_obs.Controls.Add(this.bt_enviar_bal_mag);
            this.gb_bal_mag_obs.Controls.Add(this.text_obs_bal_mag);
            this.gb_bal_mag_obs.Location = new System.Drawing.Point(13, 210);
            this.gb_bal_mag_obs.Name = "gb_bal_mag_obs";
            this.gb_bal_mag_obs.Size = new System.Drawing.Size(490, 145);
            this.gb_bal_mag_obs.TabIndex = 13;
            this.gb_bal_mag_obs.TabStop = false;
            this.gb_bal_mag_obs.Text = "Observações";
            this.gb_bal_mag_obs.Visible = false;
            this.gb_bal_mag_obs.Enter += new System.EventHandler(this.gb_bal_mag_obs_Enter);
            // 
            // bt_enviar_bal_mag
            // 
            this.bt_enviar_bal_mag.Location = new System.Drawing.Point(209, 95);
            this.bt_enviar_bal_mag.Name = "bt_enviar_bal_mag";
            this.bt_enviar_bal_mag.Size = new System.Drawing.Size(75, 39);
            this.bt_enviar_bal_mag.TabIndex = 8;
            this.bt_enviar_bal_mag.Text = "Enviar";
            this.bt_enviar_bal_mag.UseVisualStyleBackColor = true;
            this.bt_enviar_bal_mag.Click += new System.EventHandler(this.bt_enviar_bal_mag_Click);
            // 
            // text_obs_bal_mag
            // 
            this.text_obs_bal_mag.Location = new System.Drawing.Point(26, 20);
            this.text_obs_bal_mag.MaxLength = 140;
            this.text_obs_bal_mag.Multiline = true;
            this.text_obs_bal_mag.Name = "text_obs_bal_mag";
            this.text_obs_bal_mag.Size = new System.Drawing.Size(437, 69);
            this.text_obs_bal_mag.TabIndex = 7;
            // 
            // bt_bal_mag_nao
            // 
            this.bt_bal_mag_nao.BackColor = System.Drawing.Color.Salmon;
            this.bt_bal_mag_nao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_bal_mag_nao.Location = new System.Drawing.Point(262, 105);
            this.bt_bal_mag_nao.Name = "bt_bal_mag_nao";
            this.bt_bal_mag_nao.Size = new System.Drawing.Size(183, 99);
            this.bt_bal_mag_nao.TabIndex = 12;
            this.bt_bal_mag_nao.Text = "NÃO";
            this.bt_bal_mag_nao.UseVisualStyleBackColor = false;
            this.bt_bal_mag_nao.Click += new System.EventHandler(this.bt_bal_mag_nao_Click);
            // 
            // bt_bal_mag_sim
            // 
            this.bt_bal_mag_sim.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_bal_mag_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_bal_mag_sim.Location = new System.Drawing.Point(73, 105);
            this.bt_bal_mag_sim.Name = "bt_bal_mag_sim";
            this.bt_bal_mag_sim.Size = new System.Drawing.Size(183, 99);
            this.bt_bal_mag_sim.TabIndex = 11;
            this.bt_bal_mag_sim.Text = "SIM";
            this.bt_bal_mag_sim.UseVisualStyleBackColor = false;
            this.bt_bal_mag_sim.Click += new System.EventHandler(this.bt_bal_mag_sim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "O teste da balança foi satisfatório?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // validacao_bal_mag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 369);
            this.ControlBox = false;
            this.Controls.Add(this.gb_bal_mag_obs);
            this.Controls.Add(this.bt_bal_mag_nao);
            this.Controls.Add(this.bt_bal_mag_sim);
            this.Controls.Add(this.label1);
            this.Name = "validacao_bal_mag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.gb_bal_mag_obs.ResumeLayout(false);
            this.gb_bal_mag_obs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_bal_mag_obs;
        private System.Windows.Forms.Button bt_enviar_bal_mag;
        private System.Windows.Forms.TextBox text_obs_bal_mag;
        private System.Windows.Forms.Button bt_bal_mag_nao;
        private System.Windows.Forms.Button bt_bal_mag_sim;
        private System.Windows.Forms.Label label1;
    }
}