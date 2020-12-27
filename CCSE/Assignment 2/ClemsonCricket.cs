using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class ClemsonCricket : Cricket
    {
        public ClemsonCricket() : base() {
            base.chirpFrequency *= 0.8f;
        }

        public ClemsonCricket(double freq) : base(freq) {

        }
        

        public override void randomizeChirp() {
            base.randomizeChirp();
            base.chirpFrequency *= 0.8f; 
        }

    }
}
