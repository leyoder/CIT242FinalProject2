using Packt;
using System;
using Xunit;

namespace NorthwindEntitiesLibTests
{
    public class NorthwindEntitiesLibTests
    {
        [Fact]
        public void TestDifferenceTodayAndTomorrow()
        {
            //arrange
            DateTime start = new DateTime(2020,12,16);
            DateTime end = new DateTime(2020,12,17);
            int expected = 1;
            var calc = new Functions();

            //act
            int actual = calc.Difference(start, end);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDifferenceTodayAndAYearAgo()
        {
            //arrange
            DateTime start = new DateTime(2019,12,16);
            DateTime end = new DateTime(2020,12,16);
            int expected = 366;
            var calc = new Functions();

            //act
            int actual = calc.Difference(start, end);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTax10Dollars()
        {
            //arrange
            double subTotal = 10;
            double expected = .7;
            var calc = new Functions();

            //act
            double actual = calc.Tax(subTotal);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTax200Dollars()
        {
            //arrange
            double subTotal = 200;
            double expected = 14;
            var calc = new Functions();

            //act
            double actual = calc.Tax(subTotal);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTotal10And07()
        {
            //arrange
            double subTotal = 10;
            double Tax = .07;
            double expected = 10.07;
            var calc = new Functions();

            //act
            double actual = calc.Total(subTotal, Tax);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTotal200And14()
        {
            //arrange
            double subTotal = 200;
            double Tax = 14;
            double expected = 214;
            var calc = new Functions();

            //act
            double actual = calc.Total(subTotal, Tax);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestEmployeeDiscount10Dollars()
        {
            //arrange
            double subTotal = 10;
            double expected = 1;
            var calc = new Functions();

            //act
            double actual = calc.EmployeeDiscount(subTotal);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestEmployeeDiscount200Dollars()
        {
            //arrange
            double subTotal = 200;
            double expected = 20;
            var calc = new Functions();

            //act
            double actual = calc.EmployeeDiscount(subTotal);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestExtendedCost50And5()
        {
            //arrange
            double cost = 50;
            double quantity = 5;
            double expected = 250;
            var calc = new Functions();

            //act
            double actual = calc.ExtendedCost(cost, quantity);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]        
        public void TestExtendedCost15And1000()
        {
            //arrange
            double cost = 15;
            double quantity = 1000;
            double expected = 15000;
            var calc = new Functions();

            //act
            double actual = calc.ExtendedCost(cost, quantity);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
