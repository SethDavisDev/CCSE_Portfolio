using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public abstract class Item
    {
        protected string title;

        public Item(string name) {
            title = name;
        }

        public string getTitle() {
            return title;
        }

        public abstract string getListing();
    }
}
