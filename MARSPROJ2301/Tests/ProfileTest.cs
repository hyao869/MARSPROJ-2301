using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SkillsTest.Pages;
using NUnit.Framework;
using SkillsTest.Utilities;
using System.Diagnostics.Metrics;

namespace SkillsTest.Tests
{
    [TestFixture]
    public class ProfileTest : CommonDriver
    {
       [Test, Order(1), Description("check if user is able to create new education history with valid data")]
        public void CreatEducationTest()
        {
            //Profile page object initialization and definiton
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.GoToEducationTab(driver);
            //Education tab object initialization and definiton
            EducationTab educationTabObj = new EducationTab();
            //educationTabObj.AddNewEducaion(driver, institute, country, title, degree, year);

        }
        [Test, Order(2), Description("check if user is able to edit an exsiting education record")]
        public void EditEducationTest()
        {
            //Profile page object initialization and definiton
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.GoToEducationTab(driver);

            //Education tab object initialization and definiton
            EducationTab educationTabObj = new EducationTab();
            //educationTabObj.EditEducaion(driver);       //row number parameter?
        }
        [Test,Order(3), Description("check if user is able to delete an exsiting education record")]
        public void DeleteEducationTest() 
        {
            //Profile page object initialization and definiton
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.GoToEducationTab(driver);

            //Education tab object initialization and definiton
            EducationTab educationTabObj = new EducationTab();
            educationTabObj.DeleteEducaion(driver);     //row number parameter?
        }
    
        
    /*
 
    //verify username after login
    Thread.Sleep(5000);
    string username = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span")).Text;
    //Console.WriteLine(username);
    if (username == "Hi Heather") Console.WriteLine("--logged in successfully, test passed");
    else Console.WriteLine("-- login failed");

    */

        
    }
}
