using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab1Charp;

namespace Testlab1
{
    [TestClass]
    public class Lab1Tests
    {
        [TestMethod]
        public void GetProgressionSum_ValidData_ReturnsSum()
        {
            double result = Lab1Logic.GetProgressionSum(1.0, 2.0, 5);
            Assert.AreEqual(25.0, result, 0.001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetProgressionSum_InvalidN_ThrowsException()
        {
            Lab1Logic.GetProgressionSum(1.0, 2.0, -1);
        }

        [TestMethod]
        public void IsIsoscelesTriangle_ValidIsosceles_ReturnsTrue()
        {
            bool result = Lab1Logic.IsIsoscelesTriangle(5, 5, 6);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsIsoscelesTriangle_InvalidTriangle_ReturnsFalse()
        {
            bool result = Lab1Logic.IsIsoscelesTriangle(1, 2, 10);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckPointLocation_Inside_ReturnsYes()
        {
            string result = Lab1Logic.CheckPointLocation(5, 2);
            Assert.AreEqual("yes", result);
        }

        [TestMethod]
        public void CheckPointLocation_Outside_ReturnsNo()
        {
            string result = Lab1Logic.CheckPointLocation(12, 12);
            Assert.AreEqual("no", result);
        }

        [TestMethod]
        public void CheckPointLocation_OnBorder_ReturnsClose()
        {
            string result = Lab1Logic.CheckPointLocation(10, 0);
            Assert.AreEqual("close", result);
        }

        [TestMethod]
        public void GetCircleMetrics_ValidRadius_ReturnsCorrectMetrics()
        {
            var result = Lab1Logic.GetCircleMetrics(5);
            Assert.AreEqual(31.415, result.Perimeter, 0.01);
            Assert.AreEqual(78.539, result.Area, 0.01);
        }

        [TestMethod]
        public void GetTriangleMetrics_ValidSides_ReturnsCorrectMetrics()
        {
            var result = Lab1Logic.GetTriangleMetrics(3, 4, 5);
            Assert.AreEqual(12.0, result.Perimeter, 0.001);
            Assert.AreEqual(6.0, result.Area, 0.001);
        }

        [TestMethod]
        public void CubeOfDifference_ValidData_ReturnsCube()
        {
            double result = Lab1Logic.CubeOfDifference(5, 2);
            Assert.AreEqual(27.0, result, 0.001);
        }

        [TestMethod]
        public void CalculateExpression_ValidData_ReturnsResult()
        {
            double result = Lab1Logic.CalculateExpression(2, 3);
            Assert.AreEqual(0.6666, result, 0.001);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void CalculateExpression_DenominatorZero_ThrowsException()
        {
            Lab1Logic.CalculateExpression(-1, -1);
        }
    }
}