using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Book
    {
    private string Title;
    private string Author;
    private string ISBN;
    private int AvailableCopies;

    public string title { get { return Title; } }
    public string author { get { return Author; } }
    public string iSBN { get { return ISBN; } }
    public int availableCopies { get { return AvailableCopies; } }


    public Book(string Title, String Author, String ISBN,int AvailableCopies) 
    {
        this.Title = Title;
        this.Author = Author;
        this.ISBN = ISBN;
        this.AvailableCopies = AvailableCopies;
    }

    public bool loanBook() 
    {
        if (AvailableCopies > 0)
        {
            AvailableCopies--;
            return true;

        }
        else { return false; }
    }

    public override string ToString()
    {
        return Title + " " + Author;
    }
}

