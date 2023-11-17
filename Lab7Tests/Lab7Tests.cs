using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab7;

namespace Lab7Tests
{
    [TestClass]
    public class Lab7Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Vector a = new Vector();
            Vector b = new Vector();
            Vector c = new Vector();

            a.x1 = 1; a.y1 = 2; a.z1 = 3;
            a.x2 = 4; a.y2 = 5; a.z2 = 6;

            b.x1 = 3; b.y1 = 4; b.z1 = 5;
            b.x2 = 6; b.y2 = 7; b.z2 = 8;

            c.x1 = 3; c.y1 = 4; c.z1 = 5;
            c.x2 = 6; c.y2 = 7; c.z2 = 8;

            Vector d = new Vector();
            Vector actual = d.Plus(a, b);

            Assert.AreEqual(c, actual);
        }

    }
}
