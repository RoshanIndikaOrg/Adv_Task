using MARS_ADV_Task.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MARS_ADV_Task.Pages
{
    internal class Managelistings : Commondriver
    {

        IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section.nav-secondary > div > a:nth-child(3)")]
        public IWebElement manageListings { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(1) > td:nth-child(8) > div > button:nth-child(2) > i")]
        public IWebElement editButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(1) > td:nth-child(8) > div > button:nth-child(1) > i")]
        public IWebElement detailBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-detail-section > div.ui.container > div > div:nth-child(2) > div.ten.wide.column > div.ui.fluid.card > div.content > div:nth-child(5) > div > div > div:nth-child(4) > div.ui.list > div > div > div.description > span:nth-child(3)")]
        public IWebElement actualSkillexchange { get; set; }

        [FindsBy(How = How.Name, Using = "title")]
        public IWebElement titleBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(4) > div.twelve.wide.column > div > div > div > div > input")]
        public IWebElement tagsBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(8) > div:nth-child(4) > div > div > div > div > div > input")]
        public IWebElement skillExchangeTag { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div.ui.vertically.padded.right.aligned.grid > div > input.ui.teal.button")]
        public IWebElement saveButton { get; set; }
       
        [FindsBy(How = How.CssSelector, Using = "#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(1) > td:nth-child(3)")]
        public IWebElement deletedTitle { get; set; }

        string managelistingx = "#account-profile-section > div > section.nav-secondary > div > a:nth-child(3)";
        string editBtnx = "#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(1) > td:nth-child(8) > div > button:nth-child(2) > i";
        string detailBtnX = "#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(1) > td:nth-child(8) > div > button:nth-child(1) > i";

        public void EditSkillfunction(string title, string skillTag)
        {
            Wait.WaitForclicable(driver, "CssSelector", managelistingx, 2);

            manageListings.Click();

            Wait.WaitForclicable(driver, "CssSelector", editBtnx, 2);
            editButton.Click();

            Wait.WaitForvisible(driver, "Name", "title", 2);
            titleBox.Clear();
            titleBox.SendKeys(title);

            jse.ExecuteScript("window.scrollBy(0,500)");

            tagsBox.Click();
            tagsBox.SendKeys(Keys.Backspace);
            tagsBox.SendKeys("Python");
            tagsBox.SendKeys(Keys.Enter);

            jse.ExecuteScript("window.scrollBy(0,800)");

            skillExchangeTag.Click();
            skillExchangeTag.SendKeys(Keys.Backspace);
            skillExchangeTag.SendKeys(skillTag);
            skillExchangeTag.SendKeys(Keys.Enter);

            saveButton.Click();

        }



        [FindsBy(How = How.CssSelector, Using = "#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(1) > td:nth-child(8) > div > button:nth-child(3) > i")]
        public IWebElement deleteBtn { get; set; }

        string deleteBtnx = "#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(1) > td:nth-child(8) > div > button:nth-child(3) > i";
        string deleteWindowbtnx = "body > div.ui.page.modals.dimmer.transition.visible.active > div > div.actions > button.ui.icon.positive.right.labeled.button";
        
        public void DeleteSkillsFunction()
        {
            Wait.WaitForclicable(driver, "CssSelector", managelistingx, 2);
            manageListings.Click();

            Wait.WaitForvisible(driver, "CssSelector", deleteBtnx, 2);
            deleteBtn.Click();

            IWebElement deleteWindowbtn = driver.FindElement(By.CssSelector("body > div.ui.page.modals.dimmer.transition.visible.active > div > div.actions > button.ui.icon.positive.right.labeled.button"));
            Wait.WaitForvisible(driver, "CssSelector", deleteWindowbtnx, 2);
            deleteWindowbtn.Click();

        }

        [FindsBy(How = How.CssSelector, Using = "#service-detail-section > div.ui.container > div > div:nth-child(1) > div > div > div > div")]
        public IWebElement actualTitle { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-detail-section > div.ui.container > div > div:nth-child(2) > div.ten.wide.column > div.ui.fluid.card > div.content > div:nth-child(5) > div > div > div:nth-child(4) > div.ui.list > div > div > div.description > span:last-child")]
        public IWebElement actualskilexchangetag { get; set; }

        string actualTitlex = "#service-detail-section > div.ui.container > div > div:nth-child(1) > div > div > div > div";
        string actualskilexchangetagx = "#service-detail-section > div.ui.container > div > div:nth-child(2) > div.ten.wide.column > div.ui.fluid.card > div.content > div:nth-child(5) > div > div > div:nth-child(4) > div.ui.list > div > div > div.description > span";
        string deletedTitlex = "#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(1) > td:nth-child(3)";
        public string GetEditedSkill()
        {
            Wait.WaitForclicable(driver, "CssSelector", detailBtnX , 2);
            detailBtn.Click();

            Wait.WaitForvisible(driver, "CssSelector", actualTitlex, 2);
            return actualTitle.Text;

        }

        public string Getskilexchangetag()
        {
            jse.ExecuteScript("window.scrollBy(0,800)");

            Wait.WaitForvisible(driver, "CssSelector", actualskilexchangetagx, 2);
            return actualskilexchangetag.Text;

        }



        public string GetdeletedSkill()
        {
            Wait.WaitForvisible(driver, "CssSelector", deletedTitlex, 2);
            return deletedTitle.Text;
        }

    }
}

