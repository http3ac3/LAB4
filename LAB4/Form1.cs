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

            
            foreach (var tb in this.Controls.OfType<TextBox>())
            {
                if (tb.Text.Length == 5)
                {
                    tb.Text = "";
                    char[] oldCharArr = tb.Text.ToCharArray();
                    char[] newCharArr = new char[5];

                    for (int i = 0; i < mask.Length; i++)
                    {
                        newCharArr[i] = oldCharArr[mask[i] - 1];
                    }

                    foreach (var c in newCharArr) 
                        tb.Text += c;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SymbolsAmount.Text = TextTB.Text.Length.ToString();
            FirstBlockTB.Text = TextTB.Text.Substring(0, 5);
            SecondBlockTB.Text = TextTB.Text.Substring(5, 5);
            ThirdBlockTB.Text = TextTB.Text.Substring(10, 5);
            FourthBlockTB.Text = TextTB.Text.Substring(15, 5);
            FifthBlockTB.Text = TextTB.Text.Substring(20, 5);

            foreach (var tb in this.Controls.OfType<TextBox>())
                tb.Text = tb.Text.Replace(' ', '_');
        }
    }
}
