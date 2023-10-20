using FigureArea.Shapes;

namespace FigureArea.Tests
{
    [TestClass]
    public class TriangleTest
    {
        /// <summary>
        /// One or more sides of Triangle is zero
        /// Should throw away ArgumentException!
        /// </summary>
        [ExpectedException(typeof(System.ArgumentException), "")]
        [TestMethod]
        public void SideIsZero()
        {
            Triangle _ = new(6.0, 0.0, 4.0);
        }


        /// <summary>
        /// One or more sides of Triangle is less than zero
        /// Should throw away ArgumentException!
        /// </summary>
        [ExpectedException(typeof(System.ArgumentException), "")]
        [TestMethod]
        public void SideIsLessThanZero()
        {
            Triangle _ = new(6.0, 10.0, -4.0);
        }


        /// <summary>
        /// The triangle does not exist
        /// Should throw away ArgumentException!
        /// </summary>
        [ExpectedException(typeof(System.ArgumentException), "")]
        [TestMethod]
        public void TriangleNotExist()
        {
            Triangle _ = new(25, 10, 5);
        }


        /// <summary>
        /// Checking the calculation of the area of the Triangle with accuracy
        /// </summary>
        [TestMethod]
        public void TriangleAreaDeltaCompute()
        {
            Triangle trg = new(40, 35, 25);
            Assert.AreEqual(433.0127018922193, trg.GetArea(), "Result out of range!");
        }


        /// <summary>
        /// Checking for the squareness of the triangle
        /// This triangle is rectangular
        /// </summary>
        [TestMethod]
        public void TriangleIsRight()
        {
            Triangle trg = new(17, 144, 145);
            Assert.IsTrue(trg.IsRightTriangle());
        }


        /// <summary>
        /// Checking for the squareness of the triangle
        /// This triangle is not rectangular
        /// </summary>
        [TestMethod]
        public void TriangleIsNotRight()
        {
            Triangle trg = new(17, 144, 145.04);
            Assert.IsFalse(trg.IsRightTriangle());
        }
    }
}
