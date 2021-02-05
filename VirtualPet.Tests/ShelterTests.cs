using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class ShelterTests
    {
        Shelter testShelter;

        public ShelterTests()
        {
            testShelter = new Shelter();
        }

        [Fact] 
        public void AddPet_Should_Increase_List_Count_by_1()
        {
            //Arrange
            testShelter.ListOfPets.Clear();
            Pet newPet = new Pet();
            //Act
            testShelter.AddPet(newPet);
            //Assert
            Assert.Single(testShelter.ListOfPets);
        }
        [Fact]
        public void SelectPet_Should_Allow_User_To_Pick_Pet_From_Shelter()
        {
            //Arrange
            testShelter.ListOfPets.Clear();
            Pet pet1 = new Pet();
            Pet pet2 = new Pet();
            testShelter.AddPet(pet1);
            testShelter.AddPet(pet2);
            //Act
            //Assert
            Assert.Equal(pet2, testShelter.ListOfPets[1]);

        }
    }
}
