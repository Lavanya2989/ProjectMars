using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class Login
    {
        private IWebDriver _driver;
        public Login(IWebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"Login to the website")]
        public void GivenLoginToTheWebsite()
        {
             //Enter Url
            _driver.Navigate().GoToUrl("http://192.168.99.100:5000");
         }
        
        [When(@"I enter valid username and password")]
        public void WhenIEnterValidUsernameAndPassword()
        {
            //Enter sign in
            _driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a")).Click();
            //Enter Username
            _driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input")).SendKeys("abc@abc.com");

            //Enter password
            _driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input")).SendKeys("marstest");
            //Click on Login Button
            _driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button")).Click();
        }
        
        [Then(@"I should be at the homepage")]
        public void ThenIShouldBeAtTheHomepage()
        {
            Console.WriteLine("I logged in");
        }
    }
}
