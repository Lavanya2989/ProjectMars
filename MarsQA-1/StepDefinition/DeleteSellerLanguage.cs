using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.Step_definition
{

    [Scope(Scenario = "Delete language")]
    class DeleteSellerProfile
    {
        
        [Given(@"Click delete button")]
        public static void GivenClickDeleteButton()
        {
            Driver.TurnOnWait();
            Thread.Sleep(15000);
            //Click delete button
            Driver.driver.FindElement(By.XPath("//div[@data-tab='first']//table//tbody[last()]//tr//td[3]//i[@class='remove icon']")).Click();
           
        }
        [Then(@"Pop up will show deleted")]
        public static void ThenPopUpWillShowDeleted()
        {
            Thread.Sleep(1000);
            String addMessage = Driver.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']//div")).Text;
            String expectedAddMessage = "French has been deleted from your languages";
            Assert.AreEqual(addMessage, expectedAddMessage);
        }

    }


}
