using BooksPlusData.Models;
using Microsoft.Data.SqlClient;

namespace BooksPlusData.Data;

public class BookDao
{
    private readonly string connectionString;

    public BookDao(string connectionString)
    {
        this.connectionString = connectionString;
    }

    // The book with this id, or null if there isn't one.
    public Book? GetById(int bookId)
    {
        return null;
    }

    // Every book in the category, in alphabetical order of title.
    public List<Book> GetByCategory(int categoryId)
    {
        return new List<Book>();
    }

    // Every book whose title contains the text, anywhere, in alphabetical
    // order of title. SearchByTitle("Program") finds "SQL Server 2012 Programming".
    public List<Book> SearchByTitle(string text)
    {
        return new List<Book>();
    }
}
