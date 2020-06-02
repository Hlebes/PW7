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
    public partial class ShoppingForm : Form
    {
        public ShoppingForm()
        {
            InitializeComponent();
        }

        private void ShoppingForm_Load(object sender, EventArgs e)
        {
            // инициализируем таблицу
            dataGridView.ColumnCount = 3;
            dataGridView.ColumnHeadersVisible = true;
            dataGridView.Columns[0].Name = "Товар";
            dataGridView.Columns[1].Name = "Цена";
            dataGridView.Columns[2].Name = "Количество";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "txt files(*.txt)|*.txt|csv files(*.csv)|*.csv"; // фильтры форматов файла
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFile.FileName;
                using (StreamWriter writer = new StreamWriter(fileName, false, Encoding.GetEncoding(1251))) // поток на запись
                {
                    writer.Write($"{dataGridView.Columns[0].HeaderText};"); // запись заголовков
                    writer.Write($"{dataGridView.Columns[1].HeaderText};");
                    writer.Write($"{dataGridView.Columns[2].HeaderText}\n");
                    for (int i = 0; i < dataGridView.Rows.Count; i++) // цикл на запись строк
                    {
                        for (int j = 0; j < dataGridView.Columns.Count; j++) // цикл на запись столбцов
                        {
                            writer.Write(dataGridView.Rows[i].Cells[j].Value);
                            if (j != 2)
                            {
                                writer.Write(';');
                            }
                        }
                        writer.Write('\n');
                    }
                }
            }
        }
    }
}
