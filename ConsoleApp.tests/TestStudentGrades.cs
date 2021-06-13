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
        private readonly StudentGrades
            studentGrades = new StudentGrades();
       
           private readonly int[] StatsMarks = new int[]
            {
                10, 20, 30, 40, 50, 60, 70, 80, 90, 100
            };
        
        /// <summary>
        /// Explain briefly the purpose of this specific test
        /// </summary>
        [TestMethod]
        public void TestConvert0ToGradeF()
        {
            //Arrange

            Grades expectedGrade = Grades.F;

            //Act

            Grades actualGrade = studentGrades.ConvertToGrade(0);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert39ToGradeF()
        {
            //Arrange

            Grades expectedGrade = Grades.F;

            //Act

            Grades actualGrade = studentGrades.ConvertToGrade(39);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestCalculateMean()
        {
            //Arange

            studentGrades.Marks = StatsMarks;

            double expectedMean = 55.0;

            //Act

            studentGrades.CalculateStats();
            
            //Assert

            Assert.AreEqual(expectedMean, studentGrades.Mean);
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
        [TestMethod]
        public void TestGradeProfile()
        {
            //Arange
            studentGrades.Marks = StatsMarks;
            bool expectedProfile = false;

            //Act
            studentGrades.CalculateGradeProfile();

            expectedProfile = ((studentGrades.GradeProfile[0] == 3) &&
                               (studentGrades.GradeProfile[1] == 1) &&
                               (studentGrades.GradeProfile[2] == 1) &&
                               (studentGrades.GradeProfile[3] == 1) &&
                               (studentGrades.GradeProfile[4] == 4));

            //Assert
            Assert.IsTrue(expectedProfile);
        }
    }
}
