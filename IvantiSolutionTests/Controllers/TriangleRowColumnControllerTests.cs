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
    public class TriangleRowColumnControllerTests
    {
        TriangleRowColumnController controller;

        [TestInitialize()]
        public void Initialize()
        {
            controller = new TriangleRowColumnController();
        }

        [TestMethod()]
        public void GetTest_ValidInput()
        {
            //arrange
            //act
            var res = controller.Get(0,10,0,20,10,20);
            //assert
            Assert.AreEqual(res.Result, "VALID");
        }

        [TestMethod()]
        public void GetTest_CoordsNotDivisibleByTen()
        {
            //arrange
            //act
            var res = controller.Get(0, 6, 0, 20, 10, 20);
            //assert
            Assert.AreEqual(res.Result, "INVALID COORDINATES: Not divisible by 10");
        }

        [TestMethod()]
        public void GetTest_CoordsOutOfRange()
        {
            //arrange
            //act
            var res = controller.Get(0, 10, 0, 20, 10, 200);
            //assert
            Assert.AreEqual(res.Result, "INVALID COORDINATES: Outside of range (0 - 60)");
        }
    }
}