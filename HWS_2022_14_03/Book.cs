using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_2022_14_03
{
    public class Book
    {
        //Fields
        private static BookContent bookContent = new();
        public static List<Book> books = new();
        //Properties
        public string Title { get; private set; }
        public string Content { get; private set; }
        public string Author { get; private set; }
        public CategoryTypes Category { get; private set; }
        //Constructor
        public Book(string title, string author, CategoryTypes category)
        {
            Title = title;
            Content = bookContent.Get(this);
            Author = author;
            Category = category;
            books.Add(this);
        }
        //Overrides
        public override string ToString()
        {
            return $"Book: {Title}\n" +
                   $"Written By: {Author}\n" +
                   $"Category: {Category}\n";
        }
        //a private struct that holds and gets the books content
        private struct BookContent
        {
            private readonly string loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                                                 "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                                                 "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris " +
                                                 "nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in " +
                                                 "reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla " +
                                                 "pariatur. Excepteur sint occaecat cupidatat non proident, sunt in " +
                                                 "culpa qui officia deserunt mollit anim id est laborum";

            private readonly string dragonShards = "& then the princess picked the most beutiful flower in her " +
                                                   "kingdom & gave it to the ugliest dwarf in hell as a gift for " +
                                                   "being her insperation. The dwarf took the flower & smelled it " +
                                                   "only to show like he cares. The princess noticed the dwarf's lie " +
                                                   "and turned him into a dragon statue immediately, and she was so " +
                                                   "angry that she crushed the statue to the floor & sent its shards " +
                                                   "to many different distatnt locations around the galaxy, the shards " +
                                                   "of this statue are hard to come by around the galaxy & are so " +
                                                   "expensive, that only few powerful peaple could get their hands on " +
                                                   "some small pieces.";

            private readonly string doorsOfPerception = "And yet, I felt myself constrained to say, as I listened to " +
                                                        "these strange products of a Counter-Reformation psychosis working " +
                                                        "upon a late mediaeval art form, and yet it does not matter that " +
                                                        "he’s all in bits. The whole is disorganized. But each individual " +
                                                        "fragment is in order, is a representative of a Higher Order. The " +
                                                        "Higher Order prevails even in the disintegration. The totality is " +
                                                        "present even in the broken pieces. More clearly present, perhaps, " +
                                                        "than in a completely coherent work. At least you aren’t lulled into " +
                                                        "a sense of false security by some merely human, merely fabricated " +
                                                        "order. You have to rely on your immediate perception of the ultimate " +
                                                        "order. So in a certain sense disintegration may have its advantages. " +
                                                        "But of course it’s dangerous, horribly dangerous. Suppose you couldn’t " +
                                                        "get back, out of the chaos....From Gesualdo’s madrigals we jumped, " +
                                                        "across a gulf of three centuries, to Alban Berg and the Lyric Suite. " +
                                                        "\'This\', I announced in advance, \'is going to be hell.\'";
            
            public string Get(Book book)
            {
                switch (book.Title)
                {
                    case "Lorem Ipsum":
                        {
                            return loremIpsum;
                        }
                    case "The Dragon Shards":
                        {
                            return dragonShards;
                        }
                    case "The Doors Of Perception":
                        {
                            return doorsOfPerception;
                        }
                }
                return string.Empty;
            }
        }
    }
}
