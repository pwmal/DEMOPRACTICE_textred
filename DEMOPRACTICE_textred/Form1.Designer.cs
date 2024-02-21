namespace DEMOPRACTICE_textred
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            textToolStripMenuItem = new ToolStripMenuItem();
            boldToolStripMenuItem = new ToolStripMenuItem();
            cursiveToolStripMenuItem = new ToolStripMenuItem();
            underlinedToolStripMenuItem = new ToolStripMenuItem();
            normalToolStripMenuItem = new ToolStripMenuItem();
            backgroundToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            progLangToolStripMenuItem = new ToolStripMenuItem();
            cToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            colorDialog1 = new ColorDialog();
            contextMenuStrip1 = new ContextMenuStrip(components);
            copyToolStripMenuItem1 = new ToolStripMenuItem();
            pasteToolStripMenuItem1 = new ToolStripMenuItem();
            cutToolStripMenuItem1 = new ToolStripMenuItem();
            backgroundToolStripMenuItem1 = new ToolStripMenuItem();
            boldToolStripMenuItem1 = new ToolStripMenuItem();
            cursiveToolStripMenuItem1 = new ToolStripMenuItem();
            underlinedToolStripMenuItem1 = new ToolStripMenuItem();
            normalToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, textToolStripMenuItem, backgroundToolStripMenuItem, searchToolStripMenuItem, progLangToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveAsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(112, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(112, 22);
            saveAsToolStripMenuItem.Text = "Save as";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copyToolStripMenuItem, pasteToolStripMenuItem, cutToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(102, 22);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(102, 22);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(102, 22);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // textToolStripMenuItem
            // 
            textToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { boldToolStripMenuItem, cursiveToolStripMenuItem, underlinedToolStripMenuItem, normalToolStripMenuItem });
            textToolStripMenuItem.Name = "textToolStripMenuItem";
            textToolStripMenuItem.Size = new Size(40, 20);
            textToolStripMenuItem.Text = "Text";
            // 
            // boldToolStripMenuItem
            // 
            boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            boldToolStripMenuItem.Size = new Size(132, 22);
            boldToolStripMenuItem.Text = "Bold ";
            boldToolStripMenuItem.Click += boldToolStripMenuItem_Click;
            // 
            // cursiveToolStripMenuItem
            // 
            cursiveToolStripMenuItem.Name = "cursiveToolStripMenuItem";
            cursiveToolStripMenuItem.Size = new Size(132, 22);
            cursiveToolStripMenuItem.Text = "Cursive";
            cursiveToolStripMenuItem.Click += cursiveToolStripMenuItem_Click;
            // 
            // underlinedToolStripMenuItem
            // 
            underlinedToolStripMenuItem.Name = "underlinedToolStripMenuItem";
            underlinedToolStripMenuItem.Size = new Size(132, 22);
            underlinedToolStripMenuItem.Text = "Underlined";
            underlinedToolStripMenuItem.Click += underlinedToolStripMenuItem_Click;
            // 
            // normalToolStripMenuItem
            // 
            normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            normalToolStripMenuItem.Size = new Size(132, 22);
            normalToolStripMenuItem.Text = "Normal";
            normalToolStripMenuItem.Click += normalToolStripMenuItem_Click;
            // 
            // backgroundToolStripMenuItem
            // 
            backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            backgroundToolStripMenuItem.Size = new Size(83, 20);
            backgroundToolStripMenuItem.Text = "Background";
            backgroundToolStripMenuItem.Click += backgroundToolStripMenuItem_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(54, 20);
            searchToolStripMenuItem.Text = "Search";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
            // 
            // progLangToolStripMenuItem
            // 
            progLangToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cToolStripMenuItem });
            progLangToolStripMenuItem.Name = "progLangToolStripMenuItem";
            progLangToolStripMenuItem.Size = new Size(70, 20);
            progLangToolStripMenuItem.Text = "ProgLang";
            // 
            // cToolStripMenuItem
            // 
            cToolStripMenuItem.Name = "cToolStripMenuItem";
            cToolStripMenuItem.Size = new Size(180, 22);
            cToolStripMenuItem.Text = "C#";
            cToolStripMenuItem.Click += cToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 24);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 426);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.MouseUp += richTextBox1_MouseUp;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { copyToolStripMenuItem1, pasteToolStripMenuItem1, cutToolStripMenuItem1, backgroundToolStripMenuItem1, boldToolStripMenuItem1, cursiveToolStripMenuItem1, underlinedToolStripMenuItem1, normalToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(139, 180);
            // 
            // copyToolStripMenuItem1
            // 
            copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            copyToolStripMenuItem1.Size = new Size(138, 22);
            copyToolStripMenuItem1.Text = "Copy";
            copyToolStripMenuItem1.Click += copyToolStripMenuItem1_Click;
            // 
            // pasteToolStripMenuItem1
            // 
            pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            pasteToolStripMenuItem1.Size = new Size(138, 22);
            pasteToolStripMenuItem1.Text = "Paste";
            pasteToolStripMenuItem1.Click += pasteToolStripMenuItem1_Click;
            // 
            // cutToolStripMenuItem1
            // 
            cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            cutToolStripMenuItem1.Size = new Size(138, 22);
            cutToolStripMenuItem1.Text = "Cut";
            cutToolStripMenuItem1.Click += cutToolStripMenuItem1_Click;
            // 
            // backgroundToolStripMenuItem1
            // 
            backgroundToolStripMenuItem1.Name = "backgroundToolStripMenuItem1";
            backgroundToolStripMenuItem1.Size = new Size(138, 22);
            backgroundToolStripMenuItem1.Text = "Background";
            backgroundToolStripMenuItem1.Click += backgroundToolStripMenuItem1_Click;
            // 
            // boldToolStripMenuItem1
            // 
            boldToolStripMenuItem1.Name = "boldToolStripMenuItem1";
            boldToolStripMenuItem1.Size = new Size(138, 22);
            boldToolStripMenuItem1.Text = "Bold";
            boldToolStripMenuItem1.Click += boldToolStripMenuItem1_Click;
            // 
            // cursiveToolStripMenuItem1
            // 
            cursiveToolStripMenuItem1.Name = "cursiveToolStripMenuItem1";
            cursiveToolStripMenuItem1.Size = new Size(138, 22);
            cursiveToolStripMenuItem1.Text = "Cursive";
            cursiveToolStripMenuItem1.Click += cursiveToolStripMenuItem1_Click;
            // 
            // underlinedToolStripMenuItem1
            // 
            underlinedToolStripMenuItem1.Name = "underlinedToolStripMenuItem1";
            underlinedToolStripMenuItem1.Size = new Size(138, 22);
            underlinedToolStripMenuItem1.Text = "Underlined";
            underlinedToolStripMenuItem1.Click += underlinedToolStripMenuItem1_Click;
            // 
            // normalToolStripMenuItem1
            // 
            normalToolStripMenuItem1.Name = "normalToolStripMenuItem1";
            normalToolStripMenuItem1.Size = new Size(138, 22);
            normalToolStripMenuItem1.Text = "Normal";
            normalToolStripMenuItem1.Click += normalToolStripMenuItem1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem textToolStripMenuItem;
        private ToolStripMenuItem boldToolStripMenuItem;
        private ToolStripMenuItem cursiveToolStripMenuItem;
        private ToolStripMenuItem underlinedToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem progLangToolStripMenuItem;
        private ToolStripMenuItem cToolStripMenuItem;
        public RichTextBox richTextBox1;
        private ToolStripMenuItem normalToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem backgroundToolStripMenuItem;
        private ColorDialog colorDialog1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem copyToolStripMenuItem1;
        private ToolStripMenuItem pasteToolStripMenuItem1;
        private ToolStripMenuItem cutToolStripMenuItem1;
        private ToolStripMenuItem backgroundToolStripMenuItem1;
        private ToolStripMenuItem boldToolStripMenuItem1;
        private ToolStripMenuItem cursiveToolStripMenuItem1;
        private ToolStripMenuItem underlinedToolStripMenuItem1;
        private ToolStripMenuItem normalToolStripMenuItem1;
    }
}