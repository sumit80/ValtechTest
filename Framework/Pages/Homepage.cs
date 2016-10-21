using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.TestFixtures;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Pages
{
    public class Homepage
    {
        private static string Url = "https://www.valtech.com/";
        private static string PageTitle = "Where Experiences are Engineered - Valtech";
        [FindsBy(How = How.XPath, Using = "//h2[text()='Latest news']")] 
        private IWebElement LatestNews;
        [FindsBy(How = How.XPath, Using = "//span[@id='navigation-toggle-button']")]
        private IWebElement Navigate;
        [FindsBy(How = How.XPath, Using = "//a[@title='Cases']")]
        private IWebElement Cases;
        [FindsBy(How = How.XPath, Using = "//a[@title='Services']")]
        private IWebElement Services;
        [FindsBy(How = How.XPath, Using = "//a[@title='Jobs']")]
        private IWebElement Jobs;
        [FindsBy(How = How.XPath, Using = "//a[@id='contacticon']")]
        private IWebElement ContactUs;

        public void Goto()
        {
            Browser.Goto(Url);
        }

        public bool IsAt()
        {
            Goto();
            return Browser.Driver.Title == PageTitle;
        }

        public bool VerifyLatestNewsExist()
        {
            return LatestNews.Displayed ? true : false;
        }

        public void NavigateTo(string page)
        {
            Navigate.Click();
            switch (page)
            {
                case "Cases": Cases.Click(); break;
                case "Services": Services.Click(); break;
                case "Jobs": Jobs.Click(); break;
            }

        }

        public void ClickGlobeIcon()
        {
            ContactUs.Click();
        }

    }
}
