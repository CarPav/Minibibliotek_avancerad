using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minibibliotek_avancerad
{
    public class Book
    {
        public string Title { get; set; }
        public int ID { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }
        public int ISBN { get; set; }
        public List<int> Reviews { get; set; }

        public Book(string title, int id, string author, int yearPublished, int isbn, List<int> reviews)
        {
            Title = title;
            ID = id;
            Author = author;
            YearPublished = yearPublished;
            ISBN = isbn;
            Reviews = reviews;
        }
    }
}
