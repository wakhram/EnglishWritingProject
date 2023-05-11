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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Windows.Threading;
using NHunspell;
using System.Windows;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace EnglishWritingProject
{
    public partial class mainForm : Form
    {
        DispatcherTimer timer;
        int timeK = 0;
        string[] datesList = { "last essay", "last week", "last month", "all"};

        loginForm form;
        string login, nickname;
        List<string> topics = new List<string>();
        List<string> writtenTopics = new List<string>();
        List<string> writtenTopicsTime = new List<string>();
        string ChoosedTopic;
        public mainForm(string l, string nName, loginForm f)
        {
            InitializeComponent();
            login = l;
            nickname = nName;
            form = f;
            this.Text = nName;

            importTopics();
            importDatesList();
            importTopicsForFilesList();
            checkFilesTime();

            mainTextBox.Enabled = false;

        }

        private void importDatesList ()
        {
            foreach (string date in datesList)
            {
                datesComboBox.Items.Add(date);
            }
        }

        private void importTopicsForFilesList() 
        {
            string path = @"..\Debug\" + login + @"\AllTexts.xml";
            if (File.Exists(path))
            {
                XDocument doc = XDocument.Load(path);
                XElement datas = doc.Element("datas");
                foreach (XElement text in datas.Elements("text"))
                {
                    XElement topic = text.Element("topic");  
                    XElement time = text.Element("time");

                    writtenTopics.Add(topic.Value);
                    writtenTopicsTime.Add(time.Value);

                    filesList.Items.Add(topic.Value);
                }
            }
        }

        private void importTopics()
        {
            XDocument doc = XDocument.Load("topics.xml");
            XElement datas = doc.Element("datas");

            foreach (XElement elem in datas.Elements("topic"))
            {
                topics.Add(elem.Value);
            }
        }

        private void topicButtonClick(object sender, EventArgs e)
        {
            ChoosedTopic = topics[(new Random(Guid.NewGuid().GetHashCode()).Next(0, topics.Count))].ToString();
            if (File.Exists(ChoosedTopic + ".xml")) 
            {
                newTopic();
                topicLabel.Text = ChoosedTopic;
            }
            else
            {
                topicLabel.Text = ChoosedTopic;
            }
        }

        private string newTopic()
        {
            ChoosedTopic = topics[(new Random(Guid.NewGuid().GetHashCode()).Next(0, topics.Count))].ToString();
            if (!File.Exists(ChoosedTopic + ".xml"))
            {
                return ChoosedTopic;
            }
            return "\0" + newTopic();
        }

        private void backButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Show();
        }

        private void timer_tick(object sender, EventArgs e)
        {
            timeK++;
            if (timeK == 3)
            {
                colorBox.BackColor = Color.White;
                timeK = 0;
                timer.Stop();
            }

        }

        /*
        private void setToolTip ()
        {
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.mainTextBox, "First create a file for your theme");
        }
        */

                
         
        private void checkFilesTime ()
        {
            string path = @"..\Debug\" + login + @"\AllTexts.xml";

            if (File.Exists(path))
            {
                foreach (string time in writtenTopicsTime)
                {
                    DateTime dateTime = DateTime.ParseExact(time, "HH:mm:ss dd.MM.yyyy", CultureInfo.InvariantCulture);
                    TimeSpan ts = DateTime.Now - dateTime;
                    int seconds = Convert.ToInt32(ts.TotalSeconds);

                    if (seconds <= 86400)
                    {
                        topicButton.Enabled = false;
                        createFileButton.Enabled = false;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else
            {

            }

            
        }

        private void saveFileCreateTime (string topic)
        {
            string path = @"..\Debug\" + login + @"\AllTexts.xml";
            if (File.Exists(path))
            {
                XDocument doc = XDocument.Load(path);
                XElement datas = doc.Element("datas");
                XElement text = doc.Element("text");

                XElement myTopic = new XElement("topic");
                myTopic.Value = topic;

                XElement time = new XElement("time");
                myTopic.Value = DateTime.Now.ToString("HH:mm:ss dd.MM.yyyy");

                text.Add(myTopic, time);
                datas.Add(text);

                doc.Add(datas);
                doc.Save(path);
            }
            else
            {
                XDocument doc = new XDocument();
                XElement datas = new XElement("datas");
                XElement text = doc.Element("text");

                XElement myTopic = new XElement("topic");
                myTopic.Value = topic;

                XElement time = new XElement("time");
                myTopic.Value = DateTime.Now.ToString("HH:mm:ss dd.MM.yyyy");

                text.Add(myTopic, time);
                datas.Add(text);

                doc.Add(datas);
                doc.Save(path);
            }
        }

        private void createFileButtonClick(object sender, EventArgs e)
        {
            if (topicLabel.Text != "")
            {
                mainTextBox.Enabled = true;
                toolTipLabel.Visible = false;
                toolTipLabel.Enabled = false;

                XDocument doc = new XDocument();
                XElement datas = new XElement("datas");

                XElement cDate = new XElement("createDate");
                XElement wCount = new XElement("wordCount");
                XElement chCount = new XElement("charCount");
                XElement mCount = new XElement("mistakesCount");
                XElement eRate = new XElement("errorRate");
                XElement grade = new XElement("grade");
                XElement text = new XElement("text");

                cDate.Value = DateTime.Now.ToString("HH:mm:ss dd.MM.yyyy");
                datas.Add(cDate, wCount, chCount, mCount, eRate, grade, text);

                doc.Add(datas);
                string fName = topicLabel.Text + ".xml";
                string fName2 = topicLabel.Text + ".txt";
                doc.Save(@"..\Debug\" + login + @"\xml\" + fName);

                File.Create(@"..\Debug\" + login + @"\txt\" + fName2);

                saveFileCreateTime(topicLabel.Text);

                colorBox.BackColor = Color.Green;
                timer = new DispatcherTimer();
                timer.Interval = TimeSpan.FromSeconds(1);
                timer.Tick += timer_tick;
                timer.Start();

                topicButton.Enabled = false;
            }
            else
            {
                MessageBox.Show("Get a theme first!", "Do not hurry", MessageBoxButtons.OK);
            }
        }

        private void wordCount(string fName)
        {
            XDocument doc = XDocument.Load(fName);
            var datas = doc.Element("datas");
            if (datas != null)
            {
                var text = datas.Element("text");
                string[] checkText = text.Value.Split(' ');

                var wCount = datas.Element("wordCount");
                wCount.Value = checkText.Length.ToString();

                doc.Save(fName);
            }
        }

        private void charCount(string fName)
        {
            XDocument doc = XDocument.Load(fName);
            var datas = doc.Element("datas");
            if (datas != null)
            {
                var text = datas.Element("text");
                char[] checkText = text.Value.ToCharArray();

                var chCount = datas.Element("charCount");
                chCount.Value = checkText.Length.ToString();

                doc.Save(fName);
            }
        }

        private void mistakesWords(string mPath, string w)
        {
            if (File.Exists(mPath))
            {
                XDocument myDoc = XDocument.Load(mPath);
                XElement myDatas = myDoc.Element("datas");
                if (myDatas != null)
                {
                    myDatas.Add(new XElement("word", w));
                }
                myDoc.Save(mPath);

            }
            else
            {
                XDocument doc = new XDocument();
                XElement datas = new XElement("datas");
                doc.Add(datas);
                doc.Save(mPath);

                XDocument myDoc = XDocument.Load(mPath);
                XElement myDatas = myDoc.Element("datas");
                if (myDatas != null)
                {
                    myDatas.Add(new XElement("word", w));
                }
                myDoc.Save(mPath);

            }
        }


        private void mistakesCount(string fName2, string fName, string mPath)
        {
            using (Hunspell hunspell = new Hunspell("en-US.aff", "en-US.dic"))
            {
                int count = 0;
                
                string[] lines = System.IO.File.ReadAllLines(fName2);
                
                foreach (var line in lines)
                {
                    string[] words = line.Split(' ', ',', '.', '(', ')', ':', ';', '"');
                    foreach (var word in words)
                    {
                        bool correct = hunspell.Spell(word);
                        if (!correct)
                        {
                            mistakesWords(mPath, word);
                            count++;
                        }
                    }
                }
                
                

                XDocument doc = XDocument.Load(fName);
                var datas = doc.Element("datas");
                if (datas != null)
                {
                    var mCount = datas.Element("mistakesCount");
                    mCount.Value = count.ToString();

                    var wCount = datas.Element("wordCount");
                    var errRate = datas.Element("errorRate");

                    double eRate = (count * 100) / (Convert.ToInt32(wCount.Value));
                    errRate.Value = eRate.ToString();

                    doc.Save(fName);
                }
            }
        }

        private void gradeFunction (string fName)
        {
            XDocument doc = XDocument.Load(fName);
            var datas = doc.Element("datas");
            if (datas != null)
            {
                var wCount = datas.Element("wordCount");
                double wordsCount = Convert.ToDouble(wCount.Value); 

                var errRate = datas.Element("errorRate");
                double err = Convert.ToDouble(errRate.Value);

                double myGrade = wordsCount / err;

                var gr = datas.Element("grade");
                
                if (myGrade >= 0.1 && myGrade < 3) 
                {
                    gr.Value = "F";
                }
                else if (myGrade >= 3 && myGrade < 5)
                {
                    gr.Value = "C-";
                }
                else if (myGrade >= 5 && myGrade < 9)
                {
                    gr.Value = "C";
                }
                else if (myGrade >= 9 && myGrade < 19)
                {
                    gr.Value = "C+";
                }
                else if (myGrade >= 19 && myGrade < 29)
                {
                    gr.Value = "B-";
                }
                else if (myGrade >= 29 && myGrade < 39)
                {
                    gr.Value = "B";
                }
                else if (myGrade >= 39 && myGrade < 49)
                {
                    gr.Value = "B+";
                }
                else if (myGrade >= 49 && myGrade < 65)
                {
                    gr.Value = "A-";
                }
                else if (myGrade >= 65 && myGrade < 100)
                {
                    gr.Value = "A";
                }
                else 
                {
                    gr.Value = "A+";
                }
                doc.Save(fName);
            }
        }

        private void mainForm_Click(object sender, EventArgs e)
        {
            filesList.SelectedIndex = -1;
            mainTextBox.Text = "";
            mainTextBox.ReadOnly = false;
            topicLabel.Text = "";
            topicButton.Enabled = true;
            saveFileButton.Enabled = true;
            createFileButton.Enabled = true;
        }

        private void statisticsButtonClick(object sender, EventArgs e)
        {
            string path = @"..\Debug\" + login + @"\xml\" + topicLabel.Text + ".xml";
            if (File.Exists(path))
            {
                XDocument doc = XDocument.Load(path);
                var datas = doc.Element("datas");
                if (datas != null)
                {
                    XElement wCount = datas.Element("wordCount");
                    XElement chCount = datas.Element("charCount");
                    XElement mCount = datas.Element("mistakesCount");
                    XElement eRate = datas.Element("errorRate");
                    XElement grade = datas.Element("grade");

                    if (wCount.Value.Length > 0)
                    {
                        wordCountLabel.Text = "Words count : " + wCount.Value;
                        charsCountLabel.Text = "Chars count : " + chCount.Value;
                        mistakesCountLabel.Text = "Mistakes count : " + mCount.Value;
                        errorRateLabel.Text = "Error rate : " + eRate.Value;
                        gradeLabel.Text = "Your grade : " + grade.Value;
                    }
                    else
                    {
                        MessageBox.Show("First create a file", "Do not hurry", MessageBoxButtons.OK);
                    }

                }
            }
            else
            {
                MessageBox.Show("First create a file", "Do not hurry", MessageBoxButtons.OK);
            }

        }

        private void datesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filesList.Items.Clear();

            int x = datesComboBox.SelectedIndex;
            switch(x)
            {
                case 0:
                    filesList.Items.Add(writtenTopics[writtenTopics.Count - 1]);
                    break;
                case 1:
                    if (writtenTopics.Count <= 7)
                    {
                        foreach (string t in writtenTopics)
                        {
                            filesList.Items.Add(t);
                        }
                    }
                    else
                    {
                        for (int i = (writtenTopics.Count - 1); i >= (writtenTopics.Count - 7); i--)
                        {
                            filesList.Items.Add(writtenTopics[i]);
                        }
                    }
                    break;
                case 2:
                    if (writtenTopics.Count <= 30)
                    {
                        foreach (string t in writtenTopics)
                        {
                            filesList.Items.Add(t);
                        }
                    }
                    else
                    {
                        for (int i = (writtenTopics.Count - 1); i >= (writtenTopics.Count - 30); i--)
                        {
                            filesList.Items.Add(writtenTopics[i]);
                        }
                    }
                    break;
                case 3:
                    foreach (string t in writtenTopics)
                    {
                        filesList.Items.Add(t);
                    }
                    break;
                default:
                    foreach (string t in writtenTopics)
                    {
                        filesList.Items.Add(t);
                    }
                    break;
            } 
        }

        private void mistakesButtonClick(object sender, EventArgs e)
        {
            string fName, mistakesPath;
            if (filesList.SelectedIndex == -1)
            {
                fName = @"..\Debug\" + login + @"\xml\" + topicLabel.Text + ".xml";
                mistakesPath = @"..\Debug\" + login + @"\xml\" + topicLabel.Text + "_MistakesWord.xml";
            }
            else
            {
                fName = @"..\Debug\" + login + @"\xml\" + filesList.SelectedItem.ToString() + ".xml";
                mistakesPath = @"..\Debug\" + login + @"\xml\" + filesList.SelectedItem.ToString() + "_MistakesWord.xml";
            }
            mistakesForm mF = new mistakesForm(fName, mistakesPath);
            mF.ShowDialog();
        }

        private void filesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filesList.SelectedIndex != -1)
            {
                mainTextBox.Enabled = true;
                toolTipLabel.Visible = false;
                toolTipLabel.Enabled = false;

                topicButton.Enabled = false;
                createFileButton.Enabled = false;

                topicLabel.Text = filesList.SelectedItem.ToString();

                string path = @"..\Debug\" + login + @"\xml\" + topicLabel.Text + ".xml";
                XDocument doc = XDocument.Load(path);
                XElement datas = doc.Element("datas");
                XElement time = datas.Element("createDate");
                XElement text = datas.Element("text");

                DateTime dateTime = DateTime.ParseExact(time.Value, "HH:mm:ss dd.MM.yyyy", CultureInfo.InvariantCulture);
                TimeSpan ts = DateTime.Now - dateTime;
                int seconds = Convert.ToInt32(ts.TotalSeconds);
                if (seconds <= 86400)
                {
                    saveFileButton.Enabled = true;
                    mainTextBox.ReadOnly = false;
                }
                else
                {
                    saveFileButton.Enabled = false;
                    mainTextBox.ReadOnly = true;
                }

                mainTextBox.Text = text.Value;

            }
        }

        private void saveFileButtonClick(object sender, EventArgs e)
        {
            if (topicLabel.Text != "")
            {
                if (File.Exists(@"..\Debug\" + login + @"\xml\" + topicLabel.Text + ".xml"))
                {
                    string fName = @"..\Debug\" + login + @"\xml\" + topicLabel.Text + ".xml";
                    string mistakesPath = @"..\Debug\" + login + @"\xml\" + topicLabel.Text + "_MistakesWord.xml";
                    string fName2 = @"..\Debug\" + login + @"\txt\" + topicLabel.Text + ".txt";
                    if (File.Exists(mistakesPath))
                    {
                        File.Delete(mistakesPath);
                    }
                    XDocument doc = XDocument.Load(@"..\Debug\" + login + @"\xml\" + topicLabel.Text + ".xml");
                    var datas = doc.Element("datas");                    
                    if (datas != null)
                    {
                        var text = datas.Element("text");
                        text.Value = mainTextBox.Text;

                        doc.Save(fName);

                        StreamWriter sw = new StreamWriter(@"..\Debug\" + login + @"\txt\" + topicLabel.Text + ".txt");
                        sw.WriteLine(mainTextBox.Text);
                        sw.Close();

                        colorBox.BackColor = Color.Green;
                        timer = new DispatcherTimer();
                        timer.Interval = TimeSpan.FromSeconds(1);
                        timer.Tick += timer_tick;
                        timer.Start();
                    }

                    wordCount(fName);
                    charCount(fName);
                    mistakesCount(fName2, fName, mistakesPath);
                    gradeFunction(fName);
                }
                else
                {
                    MessageBox.Show("First create a file", "Do not hurry", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("First, get a theme and create a file for it", "Do not hurry", MessageBoxButtons.OK);
            }
        }

    }
}
