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
    public partial class mistakesForm : Form
    {
        public mistakesForm(string path, string mPath)
        {
            InitializeComponent();

            XDocument doc = XDocument.Load(path);
            XElement datas = doc.Element("datas");
            XElement t = datas.Element("text");
            string text = t.Value;

            mainText.Text = text;
            
            XDocument doc2 = XDocument.Load(mPath);
            XElement datas2 = doc2.Element("datas");
            foreach (XElement word in datas2.Elements("word"))
            {
                int myIndex = text.IndexOf(word.Value);
                mainText.Links.Add(myIndex, word.Value.Length);
            }

        }
    }
}
