using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_9;
namespace CircleTest
{ 
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCircumference()
        {
            Circle testCircle = new Circle(3);
            //double circumference = Math.PI * 3 * 3;
           string circumference = testCircle.getFormatedCircumference();
            Assert.AreEqual("18.85", circumference);
        }

        [TestMethod]
        public void TestArea()
        {
            Circle testArea = new Circle(3);
            string area = testArea.getFormatedArea();
            Assert.AreEqual("28.27", area);
        }
    }
}
