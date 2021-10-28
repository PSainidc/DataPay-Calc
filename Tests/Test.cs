using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestDataPay.ScreenObjects;

namespace TestDataPay.Tests
{
    [TestFixture]
    public class Test : DriverContext
    {

        private readonly AppScreen screen = new AppScreen(_elementDriver);

        [Test]

        public void OneTimeSetUp()
        {
            screen.button9.Click();
            screen.buttonMultiply.Click();
            screen.button2.Click();
            screen.buttonEqual.Click();

        }
    }
}
