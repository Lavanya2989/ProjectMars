﻿using MarsQA_1.Helpers;
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
              Driver.driver.FindElement(By.XPath("//i[@class='remove icon']")).Click();
              Console.WriteLine("Pop up shows your language has neen deleted");
        }

    }

}