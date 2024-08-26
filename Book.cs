using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_EFcore_Project
{
 public  class Book
    {
        public int BookId {  get; set; }   

        public string Bookname { get; set; }    
        public string author { get; set; }   
        public string theyaer { get; set; }
        public string canborrow {  get; set; }    



        public override string ToString()
        {
            return $"[{BookId}] {Bookname}||{author}||{theyaer}||{canborrow}";
        }
    }
}
