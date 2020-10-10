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

        //Method to capitalize first letter
        public static string FirstCharToUpper(string input)
        {
            switch (input)
            {
                case null: throw new ArgumentNullException(nameof(input));
                case "": throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
                default: return input.First().ToString().ToUpper() + input.Substring(1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int counter = 0;
            string line;

            //Reading the file with stream reader
            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            System.IO.StreamReader nountxt = new System.IO.StreamReader(dir + @"\txt\nouns.txt");
            System.IO.StreamReader adjtxt = new System.IO.StreamReader(dir + @"\txt\adjs.txt"); 
            //adding to a list
            List<string> nounList = new List<string>();
            List<string> adjList = new List<string>();

            //While line does not equal to null (as long as something is there)
            //Then it will pull items from list and add item
            //Keeps looping till line equals null
            while ((line = nountxt.ReadLine()) != null)
            {
                //listBox1.Items.Add(line);
                nounList.Add(line);
                //counter++;
            }
            while ((line = adjtxt.ReadLine()) != null)
            {
                //listBox2.Items.Add(line);
                adjList.Add(line);
                //counter++;
            }
            //Converting the list to an Array
            string[] nounArr = nounList.ToArray();
            string[] adjArr = adjList.ToArray();

            //Count the total number of items within array
            int totalNouns = nounArr.Length;
            int totalAdjs = adjArr.Length;

            //Generating a random number to get random nouns and adjectives between 0 and total amount
            Random rnd = new Random();
            int randomNumNoun = rnd.Next(0, totalNouns); // creates a number between 0 and total number of nouns
            int randomNumAdjs = rnd.Next(0, totalAdjs);   // creates a number between 0 and total number of adjectives

            string username = FirstCharToUpper(adjArr[randomNumAdjs]) + FirstCharToUpper(nounArr[randomNumNoun]);
            textBox_username.Text = username;
            //MessageBox.Show(FirstCharToUpper(adjArr[randomNumAdjs]) + FirstCharToUpper(nounArr[randomNumNoun]));

            //MessageBox.Show(totalNouns + " " + totalAdjs);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string description = "Username Generator is a mini project created by Kevin Chow and Sally Yu. This project was created to assist those who have trouble coming up with usernames.";
            MessageBox.Show(description + Environment.NewLine + Environment.NewLine + "Thank you and enjoy!" + Environment.NewLine + Environment.NewLine + "Created on January 14, 2018.", "About this project");
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            textBox_username.BackColor = textBox_username.BackColor;
            textBox_username.ForeColor = textBox_username.ForeColor;
            textBox_username.ReadOnly = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox_username.Text);
        }
    }
}
