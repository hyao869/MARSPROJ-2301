using System;
using TechTalk.SpecFlow;

namespace SkillsTest.StepDefinitions
{
    [Binding]
    public class LanguagesStepDefinitions
    {
        [When(@"Seller navigates to Language Tab")]
        public void WhenSellerNavigatesToLanguageTab()
        {
            throw new PendingStepException();
        }

        [When(@"Seller enters Language '([^']*)' and Level '([^']*)'")]
        public void WhenSellerEntersLanguageAndLevel(string language, string level)
        {
            throw new PendingStepException();
        }

        [Then(@"The Language and Level were entered as '([^']*)' and '([^']*)'")]
        public void ThenTheLanguageAndLevelWereEnteredAsAnd(string language, string level)
        {
            throw new PendingStepException();
        }

        [When(@"user navigate to language tab")]
        public void WhenUserNavigateToLanguageTab()
        {
            throw new PendingStepException();
        }

        [When(@"edit an existing language")]
        public void WhenEditAnExistingLanguage()
        {
            throw new PendingStepException();
        }

        [Then(@"The existing language should be updated successfully")]
        public void ThenTheExistingLanguageShouldBeUpdatedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"delete an existing language")]
        public void WhenDeleteAnExistingLanguage()
        {
            throw new PendingStepException();
        }

        [Then(@"The selected language should be deleted successfully")]
        public void ThenTheSelectedLanguageShouldBeDeletedSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
