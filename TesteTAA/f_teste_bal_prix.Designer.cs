namespace TesteTAA
{
    partial class f_teste_bal_prix
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
            this.components = new System.ComponentModel.Container();
            this.bt_sair_bal_prix = new System.Windows.Forms.Button();
            this.gb_teste_bal_prix = new System.Windows.Forms.GroupBox();
            this.lbl_peso_bal_prix = new System.Windows.Forms.Label();
            this.bt_pesar_bal_prix = new System.Windows.Forms.Button();
            this.bt_ok_bal_prix = new System.Windows.Forms.Button();
            this.cb_porta_bal_prix = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PortaBalPrix = new System.IO.Ports.SerialPort(this.components);
            this.gb_teste_bal_prix.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_sair_bal_prix
            // 
            this.bt_sair_bal_prix.BackColor = System.Drawing.Color.Salmon;
            this.bt_sair_bal_prix.Location = new System.Drawing.Point(335, 228);
            this.bt_sair_bal_prix.Name = "bt_sair_bal_prix";
            this.bt_sair_bal_prix.Size = new System.Drawing.Size(116, 33);
            this.bt_sair_bal_prix.TabIndex = 9;
            this.bt_sair_bal_prix.Text = "SAIR";
            this.bt_sair_bal_prix.UseVisualStyleBackColor = false;
            this.bt_sair_bal_prix.Click += new System.EventHandler(this.bt_sair_bal_prix_Click);
            // 
            // gb_teste_bal_prix
            // 
            this.gb_teste_bal_prix.Controls.Add(this.lbl_peso_bal_prix);
            this.gb_teste_bal_prix.Controls.Add(this.bt_pesar_bal_prix);
            this.gb_teste_bal_prix.Location = new System.Drawing.Point(26, 90);
            this.gb_teste_bal_prix.Name = "gb_teste_bal_prix";
            this.gb_teste_bal_prix.Size = new System.Drawing.Size(425, 132);
            this.gb_teste_bal_prix.TabIndex = 8;
            this.gb_teste_bal_prix.TabStop = false;
            // 
            // lbl_peso_bal_prix
            // 
            this.lbl_peso_bal_prix.AutoSize = true;
            this.lbl_peso_bal_prix.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_peso_bal_prix.ForeColor = System.Drawing.Color.Blue;
            this.lbl_peso_bal_prix.Location = new System.Drawing.Point(228, 54);
            this.lbl_peso_bal_prix.Name = "lbl_peso_bal_prix";
            this.lbl_peso_bal_prix.Size = new System.Drawing.Size(0, 25);
            this.lbl_peso_bal_prix.TabIndex = 13;
            // 
            // bt_pesar_bal_prix
            // 
            this.bt_pesar_bal_prix.BackColor = System.Drawing.Color.White;
            this.bt_pesar_bal_prix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pesar_bal_prix.Location = new System.Drawing.Point(6, 19);
            this.bt_pesar_bal_prix.Name = "bt_pesar_bal_prix";
            this.bt_pesar_bal_prix.Size = new System.Drawing.Size(183, 99);
            this.bt_pesar_bal_prix.TabIndex = 12;
            this.bt_pesar_bal_prix.Text = "PESAR";
            this.bt_pesar_bal_prix.UseVisualStyleBackColor = false;
            this.bt_pesar_bal_prix.Click += new System.EventHandler(this.bt_pesar_bal_prix_Click);
            // 
            // bt_ok_bal_prix
            // 
            this.bt_ok_bal_prix.BackColor = System.Drawing.Color.White;
            this.bt_ok_bal_prix.Location = new System.Drawing.Point(276, 37);
            this.bt_ok_bal_prix.Name = "bt_ok_bal_prix";
            this.bt_ok_bal_prix.Size = new System.Drawing.Size(116, 33);
            this.bt_ok_bal_prix.TabIndex = 7;
            this.bt_ok_bal_prix.Text = "OK";
            this.bt_ok_bal_prix.UseVisualStyleBackColor = false;
            this.bt_ok_bal_prix.Click += new System.EventHandler(this.bt_ok_bal_prix_Click);
            // 
            // cb_porta_bal_prix
            // 
            this.cb_porta_bal_prix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_porta_bal_prix.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_porta_bal_prix.FormattingEnabled = true;
            this.cb_porta_bal_prix.Location = new System.Drawing.Point(132, 37);
            this.cb_porta_bal_prix.Name = "cb_porta_bal_prix";
            this.cb_porta_bal_prix.Size = new System.Drawing.Size(121, 33);
            this.cb_porta_bal_prix.TabIndex = 6;
            this.cb_porta_bal_prix.SelectedIndexChanged += new System.EventHandler(this.cb_porta_bal_mag_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Porta:";
            // 
            // f_teste_bal_prix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 291);
            this.ControlBox = false;
            this.Controls.Add(this.bt_sair_bal_prix);
            this.Controls.Add(this.gb_teste_bal_prix);
            this.Controls.Add(this.bt_ok_bal_prix);
            this.Controls.Add(this.cb_porta_bal_prix);
            this.Controls.Add(this.label1);
            this.Name = "f_teste_bal_prix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TESTE - Balança Prix";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.f_teste_bal_prix_Load);
            this.gb_teste_bal_prix.ResumeLayout(false);
            this.gb_teste_bal_prix.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_sair_bal_prix;
        private System.Windows.Forms.GroupBox gb_teste_bal_prix;
        private System.Windows.Forms.Label lbl_peso_bal_prix;
        private System.Windows.Forms.Button bt_pesar_bal_prix;
        private System.Windows.Forms.Button bt_ok_bal_prix;
        private System.Windows.Forms.ComboBox cb_porta_bal_prix;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort PortaBalPrix;
    }
}