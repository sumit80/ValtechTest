using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.TestFixtures;
using TechTalk.SpecFlow;

namespace Tests.StepDefinitions
{
    [Binding]
    public class FeatureBase
    {
        [BeforeTestRun]
        public static void StartExecution()
        {
            Browser.Initialize();
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Browser.Close();
        }
    }
}
