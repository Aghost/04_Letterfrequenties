using System;
using System.IO;
<<<<<<< HEAD
using System.Runtime.CompilerServices;
=======
>>>>>>> 0f03cb84746a6eb75d6d0b2336ef20e491824fff
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
<<<<<<< HEAD
 
            //string defaultText = String.Format($"words:\t\t\t{words}{NL}characters:\t\t{characters}{NL}");
            string defaultText = $"words:\t\t\t{words}{NL}characters:\t\t{characters}{NL}";
=======
            PrintResult();

            string defaultText = String.Format($"words:\t\t\t{words}{NL}characters:\t\t{characters}\n\r{NL}");
>>>>>>> 0f03cb84746a6eb75d6d0b2336ef20e491824fff
            textBox.Text = defaultText;
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            text = "";
            //string textfile = Directory.GetCurrentDirectory() + @"\file.txt";

            string textfile = @"C:\Users\v\source\repos\04_Letterfrequenties\04_Letterfrequenties\file.txt";

=======
            //string textfile = Directory.GetParent(Directory.GetCurrentDirectory()) + @"\..\..\..\file.txt";

            string textfile = @"C:\Users\deploy\source\repos\04_Letterfrequenties\04_Letterfrequenties\file.txt";
>>>>>>> 0f03cb84746a6eb75d6d0b2336ef20e491824fff
            text = File.ReadAllText(textfile);

<<<<<<< HEAD
        private void btnDisplayFile_Click(object sender, EventArgs e)
        {
=======
>>>>>>> 0f03cb84746a6eb75d6d0b2336ef20e491824fff
            textBox.Text = text;
        }

        private void btnDisplayChars_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
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
=======
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
>>>>>>> 0f03cb84746a6eb75d6d0b2336ef20e491824fff
        }
    }
}