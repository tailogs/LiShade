namespace LiShade
{
    partial class MainForm
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
            menuStrip1=new MenuStrip();
            fileToolStripMenuItem=new ToolStripMenuItem();
            createFileToolStripMenuItem=new ToolStripMenuItem();
            openFileToolStripMenuItem=new ToolStripMenuItem();
            saveFileToolStripMenuItem=new ToolStripMenuItem();
            SaveFileAsToolStripMenuItem=new ToolStripMenuItem();
            closeFileToolStripMenuItem=new ToolStripMenuItem();
            exitToolStripMenuItem=new ToolStripMenuItem();
            correctionToolStripMenuItem=new ToolStripMenuItem();
            cutToolStripMenuItem=new ToolStripMenuItem();
            copyToolStripMenuItem=new ToolStripMenuItem();
            pasteToolStripMenuItem=new ToolStripMenuItem();
            selectAllToolStripMenuItem=new ToolStripMenuItem();
            deleteSelectedToolStripMenuItem=new ToolStripMenuItem();
            helpToolStripMenuItem=new ToolStripMenuItem();
            developerTailogsToolStripMenuItem=new ToolStripMenuItem();
            обРазобротчикеToolStripMenuItem=new ToolStripMenuItem();
            statusStrip1=new StatusStrip();
            toolStripStatusLabel1=new ToolStripStatusLabel();
            openFileDialog1=new OpenFileDialog();
            saveFileDialog1=new SaveFileDialog();
            panel1=new Panel();
            richTextBox1=new RichTextBox();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor=SystemColors.ControlDarkDark;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, correctionToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location=new Point(0, 0);
            menuStrip1.MdiWindowListItem=fileToolStripMenuItem;
            menuStrip1.Name="menuStrip1";
            menuStrip1.Size=new Size(882, 24);
            menuStrip1.TabIndex=0;
            menuStrip1.Text="menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.BackColor=SystemColors.ControlDarkDark;
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createFileToolStripMenuItem, openFileToolStripMenuItem, saveFileToolStripMenuItem, SaveFileAsToolStripMenuItem, closeFileToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.ForeColor=SystemColors.Control;
            fileToolStripMenuItem.Name="fileToolStripMenuItem";
            fileToolStripMenuItem.Size=new Size(48, 20);
            fileToolStripMenuItem.Text="Файл";
            // 
            // createFileToolStripMenuItem
            // 
            createFileToolStripMenuItem.BackColor=SystemColors.ControlDarkDark;
            createFileToolStripMenuItem.ForeColor=SystemColors.Control;
            createFileToolStripMenuItem.Name="createFileToolStripMenuItem";
            createFileToolStripMenuItem.Size=new Size(263, 22);
            createFileToolStripMenuItem.Text="Создать файл                       (Ctrl+N)";
            createFileToolStripMenuItem.Click+=createFileToolStripMenuItem_Click;
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.BackColor=SystemColors.ControlDarkDark;
            openFileToolStripMenuItem.ForeColor=SystemColors.Control;
            openFileToolStripMenuItem.Name="openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size=new Size(263, 22);
            openFileToolStripMenuItem.Text="Открыть файл                      (Ctrl+O)";
            openFileToolStripMenuItem.Click+=openFileToolStripMenuItem_Click;
            // 
            // saveFileToolStripMenuItem
            // 
            saveFileToolStripMenuItem.BackColor=SystemColors.ControlDarkDark;
            saveFileToolStripMenuItem.ForeColor=SystemColors.Control;
            saveFileToolStripMenuItem.Name="saveFileToolStripMenuItem";
            saveFileToolStripMenuItem.Size=new Size(263, 22);
            saveFileToolStripMenuItem.Tag="";
            saveFileToolStripMenuItem.Text="Сохранить файл                  (Ctrl+S)";
            saveFileToolStripMenuItem.Click+=saveFileToolStripMenuItem_Click;
            // 
            // SaveFileAsToolStripMenuItem
            // 
            SaveFileAsToolStripMenuItem.BackColor=SystemColors.ControlDarkDark;
            SaveFileAsToolStripMenuItem.ForeColor=SystemColors.Control;
            SaveFileAsToolStripMenuItem.Name="SaveFileAsToolStripMenuItem";
            SaveFileAsToolStripMenuItem.Size=new Size(263, 22);
            SaveFileAsToolStripMenuItem.Text="Сохранить файл как";
            SaveFileAsToolStripMenuItem.Click+=SaveFileAsToolStripMenuItem_Click;
            // 
            // closeFileToolStripMenuItem
            // 
            closeFileToolStripMenuItem.BackColor=SystemColors.ControlDarkDark;
            closeFileToolStripMenuItem.ForeColor=SystemColors.Control;
            closeFileToolStripMenuItem.Name="closeFileToolStripMenuItem";
            closeFileToolStripMenuItem.Size=new Size(263, 22);
            closeFileToolStripMenuItem.Text="Закрыть файл";
            closeFileToolStripMenuItem.Click+=closeFileToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor=SystemColors.ControlDarkDark;
            exitToolStripMenuItem.ForeColor=SystemColors.Control;
            exitToolStripMenuItem.Name="exitToolStripMenuItem";
            exitToolStripMenuItem.Size=new Size(263, 22);
            exitToolStripMenuItem.Text="Выход";
            exitToolStripMenuItem.Click+=exitToolStripMenuItem_Click;
            // 
            // correctionToolStripMenuItem
            // 
            correctionToolStripMenuItem.BackColor=SystemColors.ControlDarkDark;
            correctionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, selectAllToolStripMenuItem, deleteSelectedToolStripMenuItem });
            correctionToolStripMenuItem.ForeColor=SystemColors.Control;
            correctionToolStripMenuItem.Name="correctionToolStripMenuItem";
            correctionToolStripMenuItem.Size=new Size(79, 20);
            correctionToolStripMenuItem.Text="Коррекция";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.BackColor=SystemColors.ControlDarkDark;
            cutToolStripMenuItem.ForeColor=SystemColors.Control;
            cutToolStripMenuItem.Name="cutToolStripMenuItem";
            cutToolStripMenuItem.Size=new Size(263, 22);
            cutToolStripMenuItem.Text="Вырезать                                (Ctrl+X)";
            cutToolStripMenuItem.Click+=cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.BackColor=SystemColors.ControlDarkDark;
            copyToolStripMenuItem.ForeColor=SystemColors.Control;
            copyToolStripMenuItem.Name="copyToolStripMenuItem";
            copyToolStripMenuItem.Size=new Size(263, 22);
            copyToolStripMenuItem.Text="Копировать                           (Ctrl+C)";
            copyToolStripMenuItem.Click+=copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.BackColor=SystemColors.ControlDarkDark;
            pasteToolStripMenuItem.ForeColor=SystemColors.Control;
            pasteToolStripMenuItem.Name="pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size=new Size(263, 22);
            pasteToolStripMenuItem.Text="Вставить                                 (Ctrl+V)";
            pasteToolStripMenuItem.Click+=pasteToolStripMenuItem_Click;
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.BackColor=SystemColors.ControlDarkDark;
            selectAllToolStripMenuItem.ForeColor=SystemColors.Control;
            selectAllToolStripMenuItem.Name="selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size=new Size(263, 22);
            selectAllToolStripMenuItem.Text="Выбрать все                          (Ctrl+A)";
            selectAllToolStripMenuItem.Click+=selectAllToolStripMenuItem_Click;
            // 
            // deleteSelectedToolStripMenuItem
            // 
            deleteSelectedToolStripMenuItem.BackColor=SystemColors.ControlDarkDark;
            deleteSelectedToolStripMenuItem.ForeColor=SystemColors.Control;
            deleteSelectedToolStripMenuItem.Name="deleteSelectedToolStripMenuItem";
            deleteSelectedToolStripMenuItem.Size=new Size(263, 22);
            deleteSelectedToolStripMenuItem.Text="Удалить выделенное";
            deleteSelectedToolStripMenuItem.Click+=deleteSelectedToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.BackColor=SystemColors.ControlDarkDark;
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { developerTailogsToolStripMenuItem });
            helpToolStripMenuItem.ForeColor=SystemColors.Control;
            helpToolStripMenuItem.Name="helpToolStripMenuItem";
            helpToolStripMenuItem.Size=new Size(68, 20);
            helpToolStripMenuItem.Text="Помощь";
            // 
            // developerTailogsToolStripMenuItem
            // 
            developerTailogsToolStripMenuItem.BackColor=SystemColors.ControlDarkDark;
            developerTailogsToolStripMenuItem.ForeColor=SystemColors.Control;
            developerTailogsToolStripMenuItem.Name="developerTailogsToolStripMenuItem";
            developerTailogsToolStripMenuItem.Size=new Size(186, 22);
            developerTailogsToolStripMenuItem.Text="Разработчик: Tailogs";
            developerTailogsToolStripMenuItem.TextAlign=ContentAlignment.TopRight;
            // 
            // обРазобротчикеToolStripMenuItem
            // 
            обРазобротчикеToolStripMenuItem.Name="обРазобротчикеToolStripMenuItem";
            обРазобротчикеToolStripMenuItem.Size=new Size(32, 19);
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor=SystemColors.ControlDarkDark;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location=new Point(0, 468);
            statusStrip1.Name="statusStrip1";
            statusStrip1.Size=new Size(882, 22);
            statusStrip1.TabIndex=2;
            statusStrip1.Text="statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.ForeColor=SystemColors.Control;
            toolStripStatusLabel1.Name="toolStripStatusLabel1";
            toolStripStatusLabel1.Size=new Size(22, 17);
            toolStripStatusLabel1.Text="---";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName="openFileDialog1";
            // 
            // panel1
            // 
            panel1.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;
            panel1.BackColor=Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(richTextBox1);
            panel1.Location=new Point(0, 27);
            panel1.Name="panel1";
            panel1.Size=new Size(882, 438);
            panel1.TabIndex=2;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;
            richTextBox1.BackColor=Color.FromArgb(64, 64, 64);
            richTextBox1.BorderStyle=BorderStyle.None;
            richTextBox1.Font=new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.ForeColor=SystemColors.Control;
            richTextBox1.Location=new Point(12, 13);
            richTextBox1.Name="richTextBox1";
            richTextBox1.ScrollBars=RichTextBoxScrollBars.ForcedBoth;
            richTextBox1.Size=new Size(858, 414);
            richTextBox1.TabIndex=2;
            richTextBox1.Text="";
            richTextBox1.TextChanged+=richTextBox1_TextChanged;
            richTextBox1.KeyDown+=richTextBox1_KeyDown;
            richTextBox1.MouseHover+=richTextBox1_MouseHover;
            // 
            // MainForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.ControlDarkDark;
            ClientSize=new Size(882, 490);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip=menuStrip1;
            Name="MainForm";
            Text="LiShade";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem createFileToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem correctionToolStripMenuItem;
        private ToolStripMenuItem closeFileToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem обРазобротчикеToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem SaveFileAsToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem deleteSelectedToolStripMenuItem;
        private Panel panel1;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem developerTailogsToolStripMenuItem;
    }
}