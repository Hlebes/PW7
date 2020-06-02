using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractWork7
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void searchFormButton_Click(object sender, EventArgs e)
        {
            Form form = new SearchForm();
            form.Show();
        }

        private void shoppingFormButton_Click(object sender, EventArgs e)
        {
            Form form = new ShoppingForm();
            form.Show();
        }

        private void notesFormButton_Click(object sender, EventArgs e)
        {
            Form form = new NotesForm();
            form.Show();
        }

        private void registrationFormButton_Click(object sender, EventArgs e)
        {
            Form form = new RegistrationForm();
            form.Show();
        }
    }
}
