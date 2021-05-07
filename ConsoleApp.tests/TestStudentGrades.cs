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




    }
}
