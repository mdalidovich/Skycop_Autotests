using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoTest_Skycop.Utilities
{
    class Driver
    {
        public static IWebDriver driver;
        public static void InitializeDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("incognito");
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);


        }
    }
}
