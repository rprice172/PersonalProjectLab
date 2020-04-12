using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalProjectLab;

namespace PersonalProjectLabTests
{
    [TestClass]
    public class distanceconversiontest
    {
        [TestMethod]
        public void distanceconversion_calculatemeters()
        {
            distanceconversion  ans = new distanceconversion();

            double meters = ans.calculatemeters(1);

            Assert.AreEqual(.3048, meters);

        }

        [TestMethod]
        public void distanceconversion_calculatekilometers()
        {
            distanceconversion  ans = new distanceconversion ();

            double kilometers = ans.calculatekilometers(1);

            Assert.AreEqual(1.609344, kilometers);

        }
    }
}