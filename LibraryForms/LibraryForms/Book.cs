using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForms
{
    internal class Book:IBook
    {
        public string Name { get;set; }
        public DateTime date { get;set; } = DateTime.Now;
        public void TakeBook()
        {
            MessageBox.Show($"You have taken {Name} book at {date}");
            MessageBox.Show($"Please, return it at {date.Day + 5}/{date.Month}");
        }
        public void ReturnBook()
        {
            MessageBox.Show("Thank you!");
        }
    }
}
