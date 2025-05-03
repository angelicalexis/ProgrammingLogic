using System;

namespace Lab7;

//Problem 1
class Book
{
    private string title;

    //Problem 3
    private string author; 

    //Problem 1
    public Book()
    {
        title = "Unknown Title";
        author = "Unknown Author"; 
    }

    //Problem 2
    public Book(string title)
    {
        this.title = title;
    }

    //Problem 3
    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
    }

    //Problem 1
    public string GetTitle()
    {
        return title;
    }

    public void SetTitle(string newTitle)
    {
        title = newTitle;
    }

    //Problem 3
    public string Author
    {
        get {return author;}
        set {author = value;}
    }

    public void SetAuthor(string newAuthor)
    {
        author = newAuthor;
    }
}

//Problem 1
class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        Console.WriteLine(book1.GetTitle());

        book1.SetTitle("C# Fundamentals");
        Console.WriteLine(book1.GetTitle());

        // Problem 2
        Book book2 = new Book("Advanced C#");
        Console.WriteLine(book2.GetTitle());

        // Problem 3
        Book book3 = new Book("Advanced C#", "John Doe");
        Console.WriteLine(book3.GetTitle());

        Console.WriteLine(book3.Author); 

        //Problem 4
        Book book4 = new Book("Mastering C#", "Jane Smith");
        Console.WriteLine(book4.GetTitle());
        Console.WriteLine(book4.Author);
    }
}

/* This was very difficult for me to get correct and 
took a couple of hours to finish! Even if it is correct, 
I would really appreciate feedback regarding the order 
of things under the Book class. I tried to label each step 
and place them in the order I believe they should be in, 
moving the constructors and methods around. Just want to 
be sure I wrote this correctly. Thank you!
*/