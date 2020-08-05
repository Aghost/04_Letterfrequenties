using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Letterfrequenties
{
    public partial class Form1 : Form
    {
        int words = 0;
        int characters = 0;

        int[] countChar = new int[255] ;

        string text = "";

        string NL = Environment.NewLine;

        public Form1()
        {
            InitializeComponent();
            PrintResult();

            string defaultText = String.Format($"words:\t\t\t{words}{NL}characters:\t\t{characters}{NL}");
            textBox.Text = defaultText;
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            //string textfile = Directory.GetCurrentDirectory() + @"\file.txt";
            string textfile = @"C:\Users\deploy\source\repos\04_Letterfrequenties\04_Letterfrequenties\file.txt";
            text = File.ReadAllText(textfile);
        }

        private void PrintFile()
        {
            textBox.Text = text;
        }

        private void PrintResult()
        {
            if (text != "") { foreach (char character in text) { countChar[character] += 1; } };

            foreach (int i in countChar) { Console.WriteLine(i) ; }

            string defaultText = String.Format($"words:\t\t\t{words}{NL}characters:\t\t{characters}{NL}{NL}");
            textBox.Text = defaultText;
        }

        private void TEST_Click(object sender, EventArgs e)
        {
            Console.WriteLine("TEST");
            PrintResult();
        }

        private void btnDisplayFile_Click(object sender, EventArgs e)
        {
            PrintFile();
        }
    }
}
