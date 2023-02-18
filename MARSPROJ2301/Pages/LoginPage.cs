using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SkillsTest.Pages
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();

            //launch website
            string baseURL = "http://localhost:5000";
            driver.Navigate().GoToUrl(baseURL);

            //identify signin button
            IWebElement SignInBtn = driver.FindElement(By.PartialLinkText("Sign")); //By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a")
            SignInBtn.Click();    

            //identify email address textbox and enter email
            IWebElement email = driver.FindElement(By.Name("email"));
            email.SendKeys("heatheryaoh@gmail.com");

            //identify password textbox and enther password
            IWebElement psw = driver.FindElement(By.Name("password"));
            psw.SendKeys("P4ssW0rd3523");

            //login button, click a button by text
            IWebElement loginBtn = driver.FindElement(By.XPath("//button[contains(text(), 'Login')]"));
            loginBtn.Click();

        }
    }
}
