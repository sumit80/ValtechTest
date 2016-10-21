using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Pages;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.TestFixtures
{
    public static class Page
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);

            return page;
        }
        public static Homepage HomePage
        {
            get
            {
                return GetPage<Homepage>();
            }
        }

        public static Cases Cases
        {
            get
            {
                return GetPage<Cases>();
            }
        }
        public static Services Services
        {
            get
            {
                return GetPage<Services>();
            }
        }

        public static Jobs Jobs
        {
            get
            {
                return GetPage<Jobs>();
            }
        }

        public static Contact Contact 
        {
            get
            {
                return GetPage<Contact>();
            }
        }
    }
}
