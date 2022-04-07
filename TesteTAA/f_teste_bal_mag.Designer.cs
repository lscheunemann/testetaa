namespace TesteTAA
{
    partial class f_teste_bal_mag
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_porta_bal_mag = new System.Windows.Forms.ComboBox();
            this.bt_ok_bal_mag = new System.Windows.Forms.Button();
            this.gb_teste_bal_mag = new System.Windows.Forms.GroupBox();
            this.lbl_peso_bal_mag = new System.Windows.Forms.Label();
            this.bt_pesar_bal_mag = new System.Windows.Forms.Button();
            this.PortaBalMag = new System.IO.Ports.SerialPort(this.components);
            this.bt_sair_bal_mag = new System.Windows.Forms.Button();
            this.gb_teste_bal_mag.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Porta:";
            // 
            // cb_porta_bal_mag
            // 
            this.cb_porta_bal_mag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_porta_bal_mag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_porta_bal_mag.FormattingEnabled = true;
            this.cb_porta_bal_mag.Location = new System.Drawing.Point(132, 37);
            this.cb_porta_bal_mag.Name = "cb_porta_bal_mag";
            this.cb_porta_bal_mag.Size = new System.Drawing.Size(121, 33);
            this.cb_porta_bal_mag.TabIndex = 1;
            this.cb_porta_bal_mag.SelectedIndexChanged += new System.EventHandler(this.cb_porta_bal_mag_SelectedIndexChanged);
            // 
            // bt_ok_bal_mag
            // 
            this.bt_ok_bal_mag.BackColor = System.Drawing.Color.White;
            this.bt_ok_bal_mag.Location = new System.Drawing.Point(276, 37);
            this.bt_ok_bal_mag.Name = "bt_ok_bal_mag";
            this.bt_ok_bal_mag.Size = new System.Drawing.Size(116, 33);
            this.bt_ok_bal_mag.TabIndex = 2;
            this.bt_ok_bal_mag.Text = "OK";
            this.bt_ok_bal_mag.UseVisualStyleBackColor = false;
            this.bt_ok_bal_mag.Click += new System.EventHandler(this.bt_ok_bal_mag_Click);
            // 
            // gb_teste_bal_mag
            // 
            this.gb_teste_bal_mag.Controls.Add(this.lbl_peso_bal_mag);
            this.gb_teste_bal_mag.Controls.Add(this.bt_pesar_bal_mag);
            this.gb_teste_bal_mag.Location = new System.Drawing.Point(26, 90);
            this.gb_teste_bal_mag.Name = "gb_teste_bal_mag";
            this.gb_teste_bal_mag.Size = new System.Drawing.Size(425, 132);
            this.gb_teste_bal_mag.TabIndex = 3;
            this.gb_teste_bal_mag.TabStop = false;
            // 
            // lbl_peso_bal_mag
            // 
            this.lbl_peso_bal_mag.AutoSize = true;
            this.lbl_peso_bal_mag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_peso_bal_mag.ForeColor = System.Drawing.Color.Blue;
            this.lbl_peso_bal_mag.Location = new System.Drawing.Point(228, 54);
            this.lbl_peso_bal_mag.Name = "lbl_peso_bal_mag";
            this.lbl_peso_bal_mag.Size = new System.Drawing.Size(0, 25);
            this.lbl_peso_bal_mag.TabIndex = 13;
            // 
            // bt_pesar_bal_mag
            // 
            this.bt_pesar_bal_mag.BackColor = System.Drawing.Color.White;
            this.bt_pesar_bal_mag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pesar_bal_mag.Location = new System.Drawing.Point(6, 19);
            this.bt_pesar_bal_mag.Name = "bt_pesar_bal_mag";
            this.bt_pesar_bal_mag.Size = new System.Drawing.Size(183, 99);
            this.bt_pesar_bal_mag.TabIndex = 12;
            this.bt_pesar_bal_mag.Text = "PESAR";
            this.bt_pesar_bal_mag.UseVisualStyleBackColor = false;
            this.bt_pesar_bal_mag.Click += new System.EventHandler(this.bt_pesar_bal_mag_Click);
            // 
            // PortaBalMag
            // 
            this.PortaBalMag.DataBits = 7;
            this.PortaBalMag.Parity = System.IO.Ports.Parity.Even;
            // 
            // bt_sair_bal_mag
            // 
            this.bt_sair_bal_mag.BackColor = System.Drawing.Color.Salmon;
            this.bt_sair_bal_mag.Location = new System.Drawing.Point(335, 228);
            this.bt_sair_bal_mag.Name = "bt_sair_bal_mag";
            this.bt_sair_bal_mag.Size = new System.Drawing.Size(116, 33);
            this.bt_sair_bal_mag.TabIndex = 4;
            this.bt_sair_bal_mag.Text = "SAIR";
            this.bt_sair_bal_mag.UseVisualStyleBackColor = false;
            this.bt_sair_bal_mag.Click += new System.EventHandler(this.bt_sair_bal_mag_Click);
            // 
            // f_teste_bal_mag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 291);
            this.ControlBox = false;
            this.Controls.Add(this.bt_sair_bal_mag);
            this.Controls.Add(this.gb_teste_bal_mag);
            this.Controls.Add(this.bt_ok_bal_mag);
            this.Controls.Add(this.cb_porta_bal_mag);
            this.Controls.Add(this.label1);
            this.Name = "f_teste_bal_mag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TESTE - Balança Magellan";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.f_teste_bal_mag_Load);
            this.gb_teste_bal_mag.ResumeLayout(false);
            this.gb_teste_bal_mag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_porta_bal_mag;
        private System.Windows.Forms.Button bt_ok_bal_mag;
        private System.Windows.Forms.GroupBox gb_teste_bal_mag;
        private System.Windows.Forms.Button bt_pesar_bal_mag;
        private System.Windows.Forms.Label lbl_peso_bal_mag;
        private System.IO.Ports.SerialPort PortaBalMag;
        private System.Windows.Forms.Button bt_sair_bal_mag;
    }
}