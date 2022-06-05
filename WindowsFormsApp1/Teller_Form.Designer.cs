namespace WindowsFormsApp1
{
    partial class Teller_Form
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DepositeRadio = new System.Windows.Forms.RadioButton();
            this.WithdrawRadio = new System.Windows.Forms.RadioButton();
            this.TransfereRadio = new System.Windows.Forms.RadioButton();
            this.BalanceRadio = new System.Windows.Forms.RadioButton();
            this.CreateRadio = new System.Windows.Forms.RadioButton();
            this.DeleteRadio = new System.Windows.Forms.RadioButton();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operations :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 8.25F);
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Deposite :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 8.25F);
            this.label5.Location = new System.Drawing.Point(12, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Withdraw :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 8.25F);
            this.label6.Location = new System.Drawing.Point(14, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Transfere :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 8.25F);
            this.label7.Location = new System.Drawing.Point(12, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Check Balance :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 8.25F);
            this.label8.Location = new System.Drawing.Point(211, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Create user :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 8.25F);
            this.label9.Location = new System.Drawing.Point(211, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Delete user :";
            // 
            // DepositeRadio
            // 
            this.DepositeRadio.AutoSize = true;
            this.DepositeRadio.Location = new System.Drawing.Point(151, 137);
            this.DepositeRadio.Name = "DepositeRadio";
            this.DepositeRadio.Size = new System.Drawing.Size(17, 16);
            this.DepositeRadio.TabIndex = 9;
            this.DepositeRadio.TabStop = true;
            this.DepositeRadio.UseVisualStyleBackColor = true;
            // 
            // WithdrawRadio
            // 
            this.WithdrawRadio.AutoSize = true;
            this.WithdrawRadio.Location = new System.Drawing.Point(151, 185);
            this.WithdrawRadio.Name = "WithdrawRadio";
            this.WithdrawRadio.Size = new System.Drawing.Size(17, 16);
            this.WithdrawRadio.TabIndex = 10;
            this.WithdrawRadio.TabStop = true;
            this.WithdrawRadio.UseVisualStyleBackColor = true;
            // 
            // TransfereRadio
            // 
            this.TransfereRadio.AutoSize = true;
            this.TransfereRadio.Location = new System.Drawing.Point(151, 241);
            this.TransfereRadio.Name = "TransfereRadio";
            this.TransfereRadio.Size = new System.Drawing.Size(17, 16);
            this.TransfereRadio.TabIndex = 11;
            this.TransfereRadio.TabStop = true;
            this.TransfereRadio.UseVisualStyleBackColor = true;
            // 
            // BalanceRadio
            // 
            this.BalanceRadio.AutoSize = true;
            this.BalanceRadio.Location = new System.Drawing.Point(151, 296);
            this.BalanceRadio.Name = "BalanceRadio";
            this.BalanceRadio.Size = new System.Drawing.Size(17, 16);
            this.BalanceRadio.TabIndex = 12;
            this.BalanceRadio.TabStop = true;
            this.BalanceRadio.UseVisualStyleBackColor = true;
            // 
            // CreateRadio
            // 
            this.CreateRadio.AutoSize = true;
            this.CreateRadio.Location = new System.Drawing.Point(334, 137);
            this.CreateRadio.Name = "CreateRadio";
            this.CreateRadio.Size = new System.Drawing.Size(17, 16);
            this.CreateRadio.TabIndex = 13;
            this.CreateRadio.TabStop = true;
            this.CreateRadio.UseVisualStyleBackColor = true;
            // 
            // DeleteRadio
            // 
            this.DeleteRadio.AutoSize = true;
            this.DeleteRadio.Location = new System.Drawing.Point(334, 185);
            this.DeleteRadio.Name = "DeleteRadio";
            this.DeleteRadio.Size = new System.Drawing.Size(17, 16);
            this.DeleteRadio.TabIndex = 14;
            this.DeleteRadio.TabStop = true;
            this.DeleteRadio.UseVisualStyleBackColor = true;
            // 
            // logoutbtn
            // 
            this.logoutbtn.Location = new System.Drawing.Point(365, 12);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(59, 33);
            this.logoutbtn.TabIndex = 15;
            this.logoutbtn.Text = "logout";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(334, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Proceed->";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorlabel
            // 
            this.errorlabel.AutoSize = true;
            this.errorlabel.ForeColor = System.Drawing.Color.Red;
            this.errorlabel.Location = new System.Drawing.Point(129, 363);
            this.errorlabel.Name = "errorlabel";
            this.errorlabel.Size = new System.Drawing.Size(0, 16);
            this.errorlabel.TabIndex = 17;
            // 
            // Teller_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 398);
            this.Controls.Add(this.errorlabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.DeleteRadio);
            this.Controls.Add(this.CreateRadio);
            this.Controls.Add(this.BalanceRadio);
            this.Controls.Add(this.TransfereRadio);
            this.Controls.Add(this.WithdrawRadio);
            this.Controls.Add(this.DepositeRadio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Teller_Form";
            this.Text = "TellerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton DepositeRadio;
        private System.Windows.Forms.RadioButton WithdrawRadio;
        private System.Windows.Forms.RadioButton TransfereRadio;
        private System.Windows.Forms.RadioButton BalanceRadio;
        private System.Windows.Forms.RadioButton CreateRadio;
        private System.Windows.Forms.RadioButton DeleteRadio;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label errorlabel;
    }
}