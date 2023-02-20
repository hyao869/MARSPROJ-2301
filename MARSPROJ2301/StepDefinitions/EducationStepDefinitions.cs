using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SkillsTest.Pages;
using SkillsTest.Utilities;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using TechTalk.SpecFlow;

namespace SkillsTest.StepDefinitions
{
    [Binding]
    public class EducationStepDefinitions : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        ProfilePage profilePageObj = new ProfilePage();
        EducationTab educationTabObj = new EducationTab();

        [Given(@"User logged into Mars successfully")]
        public void GivenUserLoggedIntoMarsSuccessfully()
        {
            driver = new ChromeDriver();

            loginPageObj.LoginActions(driver);
        }

        [When(@"user navigate to education tab")]
        public void WhenUserNavigateToEducationTab()
        {   
            profilePageObj.GoToEducationTab();
        }

        [When(@"create new education record with '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)'")]
        public void WhenCreateNewEducationRecordWith(string instituteName, string country, string title, string degree, string year)
        {
            educationTabObj.AddNewEducaion(instituteName, country, title, degree, year);
        }

        [Then(@"The record should be added successfully '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)'")]
        public void ThenTheRecordShouldBeAddedSuccessfully(string instituteName, string country, string title, string degree, string year)
        {
            string newInstituteName = educationTabObj.GetInstituteName();            
            string newDegreeName = educationTabObj.GetDegreeName();
            //Debug.WriteLine(newInstituteName);
            //Debug.WriteLine(newDegreeName);

            Assert.That(newInstituteName == "AUT", "Actual institute name and expected name do not match.");
            Assert.That(newDegreeName == "Science", "Actual degree name and expected degree do not match.");
        }

     
        [When(@"Edit '([^']*)', '([^']*)', '([^']*)'on an exsiting education record")]
        public void WhenEditOnAnExsitingEducationRecord(string institute, string degree, string year)
        {
            educationTabObj.EditEducaion(institute, degree, year);
        }


        [Then(@"The record should have been modified to '([^']*)', '([^']*)', '([^']*)'")]
        public void ThenTheRecordShouldHaveBeenModifiedTo(string institute, string degree, string year)
        {
            string editedinstituteName = educationTabObj.GetEditedInstituteName();
            string editedDegree = educationTabObj.GetEditedDegreeName();
            string editedYear = educationTabObj.GetEditedYear();

            Assert.That(editedinstituteName == institute, "Actual institute name and expected name do not match.");
            Assert.That(editedDegree == degree, "Actual degree and expected degree do not match.");
            Assert.That(editedYear == year, "Actual graduate year and expected year do not match.");
        }

      
        [When(@"delete an existing education record")]
        public void WhenDeleteAnExistingEducationRecord()
        {
            educationTabObj.DeleteEducaion();
        }

        [Then(@"The record should be deleted successfully")]
        public void ThenTheRecordShouldBeDeletedSuccessfully()
        {
            educationTabObj.deleteValidation();
        }
      
        [AfterScenario]
        public void AfterScenarioCleanup()
        {
             CloseTestRun();
        }
    }
}
