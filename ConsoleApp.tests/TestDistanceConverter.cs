using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;

namespace ConsoleApp.tests
{
    [TestClass]
    public class TestDistanceConverter
    {
        [TestMethod]
        public void TestMilesToFeet()
        {
            //aranged all the values needed
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.MILES;
            converter.ToUnit = DistanceConverter.FEET;
            
            //act
            converter.FromDistance = 1.0;
            converter.CalculateDistance();

            double expectedDistance = 5280;

            //Assurt
            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }

        public void TestFeetToMiles()
        {
            //aranged all the values needed
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.FEET;
            converter.ToUnit = DistanceConverter.MILES;
           

            //act
            converter.FromDistance = 5280;
            converter.CalculateDistance();

            double expectedDistance = 1.0;
            
            //Assurt
            
            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
    }
}
