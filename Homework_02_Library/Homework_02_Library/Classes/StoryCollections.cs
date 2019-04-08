using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02_Library.Classes
{
    public class StoryCollections : Book, IBook
    {
        public string Author { get; set; }
        public List<Story> Stories { get; set; } = new List<Story>();

        public StoryCollections()
        {

        }

        public StoryCollections(string author, string title, TypeOfEdition typeOfEdition, int numberOfPages) : base(title, typeOfEdition, numberOfPages)
        {
            Author = author;
        }

        public override string GetTypeOfBook()
        {
            return "Story collections";
        }

        public override string ToString()
        {
            return $"{Title}, {Author}, {Stories.Count}.";
        }
    }
}
