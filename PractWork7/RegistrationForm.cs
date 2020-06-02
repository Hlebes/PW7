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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\Temp\logins.dat"; // путь к файлу (не знал как сделать путь относительно проекта)
            bool coincidence = false; // логическая переменная наличия совпадений с логином
            using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.OpenOrCreate))) // поток чтения файла
            {
                while (reader.PeekChar() > -1) // цикл по количеству строк в файле
                {
                    string clogin = reader.ReadString(); // переменная, присваивающая читаемую строку 
                    if (clogin == $"||{loginTextBox.Text}||\n") // если логин и строка совпадают
                    {
                        coincidence = true; // пишем о наличии совпадения
                    }
                }
            }
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Append))) // поток записи в файл
            {
                if (coincidence == true) // если есть совпадения с логином
                {
                    MessageBox.Show("Такой логин уже существует"); // вывод сообщения о наличии совпадений
                }
                else // иначе
                {
                    // выводим данные в файл (|| - разделители для распознавания логина)
                    writer.Write($"||{loginTextBox.Text}||\n");
                    writer.Write($"{passTextBox.Text}\n");
                    writer.Write($"{ageTextBox.Text}\n");
                }
            }
        }
    }
}