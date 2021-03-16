using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Program360
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Test0()
        {
             string actual = Program360.Castles.Process(
            new uint[,] {
                { 5, 0, 0, 0 },
                { 0, 0, 0, 2 },
            });
            string expected = String.Format(
                    "Your castle at ({0},{1}) earns {2}. Your nemesis' castle at ({3},{4}) earns {5}.",
                    0, 0, 5,
                    1, 3, 2);
            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected, actual, "Unexpected result");
        }
        [TestMethod]
        public void Test1()
        {
            string actual = Program360.Castles.Process(
            new uint[,] {
                { 2, 0, 0, 1 },
                { 0, 0, 1, 1 },
            });
            string expected = String.Format(
                    "Your castle at ({0},{1}) earns {2}. Your nemesis' castle at ({3},{4}) earns {5}.",
                    1, 3, 3,
                    0, 0, 2);
            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected, actual, "Unexpected result");
        }
        [TestMethod]
        public void Test2()
        {
            string actual = Program360.Castles.Process(
            new uint[,] {
                { 3, 4, 1, 0, 0, 0, 0 },
                { 2, 1, 1, 0, 0, 0, 0 },
                { 1, 1, 1, 1, 0, 0, 0 },
                { 1, 1, 1, 0, 1, 1, 1 },
                { 0, 0, 0, 1, 1, 1, 2 },
                { 0, 0, 0, 0, 1, 2, 1 },
                { 0, 0, 0, 0, 1, 3, 4 }
            });
            string expected = String.Format(
                    "Your castle at ({0},{1}) earns {2}. Your nemesis' castle at ({3},{4}) earns {5}.",
                    2, 3, 29,
                    3, 0, 9);
            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected, actual, "Unexpected result");
        }
        [TestMethod]
        public void Test3()
        {
            string actual = Program360.Castles.Process(
                    new uint[,] {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 },
                { 0, 1, 2, 2, 2, 2, 2, 2, 1, 0 },
                { 0, 1, 2, 3, 3, 3, 3, 2, 1, 0 },
                { 0, 1, 2, 3, 4, 4, 3, 2, 1, 0 },
                { 0, 1, 2, 3, 5, 4, 3, 2, 1, 0 },
                { 0, 1, 2, 3, 3, 3, 3, 2, 1, 0 },
                { 0, 1, 2, 2, 2, 2, 2, 2, 1, 0 },
                { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            });
            string expected = String.Format(
                    "Your castle at ({0},{1}) earns {2}. Your nemesis' castle at ({3},{4}) earns {5}.",
                    3, 4, 112,
                    1, 1, 8);
            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected, actual, "Unexpected result");
        }
        [TestMethod]
        public void Test4()
        {
            string actual = Program360.Castles.Process(
                    new uint[,] {
                 { 0,  0, 0, 0, 0, 0, 0, 0,  0, 0 },
                 { 0, 40, 1, 1, 1, 1, 1, 1,  1, 0 },
                 { 0,  1, 1, 1, 1, 1, 1, 1,  1, 0 },
                 { 0,  1, 2, 2, 2, 2, 2, 2,  1, 0 },
                 { 0,  1, 2, 2, 2, 2, 2, 2,  1, 0 },
                 { 0,  1, 2, 3, 3, 3, 3, 2,  1, 0 },
                 { 0,  1, 2, 3, 3, 3, 3, 2,  1, 0 },
                 { 0,  1, 2, 3, 4, 4, 3, 2,  1, 0 },
                 { 0,  1, 2, 3, 4, 4, 3, 2,  1, 0 },
                 { 0,  1, 2, 3, 5, 4, 3, 2,  1, 0 },
                 { 0,  1, 2, 3, 5, 4, 3, 2,  1, 0 },
                 { 0,  1, 2, 3, 3, 3, 3, 2,  1, 0 },
                 { 0,  1, 2, 3, 3, 3, 3, 2,  1, 0 },
                 { 0,  1, 2, 2, 2, 2, 2, 2,  1, 0 },
                 { 0,  1, 2, 2, 2, 2, 2, 2,  1, 0 },
                 { 0,  1, 1, 1, 1, 1, 1, 1,  1, 0 },
                 { 0,  1, 1, 1, 1, 1, 1, 1, 40, 0 },
                 { 0,  0, 0, 0, 0, 0, 0, 0,  0, 0 }
            });
            string expected = String.Format(
                    "Your castle at ({0},{1}) earns {2}. Your nemesis' castle at ({3},{4}) earns {5}.",
                    6, 4, 202,
                    1, 8, 19);
            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected, actual, "Unexpected result");
        }
        [TestMethod]
        public void Test5()
        {
            string actual = Program360.Castles.Process(
                    new uint[,] {
                 { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                 { 0, 9, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 },
                 { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            });
            string expected = String.Format(
                    "Your castle at ({0},{1}) earns {2}. Your nemesis' castle at ({3},{4}) earns {5}.",
                    1,  7, 20,
                    1, 18, 6);
            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected, actual, "Unexpected result");
        }
        [TestMethod]
        public void Test6()
        {
            string actual = Program360.Castles.Process(
                    new uint[,] {
                 { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                 { 0, 1, 1, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3, 1, 1, 0 },
                 { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            });
            string expected = String.Format(
                    "Your castle at ({0},{1}) earns {2}. Your nemesis' castle at ({3},{4}) earns {5}.",
                    1, 5, 8,
                    1, 1, 2);
            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected, actual, "Unexpected result");
        }
        [TestMethod]
        public void Test7()
        {
            string actual = Program360.Castles.Process(
                    new uint[,] {
                 { 0, 0, 0 },
                 { 0, 1, 0 },
                 { 0, 1, 0 },
                 { 0, 1, 0 },
                 { 0, 1, 0 },
                 { 0, 1, 0 },
                 { 0, 1, 0 },
                 { 0, 1, 0 },
                 { 0, 1, 0 },
                 { 0, 1, 0 },
                 { 0, 1, 0 },
                 { 0, 1, 0 },
                 { 0, 1, 0 },
                 { 0, 1, 0 },
                 { 0, 1, 0 },
                 { 0, 1, 0 },
                 { 0, 8, 0 },
                 { 0, 1, 0 },
                 { 0, 1, 0 },
                 { 0, 0, 0 }
            });
            string expected = String.Format(
                    "Your castle at ({0},{1}) earns {2}. Your nemesis' castle at ({3},{4}) earns {5}.",
                    10, 1, 18,
                    1, 1, 5);
            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected, actual, "Unexpected result");
        }
        [TestMethod]
        public void Test8()
        {
            string actual = Program360.Castles.Process(
                    new uint[,] {
                 { 0, 0, 0 },
                 { 0, 0, 0 },
                 { 0, 0, 0 },
                 { 0, 0, 0 },
                 { 0, 0, 0 },
                 { 0, 0, 0 },
                 { 0, 0, 0 },
                 { 0, 7, 0 },
                 { 0, 0, 0 },
                 { 0, 0, 0 },
                 { 0, 0, 0 },
                 { 0, 0, 0 },
                 { 0, 0, 0 },
                 { 0, 0, 0 },
                 { 0, 0, 0 },
                 { 0, 0, 0 },
                 { 0, 8, 0 },
                 { 0, 0, 0 },
                 { 0, 0, 0 },
                 { 0, 0, 0 }
            });
            string expected = String.Format(
                    "Your castle at ({0},{1}) earns {2}. Your nemesis' castle at ({3},{4}) earns {5}.",
                    16, 1, 8,
                    7, 1, 7);
            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected, actual, "Unexpected result");
        }
        [TestMethod]
        public void Test9()
        {
            string actual = Program360.Castles.Process(
                    new uint[,] {
                 { 1, 1, 13, 1, 1, 1, 1, 1, 1, 12, 1, 1, 1, 1, 1, 9, 1, 1, 1, 1 }
            });
            string expected = String.Format(
                    "Your castle at ({0},{1}) earns {2}. Your nemesis' castle at ({3},{4}) earns {5}.",
                    0, 12, 29,
                    0, 19, 4);
            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected, actual, "Unexpected result");
        }
    }
}
