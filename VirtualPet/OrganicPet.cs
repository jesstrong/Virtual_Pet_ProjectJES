using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class OrganicPet : Pet
    {

        public int Hunger { get; set; }
        public int Health { get; set; }
        public int Cleanliness { get; set; }

        public int GetHunger()
        {
            return Hunger;
        }

        public int GetHealth()
        {
            return Health;
        }

        public void Feed()
        {
            Hunger -= 40;
        }

        public void Play()
        {
            Hunger += 10;
            Boredom -= 20;
            Health += 10;
        }

        public override void GiveHeadPats()
        {
            Boredom -= 10;
        }
    }
}
