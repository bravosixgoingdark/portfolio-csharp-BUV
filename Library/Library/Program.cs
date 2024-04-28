// See https://aka.ms/new-console-template for more information

Library library = new Library();
library.ReadBooksFromJson("books.json");

User currentUser = library.users[0];
bool running = true;

while (running)
{
    Console.Clear();
    Console.WriteLine("Enter 0 to quit");
    Console.WriteLine("Enter 1 to display all books");
    Console.WriteLine("Enter 2 to borrow a book");
    Console.WriteLine("Enter 2 to return a book");




    string input = Console.ReadLine();

    switch (input)
    {
        case "0":
            running = false;
            break;
        case "1":
            library.DisplayBooks();
            break;
        case "2":
            library.RegisterLoan(new Loan(1, library.collection[0], currentUser));
            break;
    }




}

