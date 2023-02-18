using OpenQA.Selenium;
using SkillsTest.Utilities;


namespace SkillsTest.Pages
{
    public class ProfilePage
    {
        public void GoToEducationTab (IWebDriver driver) {

            Wait.WaitForElementToExist(driver, "LinkText", "Education", 15);

            //Thread.Sleep(6000);
            IWebElement educationtab = driver.FindElement(By.LinkText("Education"));
            educationtab.Click();
        }

        public void GoToLanguageTab(IWebDriver driver)
        {
            Wait.WaitForElementToExist(driver, "LinkText", "Languages", 15);

            IWebElement educationtab = driver.FindElement(By.LinkText("Languages"));
            educationtab.Click();
        }

        public void GoToDescription(IWebDriver driver)
        {
            Wait.WaitForElementToExist(driver, "XPath", "//h3[contains(text(), \"Description\")]/span/i", 6);

            IWebElement educationtab = driver.FindElement(By.XPath("//h3[contains(text(), \"Description\")]/span/i"));
            educationtab.Click();
        }
    }
}
