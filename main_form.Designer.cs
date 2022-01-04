namespace PasswordChecker
{
    partial class main_form
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
            this.check_btn = new System.Windows.Forms.Button();
            this.header_label = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label00 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // check_btn
            // 
            this.check_btn.BackColor = System.Drawing.Color.White;
            this.check_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.check_btn.Location = new System.Drawing.Point(515, 59);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(125, 40);
            this.check_btn.TabIndex = 0;
            this.check_btn.Text = "CHECK";
            this.check_btn.UseVisualStyleBackColor = false;
            this.check_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // header_label
            // 
            this.header_label.AutoSize = true;
            this.header_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.header_label.Location = new System.Drawing.Point(76, 9);
            this.header_label.Name = "header_label";
            this.header_label.Size = new System.Drawing.Size(468, 39);
            this.header_label.TabIndex = 1;
            this.header_label.Text = "How your password is safety?";
            // 
            // password_textBox
            // 
            this.password_textBox.BackColor = System.Drawing.Color.White;
            this.password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.password_textBox.Location = new System.Drawing.Point(12, 60);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(497, 36);
            this.password_textBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Criteries:";
            // 
            // label00
            // 
            this.label00.AutoSize = true;
            this.label00.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label00.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label00.Location = new System.Drawing.Point(33, 152);
            this.label00.Name = "label00";
            this.label00.Size = new System.Drawing.Size(321, 26);
            this.label00.TabIndex = 4;
            this.label00.Text = "Consists of at least 8 characters";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(33, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(297, 26);
            this.label11.TabIndex = 5;
            this.label11.Text = "Uppercase letters are present";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label22.Location = new System.Drawing.Point(33, 204);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(297, 26);
            this.label22.TabIndex = 6;
            this.label22.Text = "Lowercase letters are present";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label33.Location = new System.Drawing.Point(33, 230);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(285, 26);
            this.label33.TabIndex = 7;
            this.label33.Text = "There are special characters";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label44.Location = new System.Drawing.Point(33, 256);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(375, 26);
            this.label44.TabIndex = 8;
            this.label44.Text = "The password is not in the popular list";
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(652, 423);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label00);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.header_label);
            this.Controls.Add(this.check_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main_form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button check_btn;
        private System.Windows.Forms.Label header_label;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label00;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label44;
    }
}