using NUnit.Framework;
using SeleniumDonetCoreTest.Loginpage;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumDonetCoreTest.LoginSteps
{
   
    [Binding]
    
    class LoginSteps : DriverHelpler
    {
        LoginPage loginpage;
        public LoginSteps() //constructor
        {

            loginpage = new LoginPage(driver);
        }

        [Given(@"Enter username and password")]
        public void GivenEnterusernameandpassword(Table table)
        {
            driver = Hooks1.driver;
             dynamic data = table.CreateDynamicInstance();
            loginpage.Login((string)data.UserName, (string)data.Password);

        }

        [Then(@"I click login button")]
        public void ThenIClickLoginButton()
        {
            
            loginpage.selectlogin();

        }

        [Then(@"I should see logout link")]
        public void ThenIShouldSeeLogoutLink()
        {
            
            Assert.That(loginpage.lnklogoutexist(), Is.True);
        }


    }
}
