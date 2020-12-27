using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class ClothingItem
    {
        public static readonly string[] names = new string[] {"shirt", "pants", "sock", "hat", "shorts", "underpants"};
        public static readonly string[] colors = new string[] {"red", "orange", "yellow", "green", "blue", "indigo", "violet"};
        static Random rn = new Random();
        string name;
        string color;
        bool isHighTempWashable;

        public ClothingItem() {
            
            name = names[rn.Next(names.Length)];
            color = colors[rn.Next(colors.Length)];
            if (rn.NextDouble() > 0.5f) {
                isHighTempWashable = true;
            } 
        }

        public ClothingItem(string n, string c, bool isHighWash) {
            name = n;
            color = c;
            isHighTempWashable = isHighWash;
        }

        public string getName() {
            return name;
        }

        public string getColor() {
            return color;
        }

        public bool getWashability() {
            return isHighTempWashable;
        }

        public void setWashability(bool isWash) {
            isHighTempWashable = isWash;
        }

        public override string ToString()
        {
            return String.Format("Name: {0}, Color: {1}, High temperature washable: {2}",name,color,isHighTempWashable);
        }

    }
}
