using System.IO;

namespace LiShade
{
    public partial class MainForm : Form
    {
        string MyFilePatch = "";
        bool mouseCursorFix = true;

        public MainForm()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Текстовые файлы(*.txt)|*.txt|Все файлы(*.*)|*.*";
            saveFileDialog1.Filter = "Текстовые файлы(*.txt)|*.txt|Все файлы(*.*)|*.*";
        }

        private void createFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = saveFileDialog1.FileName;
            MyFilePatch = filename;
            File.WriteAllText(filename, richTextBox1.Text);
            toolStripStatusLabel1.Text = "Файл сохранен!";
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = openFileDialog1.FileName;
            MyFilePatch = filename;
            string filetext = File.ReadAllText(filename);
            richTextBox1.Text = filetext;
            toolStripStatusLabel1.Text = "Файл " + filename + " открыт!";
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MyFilePatch == "")
            {
                SaveFileAsToolStripMenuItem_Click(sender, e);
            }
            File.WriteAllText(MyFilePatch, richTextBox1.Text);
            toolStripStatusLabel1.Text = "Файл сохранен!";
        }

        private void SaveFileAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = saveFileDialog1.FileName;
            MyFilePatch = filename;
            File.WriteAllText(filename, richTextBox1.Text);
            toolStripStatusLabel1.Text = "Файл сохранен как..." + filename;
        }

        private void closeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            toolStripStatusLabel1.Text = "Файл закрыть!";
            MyFilePatch = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void deleteSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                saveFileToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyCode == Keys.A && e.Modifiers == Keys.Control)
            {
                selectAllToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyCode == Keys.N && e.Modifiers == Keys.Control)
            {
                createFileToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyCode == Keys.O && e.Modifiers == Keys.Control)
            {
                openFileToolStripMenuItem_Click(sender, e);
            }
        }

        private void richTextBox1_MouseHover(object sender, EventArgs e) => richTextBox1.MouseWheel += new MouseEventHandler(this.richTextBox1_MouseWheel);

        private void richTextBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            float MySize = richTextBox1.Font.Size;
            if (e.Delta > 0)
            {
                MySize++;
                richTextBox1.Font = new Font("Arial", MySize); // Покрутка колесиком мыши вверх
                toolStripStatusLabel1.Text = Convert.ToString("Размер текста: " + richTextBox1.Font.Size + "px");
                if (mouseCursorFix)
                {
                    mouseCursorFix = false;
                }
            }
            else
            {
                MySize--;
                richTextBox1.Font = new Font("Arial", MySize); // Покрутка колесиком мыши вниз
                toolStripStatusLabel1.Text = Convert.ToString("Размер текста: " + richTextBox1.Font.Size + "px");
                if (mouseCursorFix)
                {
                    mouseCursorFix = false;
                }
            }
        }

        string[] syntaxHTML = { "<html>", "</html>", "<head>", "</head>", "<body>", "</body>" };

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Изменения внесены! Вам необходимо сохранить файл!";

            string word = "</html>";
            Color color = Color.Red;
            SetColor(this.richTextBox1, word, color);
        }

        public void SetColor(RichTextBox box, string word, Color color)
        {
            string text = box.Text;
            int length = word.Length;

            int index = 0;
            while (true)
            {
                index = text.IndexOf(word, index, StringComparison.Ordinal);
                if (index == -1)
                    break;

                box.SelectionStart = index;
                box.SelectionLength = length;
                box.SelectionColor = color;
                index = index + length;
            }
            box.SelectionColor = box.ForeColor;
        }
    }
}