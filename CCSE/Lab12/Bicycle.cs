using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Bicycle : IRollable
    {
        int numGears;
        int currentGear;
        BrakeType brakeType;
        bool hasKickStand;

        public enum BrakeType {
            BackPedal,
            HandleBar,
            footStop
        }

        public Bicycle() {
            numGears = 1;
            currentGear = 1;
            brakeType = BrakeType.footStop;
            hasKickStand = false;
        }

        public Bicycle(int gears, BrakeType type, bool kickStand) {
            numGears = gears;
            currentGear = 1;
            brakeType = type;
            hasKickStand = kickStand;
        }

        public void changeGears(int newGear){
            if (numGears > 1) {
                currentGear = newGear;
            }
        }

        public void stopMoving() {
            switch (brakeType) {
                case BrakeType.footStop:
                    Console.WriteLine("Putting foot down.");
                    break;
                case BrakeType.BackPedal:
                    Console.WriteLine("Pedaling backwards.");
                    break;
                case BrakeType.HandleBar:
                    Console.WriteLine("Squeezing handlebar");
                    break;
            }
        }


    }
}
