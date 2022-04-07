namespace TesteTAA
{
    partial class f_teste_sinalizacao
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
            this.bt_ok_sin = new System.Windows.Forms.Button();
            this.cb_porta_sin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_botoes = new System.Windows.Forms.GroupBox();
            this.bt_piscavermelho = new System.Windows.Forms.Button();
            this.bt_piscaamarelo = new System.Windows.Forms.Button();
            this.bt_piscaverde = new System.Windows.Forms.Button();
            this.bt_vermelho = new System.Windows.Forms.Button();
            this.bt_amarelo = new System.Windows.Forms.Button();
            this.bt_verde = new System.Windows.Forms.Button();
            this.bt_sair_sin = new System.Windows.Forms.Button();
            this.PortaSinalizacao = new System.IO.Ports.SerialPort(this.components);
            this.gb_botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_ok_sin
            // 
            this.bt_ok_sin.BackColor = System.Drawing.Color.White;
            this.bt_ok_sin.Location = new System.Drawing.Point(317, 46);
            this.bt_ok_sin.Name = "bt_ok_sin";
            this.bt_ok_sin.Size = new System.Drawing.Size(116, 33);
            this.bt_ok_sin.TabIndex = 10;
            this.bt_ok_sin.Text = "OK";
            this.bt_ok_sin.UseVisualStyleBackColor = false;
            this.bt_ok_sin.Click += new System.EventHandler(this.bt_ok_sin_Click);
            // 
            // cb_porta_sin
            // 
            this.cb_porta_sin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_porta_sin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_porta_sin.FormattingEnabled = true;
            this.cb_porta_sin.Location = new System.Drawing.Point(173, 46);
            this.cb_porta_sin.Name = "cb_porta_sin";
            this.cb_porta_sin.Size = new System.Drawing.Size(121, 33);
            this.cb_porta_sin.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Porta:";
            // 
            // gb_botoes
            // 
            this.gb_botoes.Controls.Add(this.bt_piscavermelho);
            this.gb_botoes.Controls.Add(this.bt_piscaamarelo);
            this.gb_botoes.Controls.Add(this.bt_piscaverde);
            this.gb_botoes.Controls.Add(this.bt_vermelho);
            this.gb_botoes.Controls.Add(this.bt_amarelo);
            this.gb_botoes.Controls.Add(this.bt_verde);
            this.gb_botoes.Location = new System.Drawing.Point(52, 101);
            this.gb_botoes.Name = "gb_botoes";
            this.gb_botoes.Size = new System.Drawing.Size(453, 248);
            this.gb_botoes.TabIndex = 11;
            this.gb_botoes.TabStop = false;
            // 
            // bt_piscavermelho
            // 
            this.bt_piscavermelho.BackColor = System.Drawing.Color.Red;
            this.bt_piscavermelho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_piscavermelho.Location = new System.Drawing.Point(294, 125);
            this.bt_piscavermelho.Name = "bt_piscavermelho";
            this.bt_piscavermelho.Size = new System.Drawing.Size(123, 65);
            this.bt_piscavermelho.TabIndex = 8;
            this.bt_piscavermelho.Text = "PISCAR";
            this.bt_piscavermelho.UseVisualStyleBackColor = false;
            this.bt_piscavermelho.Click += new System.EventHandler(this.bt_piscavermelho_Click);
            // 
            // bt_piscaamarelo
            // 
            this.bt_piscaamarelo.BackColor = System.Drawing.Color.Yellow;
            this.bt_piscaamarelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_piscaamarelo.Location = new System.Drawing.Point(165, 125);
            this.bt_piscaamarelo.Name = "bt_piscaamarelo";
            this.bt_piscaamarelo.Size = new System.Drawing.Size(123, 65);
            this.bt_piscaamarelo.TabIndex = 7;
            this.bt_piscaamarelo.Text = "PISCAR";
            this.bt_piscaamarelo.UseVisualStyleBackColor = false;
            this.bt_piscaamarelo.Click += new System.EventHandler(this.bt_piscaamarelo_Click);
            // 
            // bt_piscaverde
            // 
            this.bt_piscaverde.BackColor = System.Drawing.Color.Lime;
            this.bt_piscaverde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_piscaverde.Location = new System.Drawing.Point(36, 125);
            this.bt_piscaverde.Name = "bt_piscaverde";
            this.bt_piscaverde.Size = new System.Drawing.Size(123, 65);
            this.bt_piscaverde.TabIndex = 6;
            this.bt_piscaverde.Text = "PISCAR";
            this.bt_piscaverde.UseVisualStyleBackColor = false;
            this.bt_piscaverde.Click += new System.EventHandler(this.bt_piscaverde_Click);
            // 
            // bt_vermelho
            // 
            this.bt_vermelho.BackColor = System.Drawing.Color.Red;
            this.bt_vermelho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_vermelho.Location = new System.Drawing.Point(293, 38);
            this.bt_vermelho.Name = "bt_vermelho";
            this.bt_vermelho.Size = new System.Drawing.Size(123, 65);
            this.bt_vermelho.TabIndex = 2;
            this.bt_vermelho.Text = "LIGAR";
            this.bt_vermelho.UseVisualStyleBackColor = false;
            this.bt_vermelho.Click += new System.EventHandler(this.bt_vermelho_Click);
            // 
            // bt_amarelo
            // 
            this.bt_amarelo.BackColor = System.Drawing.Color.Yellow;
            this.bt_amarelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_amarelo.Location = new System.Drawing.Point(164, 38);
            this.bt_amarelo.Name = "bt_amarelo";
            this.bt_amarelo.Size = new System.Drawing.Size(123, 65);
            this.bt_amarelo.TabIndex = 1;
            this.bt_amarelo.Text = "LIGAR";
            this.bt_amarelo.UseVisualStyleBackColor = false;
            this.bt_amarelo.Click += new System.EventHandler(this.bt_amarelo_Click);
            // 
            // bt_verde
            // 
            this.bt_verde.BackColor = System.Drawing.Color.Lime;
            this.bt_verde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_verde.Location = new System.Drawing.Point(35, 38);
            this.bt_verde.Name = "bt_verde";
            this.bt_verde.Size = new System.Drawing.Size(123, 65);
            this.bt_verde.TabIndex = 0;
            this.bt_verde.Text = "LIGAR";
            this.bt_verde.UseVisualStyleBackColor = false;
            this.bt_verde.Click += new System.EventHandler(this.bt_verde_Click);
            // 
            // bt_sair_sin
            // 
            this.bt_sair_sin.BackColor = System.Drawing.Color.Salmon;
            this.bt_sair_sin.Location = new System.Drawing.Point(389, 355);
            this.bt_sair_sin.Name = "bt_sair_sin";
            this.bt_sair_sin.Size = new System.Drawing.Size(116, 33);
            this.bt_sair_sin.TabIndex = 12;
            this.bt_sair_sin.Text = "SAIR";
            this.bt_sair_sin.UseVisualStyleBackColor = false;
            this.bt_sair_sin.Click += new System.EventHandler(this.bt_sair_sin_Click);
            // 
            // f_teste_sinalizacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 445);
            this.ControlBox = false;
            this.Controls.Add(this.bt_sair_sin);
            this.Controls.Add(this.gb_botoes);
            this.Controls.Add(this.bt_ok_sin);
            this.Controls.Add(this.cb_porta_sin);
            this.Controls.Add(this.label1);
            this.Name = "f_teste_sinalizacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TESTE - Sinalização";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.f_teste_sinalizacao_Load);
            this.gb_botoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_ok_sin;
        private System.Windows.Forms.ComboBox cb_porta_sin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_botoes;
        private System.Windows.Forms.Button bt_piscavermelho;
        private System.Windows.Forms.Button bt_piscaamarelo;
        private System.Windows.Forms.Button bt_piscaverde;
        private System.Windows.Forms.Button bt_vermelho;
        private System.Windows.Forms.Button bt_amarelo;
        private System.Windows.Forms.Button bt_verde;
        private System.Windows.Forms.Button bt_sair_sin;
        private System.IO.Ports.SerialPort PortaSinalizacao;
    }
}