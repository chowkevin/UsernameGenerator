//Created By Kevin Chow and Sally Yu

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Username_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string line;

            //Reading the file with stream reader
            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            System.IO.StreamReader nountxt = new System.IO.StreamReader(dir + @"\txt\nouns.txt");
            System.IO.StreamReader adjtxt = new System.IO.StreamReader(dir + @"\txt\adjs.txt"); 
            //adding to a list
            List<string> nounList = new List<string>();
            List<string> adjList = new List<string>();

            while ((line = nountxt.ReadLine()) != null)
            {
                listBox1.Items.Add(line);
                nounList.Add(line);
                counter++;
            }

            while ((line = adjtxt.ReadLine()) != null)
            {
                listBox2.Items.Add(line);
                adjList.Add(line);
                counter++;
            }
            string[] nounArr = nounList.ToArray();
            string[] adjArr = adjList.ToArray();

            MessageBox.Show(adjArr[1] + " " + nounArr[2]);
        }
    }
}
