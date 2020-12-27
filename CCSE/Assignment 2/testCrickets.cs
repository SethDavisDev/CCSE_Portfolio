using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class testCrickets
    {
        static void Main(string[] args)
        {
            //creating the crickets and environment objects
            Environment env = new Environment();
            Cricket cr1 = new Cricket();
            Cricket cr2 = new ClemsonCricket();
            //doing the chirping and temperaturing for the normal cricket
            env.calculateTemperature(cr1.getChirps());
            Console.WriteLine("The current temperature is: {0:###'°F'}", env.Tempurature);
            Console.WriteLine("chirp frequency: " + cr1.getChirps());
            cr1.randomizeChirp();
            env.calculateTemperature(cr1.getChirps());
            Console.WriteLine("The current temperature is: {0:###'°F'}", env.Tempurature);
            Console.WriteLine("chirp frequency: " + cr1.getChirps());
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Clemson Cricket shows up");
            env.calculateTemperature(Math.Round(cr2.getChirps() / 0.8));
            Console.WriteLine("The current temperature is: {0:###'°F'}", env.Tempurature);
            Console.WriteLine("chirp frequency: {0:###}", cr2.getChirps());
            cr2.randomizeChirp();
            env.calculateTemperature(cr2.getChirps() / 0.8f);
            Console.WriteLine("The current temperature is: {0:###'°F'}", env.Tempurature);
            Console.WriteLine("chirp frequency: {0:###}", cr2.getChirps());

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
