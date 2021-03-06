﻿using System;
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
            bool match = false; // логическая переменная наличия совпадений с логином
            using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.OpenOrCreate))) // поток чтения файла
            {
                while (reader.PeekChar() > -1) // цикл по количеству строк в файле
                {
                    string clogin = reader.ReadString(); // переменная, присваивающая читаемую строку 
                    var dataStringArray = clogin.Split(','); // разделяем данные пользователя запятой и заносим в массив
                    if (loginTextBox.Text == dataStringArray[0]) // если логин и строка совпадают
                    {
                        match = true; // пишем о наличии совпадения
                    }
                }
            }
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Append))) // поток записи в файл
            {
                if (match == true) // если есть совпадения с логином
                {
                    MessageBox.Show("Такой логин уже существует"); // вывод сообщения о наличии совпадений
                }
                else // иначе
                {
                    // выводим данные в файл (|| - разделители для распознавания логина)
                    writer.Write($"{loginTextBox.Text},{passTextBox.Text},{ageTextBox.Text}\n");
                }
            }
        }
    }
}