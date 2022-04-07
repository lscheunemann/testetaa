namespace TesteTAA
{
    partial class f_teste_leitor_mag
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
            this.bt_ok_leitor_mag = new System.Windows.Forms.Button();
            this.cb_porta_leitor_mag = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_texto = new System.Windows.Forms.Label();
            this.bt_bal_prix = new System.Windows.Forms.Button();
            this.PortaLeitorMag = new System.IO.Ports.SerialPort(this.components);
            this.lbl_leitor_ok = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_ok_leitor_mag
            // 
            this.bt_ok_leitor_mag.BackColor = System.Drawing.Color.White;
            this.bt_ok_leitor_mag.Location = new System.Drawing.Point(287, 37);
            this.bt_ok_leitor_mag.Name = "bt_ok_leitor_mag";
            this.bt_ok_leitor_mag.Size = new System.Drawing.Size(116, 33);
            this.bt_ok_leitor_mag.TabIndex = 10;
            this.bt_ok_leitor_mag.Text = "OK";
            this.bt_ok_leitor_mag.UseVisualStyleBackColor = false;
            this.bt_ok_leitor_mag.Click += new System.EventHandler(this.bt_ok_leitor_mag_Click);
            // 
            // cb_porta_leitor_mag
            // 
            this.cb_porta_leitor_mag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_porta_leitor_mag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_porta_leitor_mag.FormattingEnabled = true;
            this.cb_porta_leitor_mag.Location = new System.Drawing.Point(143, 37);
            this.cb_porta_leitor_mag.Name = "cb_porta_leitor_mag";
            this.cb_porta_leitor_mag.Size = new System.Drawing.Size(121, 33);
            this.cb_porta_leitor_mag.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Porta:";
            // 
            // lbl_texto
            // 
            this.lbl_texto.AutoSize = true;
            this.lbl_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_texto.ForeColor = System.Drawing.Color.Blue;
            this.lbl_texto.Location = new System.Drawing.Point(58, 146);
            this.lbl_texto.Name = "lbl_texto";
            this.lbl_texto.Size = new System.Drawing.Size(0, 25);
            this.lbl_texto.TabIndex = 11;
            // 
            // bt_bal_prix
            // 
            this.bt_bal_prix.BackColor = System.Drawing.Color.White;
            this.bt_bal_prix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_bal_prix.Location = new System.Drawing.Point(157, 267);
            this.bt_bal_prix.Name = "bt_bal_prix";
            this.bt_bal_prix.Size = new System.Drawing.Size(183, 99);
            this.bt_bal_prix.TabIndex = 12;
            this.bt_bal_prix.Text = "VOLTAR";
            this.bt_bal_prix.UseVisualStyleBackColor = false;
            this.bt_bal_prix.Click += new System.EventHandler(this.bt_bal_prix_Click);
            // 
            // lbl_leitor_ok
            // 
            this.lbl_leitor_ok.AutoSize = true;
            this.lbl_leitor_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leitor_ok.ForeColor = System.Drawing.Color.Blue;
            this.lbl_leitor_ok.Location = new System.Drawing.Point(191, 195);
            this.lbl_leitor_ok.Name = "lbl_leitor_ok";
            this.lbl_leitor_ok.Size = new System.Drawing.Size(0, 25);
            this.lbl_leitor_ok.TabIndex = 13;
            // 
            // f_teste_leitor_mag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 410);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_leitor_ok);
            this.Controls.Add(this.bt_bal_prix);
            this.Controls.Add(this.lbl_texto);
            this.Controls.Add(this.bt_ok_leitor_mag);
            this.Controls.Add(this.cb_porta_leitor_mag);
            this.Controls.Add(this.label1);
            this.Name = "f_teste_leitor_mag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TESTE - Leitor de barras Magellan";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.f_teste_leitor_mag_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_ok_leitor_mag;
        private System.Windows.Forms.ComboBox cb_porta_leitor_mag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_texto;
        private System.Windows.Forms.Button bt_bal_prix;
        private System.IO.Ports.SerialPort PortaLeitorMag;
        private System.Windows.Forms.Label lbl_leitor_ok;
    }
}