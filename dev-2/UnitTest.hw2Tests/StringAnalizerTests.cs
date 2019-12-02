using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest.hw2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.hw2.Tests
{
    [TestClass()]
    public class StringAnalizerTests
    {
        [TestMethod()]
        public void MaxCountOfDifferentSymbolsTest()
        {
            //arrange 
            string str = "abcdd";
            int expected = 4;

            //act
            int actual = StringAnalizer.MaxCountOfDifferentSymbols(str);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxCountOfDifferentSymbolsTest_WhenEmpty()
        {
            //arrange 
            string str = "";
            int expected = 0;

            //act
            int actual = StringAnalizer.MaxCountOfDifferentSymbols(str);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxCountOfIdenticalDigitsTest()
        {
            //arrange 
            string str = "2222656h";
            int expected = 4;

            //act
            int actual = StringAnalizer.MaxCountOfIdenticalDigits(str);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxCountOfIdenticalDigitsTest_WhenEmpty()
        {
            //arrange 
            string str = "";
            int expected = 0;

            //act
            int actual = StringAnalizer.MaxCountOfDifferentSymbols(str);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxCountOfIdenticalLatinSymbolsTest()
        {
            //arrange 
            string str = "aaabcdd";
            int expected = 3;

            //act
            int actual = StringAnalizer.MaxCountOfIdenticalLatinSymbols(str);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxCountOfIdenticalLatinSymbolsTest_WhenEmpty()
        {
            //arrange 
            string str = "";
            int expected = 0;

            //act
            int actual = StringAnalizer.MaxCountOfIdenticalLatinSymbols(str);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}