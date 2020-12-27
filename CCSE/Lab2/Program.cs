using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the name of the item: ");
            string desc = Console.ReadLine();
            Console.WriteLine("Please enter the price for the item: ");
            decimal price = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter how many of this item are in stock");
            int quant = Int32.Parse(Console.ReadLine());
            StockItem so = new StockItem(desc, price, quant);
            Console.WriteLine(so.getDescription());
            Console.WriteLine(so.getID());
            Console.WriteLine(so.getPrice());
            Console.WriteLine(so.getQuantity());
            Console.WriteLine("Enter a new price for the item: ");
            so.setPrice(Decimal.Parse(Console.ReadLine()));
            Console.WriteLine("Enter an amount of the item to remove from storage: ");
            so.removeQuantity(Int32.Parse(Console.ReadLine()));
            Console.WriteLine("Enter an amount of the item to add to storage");
            so.addQuantity(Int32.Parse(Console.ReadLine()));
            Console.WriteLine(so.toString());

            Console.ReadKey(); 
        }
        
        public static float properRound(Decimal d) {
            float temp;
            temp = (float)Math.Round(d, 2, MidpointRounding.AwayFromZero);

            return temp;
        }
    }
}
