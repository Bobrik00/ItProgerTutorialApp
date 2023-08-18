using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItProgerTutorialApp
{
    internal interface ILibrary
    {
        int BooksCount { get; }

        void AddBook(IBook book);
        void CheckOutBook(string title, string userName);
        void ReturnBookToLibrary(string title, string userName);
        void FindBook(string title);
        void ShowBooks();
    }

}
