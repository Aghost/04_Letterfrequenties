using System;
using System.IO;
using System.Runtime.CompilerServices;
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
 
            //string defaultText = String.Format($"words:\t\t\t{words}{NL}characters:\t\t{characters}{NL}");
            string defaultText = $"words:\t\t\t{words}{NL}characters:\t\t{characters}{NL}";
            textBox.Text = defaultText;
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            text = "";
            //string textfile = Directory.GetCurrentDirectory() + @"\file.txt";

            string textfile = @"C:\Users\v\source\repos\04_Letterfrequenties\04_Letterfrequenties\file.txt";

            text = File.ReadAllText(textfile);
        }

        private void btnDisplayFile_Click(object sender, EventArgs e)
        {
            textBox.Text = text;
        }

        private void btnDisplayChars_Click(object sender, EventArgs e)
        {
            string addvalue = $"words:\t{words}{NL}characters:\t{characters}{NL}{NL}";

            if (text != "")
            {
                foreach (char character in text) { countChar[character] += 1; }
            };

            for (int i = 0; i < countChar.Length; i++)
            {
                if (i >= 32 && countChar[i] != 0)
                {
                    Console.WriteLine($"{(char)i} = {countChar[i]}");
                    addvalue += $"{(char)i} = {countChar[i]} {NL}";
                }
            }

            textBox.Text += addvalue;
        }
    }
}
