using MARS_ADV_Task.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using DataTable = System.Data.DataTable;

namespace MARS_ADV_Task.Pages
{
    internal class Loginpage : Commondriver
    {
       

        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement emailAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[2]/input")]
        public IWebElement passWord { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[4]/button")]
        public IWebElement loginButton { get; set; }
       
        [FindsBy(How = How.XPath, Using = "//*[@id='home']/div/div/div[1]/div/a")]
        public IWebElement signInButton { get; set; }

        string xSignInButton = "//*[@id='home']/div/div/div[1]/div/a";
        public void Loginsteps()
        {
            //Open Mars web page
            driver.Navigate().GoToUrl("http://localhost:5000/");

            var Homepageobj = new Homepage();
            PageFactory.InitElements(driver, Homepageobj);

            Wait.WaitForvisible(driver, "XPath", xSignInButton, 3);
            signInButton.Click();
            readCredential();
            loginButton.Click();
        }

        public void readCredential()
        {
            DataReaderExcel reader = new DataReaderExcel();
            DataTable dt = reader.readData();
            int i = 2;
            
            Wait.WaitForvisible(driver, "Name", "email", 4);
            emailAddress.SendKeys(dt.Rows[i][0].ToString());
            passWord.SendKeys(dt.Rows[i][1].ToString());
        }
    }
}