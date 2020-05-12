using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
     [Scope(Scenario = "Add language known by seller")]
    class AddingSellerProfileDetailsSteps
    {
        
         [Given(@"Select Langauge and Click Add new")]
        public static void GivenSelectLangaugeAndClickAddNew()
        {
            Driver.TurnOnWait();
            Thread.Sleep(15000);
            //Select Languages
            Driver.driver.FindElement(By.XPath("//a[@class='item active' and @data-tab='first']")).Click();
            Driver.TurnOnWait();
            //click add new
            Driver.driver.FindElement(By.XPath("//div[contains(text(),'Add New')][1]")).Click();
                
        }
        
       [When(@"Seller have entered Language and level")]
        public static void WhenSellerHaveEnteredLanguageAndLevel()
        {
            //Add language
            Driver.driver.FindElement(By.XPath("//input[@type='text'and@placeholder='Add Language']")).SendKeys("English");
            //select level
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown']")).Click();
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown']//option[@value='Fluent']")).Click();
        }

        [Then(@"Seller pressed add")]
        public static void ThenSellerPressedAdd()
        {

            //Save by clicking add
            Driver.driver.FindElement(By.XPath("//input[@value='Add']")).Click();
            Console.WriteLine("Language has been added");
        }

    }
}
