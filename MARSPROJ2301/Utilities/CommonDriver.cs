using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SkillsTest.Pages;
using TechTalk.SpecFlow;


namespace SkillsTest.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;   //parallelization, no static 

        [SetUp]
        //[OneTimeSetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();
            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);
        }

        [TearDown]
        //[OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.FindElement(By.XPath("//button[contains(text(), 'Sign Out')]")).Click();
            driver.Quit();
        }
    }
}
