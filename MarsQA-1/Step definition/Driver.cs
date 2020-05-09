using BoDi;
using MarsQA_1.Feature;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1.Helpers
{
    [Binding]
    public class Driver
    {
        private readonly IObjectContainer _objectContainer;

        private IWebDriver _driver;
        public Driver(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }
        [BeforeScenario]
        public void Initialize()
        {
            //Defining the browser
            _driver = new ChromeDriver();
            _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
            //Maximise the window
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://192.168.99.100:5000");
            Login loginobj = new Login(_driver);
            loginobj.WhenIEnterValidUsernameAndPassword();
        }
                 
        [AfterScenario]
         //Close the browser
        public void Close()
        {
            _driver.Quit();
        }

    }
}
