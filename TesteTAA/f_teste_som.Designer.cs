namespace TesteTAA
{
    partial class f_teste_som
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
            this.bt_testarsom = new System.Windows.Forms.Button();
            this.lbl_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_testarsom
            // 
            this.bt_testarsom.Location = new System.Drawing.Point(84, 22);
            this.bt_testarsom.Name = "bt_testarsom";
            this.bt_testarsom.Size = new System.Drawing.Size(139, 74);
            this.bt_testarsom.TabIndex = 10;
            this.bt_testarsom.Text = "Testar";
            this.bt_testarsom.UseVisualStyleBackColor = true;
            this.bt_testarsom.Click += new System.EventHandler(this.bt_testarsom_Click);
            // 
            // lbl_txt
            // 
            this.lbl_txt.AutoSize = true;
            this.lbl_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_txt.Location = new System.Drawing.Point(14, 116);
            this.lbl_txt.Name = "lbl_txt";
            this.lbl_txt.Size = new System.Drawing.Size(0, 24);
            this.lbl_txt.TabIndex = 9;
            // 
            // f_teste_som
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(320, 164);
            this.ControlBox = false;
            this.Controls.Add(this.bt_testarsom);
            this.Controls.Add(this.lbl_txt);
            this.Name = "f_teste_som";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TESTE - Som";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_testarsom;
        private System.Windows.Forms.Label lbl_txt;
    }
}