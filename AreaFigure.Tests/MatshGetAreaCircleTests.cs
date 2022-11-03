using AreaFigures;

namespace AreaFigure.Tests
{
    public class MatshGetAreaCircleTests
    {
        [Test]
        public void GetAreaCircle_20_1256returned()
        {
            double x = 20;
            double expected = 1256.6370614359173;

            double actual = Maths.GetAreaCircle(x);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetAreaCircleAbs_12_452returned()
        {
            double x = -12;
            double expected = 452.3893421169302;

            double actual = Maths.GetAreaCircle(x);

            Assert.AreEqual(expected, actual);
        }
    }
}
