using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace EnglishWritingProject
{
    public partial class forgotPassordForm : Form
    {
        signinForm form;
        public forgotPassordForm(signinForm f)
        {
            InitializeComponent();
            form = f;

            passwordBox.UseSystemPasswordChar = true;
            password2Box.UseSystemPasswordChar = true;

        }

        private void backButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        int k = 0;
        DispatcherTimer timer;

        private void timer_Tick(object sender, EventArgs e)
        {
            k++;
            if (k == 3)
            {
                timer.Stop();
                this.Close();
            }
        }
/*
        private void changeAccXMLLinq(string accNickName, string login, string email, string password, string fileName)
        {
            XDocument xdoc = XDocument.Load(fileName);
            XElement root = xdoc.Element("datas");


            if (root != null)
            {
                // добавляем новый элемент
                root.Add(new XElement("Account",
                            new XAttribute("login", login),
                            new XElement("nickName", accNickName),
                            new XElement("email", email),
                            new XElement("password", password)));
                xdoc.Save(fileName);
            }

        }
*/
        private bool checkPassword(string pass1)
        {
            int z = 0;
            char[] checkPass = pass1.ToCharArray();
            for (int i = 65; i <= 90; i++)
            {
                if (pass1.Contains((char)i))
                {
                    z++;
                    break;
                }
            }

            for (int i = 97; i <= 122; i++)
            {
                if (pass1.Contains((char)i))
                {
                    z++;
                    break;
                }
            }

            for (int i = 48; i <= 57; i++)
            {
                if (pass1.Contains((char)i))
                {
                    z++;
                    break;
                }
            }

            return (z == 3);
        }

        private void checkButtonClick(object sender, EventArgs e)
        {
            bool check = false;
            foreach (XElement xElement in XElement.Load(@"accounts.xml").Elements("Account"))
            {
                if (xElement.Element("email").Value == emailBox.Text)
                {
                    colorBox.BackColor = Color.Green;
                    check = true;

                    passwordBox.Enabled = true;
                    password2Box.Enabled = true;
                    break;
                }
            }
            if (!check)
            {
                passwordBox.Enabled = false;
                password2Box.Enabled = false;
                colorBox.BackColor = Color.Red;
            }
        }

        private void forgotPassordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Show();
        }

        private void showPasswordButton_MouseDown(object sender, MouseEventArgs e)
        {
            passwordBox.UseSystemPasswordChar = false;
            password2Box.UseSystemPasswordChar = false;
        }

        private void showPasswordButton_MouseUp(object sender, MouseEventArgs e)
        {
            passwordBox.UseSystemPasswordChar = true;
            password2Box.UseSystemPasswordChar = true;
        }

        private void updatePasswordButtonClick(object sender, EventArgs e)
        {
            if (passwordBox.Text == password2Box.Text && checkPassword(passwordBox.Text))
            {
                bool check = true;

                XDocument xdoc2 = XDocument.Load("accounts.xml");
                var acc = xdoc2.Element("datas").Elements("Account").FirstOrDefault(p => p.Element("email")?.Value == emailBox.Text);
                if (acc != null)
                {
                    var p = acc.Element("password");
                    p.Value = passwordBox.Text;
                    check = true;

                    xdoc2.Save("accounts.xml");
                }

                if (check)
                {
                    MessageBox.Show("Password update was successful!\r\nClick 'OK' and this window will close in 3 seconds...", "Everything is fine", MessageBoxButtons.OK);

                    timer = new DispatcherTimer();
                    timer.Interval = TimeSpan.FromSeconds(1);
                    timer.Tick += timer_Tick;
                    timer.Start();
                }
            }
            else
            {
                MessageBox.Show("You filled in the fields incorrectly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
