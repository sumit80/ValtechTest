using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;
using Framework.TestFixtures;
using TechTalk.SpecFlow;

namespace Tests.StepDefinitions
{
    [Binding]
    public sealed class HomePage
    {
        [Given(@"I am on Valtech Hompage")]
        public void GivenIAmOnValtechHompage()
        {
            Page.HomePage.IsAt().Should().BeTrue();
        }

        [Then(@"Latest News link is displayed")]
        public void ThenLatestNewsLinkIsDisplayed()
        {
            Page.HomePage.VerifyLatestNewsExist().Should().BeTrue();
        }

        [When(@"I Navigate to (.*) page")]
        public void WhenINavigateToPage(string page)
        {
            Page.HomePage.NavigateTo(page);
        }
        [Then(@"User is navigated to (.*) Page")]
        public void ThenUserIsNavigatedToCasesPage(string page)
        {
            switch (page)
            {
                case "Cases": Page.Cases.VerifyCasesisDiplayedinH1tag().Should().BeTrue(); break;
                case "Services": Page.Services.VerifyCasesisDiplayedinH1tag().Should().BeTrue(); break;
                case "Jobs": Page.Jobs.VerifyCasesisDiplayedinH1tag().Should().BeTrue(); break;
            }
        }
        [When(@"I Click Globe Icon")]
        public void WhenIClickGlobeIcon()
        {
            Page.HomePage.ClickGlobeIcon();
        }

        [Then(@"User is navigated to Contact page and (.*) offices are displayed")]
        public void ThenUserIsNavigatedToContactPageAndOfficesAreDisplayed(int OfficeCount)
        {
             Page.Contact.GetOfficeCount().Should().Be(OfficeCount);
        }



    }
}
