using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework_02_Library.Classes
{
    public class Novel : Book, IBook
    {
        public string Author { get; set; }
        public string Series { get; set; }
        public int SeriesNumber { get; set; }

        
        public Novel(string author, string title, TypeOfEdition typeOfEdition, int numberOfPages) : base(title, typeOfEdition, numberOfPages)
        {
            Author = author;
        }

        public string IsItSeries()
        {
            if (Series == null)
            {
                return "";
            }
            else
            {
                return $"{Series} is {SeriesNumber}";
            }
        }

        public override string ToString()
        {
            return $"{Title}, {Author}, {IsItSeries()}, {NumberOfPages}";
        }

        public override string GetTypeOfBook()
        {
            return "Novels";
        }
    }
}
