namespace Task_2_1_OOP_features
{
    interface ILibraryUser
    {
       
            void AddBook(string adBook);
            void RemoveBook(string removeBook);
            string BookInfo(int bookIndex);
            int BooksCount();
    }
}
