using ProjectWindowsForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Get_Leaner_Demo_Project
{
    public partial class MainWindowsCredential : Form
    {


        GetLeanerWin myTool = new GetLeanerWin();
        

        public MainWindowsCredential()
        {
            InitializeComponent();

        }

        private void UsernameLoginInput_TextChanged(object sender, EventArgs e)
        {
            UsernameInput.MaxLength = 5;
        }

        private void PasswordLogininput_TextChanged(object sender, EventArgs e)
        {
           Passwordinput.MaxLength = 5;
        }

           
       private void LoginSubmitIcon_Click(object sender, EventArgs e)
        {

            string user;
            string pass;
            user = UsernameInput.Text;
            pass = Passwordinput.Text;
            
            if (user == "su" && pass == "337")
                {
                LoginWelcomeIcon.Visible = true;
                myTool.Show();
                this.Hide();

                

                }
           else
               {
                IncorrectCrendIcon.Visible = true;
               }
            
        }

        private void ExitLoginButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
