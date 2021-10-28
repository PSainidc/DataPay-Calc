using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataPay.ScreenObjects
{
    class AppScreen : BaseClase
    {
        public AppScreen(WindowsDriver<WindowsElement> elementDriver)
        {
            _elementDriver = elementDriver;
        }
        //this is how you can create different pages of apps and can put the elements in and point them 
        public WindowsElement button9 => _elementDriver.FindElement(By.Name("Nine"));
        public WindowsElement button2 => _elementDriver.FindElement(By.Name("Two"));
        public WindowsElement buttonMultiply => _elementDriver.FindElement(By.Name("Multiply by"));
        public WindowsElement buttonEqual => _elementDriver.FindElementByAccessibilityId("equalButton");
    }
}
