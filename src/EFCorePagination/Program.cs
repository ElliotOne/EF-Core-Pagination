// Sample data: a list of integers from 1 to 50
using EFCorePagination;

List<int> numbers = Enumerable.Range(1, 50).ToList();

// Convert to IQueryable to use extension methods
IQueryable<int> data = numbers.AsQueryable();

int pageSize = 10;

Console.WriteLine($"Total Pages: {data.CountOfPages(pageSize)}");
Console.WriteLine();

// Test FirstPage
Console.WriteLine("First Page:");
foreach (var item in data.FirstPage(pageSize))
{
    Console.Write(item + " ");
}
Console.WriteLine("\n");

// Test LastPage
Console.WriteLine("Last Page:");
foreach (var item in data.LastPage(pageSize))
{
    Console.Write(item + " ");
}
Console.WriteLine("\n");

// Test Page method for page 3
int pageNumber = 3;
Console.WriteLine($"Page {pageNumber}:");
foreach (var item in data.Page(pageNumber, pageSize))
{
    Console.Write(item + " ");
}
Console.WriteLine();