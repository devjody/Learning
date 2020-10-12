using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    #region Book Class
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }
        public bool Available = true;

        public Book( string title, string author, int isbn, bool available )
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Available = available;
        }

        public string Avalibility() 
        {
            if ( Available )
            {
                return "AVAILABLE";
            }
            else
                return "UNAVAILABLE";
        }
    }
    #endregion

    #region Library Class
    public class Library
    {
        #region Init Collection of books in Library
        public List<Book> collection;
        public Library( ) { collection = new List<Book>(); }
        public void AddToLibrary( Book book ) { collection.Add( book ); }
        #endregion
        #region Show Books in Library
        public void InventoryList()
        {
            Console.WriteLine( "Displaying all of the Libraries current books\n" );
            foreach ( Book book in collection )
            {
                Console.WriteLine($"{book.ISBN} - {book.Title} by {book.Author}, {book.Avalibility()}");
            }
            Console.WriteLine();
        }
        #endregion
        #region Find/Search Function
        public void Find( string search )
        {
            Console.WriteLine( $"Your search for [{search}] returned the following books..." );
            foreach ( Book book in collection )
            {
                if ( book.Title.Contains(search) || book.Author.Contains(search) )
                {
                    Console.WriteLine( $"{book.ISBN} - {book.Title} by {book.Author}, {book.Avalibility()}" );
                }
            }
            Console.WriteLine();
        }
        #endregion
        #region Checkout Book
        public void CheckoutBook( int byIsbn )
        {
            foreach ( Book book in collection )
            {
                if ( book.ISBN == byIsbn && book.Available == true )
                {
                    book.Available = false;
                    Console.WriteLine( $"{book.ISBN} - {book.Title} by {book.Author}, CHECKED OUT" );
                }
                else if ( book.ISBN == byIsbn && book.Available == false )
                {
                    Console.WriteLine( "Sorry this book is not available..." );
                }
            }
            Console.WriteLine();
        }
        #endregion  
        #region Return Book
        public void ReturnBook( int byIsbn )
        {
            foreach ( Book book in collection )
            {
                if ( book.ISBN == byIsbn && book.Available == false )
                {
                    book.Available = true;
                    Console.WriteLine( $"{book.ISBN} - {book.Title} by {book.Author}, RETURNED" );
                }
                else if ( book.ISBN == byIsbn && book.Available == true )
                {
                    Console.WriteLine( "This book is not currently checked out..." );
                }
            }
            Console.WriteLine();
        }
        #endregion
    }
    #endregion

    class Program
    {
        static void Main( string[ ] args )
        {
            // Init new Library object
            Library library = new Library();

            // Add new Books to Library
            library.AddToLibrary( new Book( "The Fellowship of the Ring", "J. R. R. Tolkien", 252, true ) );
            library.AddToLibrary( new Book( "A Game of Thrones", "George R. R. Martin", 486, true ) );
            library.AddToLibrary( new Book( "Harry Potter and the Philosopher's Stone", "J. K. Rowling", 934, true ) );
            library.AddToLibrary( new Book( "The Way of Kings", "Brandon Sanderson", 353, true ) );
            library.AddToLibrary( new Book( "Fahrenheit 451", "Ray Bradbury", 974, true ) );
            library.AddToLibrary( new Book( "Pride and Prejudice", "Jane Austen", 530, true ) );
            library.AddToLibrary( new Book( "The Jane Austen Book Club", "Karen Joy Fowler", 261, true ) );
            library.AddToLibrary( new Book( "The Hitchhiker's Guide to the Galaxy", "Douglas Adams", 913, true ) );
            library.AddToLibrary( new Book( "Fablehaven", "Brandon Mull", 810, true ) );
            library.AddToLibrary( new Book( "The Name of the Wind", "Patrick Rothfuss", 407, true ) );


                string input; // Await instructions
                while ( ( input = Console.ReadLine() ) != "exit" )
                {
                    if ( input.StartsWith( "find all" ) || input.StartsWith( "findall" ) || input.StartsWith( "all" ) )
                    {
                        // Print out Library Inventory
                        library.InventoryList();
                    }                
                    else if ( input.StartsWith( "checkout " ) )
                    {
                        string checkout = input.Substring( 8 );
                        int byIsbn = int.Parse( checkout );
                        library.CheckoutBook( byIsbn );
                    }
                    else if ( input.StartsWith( "return " ) )
                    {
                        string rtn = input.Substring( 6 );
                        int byIsbn = int.Parse( rtn );
                        library.ReturnBook( byIsbn );
                    }
                    else if ( input.StartsWith( "find" ) )
                    {
                        string search = input.Replace( "find", "" );
                        search = search.TrimStart();
                        library.Find( search );
                    }
                    else // if invalid or unknow instruction
                        Console.WriteLine( "Please try again...\n" );
            }
                Console.ReadLine();
        }
    }
}

/*
all
Displaying all of the Libraries current books

252 - The Fellowship of the Ring by J. R. R. Tolkien, AVAILABLE
486 - A Game of Thrones by George R. R. Martin, AVAILABLE
934 - Harry Potter and the Philosopher's Stone by J. K. Rowling, AVAILABLE
353 - The Way of Kings by Brandon Sanderson, AVAILABLE
974 - Fahrenheit 451 by Ray Bradbury, AVAILABLE
530 - Pride and Prejudice by Jane Austen, AVAILABLE
261 - The Jane Austen Book Club by Karen Joy Fowler, AVAILABLE
913 - The Hitchhiker's Guide to the Galaxy by Douglas Adams, AVAILABLE
810 - Fablehaven by Brandon Mull, AVAILABLE
407 - The Name of the Wind by Patrick Rothfuss, AVAILABLE

find Ring
Your search for [Ring] returned the following books...
252 - The Fellowship of the Ring by J. R. R. Tolkien, AVAILABLE

checkout 252
252 - The Fellowship of the Ring by J. R. R. Tolkien, CHECKED OUT

find Ring
Your search for [Ring] returned the following books...
252 - The Fellowship of the Ring by J. R. R. Tolkien, UNAVAILABLE

return 252
252 - The Fellowship of the Ring by J. R. R. Tolkien, RETURNED

return 530
This book is not currently checked out...

checkout 530
530 - Pride and Prejudice by Jane Austen, CHECKED OUT

checkout 530
Sorry this book is not available...

all
Displaying all of the Libraries current books

252 - The Fellowship of the Ring by J. R. R. Tolkien, AVAILABLE
486 - A Game of Thrones by George R. R. Martin, AVAILABLE
934 - Harry Potter and the Philosopher's Stone by J. K. Rowling, AVAILABLE
353 - The Way of Kings by Brandon Sanderson, AVAILABLE
974 - Fahrenheit 451 by Ray Bradbury, AVAILABLE
530 - Pride and Prejudice by Jane Austen, UNAVAILABLE
261 - The Jane Austen Book Club by Karen Joy Fowler, AVAILABLE
913 - The Hitchhiker's Guide to the Galaxy by Douglas Adams, AVAILABLE
810 - Fablehaven by Brandon Mull, AVAILABLE
407 - The Name of the Wind by Patrick Rothfuss, AVAILABLE
*/
