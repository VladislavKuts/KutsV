using Should;
using System;
using TechTalk.SpecFlow;

namespace Facebook
{
    [Binding]
    public class MainPageFBSteps : MainPageFB
    {
        FacebookPage dribling = new FacebookPage();
        [Given(@"Main page is opened")]
        public void GivenMainPageIsOpened()
        {
            OpenRegistrationPage();
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

        [When(@"I input '(.*)' in email field")]
        public void WhenIInputInEmailField2Test(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Link Profile is clickable'")]
        public void LinkProfileisclickable(bool visibility)
        {
            var res = new FacebookPage().TapsOnProfile();
            res.ShouldEqual(visibility);
        }

        [Then(@"Error message for email field is equals '(.*)'")]
        public void ThenErrorMessageForEmailFieldIsEquals(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}