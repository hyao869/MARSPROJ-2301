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
    public class ProfileFeatureStepDefinitions : CommonDriver
    {
        // Login page object initialization and definition
        LoginPage loginPageObj = new LoginPage();
        //Profile page object initialization and definiton
        ProfilePage profilePageObj = new ProfilePage();
        //Education tab object initialization and definiton
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
            profilePageObj.GoToEducationTab(driver);
        }

        [When(@"create new education record with '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)'")]
        public void WhenCreateNewEducationRecordWith(string instituteName, string country, string title, string degree, string year)
        {
            educationTabObj.AddNewEducaion(driver, instituteName, country, title, degree, year);
        }

        [Then(@"The record should be added successfully '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)'")]
        public void ThenTheRecordShouldBeAddedSuccessfully(string instituteName, string country, string title, string degree, string year)
        {
            string newInstituteName = educationTabObj.GetInstituteName(driver);            
            string newDegreeName = educationTabObj.GetDegreeName(driver);
            Debug.WriteLine(newInstituteName);
            Debug.WriteLine(newDegreeName);

            //Assert.That(addNewBtn.Text == "", "Actual code and expected code do not match.");
            Assert.That(newInstituteName == "AUT", "Actual institute name and expected name do not match.");
            Assert.That(newDegreeName == "Science", "Actual degree name and expected degree do not match.");
        }

     
        [When(@"Edit '([^']*)', '([^']*)', '([^']*)'on an exsiting education record")]
        public void WhenEditOnAnExsitingEducationRecord(string institute, string degree, string year)
        {
            educationTabObj.EditEducaion(driver, institute, degree, year);
        }


        [Then(@"The record should have been modified to '([^']*)', '([^']*)', '([^']*)'")]
        public void ThenTheRecordShouldHaveBeenModifiedTo(string institute, string degree, string year)
        {
            string editedinstituteName = educationTabObj.GetEditedInstituteName(driver);
            string editedDegree = educationTabObj.GetEditedDegreeName(driver);
            string editedYear = educationTabObj.GetEditedYear(driver);

            Assert.That(editedinstituteName == institute, "Actual institute name and expected name do not match.");
            Assert.That(editedDegree == degree, "Actual degree and expected degree do not match.");
            Assert.That(editedYear == year, "Actual graduate year and expected year do not match.");
        }

      
        [When(@"delete an existing education record")]
        public void WhenDeleteAnExistingEducationRecord()
        {
            educationTabObj.DeleteEducaion(driver);
        }

        [Then(@"The record should be deleted successfully")]
        public void ThenTheRecordShouldBeDeletedSuccessfully()
        {
            educationTabObj.deleteValidation(driver);
        }
      
        [AfterScenario]
        public void AfterScenarioCleanup()
        {
            CloseTestRun();
        }
    }
}
