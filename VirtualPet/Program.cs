using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet myPet = new Pet();
            Shelter myShelter = new Shelter();

            Console.WriteLine("Hello! Welcome to Virtual Pets!");

            //Console.WriteLine("What kind of pet do you want?");

            //userPet.SetSpecies(Console.ReadLine());

            //Console.WriteLine("Great! What should their name be?");

            //userPet.SetName(Console.ReadLine());

            //Console.Clear();

            //Console.WriteLine("Your pet is " + userPet.GetName() + " the " + userPet.GetSpecies());

            bool keepPlaying = true;

            while (keepPlaying) 
            {
                Console.WriteLine("1. Adopt a new organic pet.");
                Console.WriteLine("2. Create a new robotic pet.");
                Console.WriteLine("3. Check status of organic pets");
                Console.WriteLine("4. Check status of robotic pets.");
                Console.WriteLine("5. Give head pats.");
                Console.WriteLine("6. Play with pet.");
                Console.WriteLine("7. Give organic pet a bath.");
                Console.WriteLine("8. Feed organic pet.");
                Console.WriteLine("9. Charge robotic pet.");
                Console.WriteLine("10. Take robotic pet to shop for maintenance.");
                Console.WriteLine("11. Update robotic pet's software.");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("What is the name of your pet?");
                        string petName = Console.ReadLine();
                        Console.WriteLine("What type of pet do you want?");
                        string petType = Console.ReadLine();
                        myPet = new OrganicPet(petName, petType);
                        myShelter.AddPet(myPet);
                        break;

                    case "2":
                        Console.WriteLine("What is the name of your robotic pet?");
                        petName = Console.ReadLine();
                        Console.WriteLine("What type of robotic pet do you want?");
                        petType = Console.ReadLine();
                        myPet = new RoboticPet(petName, petType);
                        myShelter.AddPet(myPet);
                        break;

                    case "3":
                        foreach (Pet pet in myShelter.ListOfPets)
                        {
                            Console.WriteLine($"\n{myPet.GetName()} to {myPet.GetSpecies()} status");
                            //Console.WriteLine($"Hunger Level: {pet.GetHunger()}");
                            Console.WriteLine($"Boredom Level: {pet.GetBoredom()}");
                            //Console.WriteLine($"Health Level: {pet.GetHealth()}");
                        }
                        break;

                    case "4":    
                        foreach (RoboticPet pet in myShelter.ListOfPets)
                        {
                            Console.WriteLine($"\n{myPet.GetName()} to {myPet.GetSpecies()} status");
                            Console.WriteLine($"Battery Level: {pet.GetBatteryCharge()}");
                            Console.WriteLine($"Wear and Tear Level: {pet.GetWearAndTear()}");
                            Console.WriteLine($"Software Up to Date: {pet.GetSoftware()}");
                        }
                        break;
                }



                    


                //Console.WriteLine("\n" + userPet.GetName() + " the " + userPet.GetSpecies() + "'s stats:");
                //Console.WriteLine("\nHunger level: " + userPet.GetHunger());
                //Console.WriteLine("Boredom level: " + userPet.GetBoredom());
                //Console.WriteLine("Health level: " + userPet.GetHealth());



                //Console.WriteLine("\nWhat do you want to do with " + userPet.GetName());
                //Console.WriteLine("1. Feed");
                //Console.WriteLine("2. Play");
                //Console.WriteLine("3. Give head pats!");
                //Console.WriteLine("4. Exit");

                //string userChoice = Console.ReadLine();

                //switch (userChoice)
                //{
                //    case "1":
                //        Console.WriteLine("You fed " + userPet.GetName());
                //        userPet.Feed();
                //        break;
                //    case "2":
                //        Console.WriteLine("You played with " + userPet.GetName());
                //        userPet.Play();
                //        break;
                //    case "3":
                //        Console.WriteLine(userPet.GetName() + " feels better now");
                //        userPet.GiveHeadPats();
                //        break;
                //    case "4":
                //        Console.WriteLine("Thank you for playing!");
                //        keepPlaying = false;
                //        break;
                //    default:
                //        Console.WriteLine("You have angered Horace. Please choose a proper option!");
                //        break; 

            }

                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                myPet.Tick();
                Console.Clear();



                                 
                







            
        }
    }
}
