using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AddingSellerProfileDetailsSteps
    {
        [Given(@"Select Langauge and Click Add new")]
        public void GivenSelectLangaugeAndClickAddNew()
        {
            Profile.Languages();
        }
        
        [Given(@"Seller have entered Language and level")]
        public void GivenSellerHaveEnteredLanguageAndLevel()
        {
            Profile.Languages();
        }
        
        [Given(@"Select Skill and Click add new")]
        public void GivenSelectSkillAndClickAddNew()
        {
            Profile.Skill(); 
        }
        
        [Given(@"Seller have entered Skill and level")]
        public void GivenSellerHaveEnteredSkillAndLevel()
        {
            Profile.Skill();
        }
        
        [When(@"Seller pressed add")]
        public void WhenSellerPressedAdd()
        {
            Profile.Languages();
        }
        
        [When(@"Seller pressed add button")]
        public void WhenSellerPressedAddButton()
        {
            Profile.Skill();
        }
        
        [Then(@"the pop up shows language has been added")]
        public void ThenThePopUpShowsLanguageHasBeenAdded()
        {
            Profile.Languages();
        }
        
        [Then(@"the pop up shows skill has been added")]
        public void ThenThePopUpShowsSkillHasBeenAdded()
        {
            Profile.Skill();
        }
    }
}
