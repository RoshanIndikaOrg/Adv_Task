using AutoItX3Lib;
using MARS_ADV_Task.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MARS_ADV_Task.Pages
{
    internal class ShareSkills : Commondriver
    {

        IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section.nav-secondary > div > div.right.item > a")]
        public IWebElement shareSkillbutton { get; set; }

        [FindsBy(How = How.Name, Using = "title")]
        public IWebElement titleBox { get; set; }

        [FindsBy(How = How.Name, Using = "description")]
        public IWebElement descriptionBox { get; set; }

        [FindsBy(How = How.Name, Using = "categoryId")]
        public IWebElement categoryDropdownbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(3) > div.twelve.wide.column > div > div:nth-child(1) > select > option:nth-child(7)")]
        public IWebElement categoryOption { get; set; }

        [FindsBy(How = How.Name, Using = "subcategoryId")]
        public IWebElement subCategorybox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(3) > div.twelve.wide.column > div > div:nth-child(2) > div:nth-child(1) > select > option:nth-child(5)")]
        public IWebElement subCategoryOption { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(4) > div.twelve.wide.column > div > div > div > div > input")]
        public IWebElement tagsBox { get; set; }

        [FindsBy(How = How.Name, Using = "serviceType")]
        IList<IWebElement> serviceTypeRadioBtn;

        [FindsBy(How = How.Name, Using = "locationType")]
        IList<IWebElement> locationTypeRadioBtn;


        //Date selection block starts

        [FindsBy(How = How.Name, Using = "startDate")]
        public IWebElement startDateBox { get; set; }

        [FindsBy(How = How.Name, Using = "endDate")]
        public IWebElement endDateBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(2) > div:nth-child(2) > input[type=time]")]
        public IWebElement sundayStarttime { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(2) > div:nth-child(3) > input[type=time]")]
        public IWebElement sundayEndtime { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(3) > div:nth-child(2) > input[type=time]")]
        public IWebElement mondayStarttime { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(3) > div:nth-child(3) > input[type=time]")]
        public IWebElement mondayEndtime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service - listing - section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[2]/input")]
        public IWebElement tuesdayStarttime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service - listing - section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[3]/input")]
        public IWebElement tuesdayEndtime { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(5) > div:nth-child(2) > input[type=time]")]
        public IWebElement wednesdayStarttime { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(5) > div:nth-child(3) > input[type=time]")]
        public IWebElement wednesdayEndtime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service - listing - section']/div[2]/div/form/div[7]/div[2]/div/div[6]/div[2]/input")]
        public IWebElement thursdayStarttime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service - listing - section']/div[2]/div/form/div[7]/div[2]/div/div[6]/div[3]/input")]
        public IWebElement thursdayEndtime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service - listing - section']/div[2]/div/form/div[7]/div[2]/div/div[7]/div[2]/input")]
        public IWebElement fridayStarttime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service - listing - section']/div[2]/div/form/div[7]/div[2]/div/div[7]/div[3]/input")]
        public IWebElement fridayEndtime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service - listing - section']/div[2]/div/form/div[7]/div[2]/div/div[8]/div[2]/input")]
        public IWebElement saturdayStarttime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service - listing - section']/div[2]/div/form/div[7]/div[2]/div/div[8]/div[3]/input")]
        public IWebElement saturdayEndtime { get; set; }

        //Date selection block ends



        [FindsBy(How = How.Name, Using = "skillTrades")]
        IList<IWebElement> skillTradeRadioBtn;

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(8) > div:nth-child(4) > div > div > div > div > div > input")]
        public IWebElement skillExchangeTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/input")]
        public IWebElement creditInputbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(9) > div > div.twelve.wide.column > section > div > label > div > span > i")]
        public IWebElement workSampleBtn { get; set; }

        [FindsBy(How = How.Name, Using = "isActive")]
        IList<IWebElement> activeRadioBtn;

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div.ui.vertically.padded.right.aligned.grid > div > input.ui.teal.button")]
        public IWebElement saveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/a")]
        public IWebElement errormsg { get; set; }

        string shareSkillbuttonx = "#account-profile-section > div > section.nav-secondary > div > div.right.item > a";
        string categoryOptionx = "#service-listing-section > div.ui.container > div > form > div:nth-child(3) > div.twelve.wide.column > div > div:nth-child(1) > select > option:nth-child(7)";
        string subCategoryOptionx = "#service-listing-section > div.ui.container > div > form > div:nth-child(3) > div.twelve.wide.column > div > div:nth-child(2) > div:nth-child(1) > select > option:nth-child(5)";
        string tagsBoxx = "#service-listing-section > div.ui.container > div > form > div:nth-child(4) > div.twelve.wide.column > div > div > div > div > input";
        string sundayStarttimex = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(2) > div:nth-child(2) > input[type=time]";
        string sundayEndtimex = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(2) > div:nth-child(3) > input[type=time]";


        public void ManageSkills()
        {

            Wait.WaitForclicable(driver, "CssSelector", shareSkillbuttonx , 4);
            shareSkillbutton.Click();

            titleBox.SendKeys("Programar");
            descriptionBox.SendKeys("I can analyze your system and can give you the best IT solution");

            categoryDropdownbox.Click();
            categoryOption.Click();
            subCategorybox.Click();
            subCategoryOption.Click();

            jse.ExecuteScript("window.scrollBy(0,500)");

            tagsBox.Click();
            tagsBox.SendKeys("C#");
            tagsBox.SendKeys(Keys.Enter);
            tagsBox.SendKeys("VB");
            tagsBox.SendKeys(Keys.Enter);
            tagsBox.SendKeys("Java");
            tagsBox.SendKeys(Keys.Enter);

            serviceTypeRadioBtn.ToList();
            serviceTypeRadioBtn[0].Click();

            locationTypeRadioBtn.ToList();
            locationTypeRadioBtn[1].Click();

            //Enter dates and times

            jse.ExecuteScript("window.scrollBy(0,500)");
            startDateBox.SendKeys("06/12/2022");
            endDateBox.SendKeys("13/12/2022");

            sundayStarttime.SendKeys("09:00am");
            sundayEndtime.SendKeys("15:00pm");
            mondayStarttime.SendKeys("10:00am");
            mondayEndtime.SendKeys("16:00pm");
            wednesdayStarttime.SendKeys("07:00am");
            wednesdayEndtime.SendKeys("13:30pm");

            jse.ExecuteScript("window.scrollBy(0,800)");

            skillTradeRadioBtn.ToList();
            skillTradeRadioBtn[0].Click();

            skillExchangeTag.Click();
            skillExchangeTag.SendKeys("Designing");
            skillExchangeTag.SendKeys(Keys.Enter);
            skillExchangeTag.SendKeys("Advertising");
            skillExchangeTag.SendKeys(Keys.Enter);
            skillExchangeTag.SendKeys("Costing");
            skillExchangeTag.SendKeys(Keys.Enter);

             /*workSampleBtn.Click();
             AutoItX3 autoIt = new AutoItX3();
             autoIt.WinActivate("Open");
             Thread.Sleep(1000);
             autoIt.Send(@"C:\Users\rosha\source\repos\Roshanindika1\Advance Task\Adv_Task\MARS ADV Task SpecFlow\Adv_Task\MARS ADV Task\MARS ADV Task\Data\Data Sheet.docx");
             Thread.Sleep(1000);
             autoIt.Send("{ Enter}");
             Thread.Sleep(1000);*/
         
            activeRadioBtn.ToList();
            activeRadioBtn[1].Click();
            saveButton.Click();

        }


        [FindsBy(How = How.CssSelector, Using = "#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(1) > td:nth-child(2)")]
        public IWebElement actualCategory { get; set; }

        string actualCategoryx = "#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(1) > td:nth-child(2)";
        public string GetCategory(IWebDriver driver)
        {
            Wait.WaitForvisible(driver, "CssSelector", actualCategoryx , 2);
            return actualCategory.Text;
        }

    }
}

