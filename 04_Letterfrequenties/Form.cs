using System;
using System.IO;
using System.Windows.Forms;

namespace _04_Letterfrequenties
{
    public partial class Form : System.Windows.Forms.Form
    {
        int[] countChar = new int[255] ;
        string NL = Environment.NewLine;

        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            textBox.Text = $"\t\tLetterFrequenties v0.9.0";
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBox.Text = File.ReadAllText(openFile.FileName);
            }
        }

        private void btnDisplayChars_Click(object sender, EventArgs e)
        {
            string addvalue = $"\t--- COUNTING CHARS ... ---{NL}{NL}";

            if (textBox.Text != "")
            {
                foreach (char character in textBox.Text) { countChar[character] += 1; }
            };

            for (int i = 0; i < countChar.Length; i++)
            {
                if (i >= 32 && countChar[i] != 0)
                {
                    addvalue += $"{(char)i} =\t{countChar[i]} {NL}";
                }
            }

            textBox.Text = addvalue + $"{NL}\t--- ORIGINAL ... ---{NL}{NL}" + textBox.Text;
        }

    }
}
