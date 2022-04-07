namespace TesteTAA
{
    partial class validacao_impressora
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
            this.label1 = new System.Windows.Forms.Label();
            this.bt_imp_sim = new System.Windows.Forms.Button();
            this.bt_imp_nao = new System.Windows.Forms.Button();
            this.text_obs_imp = new System.Windows.Forms.TextBox();
            this.bt_enviar_imp = new System.Windows.Forms.Button();
            this.gb_imp_obs = new System.Windows.Forms.GroupBox();
            this.gb_imp_obs.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "As 5 páginas de teste foram impressas?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bt_imp_sim
            // 
            this.bt_imp_sim.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_imp_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_imp_sim.Location = new System.Drawing.Point(76, 110);
            this.bt_imp_sim.Name = "bt_imp_sim";
            this.bt_imp_sim.Size = new System.Drawing.Size(183, 99);
            this.bt_imp_sim.TabIndex = 5;
            this.bt_imp_sim.Text = "SIM";
            this.bt_imp_sim.UseVisualStyleBackColor = false;
            this.bt_imp_sim.Click += new System.EventHandler(this.bt_imp_sim_Click);
            // 
            // bt_imp_nao
            // 
            this.bt_imp_nao.BackColor = System.Drawing.Color.Salmon;
            this.bt_imp_nao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_imp_nao.Location = new System.Drawing.Point(265, 110);
            this.bt_imp_nao.Name = "bt_imp_nao";
            this.bt_imp_nao.Size = new System.Drawing.Size(183, 99);
            this.bt_imp_nao.TabIndex = 6;
            this.bt_imp_nao.Text = "NÃO";
            this.bt_imp_nao.UseVisualStyleBackColor = false;
            this.bt_imp_nao.Click += new System.EventHandler(this.bt_imp_nao_Click);
            // 
            // text_obs_imp
            // 
            this.text_obs_imp.Location = new System.Drawing.Point(26, 20);
            this.text_obs_imp.MaxLength = 140;
            this.text_obs_imp.Multiline = true;
            this.text_obs_imp.Name = "text_obs_imp";
            this.text_obs_imp.Size = new System.Drawing.Size(437, 69);
            this.text_obs_imp.TabIndex = 7;
            this.text_obs_imp.TextChanged += new System.EventHandler(this.text_obs_imp_TextChanged);
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
            // gb_imp_obs
            // 
            this.gb_imp_obs.Controls.Add(this.bt_enviar_imp);
            this.gb_imp_obs.Controls.Add(this.text_obs_imp);
            this.gb_imp_obs.Location = new System.Drawing.Point(16, 215);
            this.gb_imp_obs.Name = "gb_imp_obs";
            this.gb_imp_obs.Size = new System.Drawing.Size(490, 145);
            this.gb_imp_obs.TabIndex = 9;
            this.gb_imp_obs.TabStop = false;
            this.gb_imp_obs.Text = "Observações";
            this.gb_imp_obs.Visible = false;
            this.gb_imp_obs.Enter += new System.EventHandler(this.gb_imp_obs_Enter);
            // 
            // validacao_impressora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 369);
            this.ControlBox = false;
            this.Controls.Add(this.gb_imp_obs);
            this.Controls.Add(this.bt_imp_nao);
            this.Controls.Add(this.bt_imp_sim);
            this.Controls.Add(this.label1);
            this.Name = "validacao_impressora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.gb_imp_obs.ResumeLayout(false);
            this.gb_imp_obs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_imp_sim;
        private System.Windows.Forms.Button bt_imp_nao;
        private System.Windows.Forms.TextBox text_obs_imp;
        private System.Windows.Forms.Button bt_enviar_imp;
        private System.Windows.Forms.GroupBox gb_imp_obs;
    }
}