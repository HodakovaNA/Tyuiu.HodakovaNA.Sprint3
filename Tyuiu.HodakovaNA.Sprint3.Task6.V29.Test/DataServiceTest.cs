using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.HodakovaNA.Sprint3.Task6.V29.Lib;

namespace Tyuiu.HodakovaNA.Sprint3.Task6.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int res = ds.GetSumTheDivisors(12, 18);
            Assert.AreEqual(178, res);
        }
    }
}
