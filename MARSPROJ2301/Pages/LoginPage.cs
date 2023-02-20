using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SkillsTest.Utilities;

namespace SkillsTest.Pages
{
    public class LoginPage : CommonDriver
    {
        string baseURL = "http://localhost:5000";

        private IWebElement SignInBtn => driver.FindElement(By.PartialLinkText("Sign")); //By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a")
        private IWebElement emailTextbox => driver.FindElement(By.Name("email"));
        private IWebElement pswTextbox => driver.FindElement(By.Name("password"));
        private IWebElement loginBtn => driver.FindElement(By.XPath("//button[contains(text(), 'Login')]"));
        public void LoginActions(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();

            //launch website
            driver.Navigate().GoToUrl(baseURL);
            
            SignInBtn.Click();
            emailTextbox.SendKeys("heatheryaoh@gmail.com");
            pswTextbox.SendKeys("P4ssW0rd3523");
            loginBtn.Click();
        }
    }
}
