using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class myCollections
    {
        static void Main(string[] args)
        {
            string[] bookNames = { "Moby Dick", "39 Clues", "Heart of Darkness", "Wherre the wild things are", "7 Lego Wonders of the World"};
            string[] authors =
            {   "Elicia Amin",
                "Beauden Spooner",
                "Duncan Archer",
                "Miriam Grey",
                "Huw Ryder"
            };

            string[] periodicals = { "Informer weekly", "Daily inform", "Information by the Minute", "Informational Hour", "Digestion's Digest" };
            int titleIndexer = 1;

            Item[] library =  new Item[10];
            for (int i = 0; i < library.Length; i++) {
                if (i % 2 == 0)
                {
                    library[i] = new Book(bookNames[i / 2], authors[i / 2], (i + 5) * 937472);
                }
                else {
                    library[i] = new Periodical(periodicals[i - titleIndexer], titleIndexer);
                    titleIndexer++;
                }
            }
            foreach(Item readable in library){
                Console.WriteLine(readable.getListing());
            } 


            Console.ReadKey();

        }
    }
}
