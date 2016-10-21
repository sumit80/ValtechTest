using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Pages
{
    public class Cases
    {
        [FindsBy(How = How.XPath, Using = "//h1[text()='Cases']")]
        private IWebElement Pageheading;

        public bool VerifyCasesisDiplayedinH1tag()
        {
            return Pageheading.Displayed ? true : false;
        }

    }


}
