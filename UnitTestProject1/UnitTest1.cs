using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BartlomiejSajdok_S00196895;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDecreasePrice()
        {
            //arrange
            Game g1 = new Game("Nier", "PS4, PS5, XBOX ONE", 9.5, 59.99m);
            decimal expectedPrice = 49.99m;
            //act
            g1.DecreasePrice(10.00m);

            Assert.AreEqual(expectedPrice, g1.Price);
        }
    }
}
