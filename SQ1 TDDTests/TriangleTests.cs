using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQ1_TDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ1_TDD.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void calculateHypotenuseTest()
        {
            //arange
            Triangle myTriangle = new Triangle();
            myTriangle.sideA = 3;
            myTriangle.sideB = 4;
            //act
            myTriangle.calculateHypotenuse();

            //assert
            Assert.AreEqual(5, myTriangle.sideC);
        }
        [TestMethod()]
        public void calculateHypotenuseBoundryTest()
        {
            //arange
            Triangle myTriangle = new Triangle();
            myTriangle.sideA = 5;
            myTriangle.sideB = 10000;
            //act
            myTriangle.calculateHypotenuse();

            //assert
            Assert.AreEqual(10000.001, myTriangle.sideC);
        }

        [TestMethod()]
        public void calculateAreaBoundryTest()
        {
            //arange
            Triangle myTriangle = new Triangle();
            myTriangle.sideA = 5;
            myTriangle.sideB = 10000;
            //act
            myTriangle.calculateArea();

            //assert
            Assert.AreEqual(25000, myTriangle.Area);
        }
        [TestMethod()]
        public void calculateAreaBoundryTestNegatives()
        {
            //arange
            Triangle myTriangle = new Triangle();
            myTriangle.sideA = -5;
            myTriangle.sideB = 6;
            //act
            myTriangle.calculateArea();

            //assert
            Assert.AreEqual(15, myTriangle.Area);
        }

        [TestMethod()]
        public void calculateAngleTest()
        {
            //arange
            Triangle myTriangle = new Triangle();
            myTriangle.angleA = 30;
            myTriangle.angleB = 80;
            //act
            myTriangle.calculateAngle();

            //assert
            Assert.AreEqual(70, myTriangle.angleC);
        }
        [TestMethod()]
        public void calculateAngleNegativeTest()
        {
            //arange
            Triangle myTriangle = new Triangle();
            myTriangle.angleA = -30;
            myTriangle.angleB = 80;
            //act
            myTriangle.calculateAngle();

            //assert
            Assert.AreEqual(70, myTriangle.angleC);
        }
    }
}