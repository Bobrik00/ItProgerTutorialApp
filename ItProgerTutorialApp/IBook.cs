using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItProgerTutorialApp
{
    internal interface IBook
    {
        string Title { get; set; }
        string Author { get; set; }
        string Genre { get; set; }
        string CheckoutDate { get; set; }
        bool IsAvailable { get; set; }
        string LastUser { get; set; }

        void CheckOut(string LastUser);
        void ReturnBook(string LastUser);
    }
}
