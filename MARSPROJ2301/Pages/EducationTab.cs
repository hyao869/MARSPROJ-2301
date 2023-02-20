using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SkillsTest.Utilities;
using NUnit.Framework;
using System.Diagnostics;

namespace SkillsTest.Pages
{
    public class EducationTab : CommonDriver
    {
        // add new
        private IWebElement addNewBtn => driver.FindElement(By.XPath("//div/table/thead/tr/th[6]/div"));
        private IWebElement instituteTextbox => driver.FindElement(By.Name("instituteName"));
        private IWebElement countryName => driver.FindElement(By.Name("country"));
        private IWebElement degreeTextbox => driver.FindElement(By.Name("degree"));
        private IWebElement addBtn => driver.FindElement(By.XPath("//input[@value='Add']"));

        //get new
        private IWebElement newInstituteName => driver.FindElement(By.XPath("//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[2]"));
        private IWebElement newCountryName => driver.FindElement(By.XPath("//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[1]"));
        private IWebElement newTitleName => driver.FindElement(By.XPath("//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[3]"));
        private IWebElement newDegree => driver.FindElement(By.XPath("//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[4]"));
        private IWebElement gradYear => driver.FindElement(By.XPath("//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[5]"));
        private IWebElement updateBtn => driver.FindElement(By.XPath("//input[@value='Update']"));
        //get edited
        private IWebElement editedInstituteName => driver.FindElement(By.XPath("//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[2]"));
        private IWebElement editedDegreeName => driver.FindElement(By.XPath("//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[4]"));
        private IWebElement editedYear => driver.FindElement(By.XPath("//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[5]"));
        //remove
        private IWebElement removeIcon => driver.FindElement(By.XPath("//table/tbody/tr/td[6]/span[2]"));
        private IWebElement lastRecord => driver.FindElement(By.XPath("//form/div[4]/div/div[2]/div/table/tbody/tr"));

        public void AddNewEducaion(string institute, string country, string title, string degree, string year)
        {            
            addNewBtn.Click();
            instituteTextbox.SendKeys(institute);        
            countryName.Click();
            new SelectElement(driver.FindElement(By.Name("country"))).SelectByValue(country);
            new SelectElement(driver.FindElement(By.Name("title"))).SelectByValue(title);
            degreeTextbox.SendKeys(degree);
            new SelectElement(driver.FindElement(By.Name("yearOfGraduation"))).SelectByValue(year);        
            addBtn.Click();  
        }

        public string GetInstituteName()
        {
            Wait.WaitForElementToExist(driver, "XPath", "//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[2]", 5);      
            //Debug.WriteLine(newInstituteName.Text);
            return newInstituteName.Text;
        }

        public string GetCountryName()
        {
            Wait.WaitForElementToExist(driver, "XPath", "//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[1]", 5);
            return newCountryName.Text;
        }

        public string GetTtitleName()
        {
            Wait.WaitForElementToExist(driver, "XPath", "//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[3]", 5);          
            return newTitleName.Text;
        }

        public string GetDegreeName()
        {
            Wait.WaitForElementToExist(driver, "XPath", "//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[4]", 5);        
            //Debug.WriteLine(newDegree.Text);
            return newDegree.Text;
        }

        public string GetYear()
        {
            Wait.WaitForElementToExist(driver, "XPath", "//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[5]", 5);
            return gradYear.Text;
            //get { return gradYear.Text; }
        }

        public void EditEducaion(string institute, string degree, string year)
        {
            string newRecordCreated = GetInstituteName();

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

            instituteTextbox.Clear();
            instituteTextbox.SendKeys(institute);
            
            degreeTextbox.Clear();
            degreeTextbox.SendKeys(degree);
            
            //select new graduate year from dropdow list
            new SelectElement(driver.FindElement(By.Name("yearOfGraduation"))).SelectByValue(year);
            //new SelectElement(driver.FindElement(By.Name("country"))).SelectByValue("New Zealand");
            //new SelectElement(driver.FindElement(By.Name("title"))).SelectByValue("B.A");
            updateBtn.Click();
        }

        public string GetEditedInstituteName()
        {
            Wait.WaitForElementToExist(driver, "XPath", "//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[2]", 5);          
            return editedInstituteName.Text;
        }

        public string GetEditedDegreeName()
        {
            Wait.WaitForElementToExist(driver, "XPath", "//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[4]", 5);
            return editedDegreeName.Text;
        }

        public string GetEditedYear()
        {
            Wait.WaitForElementToExist(driver, "XPath", "//form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[5]", 5);
            return editedYear.Text;  //text? 
        }

        public void DeleteEducaion()
        {
            //delete, no confirmation is needed
            Wait.WaitForElementToExist(driver, "XPath", "//table/tbody/tr/td[6]/span[2]", 6);

            //if no education record exists, tbody is empty, delete icon cannot be located, should check total row number of the table first
            int iRowsCount = driver.FindElements(By.XPath("//form/div[4]/div/div[2]/div/table/tbody/tr")).Count;
            
            if (iRowsCount > 0)
            {
                removeIcon.Click();
            }
            else
            {
                Assert.Fail("No record here");
            }
        }

        //Valid delete
        public void deleteValidation()
        {           
            int iRowsCount = driver.FindElements(By.XPath("//form/div[4]/div/div[2]/div/table/tbody/tr")).Count;
            //Debug.WriteLine("iRowsCount : ", iRowsCount);

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
