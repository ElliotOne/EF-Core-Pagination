# EF-Core-Pagination

## Overview

Welcome to the **EF-Core-Pagination** project! This is a lightweight **C# extension methods library** designed to simplify pagination on `IQueryable<T>` data sources, commonly used with Entity Framework Core or any LINQ-enabled collection.

The purpose of this project is to provide easy-to-use methods for paginating data in your applications, including fetching the first page, last page, any specific page, and calculating the total number of pages based on page size.

---

## Project Structure

- **EF-Core-Pagination**: A static class with extension methods that:
  - Paginate `IQueryable<T>` data with customizable page number and size.
  - Retrieve the first or last page of data easily.
  - Calculate the total number of pages given a page size.

---

## Features

- Extension method `.Page(pageNumber, pageSize)` to fetch any specific page.
- Extension method `.FirstPage(pageSize)` to fetch the first page.
- Extension method `.LastPage(pageSize)` to fetch the last page.
- Extension method `.CountOfPages(pageSize)` to calculate total pages.
- Works seamlessly with any LINQ IQueryable data source.
- Minimal, clean, and efficient implementation.

---

## How It Works

These extension methods operate on any `IQueryable<T>` data source by using LINQ's `Skip` and `Take` to select data subsets for pagination. The total page count is calculated based on the total number of records and the specified page size.

---

## Output Example

Total Pages: 5

First Page:
1 2 3 4 5 6 7 8 9 10

Last Page:
41 42 43 44 45 46 47 48 49 50

Page 3:
21 22 23 24 25 26 27 28 29 30


---

## How to Use

1. Add the `IQueryableExtensions` static class to your project.
2. Use the extension methods on any `IQueryable<T>` collection:

```csharp
var pageData = yourQueryable.Page(pageNumber, pageSize);
var firstPage = yourQueryable.FirstPage(pageSize);
var lastPage = yourQueryable.LastPage(pageSize);
int totalPages = yourQueryable.CountOfPages(pageSize);
```

3. Integrate these methods into your API or UI pagination logic to retrieve paged data efficiently.

---

## Screenshots

### Console Output

![Console Output](https://github.com/ElliotOne/EF-Core-Pagination/blob/master/screenshots/first.png)

---

## Technologies Used

- [.NET 6](https://dotnet.microsoft.com/)
- [C#](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [Visual Studio](https://visualstudio.microsoft.com/)

---

## License

This project is licensed under the MIT License. You are free to use, modify, and share it.

---

## Contributions

Contributions are welcome! Feel free to fork the repository, submit feature requests, or open pull requests to enhance pagination capabilities, support asynchronous queries, or add more advanced filtering options.

---