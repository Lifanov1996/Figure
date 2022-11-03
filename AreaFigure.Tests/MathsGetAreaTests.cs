using AreaFigures;

namespace AreaFigure.Tests
{
    public class MathsGetAreaTests
    {
        [Test]
        public void GetArea_10_100returned()
        {
            double x = 10;
            double expected = 100;

            double actual = Maths.GetArea(x);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetAreaAbs_1242_100returned()
        {
            double x = -1242;
            double expected = 1542564;

            double actual = Maths.GetArea(x);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetArea_100_100_10000returned()
        {
            double x = 100;
            double y = 100;
            double expected = 10000;

            double actual = Maths.GetArea(x);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetAreaAbs_100_900100_10000returned()
        {
            double x = -420;
            double y = -900100;
            double expected = 378042000;
            
            double actual = Maths.GetArea(x, y);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetArea_10_5_45_42returned()
        {
            double x = 10;
            double y = 5;
            double a = 45;
            double expected = 42.545176226705919;

            double actual = Maths.GetArea(x, y, a);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetAreaAbs_8_12_64_88returned()
        {
            double x = -8;
            double y = -12;
            double a = 64;
            double expected = 88.322499666891915;

            double actual = Maths.GetArea(x, y, a);

            Assert.AreEqual(expected, actual);
        }
    }
}
