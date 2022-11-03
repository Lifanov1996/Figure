using AreaFigures;

namespace AreaFigure.Tests
{
    public class MathsGetAreaTriangleTests
    {
        [Test]
        public void GetAreaTriangle_10_10_10_43returned()
        {
            double x = 10;
            double y = 10;
            double z = 10;
            double expected = 43.301270189221931;

            double actual = Maths.GetAreaTriangle(x, y, z);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetAreaTriangleAbs_10_10_10_43returned()
        {
            double x = 10;
            double y = 10;
            double z = -10;
            double expected = 43.301270189221931;

            double actual = Maths.GetAreaTriangle(x, y, z);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetAreaTriangle_10_10_50returned()
        {
            double x = 10;
            double y = 10;
            
            double expected = 50;

            double actual = Maths.GetAreaTriangle(x, y);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetAreaTriangleAbs_10_10_50returned()
        {
            double x = 10;
            double y = -10;

            double expected = 50;

            double actual = Maths.GetAreaTriangle(x, y);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetRightTriangle_8_6_10_truereturned()
        {
            double x = 8;
            double y = 6;
            double z = 10;

            bool expected = true;

            bool actual = Maths.GetRightTriangle(x, y, z);

            Assert.AreEqual(expected, actual);            
        }

        [Test]
        public void GetRightTriangleAds_4_3_5_truereturned()
        {
            double x = 4;
            double y = -3;
            double z = -5;

            bool expected = true;

            bool actual = Maths.GetRightTriangle(x, y, z);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetRightTriangleNegative_4_3_5_truereturned()
        {
            double x = 4;
            double y = 5;
            double z = 3;

            bool expected = false;

            bool actual = Maths.GetRightTriangle(x, y, z);

            Assert.AreEqual(expected, actual);
        }

    }
}