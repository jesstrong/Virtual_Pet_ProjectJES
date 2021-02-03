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
        }

        //Properties
        public string Name { get; set; }
        public string Species { get; set; }
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

       
        public int GetBoredom()
        {
            return Boredom;
        }

        public virtual void GiveHeadPats()
        {
        }

        public void Tick()
        {
        }
    }
}
