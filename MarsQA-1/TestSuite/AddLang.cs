using MarsQA_1.FeatureFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    [Scope(Scenario = "Add language known by seller")]
    class AddLang
    {
        [Given]
        public void GivenSelectLangaugeAndClickAddNew()
        {
            AddSellerLanguage.GivenSelectLangaugeAndClickAddNew();
        }
        [When]
        public void WhenSellerHaveEnteredLanguageAndLevel()
        {
            AddSellerLanguage.WhenSellerHaveEnteredLanguageAndLevel();
        }
        [Then]
        public void ThenPopUpWillShowLanguageHasBeenAdded()
        {
            AddSellerLanguage.ThenPopUpWillShowLanguageHasBeenAdded();
        }
    }
}
