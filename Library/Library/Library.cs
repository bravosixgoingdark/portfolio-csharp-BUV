using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Library
    {
    private List<Book> Collection;
    private List<User> Users;
    private List<Loan> Loans;

    public List<Book> collection { get { return Collection; } }
    public List<User> users { get { return Users; } }
    public List<Loan> loans { get { return Loans; }}


    public Library()
    {
        Collection = new List<Book>();
        Users = new List<User>();
        Users.Add(new User(1, "Admin", "Admin@email"));
        Loans = new List<Loan>();
    }

    public bool ReadBooksFromJson(string filePath)
    {
        try
        {
            // Read the file content
            string jsonContent = File.ReadAllText(filePath);

            // Deserialize the JSON content to a List of Book objects
            List<Book> books = JsonConvert.DeserializeObject<List<Book>>(jsonContent);

            Collection = books ;
            return true;
        }
        catch (Exception ex)
        {
            // Handle potential errors like file not found, or JSON parsing errors
            Console.WriteLine("An error occurred: " + ex.Message);
            return false;
        }
    }


    public void DisplayBooks()
    { foreach (Book book in Collection)
        {
            Console.WriteLine(book.ToString());        
        }
        Console.ReadLine();
    }

    public void RegisterLoan(Loan loan)
    {
        Loans.Add(loan);
    }



}

