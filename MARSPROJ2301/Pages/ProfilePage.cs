using OpenQA.Selenium;
using SkillsTest.Utilities;


namespace SkillsTest.Pages
{
    
    public class ProfilePage : CommonDriver
    {
        IWebElement educationtab => driver.FindElement(By.LinkText("Education"));
        IWebElement languagetab => driver.FindElement(By.LinkText("Languages"));
        IWebElement description => driver.FindElement(By.XPath("//h3[contains(text(), \"Description\")]/span/i"));
        public void GoToEducationTab () {

            Wait.WaitForElementToExist(driver, "LinkText", "Education", 15);
            educationtab.Click();
        }

        public void GoToLanguageTab()
        {
            Wait.WaitForElementToExist(driver, "LinkText", "Languages", 15);
            languagetab.Click();
        }

        public void GoToDescription()
        {
            Wait.WaitForElementToExist(driver, "XPath", "//h3[contains(text(), \"Description\")]/span/i", 6);
            description.Click();
        }
    }
}
