using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinition
{
    [Scope(Scenario = "Add Education done by seller")]
    class AddingSellerEducation
    {
        [Given(@"Clicked Education in home page and pressed add new")]
        public static void GivenClickedEducationInHomePageAndPressedAddNew()
        {
            Driver.TurnOnWait();
            Thread.Sleep(10000);
            //Click Education
            Driver.driver.FindElement(By.XPath("//a[@data-tab='third']")).Click();
            //Click add new
            Driver.driver.FindElement(By.XPath("(//div[contains(text(),'Add New')])[3]")).Click();
        }



        [When(@"Entered education details and pressed add")]
        public static void WhenEnteredEducationDetailsAndPressedAdd()
        {
            Driver.TurnOnWait();
            //Add college name
            Driver.driver.FindElement(By.XPath("//input[@placeholder='College/University Name']")).SendKeys("Abcdef");
            //Add Country of college
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown']//option[@value='Algeria']")).Click();
            //Add Title of Degree
            Driver.driver.FindElement(By.XPath("//select[@name='title']//option[@value='B.Tech']")).Click();
            //Add Degree
            Driver.driver.FindElement(By.XPath("//input[@name='degree']")).SendKeys("CSC");
            //Year of Education
            Driver.driver.FindElement(By.XPath("//select[@name='yearOfGraduation']//option[@value='2015']")).Click();
            //Click Add
            Driver.driver.FindElement(By.XPath("//input[@value='Add']")).Click();
        }

        [Then(@"Pop will show Education has been added")]
        public static void ThenPopWillShowEducationHasBeenAdded()
        {
            Thread.Sleep(1000);
            String addMessage = Driver.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']//div")).Text;
            String expectedAddMessage = "Education has been added";
            Assert.AreEqual(addMessage, expectedAddMessage);
        }
    }
}
