namespace WindowsFormsApp1
{
    partial class User_Form
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
            this.namelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.BalanceRadio = new System.Windows.Forms.RadioButton();
            this.DepositeRadio = new System.Windows.Forms.RadioButton();
            this.WithdrawRadio = new System.Windows.Forms.RadioButton();
            this.TransfereRadio = new System.Windows.Forms.RadioButton();
            this.proceedbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcom";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Harlow Solid Italic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.Location = new System.Drawing.Point(80, 13);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(50, 22);
            this.namelabel.TabIndex = 1;
            this.namelabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Operations :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Show Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Deposite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Withdraw";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Transfere";
            // 
            // logoutbtn
            // 
            this.logoutbtn.Location = new System.Drawing.Point(346, 6);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(72, 35);
            this.logoutbtn.TabIndex = 11;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // BalanceRadio
            // 
            this.BalanceRadio.AutoSize = true;
            this.BalanceRadio.Location = new System.Drawing.Point(135, 131);
            this.BalanceRadio.Name = "BalanceRadio";
            this.BalanceRadio.Size = new System.Drawing.Size(17, 16);
            this.BalanceRadio.TabIndex = 0;
            this.BalanceRadio.TabStop = true;
            this.BalanceRadio.UseVisualStyleBackColor = true;
            // 
            // DepositeRadio
            // 
            this.DepositeRadio.AutoSize = true;
            this.DepositeRadio.Location = new System.Drawing.Point(135, 189);
            this.DepositeRadio.Name = "DepositeRadio";
            this.DepositeRadio.Size = new System.Drawing.Size(17, 16);
            this.DepositeRadio.TabIndex = 1;
            this.DepositeRadio.TabStop = true;
            this.DepositeRadio.UseVisualStyleBackColor = true;
            // 
            // WithdrawRadio
            // 
            this.WithdrawRadio.AutoSize = true;
            this.WithdrawRadio.Location = new System.Drawing.Point(135, 252);
            this.WithdrawRadio.Name = "WithdrawRadio";
            this.WithdrawRadio.Size = new System.Drawing.Size(17, 16);
            this.WithdrawRadio.TabIndex = 12;
            this.WithdrawRadio.TabStop = true;
            this.WithdrawRadio.UseVisualStyleBackColor = true;
            // 
            // TransfereRadio
            // 
            this.TransfereRadio.AutoSize = true;
            this.TransfereRadio.Location = new System.Drawing.Point(135, 318);
            this.TransfereRadio.Name = "TransfereRadio";
            this.TransfereRadio.Size = new System.Drawing.Size(17, 16);
            this.TransfereRadio.TabIndex = 13;
            this.TransfereRadio.TabStop = true;
            this.TransfereRadio.UseVisualStyleBackColor = true;
            // 
            // proceedbtn
            // 
            this.proceedbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedbtn.Location = new System.Drawing.Point(307, 405);
            this.proceedbtn.Name = "proceedbtn";
            this.proceedbtn.Size = new System.Drawing.Size(111, 33);
            this.proceedbtn.TabIndex = 14;
            this.proceedbtn.Text = "Proceed ->";
            this.proceedbtn.UseVisualStyleBackColor = true;
            this.proceedbtn.Click += new System.EventHandler(this.proceedbtn_Click);
            // 
            // User_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.proceedbtn);
            this.Controls.Add(this.TransfereRadio);
            this.Controls.Add(this.WithdrawRadio);
            this.Controls.Add(this.DepositeRadio);
            this.Controls.Add(this.BalanceRadio);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.label1);
            this.Name = "User_Form";
            this.Text = "UserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.RadioButton DepositeRadio;
        private System.Windows.Forms.RadioButton BalanceRadio;
        private System.Windows.Forms.RadioButton WithdrawRadio;
        private System.Windows.Forms.RadioButton TransfereRadio;
        private System.Windows.Forms.Button proceedbtn;
    }
}