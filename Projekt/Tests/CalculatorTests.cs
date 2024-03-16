namespace Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestAddition()
        {
            Calculator.Calculator calculator = new Calculator.Calculator();
            double result = calculator.Add(3, 5);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            Calculator.Calculator calculator = new Calculator.Calculator();
            double result = calculator.Subtract(10, 5);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            Calculator.Calculator calculator = new Calculator.Calculator();
            double result = calculator.Multiply(3, 4);
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void TestDivision()
        {
            Calculator.Calculator calculator = new Calculator.Calculator();
            double result = calculator.Divide(10, 2);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void TestDivisionByZero()
        {
            Calculator.Calculator calculator = new Calculator.Calculator();
            calculator.Divide(10, 0);
        }

    }
}