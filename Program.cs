using System;

namespace bookStore
{
    class Book
    {
        private int _Id;
        private string _Title;
        private string _Author;

        public Book()
        {
            _Id = 0;
            _Title = "";
            _Author = "";
        }

        public Book(int i, string Title, string Author)
        {
            _Id = i;
            _Title = Title;
            _Author = Author;
        }

        public string GetFullName()
        {
            return _Title + " by " + _Author;
        }
        public int GetId()
        {
            return _Id;
        }

        public void SetId(int identification)
        {
            _Id = identification;
        }

        public void SetTitle(string title)
        {
            _Title = title;
        }

        public void SetAuthor(string author)
        {
            _Author = author;
        }

        
            static void Main(string[] args)
            {
                Book book10 = new Book();
                book10.SetId(10);
                book10.SetTitle("Reminders of Him");
                book10.SetAuthor("Colleen Hoover");

                Book book20 = new Book();
                Console.WriteLine("Please enter the book ID: ");
                book20.SetId(int.Parse(Console.ReadLine()));
                Console.WriteLine("Please enter the book name: ");
                book20.SetTitle(Console.ReadLine());
                Console.WriteLine("Please enter the author's name: ");
                book20.SetAuthor(Console.ReadLine());

                Book book30 = new Book(30, "The Lost Bookshop", "Evie Woods");

                Console.WriteLine("Please enter the book ID: ");
                int tempID = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the book name: ");
                string tempBookName = Console.ReadLine();
                Console.WriteLine("Please enter the author's name: ");
                string tempAuthorName = Console.ReadLine();
                Book book40 = new Book(tempID, tempBookName, tempAuthorName);

                displayBooks(book10);
                displayBooks(book20);
                displayBooks(book30);
                displayBooks(book40);
            }

            static void displayBooks(Book member)
            {
                Console.WriteLine("Here's your book information");
                Console.WriteLine($"Book ID: {member.GetId()}");
                Console.WriteLine($"Book Title and Author: {member.GetFullName()}");
            }

        }

    }
        
