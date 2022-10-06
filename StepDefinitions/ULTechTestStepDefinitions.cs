using BoDi;
using Dynamitey.Internal.Optimization;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using uLTechTest.PageObject;

namespace uLTechTest.StepDefinitions
{
    [Binding]
    public class ULTechTestStepDefinitions
    {
        ULHomePage uLHomePage;
        public ULTechTestStepDefinitions(IObjectContainer _container)
        {
            uLHomePage = _container.Resolve<ULHomePage>();
        }

        [Given(@"User is on ul\.com home page")]
        public void GivenUserIsOnUl_ComHomePage() => uLHomePage.navigateToSite();

        [Given(@"User click on accept all cookies")]
        public void WhenUserClickOnAcceptAllCookies() => uLHomePage.AcceptCookies();

        [When(@"User click on (.*) linktext")]
        public void WorkingAtULSolutionsLinktext(string value) => uLHomePage.ClickWorkingAtUlLinkText(value);

        [Then(@"User is on (.*) page with headerText")]
        public void ThenUserIsOnCareersPage(string expectedPageHeader)
        {
            var actualPageHeader = uLHomePage.GetCareerHeaderText();
            Assert.AreEqual(expectedPageHeader, actualPageHeader);
        }

        [Then(@"User is on global job search page with a pageHeaderText '([^']*)'")]
        public void GlobalJobSearchPageWithAMessage(string expectedPageHeaderText)
        {
            var actualPageHeaderText = uLHomePage.GetGlobalJobSearchText();
            Assert.AreEqual(expectedPageHeaderText, actualPageHeaderText);
        }

        [Then(@"User is on US job search page with a pageHeaderText '([^']*)'")]
        public void JobSearchPageWithAPageHeaderText(string expectedPageHeaderText)
        {
            var actualPageHeaderText = uLHomePage.GetUSJobSearchHeaderText();
            Assert.AreEqual(expectedPageHeaderText, actualPageHeaderText);
        }

        [Then(@"User is on Help and Support page with a pageHeaderText '([^']*)'")]
        public void HelpAndSupportPageWithAPageHeaderText(string expectedPageHeaderText)
        {
            var actualPageHeaderText = uLHomePage.GetHelpAndSupportHeaderText();
            Assert.AreEqual(expectedPageHeaderText, actualPageHeaderText);
        }

        [Then(@"User is on Tools Apps and Databases page with a pageHeaderText '([^']*)'")]
        public void ToolsAppsAndDatabasesPageWithAPageHeaderText(string expectedPageHeaderText)
        {
            var actualPageHeaderText = uLHomePage.GetToolsAppsAndDatabasesLinkText();
            Assert.AreEqual(expectedPageHeaderText, actualPageHeaderText);
        }

        [Then(@"User is on report a concern page, with a pageHeaderText '([^']*)'")]
        public void ReportAConcernPageWithAPageHeaderText(string expectedPageHeaderText)
        {
            var actualPageHeaderText = uLHomePage.GetMarketSurveillanceHeaderText();
            Assert.AreEqual(expectedPageHeaderText, actualPageHeaderText);
        }

        [Then(@"User is on contact Us page, with a pageHeaderText (.*)")]
        public void ContactUsPageWithAPageHeaderTextSStartAConversation(string expectedPageHeaderText)
        {
            var actualPageHeaderText = uLHomePage.GetLetStartAConversationHeaderText();
            Assert.AreEqual(expectedPageHeaderText, actualPageHeaderText);
        }

        [Then(@"User is on Manage Your Subscriptions page, with a pageHeaderText '([^']*)'")]
        public void ManageYourSubscriptionsPageWithAPageHeaderText(string expectedPageHeaderText)
        {
            var actualPageHeaderText = uLHomePage.GetcommunicationsPreferencesHeaderText();
            Assert.AreEqual(expectedPageHeaderText, actualPageHeaderText);
        }

        [Then(@"User is on Locations page, with a pageHeaderText '([^']*)'")]
        public void LocationsPageWithAPageHeaderText(string expectedPageHeaderText)
        {
            var actualPageHeaderText = uLHomePage.GetLocationsHeaderText();
            Assert.AreEqual(expectedPageHeaderText, actualPageHeaderText);
        }

        [When(@"User click on News btn")]
        public void GivenUserClickOnNewsBtn() => uLHomePage.ClickNewsBtn();

        [Then(@"User is presented with a particular image showing in the News section")]
        public void ParticularImageShowingInTheNewsSection()
        {
            Assert.IsTrue(uLHomePage.GetIsImageDisplay());
        }

        [When(@"User select (.*) from the selection under the Choose a region select box")]
        public void UserSelectGermanyDeutschFromTheSelectBox(string countryOption) => uLHomePage.ClickCountry(countryOption);

        [Then(@"User is redirected to the UL Solutions Deutschland page '([^']*)'")]
        public void UserIsRedirectedToTheULSolutionsDeutschlandPage(string expectedPageTitle)
        {
            var actualPageTitle = uLHomePage.GetULDeutschlandHeaderText();
            Assert.That(expectedPageTitle, Is.EqualTo(actualPageTitle));
        }
    }
}