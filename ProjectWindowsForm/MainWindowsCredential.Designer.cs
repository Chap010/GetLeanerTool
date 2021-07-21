
namespace Get_Leaner_Demo_Project
{
    partial class MainWindowsCredential
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
            this.LoginSubmitIcon = new System.Windows.Forms.Button();
            this.ExitLoginButton = new System.Windows.Forms.Button();
            this.EnterPasswordIcon = new System.Windows.Forms.Label();
            this.Passwordinput = new System.Windows.Forms.TextBox();
            this.EnterUsernamIcon = new System.Windows.Forms.Label();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.LoginWelcomeIcon = new System.Windows.Forms.Label();
            this.IncorrectCrendIcon = new System.Windows.Forms.Label();
            this.WelcomeIcon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginSubmitIcon
            // 
            this.LoginSubmitIcon.Location = new System.Drawing.Point(85, 166);
            this.LoginSubmitIcon.Name = "LoginSubmitIcon";
            this.LoginSubmitIcon.Size = new System.Drawing.Size(94, 33);
            this.LoginSubmitIcon.TabIndex = 0;
            this.LoginSubmitIcon.Text = "Login";
            this.LoginSubmitIcon.UseVisualStyleBackColor = true;
            this.LoginSubmitIcon.Click += new System.EventHandler(this.LoginSubmitIcon_Click);
            // 
            // ExitLoginButton
            // 
            this.ExitLoginButton.Location = new System.Drawing.Point(205, 166);
            this.ExitLoginButton.Name = "ExitLoginButton";
            this.ExitLoginButton.Size = new System.Drawing.Size(96, 33);
            this.ExitLoginButton.TabIndex = 1;
            this.ExitLoginButton.Text = "Exit";
            this.ExitLoginButton.UseVisualStyleBackColor = true;
            this.ExitLoginButton.Click += new System.EventHandler(this.ExitLoginButton_Click);
            // 
            // EnterPasswordIcon
            // 
            this.EnterPasswordIcon.AutoSize = true;
            this.EnterPasswordIcon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EnterPasswordIcon.Location = new System.Drawing.Point(38, 94);
            this.EnterPasswordIcon.Name = "EnterPasswordIcon";
            this.EnterPasswordIcon.Size = new System.Drawing.Size(134, 21);
            this.EnterPasswordIcon.TabIndex = 2;
            this.EnterPasswordIcon.Text = "Enter Password :";
            // 
            // Passwordinput
            // 
            this.Passwordinput.Location = new System.Drawing.Point(190, 96);
            this.Passwordinput.Name = "Passwordinput";
            this.Passwordinput.Size = new System.Drawing.Size(111, 23);
            this.Passwordinput.TabIndex = 3;
            this.Passwordinput.TextChanged += new System.EventHandler(this.PasswordLogininput_TextChanged);
            // 
            // EnterUsernamIcon
            // 
            this.EnterUsernamIcon.AutoSize = true;
            this.EnterUsernamIcon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EnterUsernamIcon.Location = new System.Drawing.Point(37, 72);
            this.EnterUsernamIcon.Name = "EnterUsernamIcon";
            this.EnterUsernamIcon.Size = new System.Drawing.Size(142, 21);
            this.EnterUsernamIcon.TabIndex = 4;
            this.EnterUsernamIcon.Text = "Enter UserName :";
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(190, 71);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(111, 23);
            this.UsernameInput.TabIndex = 5;
            this.UsernameInput.TextChanged += new System.EventHandler(this.UsernameLoginInput_TextChanged);
            // 
            // LoginWelcomeIcon
            // 
            this.LoginWelcomeIcon.AutoSize = true;
            this.LoginWelcomeIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LoginWelcomeIcon.Location = new System.Drawing.Point(127, 123);
            this.LoginWelcomeIcon.Name = "LoginWelcomeIcon";
            this.LoginWelcomeIcon.Size = new System.Drawing.Size(131, 15);
            this.LoginWelcomeIcon.TabIndex = 6;
            this.LoginWelcomeIcon.Text = "Login Suceed Welcome";
            this.LoginWelcomeIcon.Visible = false;
            // 
            // IncorrectCrendIcon
            // 
            this.IncorrectCrendIcon.AutoSize = true;
            this.IncorrectCrendIcon.ForeColor = System.Drawing.Color.Red;
            this.IncorrectCrendIcon.Location = new System.Drawing.Point(121, 139);
            this.IncorrectCrendIcon.Name = "IncorrectCrendIcon";
            this.IncorrectCrendIcon.Size = new System.Drawing.Size(140, 15);
            this.IncorrectCrendIcon.TabIndex = 7;
            this.IncorrectCrendIcon.Text = "Incorrect Credentials Bro!";
            this.IncorrectCrendIcon.Visible = false;
            // 
            // WelcomeIcon
            // 
            this.WelcomeIcon.AutoSize = true;
            this.WelcomeIcon.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.WelcomeIcon.ForeColor = System.Drawing.Color.Navy;
            this.WelcomeIcon.Location = new System.Drawing.Point(103, 9);
            this.WelcomeIcon.Name = "WelcomeIcon";
            this.WelcomeIcon.Size = new System.Drawing.Size(177, 47);
            this.WelcomeIcon.TabIndex = 8;
            this.WelcomeIcon.Text = "Welcome";
            // 
            // MainWindowsCredential
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 239);
            this.Controls.Add(this.WelcomeIcon);
            this.Controls.Add(this.IncorrectCrendIcon);
            this.Controls.Add(this.LoginWelcomeIcon);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.EnterUsernamIcon);
            this.Controls.Add(this.Passwordinput);
            this.Controls.Add(this.EnterPasswordIcon);
            this.Controls.Add(this.ExitLoginButton);
            this.Controls.Add(this.LoginSubmitIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainWindowsCredential";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginSubmitIcon;
        private System.Windows.Forms.Button ExitLoginButton;
        private System.Windows.Forms.Label EnterPasswordIcon;
        private System.Windows.Forms.TextBox Passwordinput;
        private System.Windows.Forms.Label EnterUsernamIcon;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.Label LoginWelcomeIcon;
        private System.Windows.Forms.Label IncorrectCrendIcon;
        private System.Windows.Forms.Label WelcomeIcon;
    }
}