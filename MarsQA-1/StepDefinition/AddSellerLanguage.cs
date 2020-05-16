using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.FeatureFile
{
     [Scope(Scenario = "Add language known by seller")]
    class AddSellerLanguage
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

            //Save by clicking add
            Driver.driver.FindElement(By.XPath("//input[@value='Add']")).Click();
        }

        
        [Then(@"Pop up will show Language has been added")]
        public static void ThenPopUpWillShowLanguageHasBeenAdded()
        {
            Thread.Sleep(1000);
            String addMessage = Driver.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']//div")).Text;
            String expectedAddMessage = "English has been added to your languages";
            Assert.AreEqual(addMessage, expectedAddMessage);
        }


    }
}
