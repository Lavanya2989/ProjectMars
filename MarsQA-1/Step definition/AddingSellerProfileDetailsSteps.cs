using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AddingSellerProfileDetailsSteps
    {
        private IWebDriver _driver;
        public AddingSellerProfileDetailsSteps(IWebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"Select Langauge and Click Add new")]
        public void GivenSelectLangaugeAndClickAddNew()
        {
            Thread.Sleep(15000);
            //Select Languages
            _driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")).Click();
            //click add new
            _driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
        }
        
        [Given(@"Seller have entered Language and level")]
        public void GivenSellerHaveEnteredLanguageAndLevel()
        {
            //Add language
            _driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")).SendKeys("English");
            //select level
            _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")).Click();
        }
        [When(@"Seller pressed add")]
        public void WhenSellerPressedAdd()
        {
            //Save by clicking add
            _driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")).Click();
        }
        [Then(@"the pop up shows language has been added")]
        public void ThenThePopUpShowsLanguageHasBeenAdded()
        {
            Console.WriteLine("Language has been added");
        }
        [Given(@"Select Skill and Click add new")]
        public void GivenSelectSkillAndClickAddNew()
        {
            //Select skill
            _driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();
            //Click add new
            _driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
        }
        
        [Given(@"Seller have entered Skill and level")]
        public void GivenSellerHaveEnteredSkillAndLevel()
        {
           // Add skill
            _driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input")).SendKeys("Java");
            //Select level
            _driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")).Click();
        }
        
             
        [When(@"Seller pressed add button")]
        public void WhenSellerPressedAddButton()
        {
            //Save by clicking add
            _driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();
        }
        
            
        [Then(@"the pop up shows skill has been added")]
        public void ThenThePopUpShowsSkillHasBeenAdded()
        {
            Console.WriteLine("Skill has been added");
        }
    }
}
