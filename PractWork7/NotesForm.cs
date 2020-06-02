using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PractWork7
{
    public partial class NotesForm : Form
    {
        public NotesForm()
        {
            InitializeComponent();
        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Temp\Notes.txt")) // проверяем наличие файла
            {
                MessageBox.Show("Файл с заметками перезаписывается"); // если файл есть, предупреждаем о его перезаписи
            }
            string fileName = @"C:\Temp\Notes.txt";
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine($"{textBox.Text}\n"); // выводим текст из блока в поток записи в файл
                writer.WriteLine(DateTime.Now); // выводим текущие дату и время
            }
        }
    }
}
