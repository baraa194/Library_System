using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_EFcore_Project
{
   public class CRUD_Books
    {
   public void AddBook(Book book)
     {
   using (var context=new AppDbContextcs())
            {
                context.books.Add(book);
                context.SaveChanges();

            }



     }

        public void RemoveBook(int id)
        {
            using (var context = new AppDbContextcs())
            {
               var item=context.books.FirstOrDefault(x=>x.BookId==id);
                context.books.Remove(item);
                context.SaveChanges();

            }



        }
        public void UpdateBook(Book book)
        {
            using (var context = new AppDbContextcs())
            {
                var item = context.books.FirstOrDefault(x => x.BookId == book.BookId);
                item.Bookname = book.Bookname;
                item.author = book.author;
                book.theyaer = book.theyaer;
                context.SaveChanges();


            }
        }


        public void DisplayBooks()
        {
         using(var context=new AppDbContextcs())
            {
                foreach(var book in context.books)
                {
                    Console.WriteLine(book);
                }
            }

        }











    }
}
