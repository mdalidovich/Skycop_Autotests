using AutoTest_Skycop.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoTest_Skycop.Pages
{
    public class DisruptionDetailsPage
    {
        IWebElement pageTitleElement => Driver.driver.FindElement(By.CssSelector("#page-view-title"));

        public void AssertTitle()
        {
            try
            {
                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
                WebDriverWait waitTitleTrue = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(20));
                waitTitleTrue.Until 
                (d =>
                {
                    return pageTitleElement.Text == "Type of disruption";
                });
            }
            catch (WebDriverTimeoutException)
            {

            }
            finally
            {
                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            }
                      
            
            Assert.AreEqual("Type of disruption", pageTitleElement.Text);
        }
    }
}
