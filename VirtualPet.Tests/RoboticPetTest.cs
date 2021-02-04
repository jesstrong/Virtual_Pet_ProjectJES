using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class RoboticPetTest
    {
        public RoboticPet testPet;

        public RoboticPetTest()
        {
            testPet = new RoboticPet();
        }

        [Fact]

        public void RoboticPet_Should_Have_Name()
        {
            testPet.Name = "JeffRaff";

            Assert.Equal("JeffRaff", testPet.Name);
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
        public void BatteryLife_Of_New_Pet_Is_100()
        {
            // Arrange


            // Act


            // Assert
            Assert.Equal(100, testPet.BatteryCharge);
        }

        [Fact]
        public void WearAndTear_Of_New_Pet_Is_0()
        {
            Assert.Equal(0, testPet.WearAndTear);
        }

        [Fact]
        public void SoftWare_Of_New_Pet_Is_100()
        {
            Assert.Equal(100, testPet.Software);
        }

    }
}
