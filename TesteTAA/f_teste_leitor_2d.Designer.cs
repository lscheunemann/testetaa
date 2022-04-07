namespace TesteTAA
{
    partial class f_teste_leitor_2d
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
            this.text_codigo_2d = new System.Windows.Forms.TextBox();
            this.gb_validacao_leitor_2d = new System.Windows.Forms.GroupBox();
            this.bt_enviar_ldd = new System.Windows.Forms.Button();
            this.text_ldd = new System.Windows.Forms.TextBox();
            this.bt_bal_ldd_nao = new System.Windows.Forms.Button();
            this.bt_bal_ldd_sim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_validacao_leitor_2d.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Passe um código de barras no leitor...";
            // 
            // text_codigo_2d
            // 
            this.text_codigo_2d.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_codigo_2d.Location = new System.Drawing.Point(26, 109);
            this.text_codigo_2d.Name = "text_codigo_2d";
            this.text_codigo_2d.Size = new System.Drawing.Size(435, 29);
            this.text_codigo_2d.TabIndex = 12;
            this.text_codigo_2d.Enter += new System.EventHandler(this.text_codigo_2d_Enter);
            this.text_codigo_2d.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_codigo_2d_KeyPress);
            this.text_codigo_2d.Leave += new System.EventHandler(this.text_codigo_2d_Leave);
            // 
            // gb_validacao_leitor_2d
            // 
            this.gb_validacao_leitor_2d.Controls.Add(this.bt_enviar_ldd);
            this.gb_validacao_leitor_2d.Controls.Add(this.text_ldd);
            this.gb_validacao_leitor_2d.Controls.Add(this.bt_bal_ldd_nao);
            this.gb_validacao_leitor_2d.Controls.Add(this.bt_bal_ldd_sim);
            this.gb_validacao_leitor_2d.Controls.Add(this.label2);
            this.gb_validacao_leitor_2d.Location = new System.Drawing.Point(26, 144);
            this.gb_validacao_leitor_2d.Name = "gb_validacao_leitor_2d";
            this.gb_validacao_leitor_2d.Size = new System.Drawing.Size(434, 292);
            this.gb_validacao_leitor_2d.TabIndex = 13;
            this.gb_validacao_leitor_2d.TabStop = false;
            this.gb_validacao_leitor_2d.Visible = false;
            this.gb_validacao_leitor_2d.Enter += new System.EventHandler(this.gb_validacao_leitor_2d_Enter);
            // 
            // bt_enviar_ldd
            // 
            this.bt_enviar_ldd.Location = new System.Drawing.Point(163, 234);
            this.bt_enviar_ldd.Name = "bt_enviar_ldd";
            this.bt_enviar_ldd.Size = new System.Drawing.Size(75, 39);
            this.bt_enviar_ldd.TabIndex = 16;
            this.bt_enviar_ldd.Text = "Enviar";
            this.bt_enviar_ldd.UseVisualStyleBackColor = true;
            this.bt_enviar_ldd.Visible = false;
            this.bt_enviar_ldd.Click += new System.EventHandler(this.bt_enviar_ldd_Click);
            // 
            // text_ldd
            // 
            this.text_ldd.Location = new System.Drawing.Point(16, 172);
            this.text_ldd.MaxLength = 140;
            this.text_ldd.Multiline = true;
            this.text_ldd.Name = "text_ldd";
            this.text_ldd.Size = new System.Drawing.Size(393, 56);
            this.text_ldd.TabIndex = 15;
            this.text_ldd.Visible = false;
            // 
            // bt_bal_ldd_nao
            // 
            this.bt_bal_ldd_nao.BackColor = System.Drawing.Color.Salmon;
            this.bt_bal_ldd_nao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_bal_ldd_nao.Location = new System.Drawing.Point(218, 45);
            this.bt_bal_ldd_nao.Name = "bt_bal_ldd_nao";
            this.bt_bal_ldd_nao.Size = new System.Drawing.Size(183, 99);
            this.bt_bal_ldd_nao.TabIndex = 14;
            this.bt_bal_ldd_nao.Text = "NÃO";
            this.bt_bal_ldd_nao.UseVisualStyleBackColor = false;
            this.bt_bal_ldd_nao.Click += new System.EventHandler(this.bt_bal_mag_nao_Click);
            // 
            // bt_bal_ldd_sim
            // 
            this.bt_bal_ldd_sim.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_bal_ldd_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_bal_ldd_sim.Location = new System.Drawing.Point(29, 45);
            this.bt_bal_ldd_sim.Name = "bt_bal_ldd_sim";
            this.bt_bal_ldd_sim.Size = new System.Drawing.Size(183, 99);
            this.bt_bal_ldd_sim.TabIndex = 13;
            this.bt_bal_ldd_sim.Text = "SIM";
            this.bt_bal_ldd_sim.UseVisualStyleBackColor = false;
            this.bt_bal_ldd_sim.Click += new System.EventHandler(this.bt_bal_mag_sim_Click);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 10);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // f_teste_leitor_2d
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(489, 469);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gb_validacao_leitor_2d);
            this.Controls.Add(this.text_codigo_2d);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "f_teste_leitor_2d";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TESTE - Leitor 2D";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.f_teste_leitor_2d_Load);
            this.gb_validacao_leitor_2d.ResumeLayout(false);
            this.gb_validacao_leitor_2d.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_codigo_2d;
        private System.Windows.Forms.GroupBox gb_validacao_leitor_2d;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_bal_ldd_nao;
        private System.Windows.Forms.Button bt_bal_ldd_sim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_ldd;
        private System.Windows.Forms.Button bt_enviar_ldd;
    }
}