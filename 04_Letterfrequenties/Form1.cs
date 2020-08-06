using System;
using System.IO;
using System.Windows.Forms;

namespace _04_Letterfrequenties
{
    public partial class Form1 : Form
    {
        int words = 0;
        int characters = 0;
        int[] countChar = new int[255];

        string NL = Environment.NewLine;
        string text = "";

        public Form1()
        {
            InitializeComponent();
            PrintResult();

            string defaultText = String.Format($"words:\t\t\t{words}{NL}characters:\t\t{characters}\n\r{NL}");
            textBox.Text = defaultText;
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            //string textfile = Directory.GetParent(Directory.GetCurrentDirectory()) + @"\..\..\..\file.txt";

            string textfile = @"C:\Users\deploy\source\repos\04_Letterfrequenties\04_Letterfrequenties\file.txt";
            text = File.ReadAllText(textfile);

            textBox.Text = text;
        }

        private void PrintResult()
        {
            string output = "";
            
            if (text != "")
            {
                foreach (char character in text)
                {
                    countChar[character] += 1;
                    output += $"| {character} : {countChar[character]} |";
                }
                output += $"{NL}";
            }

            int i = 32;
            while (i < countChar.Length)
            {
                output += $"{i - 32}\t[{(char)i}] =\t" + countChar[i] + $"{NL}";
                i++;
            }

            textBox.Text = output;
        }

        private void btnDisplayFile_Click(object sender, EventArgs e)
        {
            PrintResult();
        }
    }
}