using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SkillsTest.Utilities;
using NUnit.Framework;
using System.Diagnostics;

namespace SkillsTest.Pages
{
    public class EducationTab
    {
        public void AddNewEducaion(IWebDriver driver, string institute, string country, string title, string degree, string year)
        {
            // click 'Add New' button
            IWebElement addNewBtn = driver.FindElement(By.XPath("//div/table/thead/tr/th[6]/div"));
            addNewBtn.Click();

            //Assert a button present, Assert a button enabled or disabled
            IWebElement instituteName = driver.FindElement(By.Name("instituteName"));
            instituteName.SendKeys(institute);

            IWebElement countryName = driver.FindElement(By.Name("country"));
            countryName.Click();
            new SelectElement(driver.FindElement(By.Name("country"))).SelectByValue(country);

            new SelectElement(driver.FindElement(By.Name("title"))).SelectByValue(title);

            IWebElement degreeName = driver.FindElement(By.Name("degree"));
            degreeName.SendKeys(degree);
            new SelectElement(driver.FindElement(By.Name("yearOfGraduation"))).SelectByValue(year);

            IWebElement addBtn = driver.FindElement(By.XPath("//input[@value='Add']"));
            addBtn.Click();  

        }

        public string GetInstituteName(IWebDriver driver)
        {
            Wait.WaitForElementToExist(driver, "XPath", "//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[2]", 5);
            //colume 2
            IWebElement instituteName = driver.FindElement(By.XPath("//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[2]"));
            Debug.WriteLine(instituteName.Text);
            return instituteName.Text;
        }

        public string GetCountryName(IWebDriver driver)
        {
            Wait.WaitForElementToExist(driver, "XPath", "//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[1]", 5);
            //colume 1
            IWebElement countryName = driver.FindElement(By.XPath("//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[1]"));
            return countryName.Text;
        }

        public string GetTtitleName(IWebDriver driver)
        {
            Wait.WaitForElementToExist(driver, "XPath", "//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[3]", 5);
            //column 3
            IWebElement titleName = driver.FindElement(By.XPath("//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[3]"));
            return titleName.Text;
        }

        public string GetDegreeName(IWebDriver driver)
        {
            Wait.WaitForElementToExist(driver, "XPath", "//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[4]", 5);
            //column 4
            IWebElement degree = driver.FindElement(By.XPath("//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[4]"));
            Debug.WriteLine(degree.Text);
            return degree.Text;
        }

        public string GetYear(IWebDriver driver)
        {
            Wait.WaitForElementToExist(driver, "XPath", "//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[5]", 5);
            //column 5
            IWebElement gradYear = driver.FindElement(By.XPath("//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[5]"));
            return gradYear.Text;
        }

        public void EditEducaion(IWebDriver driver, string institute, string degree, string year)
        {
            string newRecordCreated = GetInstituteName(driver);

            //check record exist before edit it, avoid affecting other records
            if (newRecordCreated == "AUT")   
            {
                //Assert a button present, Assert a button enabled or disabled
                driver.FindElement(By.XPath("//table/tbody/tr/td[6]/span[1]")).Click();
            }
            else
            {
                Assert.Fail("Record to be edited hasn't been found, education record not edited");
            }

            //edit institute textbox
            IWebElement instituteTextbox = driver.FindElement(By.Name("instituteName"));
            instituteTextbox.Clear();
            instituteTextbox.SendKeys(institute);
            
            //edit degree textbox
            IWebElement degreeTextbox = driver.FindElement(By.Name("degree"));
            degreeTextbox.Clear();
            degreeTextbox.SendKeys(degree);
            
            //select new graduate year from dropdow list
            new SelectElement(driver.FindElement(By.Name("yearOfGraduation"))).SelectByValue(year);

            //new SelectElement(driver.FindElement(By.Name("country"))).SelectByValue("New Zealand");
            //new SelectElement(driver.FindElement(By.Name("title"))).SelectByValue("B.A");

            //click edit button
            IWebElement addNewBtn = driver.FindElement(By.XPath("//input[@value='Update']"));
            addNewBtn.Click();
        }

        public string GetEditedInstituteName(IWebDriver driver)
        {
            Wait.WaitForElementToExist(driver, "XPath", "//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[2]", 5);
            IWebElement editedInstituteName = driver.FindElement(By.XPath("//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[2]"));
            return editedInstituteName.Text;
        }

        public string GetEditedDegreeName(IWebDriver driver)
        {
            Wait.WaitForElementToExist(driver, "XPath", "//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[4]", 5);
            IWebElement editedDegreeName = driver.FindElement(By.XPath("//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[4]"));
            return editedDegreeName.Text;
        }

        public string GetEditedYear(IWebDriver driver)
        {
            Wait.WaitForElementToExist(driver, "XPath", "//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[5]", 5);
            IWebElement editedYear = driver.FindElement(By.XPath("//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[5]"));
            return editedYear.Text;  //text? 
        }

        public void DeleteEducaion(IWebDriver driver)
        {
            //delete, no confirmation is needed
            Wait.WaitForElementToExist(driver, "XPath", "//table/tbody/tr/td[6]/span[2]", 6);

            //if no education record exists, tbody is empty, delete icon cannot be located, should check total row number of the table first
            int iRowsCount = driver.FindElements(By.XPath("//form/div[4]/div/div[2]/div/table/tbody/tr")).Count;
            
            if (iRowsCount > 0)
            {
                IWebElement removeIcon = driver.FindElement(By.XPath("//table/tbody/tr/td[6]/span[2]"));
                removeIcon.Click();
            }
            else
            {
                Assert.Fail("No record here");
            }
        }

        //Valid delete
        public void deleteValidation(IWebDriver driver)
        {
            IWebElement lastRecord = driver.FindElement(By.XPath("//form/div[4]/div/div[2]/div/table/tbody/tr"));
           
            int iRowsCount = driver.FindElements(By.XPath("//form/div[4]/div/div[2]/div/table/tbody/tr")).Count;
            Debug.WriteLine("iRowsCount : ", iRowsCount);

            if (iRowsCount == 0 ||lastRecord.Text == "" || lastRecord.Text != "MIT")
            {
                Assert.Pass("Record has been deleted successfully ");
            }
            else
            {
                Assert.Fail("Record hasn't been deleted");
            }
        }
    }
}
