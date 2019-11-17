using LibraryMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestExamples
{
    [TestClass]
    public class TestCalcoli
    {
        [TestMethod]
        public void Calcolo1Test()
        {
            bool r = Calcoli.Calcolo1();
            Assert.AreEqual(true, r);

        }
        [TestMethod]
        public void Calcolo2Test()
        {
            bool r = Calcoli.Calcolo2();
            Assert.AreEqual(true, r);

        }
    }
}
