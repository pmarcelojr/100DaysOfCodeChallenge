using System;
using _007Day.Entities;

namespace _007Day
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");

            Post p1 = new Post(
                DateTime.Parse("19/12/2020 14:15:05"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12
            );
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night!");
            Comment c4 = new Comment("May the Force be with you");

            Post p2 = new Post(
                DateTime.Parse("19/12/2020 14:25:05"),
                "Good night guys",
                "See you tomorrow",
                5
            );

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
