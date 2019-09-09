namespace WindowsFormsApplication2
{
    partial class log
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
            this.panel9 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.submit1 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel9.BackColor = System.Drawing.Color.PaleGreen;
            this.panel9.Controls.Add(this.panel1);
            this.panel9.Location = new System.Drawing.Point(83, 37);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(588, 470);
            this.panel9.TabIndex = 8;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Sienna;
            this.label24.Location = new System.Drawing.Point(284, 327);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(123, 20);
            this.label24.TabIndex = 7;
            this.label24.Text = "forgot pssword?";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Sienna;
            this.label23.Location = new System.Drawing.Point(273, 302);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(134, 20);
            this.label23.TabIndex = 6;
            this.label23.Text = "change pssword?";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // submit1
            // 
            this.submit1.BackColor = System.Drawing.Color.LimeGreen;
            this.submit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit1.ForeColor = System.Drawing.Color.White;
            this.submit1.Location = new System.Drawing.Point(57, 223);
            this.submit1.Name = "submit1";
            this.submit1.Size = new System.Drawing.Size(305, 39);
            this.submit1.TabIndex = 5;
            this.submit1.Text = "Submit";
            this.submit1.UseVisualStyleBackColor = false;
            this.submit1.Click += new System.EventHandler(this.submit1_Click);
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(169, 144);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.PasswordChar = '*';
            this.textBox11.Size = new System.Drawing.Size(180, 35);
            this.textBox11.TabIndex = 4;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(169, 94);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(180, 35);
            this.textBox9.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(37, 150);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(112, 24);
            this.label22.TabIndex = 2;
            this.label22.Text = "Password :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(33, 97);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(117, 24);
            this.label21.TabIndex = 1;
            this.label21.Text = "Username :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.LimeGreen;
            this.label20.Location = new System.Drawing.Point(94, 14);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(208, 37);
            this.label20.TabIndex = 0;
            this.label20.Text = "Admin Login";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.submit1);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.textBox11);
            this.panel1.Location = new System.Drawing.Point(89, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 356);
            this.panel1.TabIndex = 8;
            // 
            // log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 553);
            this.Controls.Add(this.panel9);
            this.Name = "log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.login_Load);
            this.panel9.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button submit1;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel1;
    }
}