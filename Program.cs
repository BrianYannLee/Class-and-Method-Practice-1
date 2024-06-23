namespace Class_and_Method_Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryManager libraryManager = new LibraryManager();
            libraryManager.Preload();

            libraryManager.library.DisplayAllBook();
            Console.WriteLine();

            libraryManager.library.AddBook("The Great Gatsby", "F. Scott Fitzgerald", "1234567892");

            libraryManager.library.DisplayAllBook();

        }
    }
    public class LibraryManager
    {
        public Library library { get; private set; }

        public LibraryManager()
        {
            library = new Library();
        }
        public void Preload()
        {
            library.AddBook("1984", "George Orwell", "1234567890");
            library.AddBook("To Kill a Mockingbird", "Harper Lee", "1234567891");
        }
    }
    public class Book
    {
        //Field: Fast Input = prop
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        //Constructor: Fast Input = ctrl+. the field
        public Book(string title, string author, string iSBN)
        {
            
            Title = title;
            Author = author;
            ISBN = iSBN;
        }
        //Default: Fast Input = ctor
        public Book()
        {
            Title = "No Book";
            Author = "No Author";
            ISBN = "No ISBN";
        }
        //Display Formatting
        public string GetBookInfo()
        {
            return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}";
        }
    }
    public class Library
    {
        //Create the Book list
        public List<Book> BookList { get; private set; }

        // In this constructor, the Books property is being initialized to a new List<Book>.
        public Library()
        {
            BookList = new List<Book>();
        }
        public void AddBook(string title, string author, string isbn)
        {
            Book newBook = new Book(title, author, isbn);
            BookList.Add(newBook);
        }
        public void RemoveBook(string bookID)
        {
            Book bookToRemove = BookList.FirstOrDefault(b => b.ISBN == bookID);
            if (bookToRemove != null)
            {
                BookList.Remove(bookToRemove);
            }
            else
            {
                Console.WriteLine("No Book listed");
            }
        }
        public void DisplayAllBook()
        {
            foreach (var book in BookList)
            {
                Console.WriteLine(book.GetBookInfo());
            }
        }
    }
}
