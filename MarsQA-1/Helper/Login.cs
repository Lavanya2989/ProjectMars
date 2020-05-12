using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class Login
    {
        
        [Given(@"Login to the website")]
        public static void GivenLoginToTheWebsite()
        {
            //Enter Url
           Driver.driver.Navigate().GoToUrl("http://192.168.99.100:5000");
            //Maximise the window
            Driver.driver.Manage().Window.Maximize();
        }
        
        [When(@"I enter valid username and password")]
        public static void WhenIEnterValidUsernameAndPassword()
        {
            //Enter sign in
           Driver.driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a")).Click();
            //Enter Username
            Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input")).SendKeys("abc@abc.com");

            //Enter password
           Driver. driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input")).SendKeys("marstest");
            //Click on Login Button
            Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button")).Click();
        }
        
        [Then(@"I should be at the homepage")]
        public static void ThenIShouldBeAtTheHomepage()
        {
            Thread.Sleep(10000);
            //validate seller logged in
            Assert.That(Driver.driver.FindElement(By.XPath("//div[@class='title' and contains(text(),'Lavanya Rajendran')]")).Text, Is.EqualTo("Lavanya Rajendran"));
        }
    }
}
