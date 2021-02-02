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

            Console.Clear();

            Console.WriteLine("Your pet is " + userPet.GetName() + " the " + userPet.GetSpecies());

            bool keepPlaying = true;

            while (keepPlaying) 
            {
                Console.WriteLine("What do you want to do with " + userPet.GetName());

                Console.WriteLine("1. Feed");

                Console.WriteLine("2. Play");

                Console.WriteLine("3. See doctor?");

                Console.WriteLine("4. Exit");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("You fed " + userPet.GetName());
                        userPet.Feed();
                        break;
                    case "2":
                        Console.WriteLine("You played with " + userPet.GetName());
                        userPet.Play();
                        break;
                    case "3":
                        Console.WriteLine(userPet.GetName() + " feels alot better now");
                        userPet.SeeDoctor();
                        break;
                    case "4":
                        Console.WriteLine("Thank you for playing!");
                        keepPlaying = false;
                        break;
                    default:
                        Console.WriteLine("You have angered Horace. Please choose a proper option!");
                        break; 
                        
                }





                                 
                




            } 


            
        }
    }
}
