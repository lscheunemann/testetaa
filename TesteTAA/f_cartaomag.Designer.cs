namespace TesteTAA
{
    partial class f_cartaomag
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
            this.gb_validacao_cartaomag = new System.Windows.Forms.GroupBox();
            this.bt_enviar_lcm = new System.Windows.Forms.Button();
            this.text_lcm = new System.Windows.Forms.TextBox();
            this.bt_leitor_nao = new System.Windows.Forms.Button();
            this.bt_leitor_sim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.text_cartaomag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_validacao_cartaomag.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_validacao_cartaomag
            // 
            this.gb_validacao_cartaomag.Controls.Add(this.bt_enviar_lcm);
            this.gb_validacao_cartaomag.Controls.Add(this.text_lcm);
            this.gb_validacao_cartaomag.Controls.Add(this.bt_leitor_nao);
            this.gb_validacao_cartaomag.Controls.Add(this.bt_leitor_sim);
            this.gb_validacao_cartaomag.Controls.Add(this.label2);
            this.gb_validacao_cartaomag.Location = new System.Drawing.Point(43, 133);
            this.gb_validacao_cartaomag.Name = "gb_validacao_cartaomag";
            this.gb_validacao_cartaomag.Size = new System.Drawing.Size(434, 292);
            this.gb_validacao_cartaomag.TabIndex = 16;
            this.gb_validacao_cartaomag.TabStop = false;
            this.gb_validacao_cartaomag.Visible = false;
            // 
            // bt_enviar_lcm
            // 
            this.bt_enviar_lcm.Location = new System.Drawing.Point(163, 234);
            this.bt_enviar_lcm.Name = "bt_enviar_lcm";
            this.bt_enviar_lcm.Size = new System.Drawing.Size(75, 39);
            this.bt_enviar_lcm.TabIndex = 16;
            this.bt_enviar_lcm.Text = "Enviar";
            this.bt_enviar_lcm.UseVisualStyleBackColor = true;
            this.bt_enviar_lcm.Visible = false;
            this.bt_enviar_lcm.Click += new System.EventHandler(this.bt_enviar_lcm_Click);
            // 
            // text_lcm
            // 
            this.text_lcm.Location = new System.Drawing.Point(16, 172);
            this.text_lcm.MaxLength = 140;
            this.text_lcm.Multiline = true;
            this.text_lcm.Name = "text_lcm";
            this.text_lcm.Size = new System.Drawing.Size(393, 56);
            this.text_lcm.TabIndex = 15;
            this.text_lcm.Visible = false;
            // 
            // bt_leitor_nao
            // 
            this.bt_leitor_nao.BackColor = System.Drawing.Color.Salmon;
            this.bt_leitor_nao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_leitor_nao.Location = new System.Drawing.Point(218, 45);
            this.bt_leitor_nao.Name = "bt_leitor_nao";
            this.bt_leitor_nao.Size = new System.Drawing.Size(183, 99);
            this.bt_leitor_nao.TabIndex = 14;
            this.bt_leitor_nao.Text = "NÃO";
            this.bt_leitor_nao.UseVisualStyleBackColor = false;
            this.bt_leitor_nao.Click += new System.EventHandler(this.bt_leitor_nao_Click);
            // 
            // bt_leitor_sim
            // 
            this.bt_leitor_sim.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_leitor_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_leitor_sim.Location = new System.Drawing.Point(29, 45);
            this.bt_leitor_sim.Name = "bt_leitor_sim";
            this.bt_leitor_sim.Size = new System.Drawing.Size(183, 99);
            this.bt_leitor_sim.TabIndex = 13;
            this.bt_leitor_sim.Text = "SIM";
            this.bt_leitor_sim.UseVisualStyleBackColor = false;
            this.bt_leitor_sim.Click += new System.EventHandler(this.bt_leitor_sim_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "O código foi lido corretamente?";
            // 
            // text_cartaomag
            // 
            this.text_cartaomag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_cartaomag.Location = new System.Drawing.Point(43, 98);
            this.text_cartaomag.Name = "text_cartaomag";
            this.text_cartaomag.Size = new System.Drawing.Size(435, 29);
            this.text_cartaomag.TabIndex = 15;
            this.text_cartaomag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_cartaomag_KeyPress);
            this.text_cartaomag.Leave += new System.EventHandler(this.text_cartaomag_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Passe um cartão no leitor...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 10);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // f_cartaomag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 449);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gb_validacao_cartaomag);
            this.Controls.Add(this.text_cartaomag);
            this.Controls.Add(this.label1);
            this.Name = "f_cartaomag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TESTE - Leitor Cartão Magnético";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.f_cartaomag_Load);
            this.gb_validacao_cartaomag.ResumeLayout(false);
            this.gb_validacao_cartaomag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_validacao_cartaomag;
        private System.Windows.Forms.Button bt_enviar_lcm;
        private System.Windows.Forms.TextBox text_lcm;
        private System.Windows.Forms.Button bt_leitor_nao;
        private System.Windows.Forms.Button bt_leitor_sim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_cartaomag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}