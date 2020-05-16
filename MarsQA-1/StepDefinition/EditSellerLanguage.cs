using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.Step_definition
{
    [Scope(Scenario = "Edit language")]
    class EditSellerProfile
    {
        [Given(@"Click Edit button")]
        public static void GivenClickEditButton()
        {
            Thread.Sleep(15000);
            Driver.TurnOnWait();
            //Click Edit button
            Driver.driver.FindElement(By.XPath("//div[@data-tab='first']//table//tbody[last()]//tr//td[3]//i[@class='outline write icon']")).Click();

        }

        [When(@"Seller have updated Language and level")]
        public static void WhenSellerHaveUpdatedLanguageAndLevel()
        {

            //clear language
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @placeholder='Add Language']")).Clear();
            //Enter language
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @placeholder='Add Language']")).SendKeys("French");
            //Enter level
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown']")).Click();
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown']//option[@value='Conversational']")).Click();
            //Press add
            Driver.driver.FindElement(By.XPath("//input[@value='Update']")).Click();

        }

        [Then(@"Pop up will show Language has been updated")]
        public static void ThenPopUpWillShowLanguageHasBeenUpdated()
        {
            Thread.Sleep(1000);
            String addMessage = Driver.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']//div")).Text;
            String expectedAddMessage = "French has been updated to your languages";
            Assert.AreEqual(addMessage, expectedAddMessage);
        }

    }
}
