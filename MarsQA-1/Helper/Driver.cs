using BoDi;
using MarsQA_1.Feature;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1.Helpers
{
    [Binding]
    class Driver
    {
     public static IWebDriver driver { get; set; }
        #region Before Scenario
        [BeforeScenario]
        public static void SetUp()
        {
            //Defining the browser
            driver = new ChromeDriver();
            Login.GivenLoginToTheWebsite();
            Login.WhenIEnterValidUsernameAndPassword();
        }
        #endregion
        #region wait
        public static void TurnOnWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }
        #endregion
        #region AfterScenario
        [AfterScenario]
         //Close the browser
        public void Close()
        {
            driver.Quit();
        }

    }
    #endregion
}
