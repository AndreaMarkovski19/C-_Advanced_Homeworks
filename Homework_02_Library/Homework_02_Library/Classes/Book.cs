using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02_Library.Classes
{
    public class Book : IBook
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public TypeOfEdition TypeOfEdition { get; set; }
        public int NumberOfPages { get; set; }
        public long ISBN { get; set; }

        public Book()
        {

        }

        public Book(string title, TypeOfEdition typeOfEdition, int numberOfPages)
        {
            Title = title;
            TypeOfEdition = typeOfEdition;
            NumberOfPages = numberOfPages;
            ISBN = GenerateISBN();
            ID = GenerateID();
        }
        
        public int GenerateID()
        {
            Random random = new Random();
            Int32 x = 0;
            int i;
            for (i = 1; i < 7; i++)
            {
                x += random.Next(0, 9);
            }
            return x;
        }

        public virtual string GetTypeOfBook()
        {
            return "Book.";
        }

        public long GenerateISBN()
        {
            Random random1 = new Random();
            Int32 r = 0;
            int i;
            for (i = 1; i < 14; i++)
            {
                r += random1.Next(0, 9);
            }
            return r;
        }
    }
}
