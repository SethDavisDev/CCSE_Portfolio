using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Book : Item
    {
        private string author;
        private int isbnNum;

        public Book(string bookName, string authorName, int num) : base(bookName) {
            author = authorName;
            isbnNum = num;
        }


        public override string getListing() {
            return String.Format("Book - {0}, {1}, {2}", title, author, isbnNum) ;
        }
    }
}
