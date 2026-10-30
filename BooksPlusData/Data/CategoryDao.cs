using BooksPlusData.Models;
using Microsoft.Data.SqlClient;

namespace BooksPlusData.Data;

public class CategoryDao
{
    private readonly string connectionString;

    public CategoryDao(string connectionString)
    {
        this.connectionString = connectionString;
    }

    // An example to follow: every category, in alphabetical order of name.
    public List<Category> GetAll()
    {
        string sql = """
            SELECT CategoryId, CategoryName, Description
            FROM Category
            ORDER BY CategoryName;
            """;

        List<Category> categories = new List<Category>();

        using SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();
        using SqlCommand command = new SqlCommand(sql, connection);
        using SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            categories.Add(MapRowToCategory(reader));
        }
        return categories;
    }

    // The category with this id, or null if there isn't one.
    public Category? GetById(int categoryId)
    {
        return null;
    }

    // Inserts a new category and returns the CategoryId it was given.
    // (The table also has a ModifiedDate column, which the database fills in itself.)
    public int Add(Category category)
    {
        return 0;
    }

    private static Category MapRowToCategory(SqlDataReader reader)
    {
        return new Category
        {
            CategoryId = (int)reader["CategoryId"],
            CategoryName = (string)reader["CategoryName"],
            Description = reader["Description"] as string
        };
    }
}
