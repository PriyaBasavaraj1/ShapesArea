using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesArea;

namespace AreaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidInputs_for_AreaOfCircle_DoesnotThrowAnException()
        {
            var shapeUndertest = ShapeFactory.GetShape("Circle");
            double res = shapeUndertest.CalculateArea(3).Display();
            Assert.AreEqual(Math.PI * 3 * 3, res, "error");
        }

        [TestMethod]
        public void ValidInputs_for_AreaOfRectangle_DoesnotThrowAnException()
        {
            var shapeUndertest = ShapeFactory.GetShape("Rectangle");
            double res = shapeUndertest.CalculateArea(3,4).Display();
            Assert.AreEqual(3 * 4, res, "error");
        }

        [TestMethod]
        public void ValidInputs_for_AreaOfTriangle_DoesnotThrowAnException()
        {
            var shapeUndertest = ShapeFactory.GetShape("Triangle");
            double res = shapeUndertest.CalculateArea(3,4).Display();
            Assert.AreEqual(0.5 * 3 * 4, res, "error");
        }

        [TestMethod,ExpectedException(typeof(Exception))]
        public void InvalidChoice_ThrowsAnException()
        {
            var shapeUndertest = ShapeFactory.GetShape("ydhcv");
            double res = shapeUndertest.CalculateArea(3).Display();
        }

        [TestMethod, ExpectedException(typeof(Exception))]
        public void InvalidNumberOfParameters_for_AreaOfCircle_ThrowsAnException()
        {
            var shapeUndertest = ShapeFactory.GetShape("Circle");
            double res = shapeUndertest.CalculateArea().Display();
        }

        [TestMethod, ExpectedException(typeof(Exception))]
        public void InvalidNumberOfParameters_for_AreaOfRectangle_ThrowsAnException()
        {
            var shapeUndertest = ShapeFactory.GetShape("Rectangle");
            double res = shapeUndertest.CalculateArea(3,4,5).Display();
        }

        [TestMethod, ExpectedException(typeof(Exception))]
        public void InvalidNumberOfParameters_for_AreaOfTriangle_ThrowsAnException()
        {
            var shapeUndertest = ShapeFactory.GetShape("Triangle");
            double res = shapeUndertest.CalculateArea(3, 4, 5).Display();
        }

        [TestMethod, ExpectedException(typeof(Exception))]
        public void InvalidRange_for_AreaOfCircle_ThrowsAnException()
        {
            var shapeUndertest = ShapeFactory.GetShape("Circle");
            double res = shapeUndertest.CalculateArea(-3).Display();
        }

        [TestMethod, ExpectedException(typeof(Exception))]
        public void InvalidRange_for_AreaOfRectangle_ThrowsAnException()
        {
            var shapeUndertest = ShapeFactory.GetShape("Rectangle");
            double res = shapeUndertest.CalculateArea(2,-3).Display();
        }

        [TestMethod, ExpectedException(typeof(Exception))]
        public void InvalidRange_for_AreaOfTriangle_ThrowsAnException()
        {
            var shapeUndertest = ShapeFactory.GetShape("Triangle");
            double res = shapeUndertest.CalculateArea(-3,6).Display();
        }
    }
}
