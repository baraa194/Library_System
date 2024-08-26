using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP_EFcore_Project
{
   public class BorrowBook
    {
      public bool borrow (string bookname)
        {
          using(var context=new AppDbContextcs())
            {
                var item=context.books.FirstOrDefault(x=>x.Bookname==bookname);
                if(!item.canborrow.Equals( "Borrowed"))
                {
                    item.canborrow = "Borrowed";
                    context.SaveChanges();

                    return true;
                }
                 
                else
                    return false;
                

            }
        }



    }
}
