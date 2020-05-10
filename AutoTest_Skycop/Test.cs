using AutoTest_Skycop.Pages;
using AutoTest_Skycop.Utilities;
using NUnit.Framework;

namespace AutoTest_Skycop
{
    public class Tests
    {
        public Homepage homePage;

        [SetUp]
        public void Setup()
        {
            Driver.InitializeDriver();
            homePage = new Homepage();
            Driver.driver.Url = "https://www.skycop.com/";
        }

        [Test]
        public void FilloutFlightItineraryForm()
        {
            homePage
                .ClickClaimNowButton()
                .EnterDepartureValue("VNO")
                .EnterArrivalValue("KAU")
                .ClickonContinueButton()
                .AssertTitle();

        }

        [TearDown]
        public void CloseUp()
        {
            Driver.driver.Quit();
        }

        
    }
}