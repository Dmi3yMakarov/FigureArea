using FigureArea.Shapes;

namespace FigureArea.Tests
{
    [TestClass]
    public class CircleTest
    {
        /// <summary>
        /// Check for ArgumentException (The radius of the circle is zero)
        /// Should throw away ArgumentException!
        /// </summary>
        [ExpectedException(typeof(System.ArgumentException), "")]
        [TestMethod]
        public void CircleRadiusIsZero()
        {
            Circle _ = new(0.0);
        }


        /// <summary>
        /// Check for ArgumentException (The radius of the circle is less than zero)
        /// </summary>
        [ExpectedException(typeof(System.ArgumentException), "")]
        [TestMethod]
        public void CircleRadiusIsLessThanZero()
        {
            Circle _ = new(-1.3);
        }


        /// <summary>
        /// Checking the calculation of the area of the circle with accuracy
        /// </summary>
        [TestMethod]
        public void CircleAreaDeltaCompute()
        {
            Circle crc = new(5.0);
            Assert.AreEqual(78.539816339744831, crc.GetArea(), "Result out of range!");
        }
    }
}
