using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace SeleniumDonetCoreTest.HomePages
{
    class Homepage:DriverHelpler
    {

        public Homepage(IWebDriver driver)
        {
            driver = Hooks1.driver;

        }

        public IWebElement titledrop => driver.FindElement(By.XPath("//select[@name='TitleId']//option[@value='1']"));
        public IWebElement txtinitial => driver.FindElement(By.XPath("//input[@name='Initial']"));
        public IWebElement txtfirstname=> driver.FindElement(By.XPath("//input[@name='FirstName']"));
        public IWebElement txtmiddlename => driver.FindElement(By.XPath("//input[@name='MiddleName']"));

        public IWebElement optiongender => driver.FindElement(By.XPath("//input[@name='Female']"));
        public IWebElement btnsave => driver.FindElement(By.XPath("//input[@name='Save']"));

        public void titledropdown()
        {
            titledrop.Click();

        }

        public void entername(String Initial, String Firstname, String MiddleName)
        {

            txtinitial.SendKeys(Initial);
            txtfirstname.SendKeys(Firstname);
            txtmiddlename.SendKeys(MiddleName);

        }

        public void genderoption()
        {
            optiongender.Click();

        }


        public void savebutton()
        {
            btnsave.Click();

        }

    }
}
