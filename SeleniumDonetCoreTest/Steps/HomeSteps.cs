using System;
using System.Collections.Generic;
using System.Text;
using SeleniumDonetCoreTest.HomePages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumDonetCoreTest.Steps
{
    [Binding]

    class HomeSteps:DriverHelpler
    {
        Homepage homepage;
        public HomeSteps() //constructor
        {
            driver = Hooks1.driver;
            homepage = new Homepage(driver);
        }

        [Then(@"Select Title")]
        public void ThenSelectTitle()
        {
           
            homepage.titledropdown();

        }

        [Then(@"Enter name")]
        public void ThenEnterName(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            homepage.entername((String)data.Initial, (String)data.Firstname, (String)data.Middlename);
        }

        [Then(@"Select gender")]
        public void ThenSelectGender()
        {
            homepage.genderoption();
        }

        [Then(@"Select save button")]
        public void ThenSelectSaveButton()
        {
            homepage.savebutton();
            
        }


    }
}
