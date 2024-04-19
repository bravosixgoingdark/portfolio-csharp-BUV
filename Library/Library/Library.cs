using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Library
    {
    private List<Book> Collection;
    public List<Book> collection { get { return Collection; } }


    public Library()
    {
        Collection = new List<Book>();
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



}

