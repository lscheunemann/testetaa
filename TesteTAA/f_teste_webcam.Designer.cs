namespace TesteTAA
{
    partial class f_teste_webcam
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
            this.bt_testenaook = new System.Windows.Forms.Button();
            this.bt_testeok = new System.Windows.Forms.Button();
            this.pb_webcam = new System.Windows.Forms.PictureBox();
            this.gb_webcam_obs = new System.Windows.Forms.GroupBox();
            this.bt_enviar_webcam = new System.Windows.Forms.Button();
            this.text_obs_webcam = new System.Windows.Forms.TextBox();
            this.cb_dispositivos = new System.Windows.Forms.ComboBox();
            this.bt_ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_webcam)).BeginInit();
            this.gb_webcam_obs.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_testenaook
            // 
            this.bt_testenaook.BackColor = System.Drawing.Color.DarkRed;
            this.bt_testenaook.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bt_testenaook.Location = new System.Drawing.Point(713, 504);
            this.bt_testenaook.Name = "bt_testenaook";
            this.bt_testenaook.Size = new System.Drawing.Size(123, 50);
            this.bt_testenaook.TabIndex = 21;
            this.bt_testenaook.Text = "Teste Não OK";
            this.bt_testenaook.UseVisualStyleBackColor = false;
            this.bt_testenaook.Click += new System.EventHandler(this.bt_testenaook_Click);
            // 
            // bt_testeok
            // 
            this.bt_testeok.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bt_testeok.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bt_testeok.Location = new System.Drawing.Point(584, 504);
            this.bt_testeok.Name = "bt_testeok";
            this.bt_testeok.Size = new System.Drawing.Size(123, 50);
            this.bt_testeok.TabIndex = 20;
            this.bt_testeok.Text = "Teste OK";
            this.bt_testeok.UseVisualStyleBackColor = false;
            this.bt_testeok.Click += new System.EventHandler(this.bt_testeok_Click);
            // 
            // pb_webcam
            // 
            this.pb_webcam.Location = new System.Drawing.Point(15, 69);
            this.pb_webcam.Name = "pb_webcam";
            this.pb_webcam.Size = new System.Drawing.Size(818, 429);
            this.pb_webcam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_webcam.TabIndex = 18;
            this.pb_webcam.TabStop = false;
            // 
            // gb_webcam_obs
            // 
            this.gb_webcam_obs.Controls.Add(this.bt_enviar_webcam);
            this.gb_webcam_obs.Controls.Add(this.text_obs_webcam);
            this.gb_webcam_obs.Location = new System.Drawing.Point(148, 560);
            this.gb_webcam_obs.Name = "gb_webcam_obs";
            this.gb_webcam_obs.Size = new System.Drawing.Size(490, 145);
            this.gb_webcam_obs.TabIndex = 22;
            this.gb_webcam_obs.TabStop = false;
            this.gb_webcam_obs.Text = "Observações";
            this.gb_webcam_obs.Visible = false;
            // 
            // bt_enviar_webcam
            // 
            this.bt_enviar_webcam.Location = new System.Drawing.Point(209, 95);
            this.bt_enviar_webcam.Name = "bt_enviar_webcam";
            this.bt_enviar_webcam.Size = new System.Drawing.Size(75, 39);
            this.bt_enviar_webcam.TabIndex = 8;
            this.bt_enviar_webcam.Text = "Enviar";
            this.bt_enviar_webcam.UseVisualStyleBackColor = true;
            this.bt_enviar_webcam.Click += new System.EventHandler(this.bt_enviar_webcam_Click);
            // 
            // text_obs_webcam
            // 
            this.text_obs_webcam.Location = new System.Drawing.Point(26, 20);
            this.text_obs_webcam.MaxLength = 140;
            this.text_obs_webcam.Multiline = true;
            this.text_obs_webcam.Name = "text_obs_webcam";
            this.text_obs_webcam.Size = new System.Drawing.Size(437, 69);
            this.text_obs_webcam.TabIndex = 7;
            this.text_obs_webcam.TextChanged += new System.EventHandler(this.text_obs_webcam_TextChanged);
            // 
            // cb_dispositivos
            // 
            this.cb_dispositivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dispositivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_dispositivos.FormattingEnabled = true;
            this.cb_dispositivos.Location = new System.Drawing.Point(170, 31);
            this.cb_dispositivos.Name = "cb_dispositivos";
            this.cb_dispositivos.Size = new System.Drawing.Size(236, 28);
            this.cb_dispositivos.TabIndex = 24;
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(412, 31);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(100, 28);
            this.bt_ok.TabIndex = 25;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Selecione o dispositivo";
            // 
            // f_teste_webcam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 749);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.cb_dispositivos);
            this.Controls.Add(this.gb_webcam_obs);
            this.Controls.Add(this.bt_testenaook);
            this.Controls.Add(this.bt_testeok);
            this.Controls.Add(this.pb_webcam);
            this.Name = "f_teste_webcam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TESTE - Webcam";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.f_teste_webcam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_webcam)).EndInit();
            this.gb_webcam_obs.ResumeLayout(false);
            this.gb_webcam_obs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_testenaook;
        private System.Windows.Forms.Button bt_testeok;
        private System.Windows.Forms.PictureBox pb_webcam;
        private System.Windows.Forms.GroupBox gb_webcam_obs;
        private System.Windows.Forms.Button bt_enviar_webcam;
        private System.Windows.Forms.TextBox text_obs_webcam;
        private System.Windows.Forms.ComboBox cb_dispositivos;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Label label1;
    }
}