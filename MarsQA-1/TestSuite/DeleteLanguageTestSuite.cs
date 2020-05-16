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
    [Scope(Scenario = "Delete language")]
    class DeleteLanguageTestSuite : Driver
    {
        [Given]
        public void GivenClickDeleteButton()
        {
            DeleteSellerProfile.GivenClickDeleteButton();
        }

        [Then]
        public static void ThenPopUpWillShowDeleted()
        {
            DeleteSellerProfile.ThenPopUpWillShowDeleted();
        }
    }
}
