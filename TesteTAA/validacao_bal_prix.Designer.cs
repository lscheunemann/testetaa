namespace TesteTAA
{
    partial class validacao_bal_prix
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
            this.gb_bal_prix_obs = new System.Windows.Forms.GroupBox();
            this.bt_enviar_bal_prix = new System.Windows.Forms.Button();
            this.text_obs_bal_prix = new System.Windows.Forms.TextBox();
            this.bt_bal_prix_nao = new System.Windows.Forms.Button();
            this.bt_bal_prix_sim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_bal_prix_obs.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_bal_prix_obs
            // 
            this.gb_bal_prix_obs.Controls.Add(this.bt_enviar_bal_prix);
            this.gb_bal_prix_obs.Controls.Add(this.text_obs_bal_prix);
            this.gb_bal_prix_obs.Location = new System.Drawing.Point(13, 192);
            this.gb_bal_prix_obs.Name = "gb_bal_prix_obs";
            this.gb_bal_prix_obs.Size = new System.Drawing.Size(490, 145);
            this.gb_bal_prix_obs.TabIndex = 17;
            this.gb_bal_prix_obs.TabStop = false;
            this.gb_bal_prix_obs.Text = "Observações";
            this.gb_bal_prix_obs.Visible = false;
            this.gb_bal_prix_obs.Enter += new System.EventHandler(this.gb_bal_prix_obs_Enter);
            // 
            // bt_enviar_bal_prix
            // 
            this.bt_enviar_bal_prix.Location = new System.Drawing.Point(209, 95);
            this.bt_enviar_bal_prix.Name = "bt_enviar_bal_prix";
            this.bt_enviar_bal_prix.Size = new System.Drawing.Size(75, 39);
            this.bt_enviar_bal_prix.TabIndex = 8;
            this.bt_enviar_bal_prix.Text = "Enviar";
            this.bt_enviar_bal_prix.UseVisualStyleBackColor = true;
            this.bt_enviar_bal_prix.Click += new System.EventHandler(this.bt_enviar_bal_prix_Click);
            // 
            // text_obs_bal_prix
            // 
            this.text_obs_bal_prix.Location = new System.Drawing.Point(26, 20);
            this.text_obs_bal_prix.MaxLength = 140;
            this.text_obs_bal_prix.Multiline = true;
            this.text_obs_bal_prix.Name = "text_obs_bal_prix";
            this.text_obs_bal_prix.Size = new System.Drawing.Size(437, 69);
            this.text_obs_bal_prix.TabIndex = 7;
            // 
            // bt_bal_prix_nao
            // 
            this.bt_bal_prix_nao.BackColor = System.Drawing.Color.Salmon;
            this.bt_bal_prix_nao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_bal_prix_nao.Location = new System.Drawing.Point(262, 87);
            this.bt_bal_prix_nao.Name = "bt_bal_prix_nao";
            this.bt_bal_prix_nao.Size = new System.Drawing.Size(183, 99);
            this.bt_bal_prix_nao.TabIndex = 16;
            this.bt_bal_prix_nao.Text = "NÃO";
            this.bt_bal_prix_nao.UseVisualStyleBackColor = false;
            this.bt_bal_prix_nao.Click += new System.EventHandler(this.bt_bal_prix_nao_Click);
            // 
            // bt_bal_prix_sim
            // 
            this.bt_bal_prix_sim.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_bal_prix_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_bal_prix_sim.Location = new System.Drawing.Point(73, 87);
            this.bt_bal_prix_sim.Name = "bt_bal_prix_sim";
            this.bt_bal_prix_sim.Size = new System.Drawing.Size(183, 99);
            this.bt_bal_prix_sim.TabIndex = 15;
            this.bt_bal_prix_sim.Text = "SIM";
            this.bt_bal_prix_sim.UseVisualStyleBackColor = false;
            this.bt_bal_prix_sim.Click += new System.EventHandler(this.bt_bal_prix_sim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "O teste da balança foi satisfatório?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // validacao_bal_prix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 346);
            this.ControlBox = false;
            this.Controls.Add(this.gb_bal_prix_obs);
            this.Controls.Add(this.bt_bal_prix_nao);
            this.Controls.Add(this.bt_bal_prix_sim);
            this.Controls.Add(this.label1);
            this.Name = "validacao_bal_prix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.gb_bal_prix_obs.ResumeLayout(false);
            this.gb_bal_prix_obs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_bal_prix_obs;
        private System.Windows.Forms.Button bt_enviar_bal_prix;
        private System.Windows.Forms.TextBox text_obs_bal_prix;
        private System.Windows.Forms.Button bt_bal_prix_nao;
        private System.Windows.Forms.Button bt_bal_prix_sim;
        private System.Windows.Forms.Label label1;
    }
}