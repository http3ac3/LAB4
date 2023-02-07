using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4
{
    public partial class Form1 : Form
    {
        int[] mask = { 4, 1, 2, 5, 3 };
        public Form1()
        {
            InitializeComponent();
            
        }

        private void CipherButton_Click(object sender, EventArgs e)
        {
            string cipheredWord = "";

            foreach (var tb in tabPage1.Controls.OfType<TextBox>())
            {
                if (tb.Text.Length == 5)
                {
                    char[] oldCharArr = tb.Text.ToCharArray();
                    char[] newCharArr = new char[5];

                    for (int i = 0; i < mask.Length; i++)
                    {
                        newCharArr[i] = oldCharArr[mask[i] - 1];
                        
                    }

                    tb.Text = "";
                    foreach (var c in newCharArr)
                        tb.Text += c;
                }
            }
            
            cipheredWord += FirstBlockTB.Text + SecondBlockTB.Text + ThirdBlockTB.Text + FourthBlockTB.Text + FifthBlockTB.Text;

            FifthCipherTB.Text =  cipheredWord;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SymbolsAmount.Text = TextTB.Text.Length.ToString();
            FirstBlockTB.Text = TextTB.Text.Substring(0, 5);
            SecondBlockTB.Text = TextTB.Text.Substring(5, 5);
            ThirdBlockTB.Text = TextTB.Text.Substring(10, 5);
            FourthBlockTB.Text = TextTB.Text.Substring(15, 5);
            FifthBlockTB.Text = TextTB.Text.Substring(20, 5);

            foreach (var tb in tabPage1.Controls.OfType<TextBox>())
                tb.Text = tb.Text.Replace(' ', '_');
        }

        private void SixCipherButton_Click(object sender, EventArgs e)
        {
            string openText = SixOpenTextTB.Text;
            int[] mask = { 4, 9, 5, 16, 15, 6, 10, 3, 14, 7, 11, 2, 1, 12, 8, 13 };
            string cipheredText = "";
            for (int i = 0; i < 16; i++)
            {
                SixLettersTable.Controls.Add(new Label() { Text = $"{openText[mask[i] - 1]}" });
                cipheredText += openText[mask[i] - 1];
            }
            MessageBox.Show($"Зашифрованное слово - {cipheredText}");
        }

        private void DecipherButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++) CipherButton_Click(sender, e);
        }

        private void SixDecipherButton_Click(object sender, EventArgs e)
        {
            string closedText = SixClosedTextTB.Text;
            int[] mask = { 4, 15, 6, 9, 5, 10, 3, 16, 11, 8, 13, 2, 14, 1, 12, 7};
            for (int i = 0; i < 16; i++)
            {
                var index = Array.IndexOf(mask, i + 1);
                
                SixDecipherTable.Controls.Add(new Label() { Text = $"{closedText[index]}" });
            }
        }

        private void FifthKolLettersButton_Click(object sender, EventArgs e)
        {
            string openText = TextTB.Text;
            string answer = "";
            foreach (var let in openText.Distinct().ToArray())
            {
                var count = openText.Count(chr => chr == let);
                answer += $"Символ {let} >> {count}\n";
            }
            MessageBox.Show(answer);
        }
    }
}
