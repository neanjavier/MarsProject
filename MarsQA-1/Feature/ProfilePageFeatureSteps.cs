using System;
using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class ProfilePageFeatureSteps : Driver
    {
        //page obj init
        HomePage homePageObj = new HomePage();
        ProfilePage profilePageObj = new ProfilePage();
        SignIn signInObj = new SignIn();


        [Given(@"I have logged into mars portal successfully")]
        public void GivenIHaveLoggedIntoMarsPortalSuccessfully()
        {
            //open browser
            driver = new ChromeDriver();

            //SignIn Page
            signInObj.SigninStep(driver);

            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have navigated to the profile page")]
        public void GivenIHaveNavigatedToTheProfilePage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have logged into turnup portal successfully")]
        public void GivenIHaveLoggedIntoTurnupPortalSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have navigated to the time and material page")]
        public void GivenIHaveNavigatedToTheTimeAndMaterialPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I add language record")]
        public void WhenIAddLanguageRecord()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I update '(.*)' and '(.*)' on an existing time and material record")]
        public void WhenIUpdateAndOnAnExistingTimeAndMaterialRecord(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be created successfully")]
        public void ThenTheResultShouldBeCreatedSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should have the updated '(.*)' and '(.*)'")]
        public void ThenTheResultShouldHaveTheUpdatedAnd(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
