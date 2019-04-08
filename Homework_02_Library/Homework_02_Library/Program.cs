using System;
using System.Collections.Generic;
using Homework_02_Library.Classes;

namespace Homework_02_Library
{
    class Program
    {
        public static Library InitializeLibrary()
        {
            var story1 = new Story("Story1", StoryType.Novella, true, "Name1");
            var story2 = new Story("Story2", StoryType.ShortStory, false, "Name2");
            var story3 = new Story("Story3", StoryType.Novellette, true, "Name3");
            var story4 = new Story("Story4", StoryType.ShortStory, true, "Name4");
            var story5 = new Story("Story5", StoryType.Novella, false, "Name5");
            
            var novel1 = new Novel("Author1", "Novel1", TypeOfEdition.EBook, 400);
            var novel2 = new Novel("Author2", "Novel2", TypeOfEdition.Paperback, 270) { Series = "Novel", SeriesNumber = 2 };

            var storyCollection1 = new StoryCollections("Name11", "Zbirka1", TypeOfEdition.Hardcover, 832);
            var storyCollection2 = new StoryCollections("Name22", "Zbirka2", TypeOfEdition.EBook, 327);

            storyCollection1.Stories.Add(story1);
            storyCollection1.Stories.Add(story4);            
            storyCollection2.Stories.Add(story5);            

            var anthology1 = new Anthology("Editor01", "Anthology1", TypeOfEdition.Audiobook, 432);
            var anthology2 = new Anthology("Editor02", "Anthology2", TypeOfEdition.EBook, 385);

            anthology1.Stories.Add(story3);
            anthology1.Stories.Add(story1);
            anthology2.Stories.Add(story2);
            anthology2.Stories.Add(story1);
            
            Library library = new Library();
            library.Books = new List<IBook> { novel1, novel2, storyCollection1, storyCollection2, anthology1, anthology2 };
            return library;
        }

        static void Main(string[] args)
        {
            Library library = InitializeLibrary();

            while (true)
            {
                Console.WriteLine("Press '1' - Show all books,\nPress '2'- Novels,\nPress '3'- Story collection,\nPress '4' - Anthology\n");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    Console.WriteLine("\nAll books are: \n");
                    library.ShowBooks("Book");
                }
                else if (input == 2)
                {
                    Console.WriteLine("\nAll novels are: \n");
                    library.ShowBooks("Novels");
                }
                else if (input == 3)
                {
                    Console.WriteLine("\nAll Story collection are: \n");
                    library.ShowBooks("Story collections");
                }
                else if (input == 4)
                {
                    Console.WriteLine("\nAll Anthologies are: \n");
                    library.ShowBooks("Anthology");
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }

                Console.WriteLine("\nPress enter to continue...");
                Console.ReadLine();
            }
        }
    }
}

