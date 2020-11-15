using System;
using System.Collections.Generic;
using HomeWork.Lib;
using Xunit;

namespace HomeWork.Test
{
    public class HomeWorkTest
    {
        [Fact]
        public void Test1()
        {
            var homeWorkLib = new HomeWorkLib();
            var combinations = new List<Tuple<int, string>>
            {
                new Tuple<int, string>(3, "Colin"),
                new Tuple<int, string>(5, "Pear"),
                new Tuple<int, string>(10, "Test"),
                new Tuple<int, string>(100, "(PM)")
            };
           
            Assert.All(homeWorkLib.GetFizzBuzzValueVersionTwo(100, combinations), result => Assert.Equal("15", result));
        }
    }
}
