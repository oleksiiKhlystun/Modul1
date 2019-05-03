using System;

namespace Task_2_1_OOP_features
{
    // Using hint 

    // 1) declare interface ILibraryUser
    // declare method's signature for methods of class LibraryUser



    // 2) declare class LibraryUser, it implements ILibraryUser
    class LibraryUser : ILibraryUser
    {
        // 3) declare properties: FirstName (read only), LastName (read only), 
        // Id (read only), Phone (get and set), BookLimit (read only)
        public string FirstName { get; }
        public string LastName { get; }
        public int Id { get; }
        public string Phone { get; set; }
        public int BookLimit { get; }

        // 4) declare field (bookList) as a string array
        private int length = 0;
        private string[] bookList = new string[0];
        // private static int _sid = 0;
        public LibraryUser()
        {
            FirstName = "FirstName";
            LastName = "LastName";
            Phone = "none";
            BookLimit = 10;
        }
        // 5) declare indexer BookList for array bookList
        internal string this[int index]
        {
            get
            {
                if (index >= 0 && index < bookList.Length)
                    return (string)bookList[index];
                else
                    return "Index is out of range";
            }
            set
            {
                if (index >= 0 && index < bookList.Length)
                    bookList[index] = value;
            }
        }
        // 6) declare constructors: default and parameter
        public LibraryUser(string firstName, string lastName, string phone, int bookLimit)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            BookLimit = bookLimit;
        }
        // 7) declare methods: 

        //AddBook() – add new book to array bookList

        //RemoveBook() – remove book from array bookList

        //BookInfo() – returns book info by index

        //BooksCout() – returns current count of books
        public void AddBook(string book)
        {
            if (bookList.Length + 1 <= BookLimit)
            {
                length++;
                Array.Resize(ref bookList, length);
                bookList[length - 1] = book;
            }
            else
            {
                Console.WriteLine("booklist limit");
            }
        }
        public void RemoveBook(string book)
        {
            int u = Array.LastIndexOf(bookList, book);
            if (u >= 0)
            {
                for (int i = u; i < bookList.Length - 2; i++)
                {
                    bookList[i] = bookList[i + 1];
                }
            }
            length--;
            Array.Resize(ref bookList, length);
        }
        public string BookInfo(int bookIndex)
        {
            return bookList[bookIndex];
        }
        public int BooksCount()
        {
            return bookList.Length;
        }

    }
}
