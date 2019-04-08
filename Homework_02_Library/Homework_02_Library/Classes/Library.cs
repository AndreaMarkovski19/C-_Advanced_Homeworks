using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02_Library.Classes
{
    public class Library
    {
        public List<IBook> Books = new List<IBook>();

        public void ShowBooks(string input)
        {
            List<IBook> Knigi_Demo = new List<IBook>();

            if (input == "Book")
            {
                Knigi_Demo = Books;
            }
            else
            {
                Knigi_Demo = Books.Where(x => x.GetTypeOfBook() == input).ToList();
            }

            foreach (var book in Knigi_Demo)
            {
                Console.WriteLine(book);
            }
        }
    }
}
