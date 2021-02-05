using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Shelter
    {
        public List<Pet> ListOfPets = new List<Pet>();


        public void AddPet(Pet pet)
        {
            ListOfPets.Add(pet);
        }

        //public Pet SelectPet()
        //{
        //    int index = 1;

        //    Console.WriteLine("Please select a pet from the list.");
        //    foreach (Pet pet in ListOfPets)
        //    {
        //        Console.WriteLine($"{index});

        //    }
        //}
        
    }
}
