using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace PROG2027Assign2.Tests
{
    [TestFixture]
    public class TriangleSolverTests
    {
        //sum of two sides when equal to third side cannot form a valid triangle
        [Test]
        public void Analyze_NotValidTriangle_GivenInputs5_6_11_output_Not_valid_traingle()
        {
            // Arrange
            String actual = " ";
            String expected = "Not valid traingle";

            // Act
            actual = TriangleSolver.Analyze(5, 6, 11);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeMethod_GivenInput_negative1_12_3_Result_Invalid_Triangle()
        {
            // Arrange
            String actual = " ";
            String expected = "Not valid traingle";

            // Act
            actual = TriangleSolver.Analyze(-1,12,3);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeMethod_GivenInput_9_9_9_Result_Equilateral_Traingle()
        {
            //Arrange
            String actual = "";
            String expected = "This is a valid Equilateral triangle";

            //Act
            actual = TriangleSolver.Analyze(9, 9, 9);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void AnalyzeMethod_GivenInputs_4_4_2_Result_Isosceles_Triangle()
        {
            // Arrange
            String actual = " ";
            String expected = "This is a valid Isosceles triangle";

            // Act
            actual = TriangleSolver.Analyze(4, 4, 2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeMethod_GivenInput_7_9_0_Result_Invalid_Triangle()
        {
            // Arrange
            String actual = " ";
            String expected = "Not valid traingle";

            // Act
            actual = TriangleSolver.Analyze(7, 9, 0);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeMethod_GivenInput_7_9_10_Result_Scalene_Triangle()
        {
            // Arrange
            String actual = " ";
            String expected = "This is a valid Scalene triangle";

            // Act
            actual = TriangleSolver.Analyze(7, 9, 10);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        
    }
}
