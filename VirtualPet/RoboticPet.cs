using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class RoboticPet : Pet
    {

        public RoboticPet()
        {
            BatteryCharge = 100;
            WearAndTear = 0;
            Software = 100;
        }

        public int BatteryCharge { get; set; }
        public int WearAndTear { get; set; }
        public int Software { get; set; }


        public int GetBatteryCharge()
        {
            return BatteryCharge;
        }

        public int GetWearAndTear()
        {
            return WearAndTear;
        }

        public int GetSoftware()
        {
            return Software;
        }

        public override void GiveHeadPats()
        {
            Boredom -= 10;
        }

        public override void Play()
        {
            Boredom -= 30;
            BatteryCharge -= 10;
            WearAndTear += 15;
        }

        public void Charge()
        {
            BatteryCharge = 100;
            Boredom -= 40;
        }

        public override void Tick()
        {
            BatteryCharge -= 5;
            Boredom += 5;
            Software -= 10;
            WearAndTear += 5;
        }

        public void Maintenance()
        {
            WearAndTear = 0;
        }

        public void SoftwareUpdate()
        {
            Software = 100;
        }
    }
}
