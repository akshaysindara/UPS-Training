using System;

public delegate void addbook(string message);    
public delegate void displaybook(string message);

class Program
{
    public static void AddBook(string message)
    {
        Console.WriteLine(message);
    }
    public static void DisplayBook(string message)
    {
        Console.WriteLine(message);
    }
    public static void Main(string[] args)
    {
        addbook a1 = new addbook(AddBook);
        displaybook d1 = new displaybook(DisplayBook);
        a1("Adding a new book to the library.");
        d1("Displaying all books in the library.");
    }
    
}