using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02_Library.Classes
{
    public interface IBook
    {
        int ID { get; set; }
        string Title { get; set; }
        TypeOfEdition TypeOfEdition { get; set; }
        int NumberOfPages { get; set; }
        long ISBN { get; set; }

        int GenerateID();
        string GetTypeOfBook();
        long GenerateISBN();
    }

    public enum TypeOfEdition
    {
        Hardcover,
        Paperback,
        EBook,
        Audiobook
    }
}
