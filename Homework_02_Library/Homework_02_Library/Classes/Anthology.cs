using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02_Library.Classes
{
    public class Anthology : Book, IBook
    {
        public string Editor { get; set; }
        public List<Story> Stories { get; set; } = new List<Story>();

        public Anthology()
        {

        }

        public Anthology(string editor, string title, TypeOfEdition typeOfEdition, int numberOfPages) : base(title, typeOfEdition, numberOfPages)
        {
            Editor = editor;
        }

        public override string GetTypeOfBook()
        {
            return "Anthology";
        }

        public override string ToString()
        {
            return $"{Title}, {Editor}, {Stories.Count}";
        }
    }
}
