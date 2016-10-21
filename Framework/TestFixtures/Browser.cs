using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace Framework.TestFixtures
{
   public  class Browser
    {
        public static IWebDriver Driver { get; set; }

        public static string Title
        {
            get { return Driver.Title; }
        }
        public static void Goto(string url)
        {
            if (Driver == null)
            {
                Initialize();
            }

            Driver.Navigate().GoToUrl(url);
            Maximize();
        }

        public static void Close()
        {
            if (Driver == null)
            {
                return;
            }
            Driver.Quit();
            Driver = null;
        }

        public static void Initialize(string inputConfig = null)
        {
            //C:\Program Files\Mozilla Firefox
            var pathToBinary = @"C:\\Program Files\\Mozilla Firefox\\firefox.exe";
            FirefoxBinary ffBinary = new FirefoxBinary(pathToBinary);
            FirefoxProfile firefoxProfile = new FirefoxProfile();
            Driver = new FirefoxDriver(ffBinary, firefoxProfile);
            Maximize();
        }

        #region Private methods
        private static void Maximize()
        {
            Driver.Manage().Window.Maximize();
        }

        #endregion

    }
}
