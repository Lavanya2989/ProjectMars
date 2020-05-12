using MarsQA_1.Helpers;
using MarsQA_1.Step_definition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1.TestSuite
{
    [Binding]
    [Scope(Scenario = "Edit language")]
    class EditTestSuite:Driver
    {
       [Given]
        public void GivenClickEditButton()
        {
           EditSellerProfile.GivenClickEditButton();
        }
        [When]
        public void WhenSellerHaveUpdatedLanguageAndLevel()
        {
            EditSellerProfile.WhenSellerHaveUpdatedLanguageAndLevel();
        }
        [Then]
        public void ThenSellerClickedUpdateButton()
        {
            EditSellerProfile.ThenSellerClickedUpdateButton();
        }
    }
}
