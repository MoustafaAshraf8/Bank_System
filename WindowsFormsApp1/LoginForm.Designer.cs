namespace WindowsFormsApp1
{
    partial class LoginForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "CSI bank";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password :";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(141, 184);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(316, 22);
            this.usernameBox.TabIndex = 3;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(141, 246);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(316, 22);
            this.passwordBox.TabIndex = 4;
            // 
            // loginbtn
            // 
            this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Location = new System.Drawing.Point(252, 344);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(76, 28);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.Text = "login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.Location = new System.Drawing.Point(141, 344);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(76, 28);
            this.clearbtn.TabIndex = 6;
            this.clearbtn.Text = "clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            // 
            // exitbtn
            // 
            this.exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(36, 344);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(76, 28);
            this.exitbtn.TabIndex = 7;
            this.exitbtn.Text = "exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(369, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "New account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button button1;
    }
}