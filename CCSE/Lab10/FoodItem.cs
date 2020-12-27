using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class FoodItem
    {
        public static readonly string[] names = new string[] {"pizza", "cookies", "apple", "corn", "hamburger", "hotdog"};
        static Random rn = new Random();
        string name;
        int caloriesPerServing;
        int servingsPerCountainer;

        public FoodItem() {
            name = names[rn.Next(names.Length)];
            caloriesPerServing = (rn.Next(11) + 5) * 100;
            servingsPerCountainer = rn.Next(4) + 1;
        }

        public FoodItem(string n, int cals, int servs) {
            name = n;
            caloriesPerServing = cals;
            servingsPerCountainer = servs;
        }

        public string getName() {
            return name;
        }

        public int getCalories() {
            return caloriesPerServing;
        }

        public int getServings() {
            return servingsPerCountainer;
        }

        public override string ToString()
        {
            return String.Format("Name: {0}, Calories per serving: {1}, Servings per container: {2}", name, caloriesPerServing, servingsPerCountainer);
        }
    }
}
