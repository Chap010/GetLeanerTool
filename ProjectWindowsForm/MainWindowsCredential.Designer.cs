
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
            this.components = new System.ComponentModel.Container();
            this.LoginSubmitIcon = new System.Windows.Forms.Button();
            this.ExitLoginButton = new System.Windows.Forms.Button();
            this.EnterPasswordIcon = new System.Windows.Forms.Label();
            this.Passwordinput = new System.Windows.Forms.TextBox();
            this.EnterUsernamIcon = new System.Windows.Forms.Label();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.LoginWelcomeIcon = new System.Windows.Forms.Label();
            this.IncorrectCrendIcon = new System.Windows.Forms.Label();
            this.WelcomeIcon = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LoginSubmitIcon
            // 
            this.LoginSubmitIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(224)))));
            this.LoginSubmitIcon.Location = new System.Drawing.Point(54, 238);
            this.LoginSubmitIcon.Name = "LoginSubmitIcon";
            this.LoginSubmitIcon.Size = new System.Drawing.Size(94, 33);
            this.LoginSubmitIcon.TabIndex = 0;
            this.LoginSubmitIcon.Text = "Login";
            this.LoginSubmitIcon.UseVisualStyleBackColor = false;
            this.LoginSubmitIcon.Click += new System.EventHandler(this.LoginSubmitIcon_Click);
            // 
            // ExitLoginButton
            // 
            this.ExitLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(224)))));
            this.ExitLoginButton.Location = new System.Drawing.Point(170, 238);
            this.ExitLoginButton.Name = "ExitLoginButton";
            this.ExitLoginButton.Size = new System.Drawing.Size(96, 33);
            this.ExitLoginButton.TabIndex = 1;
            this.ExitLoginButton.Text = "Exit";
            this.ExitLoginButton.UseVisualStyleBackColor = false;
            this.ExitLoginButton.Click += new System.EventHandler(this.ExitLoginButton_Click);
            // 
            // EnterPasswordIcon
            // 
            this.EnterPasswordIcon.AutoSize = true;
            this.EnterPasswordIcon.BackColor = System.Drawing.Color.White;
            this.EnterPasswordIcon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EnterPasswordIcon.ForeColor = System.Drawing.Color.MidnightBlue;
            this.EnterPasswordIcon.Location = new System.Drawing.Point(12, 134);
            this.EnterPasswordIcon.Name = "EnterPasswordIcon";
            this.EnterPasswordIcon.Size = new System.Drawing.Size(134, 21);
            this.EnterPasswordIcon.TabIndex = 2;
            this.EnterPasswordIcon.Text = "Enter Password :";
            // 
            // Passwordinput
            // 
            this.Passwordinput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(224)))));
            this.Passwordinput.Location = new System.Drawing.Point(162, 136);
            this.Passwordinput.Name = "Passwordinput";
            this.Passwordinput.Size = new System.Drawing.Size(111, 23);
            this.Passwordinput.TabIndex = 3;
            this.Passwordinput.TextChanged += new System.EventHandler(this.PasswordLogininput_TextChanged);
            // 
            // EnterUsernamIcon
            // 
            this.EnterUsernamIcon.AutoSize = true;
            this.EnterUsernamIcon.BackColor = System.Drawing.Color.White;
            this.EnterUsernamIcon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EnterUsernamIcon.ForeColor = System.Drawing.Color.MidnightBlue;
            this.EnterUsernamIcon.Location = new System.Drawing.Point(12, 109);
            this.EnterUsernamIcon.Name = "EnterUsernamIcon";
            this.EnterUsernamIcon.Size = new System.Drawing.Size(142, 21);
            this.EnterUsernamIcon.TabIndex = 4;
            this.EnterUsernamIcon.Text = "Enter UserName :";
            // 
            // UsernameInput
            // 
            this.UsernameInput.BackColor = System.Drawing.Color.White;
            this.UsernameInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(224)))));
            this.UsernameInput.Location = new System.Drawing.Point(162, 107);
            this.UsernameInput.Multiline = true;
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(111, 23);
            this.UsernameInput.TabIndex = 5;
            this.UsernameInput.TextChanged += new System.EventHandler(this.UsernameLoginInput_TextChanged);
            // 
            // LoginWelcomeIcon
            // 
            this.LoginWelcomeIcon.AutoSize = true;
            this.LoginWelcomeIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LoginWelcomeIcon.Location = new System.Drawing.Point(93, 186);
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
            this.IncorrectCrendIcon.Location = new System.Drawing.Point(92, 201);
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
            this.WelcomeIcon.ForeColor = System.Drawing.Color.MidnightBlue;
            this.WelcomeIcon.Location = new System.Drawing.Point(75, 37);
            this.WelcomeIcon.Name = "WelcomeIcon";
            this.WelcomeIcon.Size = new System.Drawing.Size(177, 47);
            this.WelcomeIcon.TabIndex = 8;
            this.WelcomeIcon.Text = "Welcome";
            // 
            // MainWindowsCredential
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(320, 311);
            this.Controls.Add(this.WelcomeIcon);
            this.Controls.Add(this.IncorrectCrendIcon);
            this.Controls.Add(this.LoginWelcomeIcon);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.EnterUsernamIcon);
            this.Controls.Add(this.Passwordinput);
            this.Controls.Add(this.EnterPasswordIcon);
            this.Controls.Add(this.ExitLoginButton);
            this.Controls.Add(this.LoginSubmitIcon);
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.Timer timer1;
    }
}