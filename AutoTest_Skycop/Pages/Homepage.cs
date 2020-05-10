using AutoTest_Skycop.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoTest_Skycop.Pages
{
    public class Homepage
    {
        private IWebElement claimNowButton => Driver.driver.FindElement(By.CssSelector(".hero-form .button"));

        public FlightItineraryPage ClickClaimNowButton()
        {
            claimNowButton.Click();
            return new FlightItineraryPage();
        }
    }
}
