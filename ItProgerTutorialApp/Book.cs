using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItProgerTutorialApp
{
    internal class Book : IBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public bool IsAvailable { get; set; }
        public string CheckoutDate { get; set; }
        public string LastUser { get; set; }

        public Book (string Title, string Author, string Genre, string LastUser) 
        {
            this.Title = Title;
            this.Author = Author;
            this.Genre = Genre;
            this.LastUser = LastUser;
        }
        public void CheckOut(string LastUser)
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                CheckoutDate = Convert.ToString(DateTime.Now);
            }
            else
            {
                Console.WriteLine("Книгу уже забрал " + LastUser);
            }
        }

        public void ReturnBook(string LastUser)
        {
            if (!IsAvailable)
            {
                IsAvailable= true; 
            }
        }
    }
}


