namespace TesteTAA
{
    partial class f_teste_touch
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
            this.bt_touch1 = new System.Windows.Forms.Button();
            this.bt_touch2 = new System.Windows.Forms.Button();
            this.bt_touch3 = new System.Windows.Forms.Button();
            this.bt_touch4 = new System.Windows.Forms.Button();
            this.bt_touch5 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bt_touch1
            // 
            this.bt_touch1.BackColor = System.Drawing.Color.Red;
            this.bt_touch1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_touch1.Location = new System.Drawing.Point(12, 12);
            this.bt_touch1.Name = "bt_touch1";
            this.bt_touch1.Size = new System.Drawing.Size(127, 65);
            this.bt_touch1.TabIndex = 0;
            this.bt_touch1.Text = "TOQUE AQUI";
            this.bt_touch1.UseVisualStyleBackColor = false;
            this.bt_touch1.Click += new System.EventHandler(this.bt_touch1_Click);
            // 
            // bt_touch2
            // 
            this.bt_touch2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_touch2.BackColor = System.Drawing.Color.Red;
            this.bt_touch2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_touch2.Location = new System.Drawing.Point(12, 589);
            this.bt_touch2.Name = "bt_touch2";
            this.bt_touch2.Size = new System.Drawing.Size(127, 65);
            this.bt_touch2.TabIndex = 1;
            this.bt_touch2.Text = "TOQUE AQUI";
            this.bt_touch2.UseVisualStyleBackColor = false;
            this.bt_touch2.Visible = false;
            this.bt_touch2.Click += new System.EventHandler(this.bt_touch2_Click);
            // 
            // bt_touch3
            // 
            this.bt_touch3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_touch3.BackColor = System.Drawing.Color.Red;
            this.bt_touch3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_touch3.Location = new System.Drawing.Point(870, 12);
            this.bt_touch3.Name = "bt_touch3";
            this.bt_touch3.Size = new System.Drawing.Size(127, 65);
            this.bt_touch3.TabIndex = 2;
            this.bt_touch3.Text = "TOQUE AQUI";
            this.bt_touch3.UseVisualStyleBackColor = false;
            this.bt_touch3.Visible = false;
            this.bt_touch3.Click += new System.EventHandler(this.bt_touch3_Click);
            // 
            // bt_touch4
            // 
            this.bt_touch4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_touch4.BackColor = System.Drawing.Color.Red;
            this.bt_touch4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_touch4.Location = new System.Drawing.Point(870, 589);
            this.bt_touch4.Name = "bt_touch4";
            this.bt_touch4.Size = new System.Drawing.Size(127, 65);
            this.bt_touch4.TabIndex = 3;
            this.bt_touch4.Text = "TOQUE AQUI";
            this.bt_touch4.UseVisualStyleBackColor = false;
            this.bt_touch4.Visible = false;
            this.bt_touch4.Click += new System.EventHandler(this.bt_touch4_Click);
            // 
            // bt_touch5
            // 
            this.bt_touch5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_touch5.BackColor = System.Drawing.Color.Red;
            this.bt_touch5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_touch5.Location = new System.Drawing.Point(424, 298);
            this.bt_touch5.Name = "bt_touch5";
            this.bt_touch5.Size = new System.Drawing.Size(127, 65);
            this.bt_touch5.TabIndex = 4;
            this.bt_touch5.Text = "TOQUE AQUI";
            this.bt_touch5.UseVisualStyleBackColor = false;
            this.bt_touch5.Visible = false;
            this.bt_touch5.Click += new System.EventHandler(this.bt_touch5_Click);
            // 
            // f_teste_touch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1009, 666);
            this.ControlBox = false;
            this.Controls.Add(this.bt_touch5);
            this.Controls.Add(this.bt_touch4);
            this.Controls.Add(this.bt_touch3);
            this.Controls.Add(this.bt_touch2);
            this.Controls.Add(this.bt_touch1);
            this.Name = "f_teste_touch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TESTE - Touchscreen";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.f_teste_touch_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_touch1;
        private System.Windows.Forms.Button bt_touch2;
        private System.Windows.Forms.Button bt_touch3;
        private System.Windows.Forms.Button bt_touch4;
        private System.Windows.Forms.Button bt_touch5;
        private System.Windows.Forms.Timer timer1;
    }
}