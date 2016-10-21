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
    public class Contact
    {
        

        public int GetOfficeCount()
        {
            return Browser.Driver.FindElements(By.XPath("//div[@id='contactbox']//li)")).Count;
        }
    }
}
