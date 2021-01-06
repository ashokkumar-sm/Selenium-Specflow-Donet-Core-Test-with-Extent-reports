using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SeleniumDonetCoreTest.Loginpage
{

    [Binding]
    class LoginPage:DriverHelpler
    {
        public LoginPage(IWebDriver driver)
        {
            driver = Hooks1.driver;

        }

        public IWebElement txtUserName => driver.FindElement(By.Name("UserName"));
        public IWebElement txtPassword => driver.FindElement(By.Name("Password"));
        public IWebElement BtnLogin => driver.FindElement(By.XPath("//input[@name='Login']"));

        public IWebElement LnkLogout => driver.FindElement(By.XPath("//span[text()='Logout']"));

        public void Login(string username, string password)
        {
            txtUserName.SendKeys(username);
            txtPassword.SendKeys(password);

        }

        public void selectlogin()
        {
            BtnLogin.Click();

        }

        public bool lnklogoutexist() => LnkLogout.Displayed;


    }


}
