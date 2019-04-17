using Facebook;
using OpenQA.Selenium;

namespace Facebook
{
    public class FacebookPage : SeleniumWrapper
    {
        internal static By Profile = By.XPath("/html/body/div[1]/div[2]/div/div[1]/div/div/div/div[2]/div[1]/div[1]/div/a/span/span");

        public bool IsProfileLinkVisible()
        {
            return IsElementVisible(Profile);
        }

        public void TapOnProfile()
        {
            FindElement(Profile).Click();
        }
    }
}