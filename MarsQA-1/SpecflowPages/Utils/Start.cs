using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;


namespace MarsQA_1.Utils
{
    [Binding]
    public class Start :Driver
    {
       
        [BeforeScenario]
        public void Setup()
        {
            //launch the browser
           Initialize();
            //call the SignIn class
            SignIn.Login();
         }
       public void Language()
        {
            Profile.Language();
        }
        public void Skill()
        {
            Profile.Skill();
        }
        [AfterScenario]
        public void TearDown()
        {
             
            //Close the browser
            Close();
             
         }
    }
}
