using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora;

namespace PruebasCalcula
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var sum = new Calcula();
            var num1 = 7;
            var num2 = 5;
            var expectedResult = 12;

            // Act
            var result = sum.DoOperation(num1, num2, "+");

            // Assert
            Assert.AreEqual(result, expectedResult);
        }
        [TestMethod]
        public void TestRestTwoNumbers()
        {
            // Arrange
            var substraction = new Calcula();
            var num1 = 7;
            var num2 = 5;
            var expectedResult = 2;

            // Act
            var result = substraction.DoOperation(num1, num2, "-");

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void TestProductTwoNumbers()
        {
            // Arrange
            var product = new Calcula();
            var num1 = 7;
            var num2 = 5;
            var expectedResult = 35;

            // Act
            var result = product.DoOperation(num1, num2, "*");

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void TestDivisionTwoNumbers()
        {
            // Arrange
            var division = new Calcula();
            var num1 = 7;
            var num2 = 5;
            var expectedResult = 1.4;

            // Act
            var result = division.DoOperation(num1, num2, "/");

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void TestDefaultwoNumbers()
        {
            // Arrange
            var division = new Calcula();
            var num1 = 7;
            var num2 = 5;
            var expectedResult = 0;

            // Act
            var result = division.DoOperation(num1, num2, "$");

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void TestTarea1()
        {
            // Arrange
            var exam = new Calcula();
            double[] num = {10, 5, 20};
            string[] sig = {"*","+"};
            var expectedResult = 70;

            // Act
            var result = exam.CalculadoraMultiple(num, sig);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void TestTarea2()
        {
            // Arrange
            var exam1 = new Calcula();
            double[] num = { 10, 5, 20 };
            string[] sig = { "-", "+" };
            var expectedResult = 25;

            // Act
            var result = exam1.CalculadoraMultiple(num, sig);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }
        [TestMethod]
        public void TestTarea3()
        {
            // Arrange
            var exam1 = new Calcula();
            double[] num = { 15, 10 };
            string[] sig = { "-" };
            var expectedResult = 5;

            // Act
            var result = exam1.CalculadoraMultiple(num, sig);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void TestTarea4()
        {
            // Arrange
            var exam1 = new Calcula();
            double[] num = { 15, 10, 20 };
            string[] sig = { "-" };
            var expectedResult = 0;

            // Act
            var result = exam1.CalculadoraMultiple(num, sig);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void TestTarea5()
        {
            // Arrange
            var exam1 = new Calcula();
            double[] num = { 15 };
            string[] sig = { "-", "+", "/" };
            var expectedResult = 0;

            // Act
            var result = exam1.CalculadoraMultiple(num, sig);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}
