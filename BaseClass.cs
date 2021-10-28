using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Appium.Windows;

namespace TestDataPay
{
    [SetUpFixture]
    public class BaseClase : DriverContext
    {
        private const string dataApp = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";

        //above path is for calculator app as data pay app doesnt open using the exe different paths used for datapay app are below. 
        //@"C:\Users\prab.saini\OneDrive - Datacom\Desktop\EasiPay(Main)";
        //@"C:\Users\prab.saini\OneDrive - Datacom\Desktop\EasiPay(Main) - Shortcut.lnk";
        //"C:/Users/prab.saini/AppData/Local/Apps/2.0/EXQ21ZVY.JCO/EBKA9CQM.THR/main_34410279e62ac762_0007.0004_aeaf104d2e689299";
        //"C:/Users/prab.saini/AppData/Roaming/Microsoft/Windows/Start Menu/Programs/Datacom Solutions Limited/EasiPay (Main).Application Reference";
        // "main_34410279e62ac762_658c62b6f49c2f69";
        //"C:/Users/prab.saini/AppData/Roaming/Microsoft/Windows/Start Menu/Programs/Datacom Solutions Limited/EasiPay (Main)";
        //"Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";

        [OneTimeSetUp]
        public void Init()
        {
            var appiumServiceBuilder = new AppiumServiceBuilder().UsingPort(4723).Build();    //UsingPort(4723).Build();
            appiumServiceBuilder.Start();
            AppiumOptions appiumOptions = new AppiumOptions();

            appiumOptions.AddAdditionalCapability("app", dataApp);
            appiumOptions.AddAdditionalCapability("deviceName", "WindowsPC");
            _elementDriver = new WindowsDriver<WindowsElement>(appiumServiceBuilder, appiumOptions);
        }
    }
}