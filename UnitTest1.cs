namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NegativeDiscriminant()
        {
            double a = 2;
            double b = 1;
            double c = 1;
            double expected = -7;
            double actual = Equation.Diskriminant(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PositiveDiscriminant()
        {
            double a = 3;
            double b = 7;
            double c = -6;
            double expected = 121;
            double actual = Equation.Diskriminant(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZeroDiscriminant()
        {
            double a = 4;
            double b = 4;
            double c = 1;
            double expected = 0;
            double actual = Equation.Diskriminant(a, b, c);
            Assert.AreEqual(expected, actual);
        }
    }
}
