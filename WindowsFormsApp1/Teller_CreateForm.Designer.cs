namespace WindowsFormsApp1
{
    partial class Teller_CreateForm
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
            this.cancelbtn = new System.Windows.Forms.Button();
            this.createaccountbtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.savingsRadio = new System.Windows.Forms.RadioButton();
            this.fixedRadio = new System.Windows.Forms.RadioButton();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.workingdirectionBox = new System.Windows.Forms.TextBox();
            this.phonenumberBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.nidBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.userlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelbtn
            // 
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.Location = new System.Drawing.Point(7, 469);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(89, 37);
            this.cancelbtn.TabIndex = 42;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // createaccountbtn
            // 
            this.createaccountbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createaccountbtn.Location = new System.Drawing.Point(328, 430);
            this.createaccountbtn.Name = "createaccountbtn";
            this.createaccountbtn.Size = new System.Drawing.Size(160, 40);
            this.createaccountbtn.TabIndex = 41;
            this.createaccountbtn.Text = "Create account";
            this.createaccountbtn.UseVisualStyleBackColor = true;
            this.createaccountbtn.Click += new System.EventHandler(this.createaccountbtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(282, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 29);
            this.label10.TabIndex = 40;
            this.label10.Text = "Fill this form";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "User :";
            // 
            // savingsRadio
            // 
            this.savingsRadio.AutoSize = true;
            this.savingsRadio.Location = new System.Drawing.Point(411, 288);
            this.savingsRadio.Name = "savingsRadio";
            this.savingsRadio.Size = new System.Drawing.Size(77, 20);
            this.savingsRadio.TabIndex = 38;
            this.savingsRadio.TabStop = true;
            this.savingsRadio.Text = "Savings";
            this.savingsRadio.UseVisualStyleBackColor = true;
            // 
            // fixedRadio
            // 
            this.fixedRadio.AutoSize = true;
            this.fixedRadio.Location = new System.Drawing.Point(217, 288);
            this.fixedRadio.Name = "fixedRadio";
            this.fixedRadio.Size = new System.Drawing.Size(61, 20);
            this.fixedRadio.TabIndex = 37;
            this.fixedRadio.TabStop = true;
            this.fixedRadio.Text = "Fixed";
            this.fixedRadio.UseVisualStyleBackColor = true;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(217, 371);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(373, 22);
            this.passwordBox.TabIndex = 36;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(217, 328);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(373, 22);
            this.usernameBox.TabIndex = 35;
            // 
            // workingdirectionBox
            // 
            this.workingdirectionBox.Location = new System.Drawing.Point(217, 240);
            this.workingdirectionBox.Name = "workingdirectionBox";
            this.workingdirectionBox.Size = new System.Drawing.Size(373, 22);
            this.workingdirectionBox.TabIndex = 34;
            // 
            // phonenumberBox
            // 
            this.phonenumberBox.Location = new System.Drawing.Point(217, 199);
            this.phonenumberBox.Name = "phonenumberBox";
            this.phonenumberBox.Size = new System.Drawing.Size(373, 22);
            this.phonenumberBox.TabIndex = 33;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(217, 160);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(373, 22);
            this.addressBox.TabIndex = 32;
            // 
            // nidBox
            // 
            this.nidBox.Location = new System.Drawing.Point(217, 120);
            this.nidBox.Name = "nidBox";
            this.nidBox.Size = new System.Drawing.Size(373, 22);
            this.nidBox.TabIndex = 31;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(217, 77);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(373, 22);
            this.nameBox.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Password :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Username :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Account type :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Working direction :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Phone number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "National ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Name :";
            // 
            // logoutbtn
            // 
            this.logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.Location = new System.Drawing.Point(556, 7);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(84, 37);
            this.logoutbtn.TabIndex = 43;
            this.logoutbtn.Text = "logout";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlabel.Location = new System.Drawing.Point(55, 3);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(41, 18);
            this.userlabel.TabIndex = 44;
            this.userlabel.Text = "user";
            // 
            // Teller_CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 518);
            this.Controls.Add(this.userlabel);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.createaccountbtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.savingsRadio);
            this.Controls.Add(this.fixedRadio);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.workingdirectionBox);
            this.Controls.Add(this.phonenumberBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.nidBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Teller_CreateForm";
            this.Text = "Teller_CreateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button createaccountbtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton savingsRadio;
        private System.Windows.Forms.RadioButton fixedRadio;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox workingdirectionBox;
        private System.Windows.Forms.TextBox phonenumberBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox nidBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Label userlabel;
    }
}