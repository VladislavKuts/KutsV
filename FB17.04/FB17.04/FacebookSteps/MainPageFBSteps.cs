using Facebook;
using System;
using TechTalk.SpecFlow;

namespace FB17._04.FacebookSteps
{
    [Binding]
    public class MainPageFBSteps : MainPageFB
    {
        FacebookPage dribling = new FacebookPage();
        [Given(@"Main page is opened")]
        public void GivenMainPageIsOpened()
        {
            OpenRegistrationPage();
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I input '(.*)' in email field")]
        public void WhenIInputInEmailField(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I input '(.*)' in password field")]
        public void WhenIInputInPasswordField(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on Submit button")]
        public void WhenIClickOnSubmitButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Visibility of SignOut link is '(.*)'")]
        public void ThenVisibilityOfSignOutLinkIs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
