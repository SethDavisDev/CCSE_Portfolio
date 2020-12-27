/* Name: Seth Davis
 * Class: CSE1322L
 * Section: 03 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            ClothingStack stack1 = new ClothingStack();
            ClothingItem clothes1 = new ClothingItem("hat", "blue", false);
            stack1.push(clothes1);
            Console.WriteLine("------------------------------------- stacks ----------------------------");
            //Console.WriteLine(stack1.ToString());
            ClothingItem clothes2 = stack1.pop();
            clothes1 = stack1.pop();
            Console.WriteLine(clothes1.ToString());
            Console.WriteLine(clothes2.ToString());
            foreach (string color in ClothingItem.colors)
            {
                Console.WriteLine("---------All " + color + " clothes--------");
                printClothingArray(stack1.getColoredClothing(color));
                Console.WriteLine();
            }

            Console.WriteLine("There are {0} articles of clothing that can be machine washed at high temperature.", stack1.getNumHighTempWashable());
            Console.WriteLine("----------------------------------- queues --------------------------------------");
            FoodQueue fq1 = new FoodQueue();
            FoodItem pizzaFood = new FoodItem("pizza", 285, 8);
            FoodItem cornDog = new FoodItem("corndog", 460, 1);
            FoodItem mystery = new FoodItem();
            fq1.enqueue(cornDog);
            fq1.enqueue(mystery);
            FoodItem nextInLine = fq1.dequeue();
            Console.WriteLine(nextInLine.ToString());
            nextInLine = fq1.dequeue();
            Console.WriteLine(nextInLine.ToString());
            Console.WriteLine("Most Calories:" + fq1.findMostCalories().ToString());
            Console.WriteLine("Average calories: " + fq1.averageCalories());
            Console.ReadKey();
        }

        public static void printClothingArray(ClothingItem[] items) {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == null) continue;
                Console.WriteLine("Clothing item " + i + ": " + items[i].ToString());
                
            }

        }
    }
}
