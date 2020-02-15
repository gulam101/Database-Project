namespace LoginDatabase
{
    partial class Login
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.database_lbl = new System.Windows.Forms.Label();
            this.btn_Help = new System.Windows.Forms.Button();
            this.username_lbl = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(203, 262);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(426, 381);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // database_lbl
            // 
            this.database_lbl.AutoSize = true;
            this.database_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.database_lbl.Location = new System.Drawing.Point(185, 23);
            this.database_lbl.Name = "database_lbl";
            this.database_lbl.Size = new System.Drawing.Size(127, 25);
            this.database_lbl.TabIndex = 2;
            this.database_lbl.Text = "DatabaseX";
            // 
            // btn_Help
            // 
            this.btn_Help.Location = new System.Drawing.Point(12, 381);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(75, 23);
            this.btn_Help.TabIndex = 3;
            this.btn_Help.Text = "Help";
            this.btn_Help.UseVisualStyleBackColor = true;
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lbl.Location = new System.Drawing.Point(18, 29);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(63, 13);
            this.username_lbl.TabIndex = 4;
            this.username_lbl.Text = "Username";
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(21, 45);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(157, 20);
            this.username_textbox.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.password_lbl);
            this.panel1.Controls.Add(this.password_textbox);
            this.panel1.Controls.Add(this.username_lbl);
            this.panel1.Controls.Add(this.username_textbox);
            this.panel1.Location = new System.Drawing.Point(149, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 144);
            this.panel1.TabIndex = 6;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(21, 95);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(157, 20);
            this.password_textbox.TabIndex = 6;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lbl.Location = new System.Drawing.Point(18, 79);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(61, 13);
            this.password_lbl.TabIndex = 7;
            this.password_lbl.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 416);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.database_lbl);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label database_lbl;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.TextBox password_textbox;
    }
}

