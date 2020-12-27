using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class testCypher
    {
        static void Main(string[] args)
        {
            //making the objects
            Cypher def = new Cypher();
            Cypher over = new Cypher("The Brown Fox Jumped Over the Lazy Dogs");

            //testing default constructed ogject with methods
            def.cypherMethod();
            def.reverseMethod();
            Console.WriteLine(def.toString());

            //testing overloaded object with methods
            over.cypherMethod();
            over.reverseMethod();
            Console.WriteLine(over.toString());
            Console.ReadKey();

        }
    }
}
