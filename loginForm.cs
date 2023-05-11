using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EnglishWritingProject
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            this.TabIndex = 0;

        }

        private void signupButtonClick(object sender, EventArgs e)
        {
            signupForm f = new signupForm(this);
            f.Show();
            Hide();
        }

        private void loginForm_Click(object sender, EventArgs e)
        {
            this.TabIndex = 0;
        }

        private void signinButtonClick(object sender, EventArgs e)
        {
            string filePath = @"accounts.xml";
            if (File.Exists(filePath))
            {
                signinForm signin = new signinForm(this);
                signin.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("You don't have an account yet.\r\nRegister to get started!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
