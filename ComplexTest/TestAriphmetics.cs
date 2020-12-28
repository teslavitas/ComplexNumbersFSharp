using ComplexNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComplexTest
{
    [TestClass]
    public class TestAriphmetics
    {
        [TestMethod]
        public void TestSum()
        {
            var x = new ComplexNumber(3, 2);
            var y = new ComplexNumber(4, -5);
            var result = ComplexOperations.Add(x, y);
            Assert.AreEqual(7, result.a);
            Assert.AreEqual(-3, result.b);
        }

        [TestMethod]
        public void TestSubstaction()
        {
            var x = new ComplexNumber(3, 2);
            var y = new ComplexNumber(4, -5);
            var result = ComplexOperations.Substract(x, y);
            Assert.AreEqual(-1, result.a);
            Assert.AreEqual(7, result.b);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            var x = new ComplexNumber(3, 2);
            var y = new ComplexNumber(4, -5);
            var result = ComplexOperations.Multiply(x, y);
            Assert.AreEqual(22, result.a);
            Assert.AreEqual(-7, result.b);
        }

        [TestMethod]
        public void TestDivision()
        {
            var x = new ComplexNumber(3, 2);
            var y = new ComplexNumber(4, -5);
            var result = ComplexOperations.Divide(x, y);
            Assert.AreEqual(2/41.0, result.a);
            Assert.AreEqual(23/41.0, result.b);
        }

        [TestMethod]
        public void TestDivisionBy0()
        {
            var x = new ComplexNumber(3, 2);
            var y = new ComplexNumber(0, 0);
            var result = ComplexOperations.Divide(x, y);
            Assert.AreEqual(float.NaN, result.a);
            Assert.AreEqual(float.NaN, result.b);
        }

        [TestMethod]
        public void TestSquare()
        {
            var x = new ComplexNumber(9, 4);
            var result = ComplexOperations.Sqr(x);
            Assert.AreEqual(65, result.a);
            Assert.AreEqual(72, result.b);
        }

        [TestMethod]
        public void TestSquareI()
        {
            var x = new ComplexNumber(0, 1);
            var result = ComplexOperations.Sqr(x);
            Assert.AreEqual(-1, result.a);
            Assert.AreEqual(0, result.b);
        }

        [TestMethod]
        public void TestSquareRootI()
        {
            var x = new ComplexNumber(-1, 0);
            var result = ComplexOperations.Sqrt(x);
            Assert.AreEqual(0, result.a);
            Assert.AreEqual(1, result.b);
        }
    }
}
