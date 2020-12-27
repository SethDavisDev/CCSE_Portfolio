using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class ClothingStack
    {
        public ClothingItem[] stack;
        int currentEmpty = 0;

        public ClothingStack() {
            stack = new ClothingItem[20];
            for (int i = 0; i < stack.Length/2; i++) {
                stack[i] = new ClothingItem();
                currentEmpty++;
            }
        }

        public void push(ClothingItem item) {
            if (currentEmpty >= stack.Length) {
                Console.WriteLine("Stack is full, item not added!");
                return;
            }
            stack[currentEmpty] = item;
            currentEmpty++;
        }

        public ClothingItem pop() {
            //should never be below 0 but just in case.
            if (currentEmpty <= 0) {
                currentEmpty = 0;
                Console.WriteLine("Stack is empty, nothing to pop!");
                return null;
            }
            //could store the item at index - 1 and do things like clear 
            //item from stack but changing the index means that the item will not ever get popped again anyways 
            currentEmpty -= 1;
            return stack[currentEmpty];

        }

        public ClothingItem peek() {
            if (currentEmpty <= 0) {
                Console.WriteLine("The stack was empty so nothing to peek");
                currentEmpty = 0;
                return null;

            }
            return stack[currentEmpty - 1];
        }

        public ClothingItem[] getColoredClothing(string color) {
            ClothingItem[] clothingItems = new ClothingItem[20];
            int colorSpecificIndex = 0;
            for (int i = 0; i < stack.Length; i++)
            {
                if (stack[i] == null) continue;
                if (color.Equals(stack[i].getColor())) {
                    clothingItems[colorSpecificIndex] = stack[i];
                    colorSpecificIndex++;
                }
            }
            return clothingItems;
        }

        public int getNumHighTempWashable() {
            int numWashable = 0;
            for (int i = 0; i < stack.Length; i++)
            {
                if (stack[i] == null) continue;
                if (stack[i].getWashability()) {
                    numWashable++;
                }
            }

            return numWashable;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < stack.Length; i++)
            {
                if (stack[i] == null) continue;
                sb.Append("Clothing item "+ i +": "+ stack[i].ToString());
                sb.AppendLine();
            }
            return sb.ToString();
        }

    }

}
