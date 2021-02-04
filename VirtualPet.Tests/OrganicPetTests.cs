using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class OrganicPetTests
    {
        OrganicPet testPet;

        public OrganicPetTests()
        {
            testPet = new OrganicPet();
        }

        [Fact]
        public void OrganicPet_Should_Have_Name()
        {
            //Arrange
            testPet.Name = "Pet Name";
            //Act

            //Assert
            Assert.Equal("Pet Name", testPet.Name);
        }

        [Fact]
        public void SetName_Should_Use_Method_From_Parent_Class()
        {
            //Arrange
            testPet.SetName("Horace");

            //Act


            //Assert
            Assert.Equal("Horace", testPet.Name);
            
        }

        [Fact]
        public void Health_Of_New_Pet_Is_70() 
        {
            // Arrange


            // Act


            // Assert
            Assert.Equal(70, testPet.Health);
        }

        [Fact]
        public void Hunger_Of_New_Pet_Is_50()
        {
            Assert.Equal(50, testPet.Hunger); 
        }

        [Fact]
        public void Cleanliness_Of_New_Pet_Is_30()
        {
            Assert.Equal(30, testPet.Cleanliness);
        }

        [Fact]
        public void GetHunger_Should_Return_Initial_Hunger_Level_Of_50()
        {
            int testPetHunger = testPet.GetHunger();

            Assert.Equal(50, testPetHunger);
        }

        [Fact]

        public void GetHealth_Should_Return_Initial_Health_Level_Of_70()
        {
            int testPetHealth = testPet.GetHealth();

            Assert.Equal(70, testPetHealth);
        }
        [Fact]
        public void Feed_Should_Decrease_Hunger_By_40()
        {
            testPet.Feed();

            Assert.Equal(10, testPet.GetHunger());
        }





    }
}
