using ItProgerTutorialApp;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace ItProgerTutorialApp
{
    class Program : ILibrary
    {
        public int BooksCount => books.Count; // Убрал set и сделал вычисляемым, чтобы показать реальное количество книг в списке.
        private List<IBook> books = new List<IBook>(); // Инициализация списка книг

        public void ShowBooks()
        {
            if (books.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Библиотека пуста.");
                return;
            }

            foreach (var book in books)
            {
                Console.WriteLine($"Название: {book.Title}, Автор: {book.Author}, Жанр: {book.Genre}, Доступность: {(book.IsAvailable ? "Доступна" : "Отсутствует")}");
            }
        }

        public void AddBook(IBook book)
        {
            Console.Clear();
            books.Add(book);
            Console.WriteLine($"Книга '{book.Title}' добавлена в библиотеку.");
        }

        public void CheckOutBook(string title, string userName)
        {
            var book = books.FirstOrDefault(b => b.Title == title);
            if (book == null)
            {
                Console.Clear();
                Console.WriteLine($"Книга '{title}' отсутствует в библиотеке.");
                return;
            }

            book.CheckOut(userName);
        }

        public void ReturnBookToLibrary(string title, string userName)
        {
            var book = books.FirstOrDefault(b => b.Title == title);
            if (book == null)
            {
                Console.Clear();
                Console.WriteLine($"Книга '{title}' отсутствует в библиотеке.");
                return;
            }

            book.ReturnBook(userName);
        }

        public void FindBook(string title)
        {
            var book = books.FirstOrDefault(b => b.Title == title);
            if (book == null)
            {
                Console.Clear();
                Console.WriteLine($"Книга '{title}' отсутствует в библиотеке.");
                return;
            }

            Console.WriteLine($"Название: {book.Title}, Автор: {book.Author}, Жанр: {book.Genre}, Доступность: {(book.IsAvailable ? "Доступна" : $"Отсутствует, взята {book.CheckoutDate} пользователем {book.LastUser}")}");
        }


        static void Main()
        {
            Program library = new();
            Console.WriteLine("Введите имя пользователя: ");
            string currentUser = Console.ReadLine();

            int choice;
            do
            {
                //Console.Clear();
                Console.WriteLine("\nВыберите действие:\n1. Просмотр всех книг\n2. Добавить книгу\n3. Взять книгу\n4. Вернуть книгу\n5. Найти книгу\n6. Выход \n");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        library.ShowBooks();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Введите название книги:");
                        string title = Console.ReadLine();
                        Console.WriteLine("Введите автора:");
                        string author = Console.ReadLine();
                        Console.WriteLine("Введите жанр:");
                        string genre = Console.ReadLine();

                        library.AddBook(new Book(title, author, genre, currentUser));
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Какую книгу вы хотите взять?");
                        title = Console.ReadLine();
                        library.CheckOutBook(title, currentUser);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Какую книгу вы хотите вернуть?");
                        title = Console.ReadLine();
                        library.ReturnBookToLibrary(title, currentUser);
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Какую книгу вы хотите найти?");
                        title = Console.ReadLine();
                        library.FindBook(title);
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Выход...");
                        break;
                }
            } while (choice != 6);
        }


    }
}