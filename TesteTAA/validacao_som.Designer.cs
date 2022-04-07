namespace TesteTAA
{
    partial class validacao_som
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
            this.gb_som_obs = new System.Windows.Forms.GroupBox();
            this.bt_som_prix = new System.Windows.Forms.Button();
            this.text_som = new System.Windows.Forms.TextBox();
            this.bt_som_nao = new System.Windows.Forms.Button();
            this.bt_som_sim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_som_obs.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_som_obs
            // 
            this.gb_som_obs.Controls.Add(this.bt_som_prix);
            this.gb_som_obs.Controls.Add(this.text_som);
            this.gb_som_obs.Location = new System.Drawing.Point(13, 171);
            this.gb_som_obs.Name = "gb_som_obs";
            this.gb_som_obs.Size = new System.Drawing.Size(490, 145);
            this.gb_som_obs.TabIndex = 21;
            this.gb_som_obs.TabStop = false;
            this.gb_som_obs.Text = "Observações";
            this.gb_som_obs.Visible = false;
            // 
            // bt_som_prix
            // 
            this.bt_som_prix.Location = new System.Drawing.Point(209, 95);
            this.bt_som_prix.Name = "bt_som_prix";
            this.bt_som_prix.Size = new System.Drawing.Size(75, 39);
            this.bt_som_prix.TabIndex = 8;
            this.bt_som_prix.Text = "Enviar";
            this.bt_som_prix.UseVisualStyleBackColor = true;
            this.bt_som_prix.Click += new System.EventHandler(this.bt_som_prix_Click);
            // 
            // text_som
            // 
            this.text_som.Location = new System.Drawing.Point(26, 20);
            this.text_som.MaxLength = 140;
            this.text_som.Multiline = true;
            this.text_som.Name = "text_som";
            this.text_som.Size = new System.Drawing.Size(437, 69);
            this.text_som.TabIndex = 7;
            this.text_som.TextChanged += new System.EventHandler(this.text_som_TextChanged);
            // 
            // bt_som_nao
            // 
            this.bt_som_nao.BackColor = System.Drawing.Color.Salmon;
            this.bt_som_nao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_som_nao.Location = new System.Drawing.Point(262, 66);
            this.bt_som_nao.Name = "bt_som_nao";
            this.bt_som_nao.Size = new System.Drawing.Size(183, 99);
            this.bt_som_nao.TabIndex = 20;
            this.bt_som_nao.Text = "NÃO";
            this.bt_som_nao.UseVisualStyleBackColor = false;
            this.bt_som_nao.Click += new System.EventHandler(this.bt_som_nao_Click);
            // 
            // bt_som_sim
            // 
            this.bt_som_sim.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_som_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_som_sim.Location = new System.Drawing.Point(73, 66);
            this.bt_som_sim.Name = "bt_som_sim";
            this.bt_som_sim.Size = new System.Drawing.Size(183, 99);
            this.bt_som_sim.TabIndex = 19;
            this.bt_som_sim.Text = "SIM";
            this.bt_som_sim.UseVisualStyleBackColor = false;
            this.bt_som_sim.Click += new System.EventHandler(this.bt_som_sim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "O teste de som foi satisfatório?";
            // 
            // validacao_som
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 323);
            this.ControlBox = false;
            this.Controls.Add(this.gb_som_obs);
            this.Controls.Add(this.bt_som_nao);
            this.Controls.Add(this.bt_som_sim);
            this.Controls.Add(this.label1);
            this.Name = "validacao_som";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.gb_som_obs.ResumeLayout(false);
            this.gb_som_obs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_som_obs;
        private System.Windows.Forms.Button bt_som_prix;
        private System.Windows.Forms.TextBox text_som;
        private System.Windows.Forms.Button bt_som_nao;
        private System.Windows.Forms.Button bt_som_sim;
        private System.Windows.Forms.Label label1;
    }
}