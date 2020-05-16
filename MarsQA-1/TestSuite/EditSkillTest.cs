using MarsQA_1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    [Scope(Scenario = "Edit Skill entered by seller")]
    class EditSkillTest:Driver
    {
        [Given]
        public void GivenClickedSkillAndPressedEditButton()
        {
            AddingSellerProfileDetailsSteps.GivenClickedSkillAndPressedEditButton();
        }
        [When]
        public void WhenSellerUpdatedSkillAndLevel()
        {
            AddingSellerProfileDetailsSteps.WhenSellerUpdatedSkillAndLevel();
        }
        [Then]
        public void ThenPopUpWillShowSkillHasBeenAdded()
        {
            AddingSellerProfileDetailsSteps.ThenPopUpWillShowSkillHasBeenAdded();
        }
    }
}
