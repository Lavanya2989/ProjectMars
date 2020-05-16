using MarsQA_1.Helpers;
using MarsQA_1.StepDefinition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    [Scope(Scenario = "Add Education done by seller")]

    class EducationAdd :Driver
    {
     
        [Given]
        public void GivenClickedEducationInHomePageAndPressedAddNew()
        {
            AddingSellerEducation.GivenClickedEducationInHomePageAndPressedAddNew();
        }
        [When]
        public void WhenEnteredEducationDetailsAndPressedAdd()
        {
            AddingSellerEducation.WhenEnteredEducationDetailsAndPressedAdd();
        }
        [Then]
        public void ThenPopWillShowEducationHasBeenAdded()
        {
            AddingSellerEducation.ThenPopWillShowEducationHasBeenAdded();
        }
    }
}
