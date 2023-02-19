using System;
using TechTalk.SpecFlow;

namespace SkillsTest.StepDefinitions
{
    [Binding]
    public class CertificationsStepDefinitions
    {
        [When(@"user navigate to Certifications tab")]
        public void WhenUserNavigateToCertificationsTab()
        {
            throw new PendingStepException();
        }

        [When(@"add new '([^']*)' , '([^']*)', '([^']*)'")]
        public void WhenAddNew(string certificate, string from, string year)
        {
            throw new PendingStepException();
        }

        [Then(@"The new Certificate should be added")]
        public void ThenTheNewCertificateShouldBeAdded()
        {
            throw new PendingStepException();
        }

        [When(@"update an existing record with '([^']*)' , '([^']*)', '([^']*)'")]
        public void WhenUpdateAnExistingRecordWith(string certificate, string certifiedFrom, string year)
        {
            throw new PendingStepException();
        }

        [Then(@"The existing Certificate should be updated successfully")]
        public void ThenTheExistingCertificateShouldBeUpdatedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"delete an existing Certificate")]
        public void WhenDeleteAnExistingCertificate()
        {
            throw new PendingStepException();
        }

        [Then(@"The selected Certificate should be deleted successfully")]
        public void ThenTheSelectedCertificateShouldBeDeletedSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
