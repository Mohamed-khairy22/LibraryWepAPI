

# Library Management System

## Description

The Library Management System is a .NET API designed to facilitate the management of library operations. This system allows for the efficient management of books, patrons, and library transactions, providing a robust solution for tracking book inventory, managing user information, and handling checkouts and returns.

## Features

- **Book Management**: Add, update, and remove books from the library inventory.
- **Patron Management**: Register new patrons and manage existing patron information.
- **Checkout and Return**: Handle book checkouts and returns, including overdue book tracking.
- **Search Functionality**: Search for books and patrons with various filters.
- **Reporting**: Generate reports on book inventory, patron activity, and overdue items.

## Prerequisites

Before you begin, ensure you have met the following requirements:

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or [LocalDB](https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb)
- [Visual Studio](https://visualstudio.microsoft.com/) or another .NET-compatible IDE

## Installation

1. **Clone the Repository**

   ```bash
   git clone https://github.com/Mohamed-khairy22/library-management-system.git
   ```

2. **Navigate to the Project Directory**

   ```bash
   cd library-management-system
   ```

3. **Install Dependencies**

   Restore the project dependencies using the following command:

   ```bash
   dotnet restore
   ```

4. **Configure the Database**

   - Create a new database in SQL Server or LocalDB.
   - Update the connection string in `appsettings.json` to point to your database.

5. **Apply Migrations**

   Create the database schema by running:

   ```bash
   dotnet ef database update
   ```

6. **Run the Application**

   Start the API by running:

   ```bash
   dotnet run
   ```

   The API will be available at `http://localhost:5000`.

## Usage

### Endpoints

- **Books**

  - `GET /api/books` - Retrieve a list of books.
  - `GET /api/books/{id}` - Retrieve a specific book by ID.
  - `POST /api/books` - Add a new book.
  - `PUT /api/books/{id}` - Update an existing book.
  - `DELETE /api/books/{id}` - Remove a book.

- **Patrons**

  - `GET /api/patrons` - Retrieve a list of patrons.
  - `GET /api/patrons/{id}` - Retrieve a specific patron by ID.
  - `POST /api/patrons` - Register a new patron.
  - `PUT /api/patrons/{id}` - Update an existing patron.
  - `DELETE /api/patrons/{id}` - Remove a patron.

- **Transactions**

  - `POST /api/transactions/checkout` - Checkout a book to a patron.
  - `POST /api/transactions/return` - Return a book.

### Example

To add a new book, send a `POST` request to `/api/books` with the following JSON payload:

```json
{
  "title": "The Great Gatsby",
  "author": "F. Scott Fitzgerald",
  "isbn": "9780743273565",
  "publishedDate": "1925-04-10"
}
```



## Contact

For any questions or issues, please contact:

- **Mohamed Khairy** - [mohamedkhairy063036@gmail.com)

