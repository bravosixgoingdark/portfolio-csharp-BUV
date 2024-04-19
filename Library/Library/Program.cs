// See https://aka.ms/new-console-template for more information


Library library = new Library();
library.ReadBooksFromJson("books.json");
foreach (Book item in library.collection)
{
    Console.WriteLine(item.title);
}


User user = new User(1,"Fraser","Fraser@email.com");
Console.WriteLine(user.userID);
