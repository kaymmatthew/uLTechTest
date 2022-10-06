using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using uLTechTest.Extension;
using uLTechTest.Support;

namespace uLTechTest.PageObject
{
    public class ULHomePage
    {
        IWebDriver Driver;

        public ULHomePage(IWebDriver Driver)
        {
            this.Driver = Driver;
        }

        private IWebElement Cookiesbtn => Driver.FindElement(By.XPath("//*[@id='onetrust-accept-btn-handler'][.='Accept All Cookies']\r\n"));
        private IWebElement CareerHeaderText => Driver.FindElement(By.XPath(
                "//*[@class='content-container hero-content--background gray']/h1[.='Careers']"));
        private IList<IWebElement> AllFooterLinkText => Driver.FindElements(By.XPath(
                "//*[@class='menu-item menu-item--default ']//*[@class=' second-level  ul-ga-footer-link']"));
        private IWebElement GlobalJobSearchHeaderText => Driver.FindElement(By.XPath("//*[@class='iCIMS_Header']"));
        private IWebElement USJobSearchHeaderText => Driver.FindElement(By.XPath("//*[@class='iCIMS_Header']"));
        private IWebElement HelpAndSupportHeaderText => Driver.FindElement(By.XPath(
                "//*[@class='content-container hero-content--background gray']/h1"));
        private IWebElement ToolsAppsAndDatabasesTextHeaderText => Driver.FindElement(By.XPath(
                "//*[@class='content-container hero-content--background gray']/h1"));
        private IWebElement MarketSurveillanceHeaderText => Driver.FindElement(By.XPath(
               "//*[@class='content-container hero-content--background gray']/h1"));
        private IWebElement LetStartAConversationHeaderText => Driver.FindElement(By.XPath(
               "//*[@class='content-container hero-content--background gray']/h1"));
        private IWebElement CommunicationsPreferencesHeaderText => Driver.FindElement(By.XPath("//*[@class='paragraph-gutter']/h2"));
        private IWebElement LocationsHeaderText => Driver.FindElement(By.XPath(
               "//*[@class='content-container hero-content--background gray']/h1"));
        private IList<IWebElement> NewsBtn => Driver.FindElements(By.XPath(
               "//*[@class='menu-item menu-item--primary-nav span-auto ']/."));
        private IWebElement IsImageDisplay => Driver.FindElement(By.XPath("//*[@class='lazy loaded']"));
        public IWebElement CountryInputField => Driver.FindThisElement(By.XPath("//*[@id='choose-region']"));
        private IWebElement CountrySelection => Driver.FindElement(By.XPath(
               "//*[@id='choose-region']//option[.='Germany (Deutsch)']"));
        private IWebElement ULDeutschlandHeaderText => Driver.FindElement(By.XPath("//*[@class='h1']"));





        public string GetULDeutschlandHeaderText() => ULDeutschlandHeaderText.Text;
        public void ClickCountry(string text)
        {
            CountryInputField.Click();
            CountrySelection.Click();
        }
        public void ClickNewsBtn()
        {
            Driver.MilliSec(2000);
            NewsBtn[4].Click();
            Driver.MilliSec(1000);
        }
        public bool GetIsImageDisplay() => IsImageDisplay.Displayed;
        public void ClickWorkingAtUlLinkText(string value)
        {
            if (value == "working at UL Solutions")
            {
                Thread.Sleep(2000);
                CustomExtension.MoveToElementViaJs(AllFooterLinkText[0], Driver);
                AllFooterLinkText[0].Click();
            }
            else if (value == "global job search")
            {
                Driver.MilliSec(1000);
                CustomExtension.MoveToElementViaJs(AllFooterLinkText[1], Driver);
                AllFooterLinkText[1].Click();
                Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//*[@id='icims_content_iframe']")));
                Driver.MilliSec(2000);
            }
            else if (value == "US job search")
            {
                Driver.MilliSec(1000);
                CustomExtension.MoveToElementViaJs(AllFooterLinkText[2], Driver);
                AllFooterLinkText[2].Click();
                Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//*[@id='icims_content_iframe']")));
                Driver.MilliSec(1000);
            }
            else if (value == "help center")
            {
                Driver.MilliSec(500);
                CustomExtension.MoveToElementViaJs(AllFooterLinkText[3], Driver);
                AllFooterLinkText[3].Click();
                Thread.Sleep(1000);
            }
            else if (value == "Tools, Apps and Databases")
            {
                Driver.MilliSec(500);
                CustomExtension.MoveToElementViaJs(AllFooterLinkText[4], Driver);
                AllFooterLinkText[4].Click();
                Thread.Sleep(1000);
            }
            else if (value == "report a concern")
            {
                Driver.WaitFor(3);
                CustomExtension.MoveToElementViaJs(AllFooterLinkText[5], Driver);
                AllFooterLinkText[5].Click();
                Thread.Sleep(1000);
            }
            else if (value == "contact Us")
            {
                Driver.MilliSec(500);
                CustomExtension.MoveToElementViaJs(AllFooterLinkText[6], Driver);
                AllFooterLinkText[6].Click();
                Driver.MilliSec(2000);
            }
            else if (value == "Manage Your Subscriptions")
            {
                Driver.WaitFor(3);
                CustomExtension.MoveToElementViaJs(AllFooterLinkText[7], Driver);
                AllFooterLinkText[7].Click();
                Driver.MilliSec(2000);
            }
            else if (value == "Locations")
            {
                Driver.WaitFor(3);
                CustomExtension.MoveToElementViaJs(AllFooterLinkText[8], Driver);
                AllFooterLinkText[8].Click();
                Driver.MilliSec(2000);
            }
            else
            {
                Assert.Fail(String.Format($"Scenario with Element: {value} not available"));
            }
        }
        public string GetCareerHeaderText()
        {
            Driver.MilliSec(1000);
            return CareerHeaderText.Text;
        }

        public string GetGlobalJobSearchText()
        {
            Driver.MilliSec(500);
            return GlobalJobSearchHeaderText.Text;
            Driver.MilliSec(2000);
        }

        public string GetUSJobSearchHeaderText()
        {
            Driver.waitFor(By.XPath("//*[@class='iCIMS_Header']"));
            return USJobSearchHeaderText.Text;
        }

        public string GetHelpAndSupportHeaderText()
        {
            Driver.MilliSec(500);
            return HelpAndSupportHeaderText.Text;
        }

        public string GetToolsAppsAndDatabasesLinkText()
        {
            Driver.MilliSec(500);
            return ToolsAppsAndDatabasesTextHeaderText.Text;
        }

        public string GetMarketSurveillanceHeaderText()
        {
            Driver.MilliSec(500);
            return MarketSurveillanceHeaderText.Text;
        }

        public string GetLetStartAConversationHeaderText()
        {
            Driver.MilliSec(500);
            return LetStartAConversationHeaderText.Text;
        }

        public string GetcommunicationsPreferencesHeaderText()
        {
            Driver.MilliSec(500);
            return CommunicationsPreferencesHeaderText.Text;
        }

        public string GetLocationsHeaderText()
        {
            Driver.MilliSec(500);
            return LocationsHeaderText.Text;
        }
        public void AcceptCookies()
        {
            Driver.MilliSec(2000);
            try
            {
                if (Cookiesbtn.Displayed)
                {
                    Cookiesbtn.Click();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        public void navigateToSite() => Driver.Navigate().GoToUrl(readTestDataConfig.ULSolutionUrl);
    }
}