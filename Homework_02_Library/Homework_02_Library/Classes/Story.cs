using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02_Library.Classes
{
    public class Story
    {
        public string StoryTitle { get; set; }
        public StoryType StoryType { get; set; }
        public bool IsOriginal { get; set; }
        public string Author { get; set; }

        public Story()
        {

        }

        public Story(string title, StoryType storyType, bool isOriginal, string author)
        {
            StoryTitle = title;
            StoryType = storyType;
            IsOriginal = isOriginal;
            Author = author;
        }
    }

    public enum StoryType
    {
        Novellette,
        Novella,
        ShortStory
    }

}
