using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Book // Create a class called book
    {
    private string Title; //properties = attributes of the book 
    private string Author;
    private string ISBN;
    private int AvailableCopies;

    public string title { get { return Title; } } // getters and setters of a property. How would anything access this infomation
    public string author { get { return Author; } }
    public string iSBN { get { return ISBN; } }
    public int availableCopies { get { return AvailableCopies; } }


    public Book(string Title, String Author, String ISBN,int AvailableCopies) // This is a constructor, it says how an object of this class is made.
    {
        this.Title = Title;
        this.Author = Author;
        this.ISBN = ISBN;
        this.AvailableCopies = AvailableCopies;
    }

    public bool loanBook() // basically a function  
    {
        if (AvailableCopies > 0)
        {
            AvailableCopies--;
            return true;

        }
        else { return false; }
    }
    public void returnBook(){
        AvailableCopies++;
    }
}

