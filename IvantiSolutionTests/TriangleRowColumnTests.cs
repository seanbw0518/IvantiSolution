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
    public class TriangleRowColumnTests
    {
        
        TriangleRowColumn triangleRowColumn;

        [TestInitialize()]
        public void Initialize()
        {
            triangleRowColumn = new TriangleRowColumn();
        }

        [TestMethod()]
        public void EqualsTest_AreEqual()
        {
            //arrange
            var rowColumn1 = new TriangleRowColumn()
            {
                Row = 'A', Column = 2
            };
            var rowColumn2 = new TriangleRowColumn()
            {
                Row = 'A', Column = 2
            };
            //act

            //assert
            Assert.AreEqual(rowColumn1, rowColumn2);
        }

        [TestMethod()]
        public void EqualsTest_AreNotEqual()
        {
            //arrange
            var rowColumn1 = new TriangleRowColumn()
            {
                Row = 'A',
                Column = 2
            };
            var rowColumn2 = new TriangleRowColumn()
            {
                Row = 'F',
                Column = 4
            };
            //act

            //assert
            Assert.AreNotEqual(rowColumn1, rowColumn2);
        }


        [TestMethod()]
        public void FindCoordsTest_OddColumn()
        {
            //arrange
            var expectedRowColumn = new TriangleRowColumn()
            {
                Row = 'C',
                Column = 9
            };
            //act
            triangleRowColumn.FindRowColumn(40, 20, 40, 30, 50, 30);
            //assert
            Assert.AreEqual(expectedRowColumn, triangleRowColumn);
        }

        [TestMethod()]
        public void FindCoordsTest_EvenColumn()
        {
            //arrange
            var expectedRowColumn = new TriangleRowColumn()
            {
                Row = 'E',
                Column = 2
            };
            //act
            triangleRowColumn.FindRowColumn(0, 40, 10, 40, 10, 50);
            //assert
            Assert.AreEqual(expectedRowColumn, triangleRowColumn);
        }

        [TestMethod()]
        public void FindCoordsTest_InvalidCoords()
        {
            //arrange
            
            //act
            triangleRowColumn.FindRowColumn(0, 40, 50, 30, 20, 0);
            //assert
            Assert.AreEqual("INVALID COORDINATES", triangleRowColumn.Result);
        }
    }
}
