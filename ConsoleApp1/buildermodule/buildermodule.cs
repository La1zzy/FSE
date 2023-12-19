namespace DefaultNamespace;

using System;


public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }

    public override string ToString()
    {
        return $"Title: {Title}, Author: {Author}, Genre: {Genre}, Year: {Year}";
    }
}


public interface IBookBuilder
{
    void BuildTitle();
    void BuildAuthor();
    void BuildGenre();
    void BuildYear();
    Book GetBook();
}


public class ConcreteBookBuilder : IBookBuilder
{
    private Book book = new Book();

    public void BuildTitle()
    {
        book.Title = "Sample Title";
    }

    public void BuildAuthor()
    {
        book.Author = "Sample Author";
    }

    public void BuildGenre()
    {
        book.Genre = "Sample Genre";
    }

    public void BuildYear()
    {
        book.Year = 2023;
    }

    public Book GetBook()
    {
        return book;
    }
}


public class BookDirector
{
    private IBookBuilder bookBuilder;

    public BookDirector(IBookBuilder builder)
    {
        bookBuilder = builder;
    }

    public void Construct()
    {
        bookBuilder.BuildTitle();
        bookBuilder.BuildAuthor();
        bookBuilder.BuildGenre();
        bookBuilder.BuildYear();
    }
}

class Program
{
    static void Main()
    {
        
        IBookBuilder builder = new ConcreteBookBuilder();

      
        BookDirector director = new BookDirector(builder);

        
        director.Construct();

     
        Book book = builder.GetBook();

        
        Console.WriteLine(book);
        
    }
}
    
