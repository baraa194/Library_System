using OOP_EFcore_Project;


Console.WriteLine("Hello! Enter L if you librarian U if you a user");
var inputtype = Console.ReadLine().ToUpper()[0];
if (inputtype == 'L')
{
    Console.WriteLine("Hello Librarian ");
    Console.WriteLine("Enter your ID : ");
    int librid = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter your Name : ");
    var name = Console.ReadLine();
    while (true)
    {

        if (isExist(librid))
        {
            Console.WriteLine($"Hello {name} Enter number");
            Console.WriteLine("1-Add Book\n2-Delete Book\n3-Update Book\n4-Show All Books");
            int optionnum = Convert.ToInt32(Console.ReadLine());
            CRUD_Books cRUD_Books = new CRUD_Books();


            switch (optionnum)
            {
                case 1:
                    Console.WriteLine("Enter Book Informations");
                    var bname = Console.ReadLine();
                    var bauthor = Console.ReadLine();
                    var byear = Console.ReadLine();
                    Book book = new Book
                    {
                        Bookname = bname,
                        author = bauthor,
                        theyaer = byear,
                        canborrow = "available",


                    };
                    cRUD_Books.AddBook(book);
                    break;
                case 2:
                    Console.WriteLine("Enter Book Id to Remove");
                    int bid = Convert.ToInt32(Console.ReadLine());
                    cRUD_Books.RemoveBook(bid);
                    break;

                case 3:
                    Console.WriteLine("Enter Book Informations to update");
                    var bookname = Console.ReadLine();
                    var bookauthor = Console.ReadLine();
                    var bookyear = Console.ReadLine();
                    Book bookk = new Book
                    {
                        Bookname = bookname,
                        author = bookauthor,
                        theyaer = bookyear,


                    };
                    cRUD_Books.UpdateBook(bookk);
                    break;


                case 4:
                    Console.WriteLine("Id\tBookName\tAuthor\t\tYear\tState");
                    cRUD_Books.DisplayBooks();
                    break;
                default: Environment.Exit(0); break;

            }

        }
        else
        {
            Console.WriteLine("Not Exist Try Again!!");
        }


    }


}
else if (inputtype == 'U')
{

    Console.WriteLine("Hello user Enter your name");
    var uname = Console.ReadLine();
    Console.WriteLine($"Hello {uname} Enter a Number");
    while (true)
    {

        Console.WriteLine("1-Borrow Book\n2-Show All Books");
        int numop = Convert.ToInt32(Console.ReadLine());


        switch (numop)
        {
            case 1:
                BorrowBook book = new BorrowBook();
                Console.WriteLine("Enter Name of the Book :");
                var namebook = Console.ReadLine();
                if (book.borrow(namebook))
                    Console.WriteLine("Borrowed Successfully");
                else
                    Console.WriteLine("SORRY!!Can not Borrowed");
                break;

            case 2:
                CRUD_Books cRUD_Books = new CRUD_Books();
                Console.WriteLine("Id\tBookName\tAuthor\t\tYear\tState");
                cRUD_Books.DisplayBooks();
                break;


        }

    }
}
else
{
    Console.WriteLine("Please Enter L or U");
}

static bool  isExist(int id)
{
    using (var context = new AppDbContextcs())
    {
       var item=context.librarians.FirstOrDefault(x=>x.LibrarianId==id);
        return item != null;
          
    }


}


