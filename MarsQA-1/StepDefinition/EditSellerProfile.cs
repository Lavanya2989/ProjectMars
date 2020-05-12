using MarsQA_1.Helpers;
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
            //Click Edit button
            Driver.driver.FindElement(By.XPath("//td[@class='right aligned']//span[@class='button']//i[@class='outline write icon']")).Click();
         
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

        }

              
       [Then(@"Seller clicked update button")]
        public static void ThenSellerClickedUpdateButton()
        {
            Driver.driver.FindElement(By.XPath("//input[@value='Update']")).Click();
            Console.WriteLine("Language has been updated");
        }


    }
}
