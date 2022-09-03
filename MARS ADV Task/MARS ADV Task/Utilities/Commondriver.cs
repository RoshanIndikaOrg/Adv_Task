using MARS_ADV_Task.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using TechTalk.SpecFlow;

namespace MARS_ADV_Task.Utilities
{
    [Binding]
    public class Commondriver
    {

        public static IWebDriver driver;

        [BeforeScenario]
        public static void LoginFunction()
        {
            driver = new ChromeDriver();
        }

        [AfterScenario]
        public static void AfterTestRun()
        {
           driver.Close();
           driver.Dispose();
        }

    }
}
    

    

