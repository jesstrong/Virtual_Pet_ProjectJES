using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet userPet = new Pet();
            
            Console.WriteLine("Hello! Welcome to Virtual Pets!");

            Console.WriteLine("What kind of pet do you want?");

            userPet.SetSpecies(Console.ReadLine());

            Console.WriteLine("Great! What should their name be?");

            userPet.SetName(Console.ReadLine());

            Console.WriteLine("Your pet is " + userPet.GetName() + " the " + userPet.GetSpecies());
        }
    }
}
