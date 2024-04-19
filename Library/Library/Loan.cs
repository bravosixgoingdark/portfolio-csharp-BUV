using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Loan
    {

    private int LoanID;
    private Book BookLoaned;
    private User Loanee;
    private bool Issued;

    public int loanID { get { return LoanID; } }
    public Book bookLoaned { get { return BookLoaned; } }
    public User loanee { get { return Loanee; } }
    public bool issued { get { return Issued; } set { Issued = value; } }

    public Loan(int id,Book book, User user)
    {
    this.LoanID = id;
    this.BookLoaned = book;
    this.Loanee = user;
    this.Issued = book.loanBook();

    }




}

