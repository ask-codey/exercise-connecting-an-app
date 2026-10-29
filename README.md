# Practice: Connecting an App

Practice code for the lesson **Practice: Connecting an App** in the C# Full-Stack Bootcamp on [ask-codey.com](https://www.ask-codey.com).

You'll write the Data Access Objects (DAOs) for three tables in the **BooksPlus** database, using ADO.NET: `SqlConnection`, `SqlCommand` and `SqlDataReader`.

## Before you start

The tests run your code against your own BooksPlus database, so:

1. SQL Server must be running on your computer.
2. The BooksPlus database must exist. If you haven't created it yet, run `BooksPlus.sql` from the course's sample databases in SSMS.

The connection string is in `BooksPlusData/appsettings.json`. It uses Windows Authentication, so there's no password in it.

## What's here

- `BooksPlusData/Models`: the `Category`, `Book` and `Customer` models, ready to use.
- `BooksPlusData/Data`: the DAOs. `CategoryDao.GetAll()` is finished, as an example to follow. Every other method returns nothing for now.
- `BooksPlusData.Tests`: tests for every DAO method. You don't need to change these.

## What to do

Write each method in `CategoryDao`, `BookDao` and `CustomerDao`. The comment above each method says what it returns.

Run the program with **Ctrl+F5** to see the categories, and run the tests with **Test > Run All Tests** (or `dotnet test`). At first many tests fail: each method you finish turns its tests green.

## Tips

- Try every query in SSMS first, against BooksPlus, then paste it into your code.
- Use a parameter for every value: `WHERE BookId = @BookId`. One test tries a SQL injection attack on `SearchByTitle`.
- `Summary` is `NULL` in every book. Read nullable columns with `reader["Summary"] as string`, or check `IsDBNull` first.
- Write one mapping method per DAO, such as `MapRowToBook`, and use it in every method.

## Hand it in

When it works, push your solution to a public repo of your own on GitHub, then paste that repo's address into **Submit your exercise** on the lesson page at [ask-codey.com](https://www.ask-codey.com). That's what completes the lesson. The lesson page shows the Git commands, step by step.
