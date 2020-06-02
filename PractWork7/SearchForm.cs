using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractWork7
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            directoryLabel.Text = "";
        }

        private void chooseDirButton_Click(object sender, EventArgs e)
        {
            using (var directory = new FolderBrowserDialog())
            {
                DialogResult result = directory.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(directory.SelectedPath)) // при выбранной папке
                {
                    string[] files = Directory.GetFiles(directory.SelectedPath); // вводим данные в массив с названиями файлов
                    directoryLabel.Text = $"{directory.SelectedPath}"; // выводим путь папки в метку
                    findFileButton.Enabled = true; // активируем кнопку поиска файлов в директории
                }
            }
        }

        private void findFileButton_Click(object sender, EventArgs e)
        {
            DirectoryInfo directory = new DirectoryInfo(directoryLabel.Text);
            listBox.Items.Clear();
            // вызываем метод поиска файлов по наличию в названии и заносим данные в массив
            FileInfo[] files = directory.GetFiles($"*{textBox.Text}*.*"); 

            foreach (FileInfo fi in files)
            {
                listBox.Items.Add(fi.ToString()); // из массива files добавляем названия найденых файлов
            }
        }
    }
}