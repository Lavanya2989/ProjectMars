using MarsQA_1.Feature;
using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1.Step_definition
{
    [Binding]
    [Scope(Scenario = "Add language known by seller")]
    class AddProfileTestSuite:Driver
    {
        [Given]
        public void GivenSelectLangaugeAndClickAddNew()
        {
            AddingSellerProfileDetailsSteps.GivenSelectLangaugeAndClickAddNew();
        }
        [When]
        public void WhenSellerHaveEnteredLanguageAndLevel()
        {
            AddingSellerProfileDetailsSteps.WhenSellerHaveEnteredLanguageAndLevel();
        }
        [Then]
        public void ThenSellerPressedAdd()
        {
            AddingSellerProfileDetailsSteps.ThenSellerPressedAdd();
        }
     }
}
