using System.Text.RegularExpressions;

namespace DEMOPRACTICE_textred
{
    public partial class Form1 : Form
    {
        Dictionary<int, Tuple<string, Color>> colors = new Dictionary<int, Tuple<string, Color>>()
        {
            {0, Tuple.Create("for", Color.Purple)},
            {1, Tuple.Create("if", Color.Purple)},
            {2, Tuple.Create("foreach", Color.Purple)},
            {3, Tuple.Create("while", Color.Purple)},
            {4, Tuple.Create("class", Color.Blue)},
            {5, Tuple.Create("public", Color.Blue)},
            {6, Tuple.Create("using", Color.Blue)},
            {7, Tuple.Create("int", Color.Blue)},
            {8, Tuple.Create("string", Color.Blue)},
            {9, Tuple.Create("new", Color.Blue)},
            {10, Tuple.Create("void", Color.Blue)},
            {11, Tuple.Create("private", Color.Blue)},
            {12, Tuple.Create("namespace", Color.Blue)},
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All text files|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
            }
            using (StreamReader sr = new StreamReader(filePath))
            {
                richTextBox1.Text = sr.ReadToEnd();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "All text files|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(sfd.FileName, richTextBox1.Text);
            }
        }

        async private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.ShowDialog();
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(Font, FontStyle.Bold);
        }

        private void cursiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(Font, FontStyle.Italic);
        }

        private void underlinedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(Font, FontStyle.Underline);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(Font, FontStyle.Regular);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.Paste();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionBackColor = colorDialog1.Color;
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.Paste();
            }
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void backgroundToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionBackColor = colorDialog1.Color;
        }

        private void boldToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(Font, FontStyle.Bold);
        }

        private void cursiveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(Font, FontStyle.Italic);
        }

        private void underlinedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(Font, FontStyle.Underline);
        }

        private void normalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(Font, FontStyle.Regular);
        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                richTextBox1.ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tuple<string, Color> temp = new Tuple<string, Color>("", Color.White);
            for(int i = 0; i < colors.Count; i++) 
            {
                temp = colors[i];
                for(int j = 0; j < richTextBox1.Text.Length; j++)
                {
                    if (temp.Item1[0] == richTextBox1.Text[j])
                    {
                        if (j + temp.Item1.Length > richTextBox1.Text.Length)
                        {
                            continue;
                        }
                        if (richTextBox1.Text.Substring(j, temp.Item1.Length) == temp.Item1)
                        {
                            richTextBox1.Select(j, temp.Item1.Length);
                            richTextBox1.SelectionColor = temp.Item2;
                        }
                    }
                }
            }
        }
    }
}