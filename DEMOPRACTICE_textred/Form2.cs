using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMOPRACTICE_textred
{
    public partial class Form2 : Form
    {
        private Form1 f1;
        private string f1Text;
        private int counter = 0;

        public Form2(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                f1Text = f1.richTextBox1.Text;
                for (int i = 0; i < f1Text.Length; i++)
                {
                    f1.richTextBox1.Select(i, 1);
                    if (f1.richTextBox1.SelectionBackColor == Color.LightGray)
                    {
                        f1.richTextBox1.SelectionBackColor = Color.White;
                    }
                }

                for (int i = 0; i < f1Text.Length; i++)
                {
                    if (f1Text[i] == textBox1.Text[0])
                    {
                        if (i + textBox1.Text.Length > f1Text.Length)
                        {
                            continue;
                        }
                        else if (f1Text.Substring(i, textBox1.Text.Length) == textBox1.Text)
                        {
                            f1.richTextBox1.Select(i, textBox1.Text.Length);
                            f1.richTextBox1.SelectionBackColor = Color.LightGray;
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                f1Text = f1.richTextBox1.Text;
                for (int i = 0; i < f1Text.Length; i++)
                {
                    if (f1Text[i] == textBox1.Text[0])
                    {
                        if (i + textBox1.Text.Length > f1Text.Length)
                        {
                            continue;
                        }
                        else if (f1Text.Substring(i, textBox1.Text.Length) == textBox1.Text)
                        {
                            counter++;
                        }
                    }
                }
                label1.Text = $"Найдено: {counter}";
                counter = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0 && textBox3.Text.Length > 0)
            {
                f1Text = f1.richTextBox1.Text;
                for (int i = f1Text.Length - 1; i >= 0; i--)
                {
                    if (f1Text[i] == textBox2.Text[textBox2.Text.Length - 1])
                    {
                        if (f1Text.Substring(i - (textBox2.Text.Length - 1), textBox2.Text.Length) == textBox2.Text)
                        {
                            f1.richTextBox1.Select(i - (textBox2.Text.Length - 1), textBox2.Text.Length);
                            f1.richTextBox1.SelectedText = textBox3.Text;
                        }
                    }
                }
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1Text = f1.richTextBox1.Text;
            for (int i = 0; i < f1Text.Length; i++)
            {
                f1.richTextBox1.Select(i, 1);
                if (f1.richTextBox1.SelectionBackColor == Color.LightGray)
                {
                    f1.richTextBox1.SelectionBackColor = Color.White;
                }
            }
            f1.richTextBox1.Select(0, 1);
        }
    }
}
