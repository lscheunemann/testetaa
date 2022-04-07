namespace TesteTAA
{
    partial class validacao_sinalizacao
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
            this.gb_sin_obs = new System.Windows.Forms.GroupBox();
            this.bt_enviar_sin = new System.Windows.Forms.Button();
            this.text_obs_sin = new System.Windows.Forms.TextBox();
            this.bt_sin_nao = new System.Windows.Forms.Button();
            this.bt_sin_sim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_sin_obs.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_sin_obs
            // 
            this.gb_sin_obs.Controls.Add(this.bt_enviar_sin);
            this.gb_sin_obs.Controls.Add(this.text_obs_sin);
            this.gb_sin_obs.Location = new System.Drawing.Point(13, 191);
            this.gb_sin_obs.Name = "gb_sin_obs";
            this.gb_sin_obs.Size = new System.Drawing.Size(490, 145);
            this.gb_sin_obs.TabIndex = 21;
            this.gb_sin_obs.TabStop = false;
            this.gb_sin_obs.Text = "Observações";
            this.gb_sin_obs.Visible = false;
            // 
            // bt_enviar_sin
            // 
            this.bt_enviar_sin.Location = new System.Drawing.Point(209, 95);
            this.bt_enviar_sin.Name = "bt_enviar_sin";
            this.bt_enviar_sin.Size = new System.Drawing.Size(75, 39);
            this.bt_enviar_sin.TabIndex = 8;
            this.bt_enviar_sin.Text = "Enviar";
            this.bt_enviar_sin.UseVisualStyleBackColor = true;
            this.bt_enviar_sin.Click += new System.EventHandler(this.bt_enviar_sin_Click);
            // 
            // text_obs_sin
            // 
            this.text_obs_sin.Location = new System.Drawing.Point(26, 20);
            this.text_obs_sin.MaxLength = 140;
            this.text_obs_sin.Multiline = true;
            this.text_obs_sin.Name = "text_obs_sin";
            this.text_obs_sin.Size = new System.Drawing.Size(437, 69);
            this.text_obs_sin.TabIndex = 7;
            // 
            // bt_sin_nao
            // 
            this.bt_sin_nao.BackColor = System.Drawing.Color.Salmon;
            this.bt_sin_nao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sin_nao.Location = new System.Drawing.Point(262, 86);
            this.bt_sin_nao.Name = "bt_sin_nao";
            this.bt_sin_nao.Size = new System.Drawing.Size(183, 99);
            this.bt_sin_nao.TabIndex = 20;
            this.bt_sin_nao.Text = "NÃO";
            this.bt_sin_nao.UseVisualStyleBackColor = false;
            this.bt_sin_nao.Click += new System.EventHandler(this.bt_sin_nao_Click);
            // 
            // bt_sin_sim
            // 
            this.bt_sin_sim.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_sin_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sin_sim.Location = new System.Drawing.Point(73, 86);
            this.bt_sin_sim.Name = "bt_sin_sim";
            this.bt_sin_sim.Size = new System.Drawing.Size(183, 99);
            this.bt_sin_sim.TabIndex = 19;
            this.bt_sin_sim.Text = "SIM";
            this.bt_sin_sim.UseVisualStyleBackColor = false;
            this.bt_sin_sim.Click += new System.EventHandler(this.bt_sin_sim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "O teste de sinalização foi satisfatório?";
            // 
            // validacao_sinalizacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 346);
            this.ControlBox = false;
            this.Controls.Add(this.gb_sin_obs);
            this.Controls.Add(this.bt_sin_nao);
            this.Controls.Add(this.bt_sin_sim);
            this.Controls.Add(this.label1);
            this.Name = "validacao_sinalizacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.gb_sin_obs.ResumeLayout(false);
            this.gb_sin_obs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_sin_obs;
        private System.Windows.Forms.Button bt_enviar_sin;
        private System.Windows.Forms.TextBox text_obs_sin;
        private System.Windows.Forms.Button bt_sin_nao;
        private System.Windows.Forms.Button bt_sin_sim;
        private System.Windows.Forms.Label label1;
    }
}