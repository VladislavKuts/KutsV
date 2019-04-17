using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Facebook
{
    [Binding]
    public class PreAndPostCondition
    {
        [BeforeScenario]
        public static void BeforeTestRun()
        {
            IWebDriver driver;

            driver = new ChromeDriver();
            ScenarioContext.Current["browser"] = driver;
            driver.Manage().Window.Maximize();

        }

        [AfterScenario]
        public static void CloseBrowser()
        {
            System.Threading.Thread.Sleep(4000);
            IWebDriver driver = (IWebDriver)ScenarioContext.Current["browser"];
            driver.Quit();
        }
    }
}