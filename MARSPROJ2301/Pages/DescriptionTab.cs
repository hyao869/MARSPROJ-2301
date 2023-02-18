using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest.Pages
{
    public class DescriptionTab
    {
        public void AddDescription(IWebDriver driver) 
        {
            IWebElement textArea = driver.FindElement(By.Name("value"));
            textArea.Clear();
            string newDescription = "fLD.JGWE;OJFE;";
            textArea.SendKeys(newDescription);
        }
    }
}
