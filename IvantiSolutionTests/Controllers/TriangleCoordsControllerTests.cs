using Microsoft.VisualStudio.TestTools.UnitTesting;
using IvantiSolution.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvantiSolution.Controllers.Tests
{
    [TestClass()]
    public class TriangleCoordsControllerTests
    {
        TriangleCoordsController controller;

        [TestInitialize()]
        public void Initialize()
        {
            controller = new TriangleCoordsController();
        }


        [TestMethod()]
        public void GetTest_ValidInput()
        {
            //arrange
            var row = 'a';
            var column = 1;
            //act
            var res = controller.Get(row, column);
            //assert
            Assert.AreEqual(res.Result, "VALID");
        }

        [TestMethod()]
        public void GetTest_InvalidRow()
        {
            //arrange
            var row = 'x';
            var column = 1;
            //act
            var res = controller.Get(row, column);
            //assert
            Assert.AreEqual(res.Result, "INVALID ROW");
        }

        [TestMethod()]
        public void GetTest_InvalidColumn()
        {
            //arrange
            var row = 'a';
            var column = 100;
            //act
            var res = controller.Get(row, column);
            //assert
            Assert.AreEqual(res.Result, "INVALID COLUMN");
        }
    }
}