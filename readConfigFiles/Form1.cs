using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace readConfigFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;

        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@textBox1.Text);

            XmlNodeList xnList = doc.SelectNodes("/configuration/appSettings");
            foreach (XmlNode xn in xnList)
            {
                if (xn.HasChildNodes)
                {
                    foreach (XmlNode item in xn.ChildNodes)
                    {
                        //richTextBox1.AppendText(item.InnerText + "\n");
                        richTextBox1.AppendText(xn.InnerXml + "\n");
                    }
                }
            }
        }

        //

    }

}

