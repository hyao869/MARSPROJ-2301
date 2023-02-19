using System;
using TechTalk.SpecFlow;

namespace SkillsTest.StepDefinitions
{
    [Binding]
    public class DescriptionStepDefinitions
    {
        [When(@"user navigate to description tab")]
        public void WhenUserNavigateToDescriptionTab()
        {
            throw new PendingStepException();
        }

        [When(@"add seller description with max (.*) characters")]
        public void WhenAddSellerDescriptionWithMaxCharacters(int p0)
        {
            throw new PendingStepException();
        }

        [Then(@"The new description should be displayed successfully")]
        public void ThenTheNewDescriptionShouldBeDisplayedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"edit an existing description")]
        public void WhenEditAnExistingDescription()
        {
            throw new PendingStepException();
        }

        [Then(@"The description should be updated successfully")]
        public void ThenTheDescriptionShouldBeUpdatedSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
