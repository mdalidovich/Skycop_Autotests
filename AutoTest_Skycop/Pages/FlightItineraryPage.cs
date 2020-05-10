using AutoTest_Skycop.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoTest_Skycop.Pages
{
    public class FlightItineraryPage
    {
        IWebElement departedFromField => Driver.driver.FindElement(By.CssSelector("#airport-departure input"));
        IWebElement dropdownOption => Driver.driver.FindElement(By.CssSelector(".Select-menu-outer .Select-option"));
        IWebElement arrivedToField => Driver.driver.FindElement(By.CssSelector("#airport-arrival input"));
        IWebElement continueButton => Driver.driver.FindElement(By.CssSelector("#step-page-content #btn-step-continue"));

        public FlightItineraryPage EnterDepartureValue(string departureValue)
        {
            departedFromField.SendKeys(departureValue);
            dropdownOption.Click();
            return this;
        }

        public FlightItineraryPage EnterArrivalValue(string arrivalValue)
        {
            arrivedToField.SendKeys(arrivalValue);
            dropdownOption.Click();
            return this;
        }

        public DisruptionDetailsPage ClickonContinueButton()
        {
            continueButton.Click();
            return new DisruptionDetailsPage();
        }
    }
}
