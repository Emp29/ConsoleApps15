using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace ConsoleApp.tests
{
    /// <summary>
    /// Explain this purpose of the test class
    /// </summary>
    [TestClass]
    public class TestStudentGrades
    {
        private readonly StudentGrades converter = new StudentGrades();
        private int[] testMarks;

        public TestStudentGrades()
        {
            testMarks = new int[]
            {
                10, 20, 30, 40, 50, 60, 70, 80, 90, 100
            };
        }
        
        /// <summary>
        /// Explain briefly the purpose of this specific test
        /// </summary>
        [TestMethod]
        public void TestConvert0ToGradeF()
        {
            //Arrange

            Grades expectedGrade = Grades.F;

            //Act

            Grades actualGrade = converter.ConvertToGrade(0);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert39ToGradeF()
        {
            //Arrange

            Grades expectedGrade = Grades.F;

            //Act

            Grades actualGrade = converter.ConvertToGrade(39);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestCalculateMean()
        {
            //Arange

            converter.Marks = testMarks;

            double expectedMean = 55.0;

            //Act

            converter.CalculateStats();
            
            //Assert

            Assert.AreEqual(expectedMean, converter.Mean);
        }

        [TestMethod]
        public void TestCalculateMin()
        {
            //Arrange
            studentGrades.Marks = StatsMarks;
            int expectedMin = 10;

            //Act
            studentGrades.CalculateStats();

            //Assert
            Assert.AreEqual(expectedMin, studentGrades.Minimum);
        }
decimal c
    }
}
