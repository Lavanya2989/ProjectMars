using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Scope(Scenario = "Edit Skill entered by seller")]
    public class AddingSellerProfileDetailsSteps
    {
        [Given(@"Clicked Skill and pressed edit button")]
        public static void GivenClickedSkillAndPressedEditButton()
        {
            Driver.TurnOnWait();
            //Select skill
            Driver.driver.FindElement(By.XPath("//a[@data-tab='second']")).Click();
            //Click edit
            Driver.driver.FindElement(By.XPath("//div[@data-tab='second']//table//tbody[last()]//tr//td[3]//i[@class='outline write icon']")).Click();
        }
        
        [When(@"Seller updated skill and level")]
        public static void WhenSellerUpdatedSkillAndLevel()
        {
            //Update skill
            Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Skill']")).Clear();
            Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Skill']")).SendKeys("Selenium");
            //Update level
            Driver.driver.FindElement(By.XPath("//select//option[@value='Beginner']")).Click();
            //Press update
            Driver.driver.FindElement(By.XPath("//input[@value='Update']")).Click();
        }
        
        [Then(@"Pop up will show Skill has been added")]
        public static void ThenPopUpWillShowSkillHasBeenAdded()
        {
            Thread.Sleep(1000);
            String addMessage = Driver.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']//div")).Text;
            String expectedAddMessage = "Selenium has been updated to your skills";
            Assert.AreEqual(addMessage, expectedAddMessage);
        }
    }
}
