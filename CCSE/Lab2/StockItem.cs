using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class StockItem
    {
        static int unusedID = 1;
        string description;
        public int VARIABLEID;
        float variablePrice;
        int variableQuantity;

        public StockItem() {
            VARIABLEID = unusedID;
            description = "item " + VARIABLEID;
            variablePrice = 0.01f;
            unusedID += 1;
        }

        public StockItem(string desc, decimal price, int quant) {
            description = desc;
            variablePrice = (float)Math.Round(price, 2, MidpointRounding.AwayFromZero);
            variableQuantity = quant;
            VARIABLEID = unusedID;
            unusedID += 1;
        }

        public string toString() {
            return "Item Id: " + VARIABLEID + "  Description: " + description + "  Price: " + variablePrice + "  Quantity: " + variableQuantity;

        }
        public string getDescription() {
            return description;
        }

        public int getID() {
            return VARIABLEID;
        }

        public float getPrice() {
            return variablePrice;
        }

        public int getQuantity() {
            return variableQuantity;
        }

        public void setPrice(decimal price) {
            variablePrice = (float)Math.Round(price, 2, MidpointRounding.AwayFromZero);

        }

        public void removeQuantity(int amount) {
            if (variableQuantity < amount)
            {
                Console.WriteLine("There were not enough items for that, removed " + variableQuantity + " instead");
                variableQuantity = 0;  
            }
            else {
                variableQuantity -= amount;
            }
        }

        public void addQuantity(int amount) {
            variableQuantity += amount;
        }
    }
}
