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
    }
}