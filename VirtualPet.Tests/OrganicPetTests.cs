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
    }
}
