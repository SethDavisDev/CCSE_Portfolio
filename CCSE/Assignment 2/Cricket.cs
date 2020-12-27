using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Cricket
    {
        static Random rand = new Random();

        protected double chirpFrequency;

        public Cricket() : this(rand.Next(161) + 40) {
        }
        public Cricket(double freq) {
            chirpFrequency = freq;
        }

        public virtual void randomizeChirp() {
            chirpFrequency = rand.Next(161) + 40;
        }

        public double getChirps() {
            return chirpFrequency;
        }

    }

}
