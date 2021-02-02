using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {
        // Constructors
        public Pet()
        {
            Hunger = 50;
            Boredom = 60; 
        }

        //Properties
        public string Name { get; set; }
        public string Species { get; set; }
        public int Hunger { get; set; }
        public int Boredom { get; set; } 



        // Methods
        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetSpecies(string species)
        {
            Species = species;
        }

        public string GetSpecies()
        {
            return Species; 
        }

        public int GetHunger()
        {
            return Hunger; 
        }
        public int GetBoredom()
        {
            return Boredom;
        }
    }

}
