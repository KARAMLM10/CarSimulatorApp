﻿using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulatorApp.Test
{
    [TestClass]
    public class CarSimulatorTest
    {
        private CarSimulator SUT;

        public CarSimulatorTest() 
        {
            SUT = new CarSimulator();
        }
        [TestMethod]
        public void low_Fatigue()
        {
            STATS stats = new STATS();
            var expected = 1;
              SUT.DriverFatigue(stats);
            Assert.AreEqual(expected,stats.Fatigue);
        }
        [TestMethod]
        public void Drive_Forward_DegresisFuel_test()
        {
            STATS stats = new STATS();
            var expected = 27;
            SUT.DriveForward(stats);
            Assert.AreEqual(expected, stats.Fuel);
        }

        [TestMethod]
        public void Drive_Forward_Low_DegresisFuel_test()
        {
            STATS stats = new STATS();
            stats.Fuel = 6;
            var expected = 3;
            SUT.DriveForward(stats);
            Assert.AreEqual(expected, stats.Fuel);
        }
        [TestMethod]
        public void Direction_test()
        {
            STATS stats = new STATS();
            var newDirection = Direction.East;
            var expected = Direction.East;
            SUT.SetDirection(newDirection, stats);
            Assert.AreEqual(expected, stats.Direction);
        }
        [TestMethod]
        public void Direction_West_test()
        {
            STATS stats = new STATS();
            var newDirection = Direction.West;
            var expected = Direction.West;
            SUT.SetDirection(newDirection, stats);
            Assert.AreEqual(expected, stats.Direction);
        }
        [TestMethod]
        public void Direction_South_test()
        {
            STATS stats = new STATS();
            var newDirection = Direction.South;
            var expected = Direction.South;
            SUT.SetDirection(newDirection, stats);
            Assert.AreEqual(expected, stats.Direction);
        }
        [TestMethod]
        public void Direction_Noth_test()
        {
            STATS stats = new STATS();
            var newDirection = Direction.North;
            var expected = Direction.North;
            SUT.SetDirection(newDirection, stats);
            Assert.AreEqual(expected, stats.Direction);
        }
        [TestMethod]
        public void Reverse_Fuel_test()
        {
            STATS stats = new STATS();
            var expected = 27;
            SUT.Reverse(stats);
            Assert.AreEqual(expected, stats.Fuel);
        }
        [TestMethod]
        public void Reverse_LowFuel_test()
        {
            STATS stats = new STATS();
            stats.Fuel = 6;
            var expected = 3;
            SUT.Reverse(stats);
            Assert.AreEqual(expected, stats.Fuel);
        }
        [TestMethod]
        public void Refuel_Test()
        {
            STATS stats = new STATS();
            stats.Fuel = 0;
            var expected = 30;
            SUT.RefuelGasoline(stats);
            Assert.AreEqual(expected, stats.Fuel);
        }
    }
}
