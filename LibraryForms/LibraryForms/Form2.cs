using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<string> AvailableJanrs = new List<string>() { "1", "2", "3" };
        List<string> AvailableAuthors = new List<string> { "1", "2", "3" };
        List<string> AvailableBooks = new List<string>() { "1", "2", "3" };
        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (var a in AvailableJanrs)
            {
                Janr.Items.Add(a);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var a in AvailableAuthors)
            {
                Author.Items.Add(a);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var a in AvailableBooks)
            {
                BookName.Items.Add(a);
            }
        }
        Book book = new Book();
        private void button4_Click(object sender, EventArgs e)
        {
            book.Name = textBox1.Text;
            book.TakeBook();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            book.ReturnBook();
        }
    }
}
