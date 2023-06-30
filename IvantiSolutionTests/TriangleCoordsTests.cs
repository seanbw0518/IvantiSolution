using Microsoft.VisualStudio.TestTools.UnitTesting;
using IvantiSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IvantiSolution.Controllers;

namespace IvantiSolution.Tests
{
    [TestClass()]
    public class TriangleCoordsTests
    {
        TriangleCoords triangleCoords;
        [TestInitialize()]
        public void Initialize()
        {
            triangleCoords = new TriangleCoords();
        }


        [TestMethod()]
        public void EqualsTest_AreEqual()
        {
            //arrange
            var coords1 = new TriangleCoords()
            {
                V1x = 0, V1y = 10,
                V2x = 0, V2y = 20,
                V3x = 10, V3y = 20,
            };
            var coords2 = new TriangleCoords()
            {
                V1x = 0,V1y = 10,
                V2x = 0,V2y = 20,
                V3x = 10,V3y = 20,
            };
            //act

            //assert
            Assert.AreEqual(coords1, coords2);
        }

        [TestMethod()]
        public void EqualsTest_AreNotEqual()
        {
            //arrange
            var coords1 = new TriangleCoords()
            {
                V1x = 0,
                V1y = 10,
                V2x = 0,
                V2y = 20,
                V3x = 10,
                V3y = 20,
            };
            var coords2 = new TriangleCoords()
            {
                V1x = 10,
                V1y = 20,
                V2x = 10,
                V2y = 30,
                V3x = 20,
                V3y = 30,
            };
            //act

            //assert
            Assert.AreNotEqual(coords1, coords2);
        }


        [TestMethod()]
        public void FindCoordsTest_OddColumn()
        {
            //arrange
            int column = 3;
            char row = 'B';
            TriangleCoords? expectedCoords = new TriangleCoords()
            {
                V1x = 10,
                V1y = 10,
                V2x = 10,
                V2y = 20,
                V3x = 20,
                V3y = 20,
            };
            //act
            triangleCoords.FindCoords(row, column);
            //assert
            Assert.AreEqual(expectedCoords, triangleCoords);
        }

        [TestMethod()]
        public void FindCoordsTest_EvenColumn()
        {
            //arrange
            int column = 6;
            char row = 'A';
            TriangleCoords? expectedCoords = new TriangleCoords()
            {
                V1x = 20,
                V1y = 0,
                V2x = 30,
                V2y = 0,
                V3x = 30,
                V3y = 10,
            };
            //act
            triangleCoords.FindCoords(row, column);
            //assert
            Assert.AreEqual(expectedCoords, triangleCoords);
        }
    }
}