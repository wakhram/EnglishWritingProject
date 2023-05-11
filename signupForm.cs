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
using System.Windows.Threading;
using System.Runtime.Remoting.Channels;

namespace EnglishWritingProject
{
    public partial class signupForm : Form
    {
        loginForm form;
        public signupForm(loginForm f)
        {
            InitializeComponent();
            form = f;

            passwordBox.UseSystemPasswordChar = true;
            password2Box.UseSystemPasswordChar = true;

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

        private void addAccXMLLinq(string accNickName, string login, string email, string password, string fileName)
        {
            XDocument xdoc = XDocument.Load(fileName);
            XElement root = xdoc.Element("datas");

            string path = @login;
            string subPath1 = "xml";
            string subPath2 = "txt";

            DirectoryInfo newDir = new DirectoryInfo(path);
            newDir.Create();
            newDir.CreateSubdirectory(subPath1);
            newDir.CreateSubdirectory(subPath2);


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

        private bool checkPassword (string pass1)
        {
            int z = 0;
            char[] checkPass = pass1.ToCharArray();
            for (int i = 65; i <= 90; i++)
            {
                if (pass1.Contains((char) i)) 
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

        private void signupButtonClick(object sender, EventArgs e)
        {
            if (nickNameBox.Text.Length > 3 && loginBox.Text.Length > 3 && emailBox.Text.Length > 3 && passwordBox.Text.Length > 3 && password2Box.Text.Length > 3 && passwordBox.Text == password2Box.Text && checkPassword(passwordBox.Text))
            {
                string filePath = @"accounts.xml";
                if (File.Exists(filePath))
                {
                    bool check = true;
                    foreach (XElement xElement in XElement.Load(@"accounts.xml").Elements("Account"))
                    {
                        if (xElement.Attribute("login").Value == loginBox.Text)
                        {
                            MessageBox.Show("Give another login and try again", "Error", MessageBoxButtons.OK);
                            check = false;
                            break;
                        }
                    }
                    if (check)
                    {
                        addAccXMLLinq(nickNameBox.Text, loginBox.Text, emailBox.Text, passwordBox.Text, "accounts.xml");
                        MessageBox.Show("Registration completed successfully!\r\nClick 'OK' and this window will close in 3 seconds...", "Everything is fine", MessageBoxButtons.OK);

                        timer = new DispatcherTimer();
                        timer.Interval = TimeSpan.FromSeconds(1);
                        timer.Tick += timer_Tick;
                        timer.Start();
                    }
                }
                else
                {
                    XDocument xdoc = new XDocument();
                    // создаем корневой элемент
                    XElement datas = new XElement("datas");

                    // добавляем корневой элемент в документ
                    xdoc.Add(datas);
                    //сохраняем документ
                    xdoc.Save("accounts.xml");
                    addAccXMLLinq(nickNameBox.Text, loginBox.Text, emailBox.Text, passwordBox.Text, "accounts.xml");
                    MessageBox.Show("Registration completed successfully!\r\nClick 'OK' and this window will close in 3 seconds...", "Everything is fine", MessageBoxButtons.OK);

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

        private void signupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Show();
        }

        private void backButtonClick(object sender, EventArgs e)
        {
            Close();
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
    }
}
