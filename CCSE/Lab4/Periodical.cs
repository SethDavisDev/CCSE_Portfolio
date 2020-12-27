using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Periodical : Item 
    {
        private int issueNum;

        public Periodical(string name, int num) : base(name) {
            issueNum = num;
        }

        public override string getListing(){
            return String.Format("Periodical - {0}, #{1}", title, issueNum);
        }

    }
}
