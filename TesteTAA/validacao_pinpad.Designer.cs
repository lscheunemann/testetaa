namespace TesteTAA
{
    partial class validacao_pinpad
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
            this.gb_pinpad_obs = new System.Windows.Forms.GroupBox();
            this.bt_enviar_imp = new System.Windows.Forms.Button();
            this.text_obs_pinpad = new System.Windows.Forms.TextBox();
            this.bt_pinpad_nao = new System.Windows.Forms.Button();
            this.bt_pinpad_sim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_pinpad_obs.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_pinpad_obs
            // 
            this.gb_pinpad_obs.Controls.Add(this.bt_enviar_imp);
            this.gb_pinpad_obs.Controls.Add(this.text_obs_pinpad);
            this.gb_pinpad_obs.Location = new System.Drawing.Point(13, 186);
            this.gb_pinpad_obs.Name = "gb_pinpad_obs";
            this.gb_pinpad_obs.Size = new System.Drawing.Size(490, 145);
            this.gb_pinpad_obs.TabIndex = 13;
            this.gb_pinpad_obs.TabStop = false;
            this.gb_pinpad_obs.Text = "Observações";
            this.gb_pinpad_obs.Visible = false;
            // 
            // bt_enviar_imp
            // 
            this.bt_enviar_imp.Location = new System.Drawing.Point(209, 95);
            this.bt_enviar_imp.Name = "bt_enviar_imp";
            this.bt_enviar_imp.Size = new System.Drawing.Size(75, 39);
            this.bt_enviar_imp.TabIndex = 8;
            this.bt_enviar_imp.Text = "Enviar";
            this.bt_enviar_imp.UseVisualStyleBackColor = true;
            this.bt_enviar_imp.Click += new System.EventHandler(this.bt_enviar_imp_Click);
            // 
            // text_obs_pinpad
            // 
            this.text_obs_pinpad.Location = new System.Drawing.Point(26, 20);
            this.text_obs_pinpad.MaxLength = 140;
            this.text_obs_pinpad.Multiline = true;
            this.text_obs_pinpad.Name = "text_obs_pinpad";
            this.text_obs_pinpad.Size = new System.Drawing.Size(437, 69);
            this.text_obs_pinpad.TabIndex = 7;
            // 
            // bt_pinpad_nao
            // 
            this.bt_pinpad_nao.BackColor = System.Drawing.Color.Salmon;
            this.bt_pinpad_nao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pinpad_nao.Location = new System.Drawing.Point(262, 81);
            this.bt_pinpad_nao.Name = "bt_pinpad_nao";
            this.bt_pinpad_nao.Size = new System.Drawing.Size(183, 99);
            this.bt_pinpad_nao.TabIndex = 12;
            this.bt_pinpad_nao.Text = "NÃO";
            this.bt_pinpad_nao.UseVisualStyleBackColor = false;
            this.bt_pinpad_nao.Click += new System.EventHandler(this.bt_pinpad_nao_Click);
            // 
            // bt_pinpad_sim
            // 
            this.bt_pinpad_sim.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_pinpad_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pinpad_sim.Location = new System.Drawing.Point(73, 81);
            this.bt_pinpad_sim.Name = "bt_pinpad_sim";
            this.bt_pinpad_sim.Size = new System.Drawing.Size(183, 99);
            this.bt_pinpad_sim.TabIndex = 11;
            this.bt_pinpad_sim.Text = "SIM";
            this.bt_pinpad_sim.UseVisualStyleBackColor = false;
            this.bt_pinpad_sim.Click += new System.EventHandler(this.bt_imp_sim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "O teste do PINPad foi satisfatório?";
            // 
            // validacao_pinpad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 346);
            this.ControlBox = false;
            this.Controls.Add(this.gb_pinpad_obs);
            this.Controls.Add(this.bt_pinpad_nao);
            this.Controls.Add(this.bt_pinpad_sim);
            this.Controls.Add(this.label1);
            this.Name = "validacao_pinpad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gb_pinpad_obs.ResumeLayout(false);
            this.gb_pinpad_obs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_pinpad_obs;
        private System.Windows.Forms.Button bt_enviar_imp;
        private System.Windows.Forms.TextBox text_obs_pinpad;
        private System.Windows.Forms.Button bt_pinpad_nao;
        private System.Windows.Forms.Button bt_pinpad_sim;
        private System.Windows.Forms.Label label1;
    }
}