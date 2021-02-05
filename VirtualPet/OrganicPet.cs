using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class OrganicPet : Pet
    {
        public OrganicPet()
        {
            Hunger = 50;
            Health = 70;
            Cleanliness = 30; 

        }

        public OrganicPet(string petName, string petType)
        {
            Hunger = 50;
            Health = 70;
            Cleanliness = 30;
            Name = petName;
            Species = petType;
        }

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

        public override void Play()
        {
            Hunger += 10;
            Boredom -= 20;
            Health += 10;
            Cleanliness += 10;
        }

        public override void GiveHeadPats()
        {
            Boredom -= 10;
            Health += 10;
        }

        public void GiveBath()
        {
            Cleanliness = 0;
        }

        public override void Tick()
        {
            Cleanliness += 5;
            Boredom += 5;
            Hunger += 5;
            Health -= 5;
        }
    }
}
