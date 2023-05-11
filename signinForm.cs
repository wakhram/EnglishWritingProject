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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Xml.Linq;

namespace EnglishWritingProject
{
    public partial class signinForm : Form
    {
        loginForm lF;
        string l = "", n = "";
        public signinForm(loginForm f)
        {
            InitializeComponent();
            lF = f;

            passwordBox.UseSystemPasswordChar = true;

        }

        private void retName (string log, string nname)
        {
            l = log;
            n = nname;
        }

        private bool checkData (string login, string password)
        {
            foreach (XElement xElement in XElement.Load(@"accounts.xml").Elements("Account"))
            {
                XAttribute loginBD = xElement.Attribute("login");
                XElement passwordBD = xElement.Element("password");
                XElement nick = xElement.Element("nickName");

                if (loginBD.Value == login && passwordBD.Value == password) 
                {
                    retName(loginBD.Value, nick.Value);
                    return true;
                }
            }
            return false;
        }

        private void signinButtonClick(object sender, EventArgs e)
        {
            if (checkData(loginBox.Text, passwordBox.Text))
            {
                mainForm newForm = new mainForm(l, n, lF);
                newForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("You entered the wrong password or login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void forgotPasswordClick(object sender, EventArgs e)
        {
            forgotPassordForm ff = new forgotPassordForm(this);
            ff.Show();
            Hide();
        }

        private void showPasswordButton_MouseDown(object sender, MouseEventArgs e)
        {
            passwordBox.UseSystemPasswordChar = false;
        }

        private void showPasswordButton_MouseUp(object sender, MouseEventArgs e)
        {
            passwordBox.UseSystemPasswordChar = true;
        }

        private void signinForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            lF.Show();
        }
    }
}
