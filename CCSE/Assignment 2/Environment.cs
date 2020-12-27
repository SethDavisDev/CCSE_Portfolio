using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Environment
    {
        private float temperature;

        public float Tempurature {
            get { return this.temperature; }
        }

        public Environment() {
            temperature = 51f;
        }

        public Environment(double chirpFreq) {
            
            temperature = ((int)chirpFreq + 40) / 4;
        }

        public void calculateTemperature(double chirpFreq) {
            temperature = ((int)chirpFreq + 40) / 4;
        }



    }
}
