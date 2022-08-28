﻿using MARS_ADV_Task.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace MARS_ADV_Task.Pages
{
    internal class ManageCertification : Commondriver
    {
        //Identify Certification Tab            
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(4)")]
        public IWebElement certificationTab { get; set; }

        //Identify Addnew certification button 
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div")]
        public IWebElement addNewCertification { get; set; }

        //Identify Add certification box 
        [FindsBy(How = How.Name, Using = "certificationName")]
        public IWebElement addCertificationAward { get; set; }

        //Identify the certified from box
        [FindsBy(How = How.Name, Using = "certificationFrom")]
        public IWebElement certifiedFrom { get; set; }

        //Identify the year of achievement 
        [FindsBy(How = How.Name, Using = "certificationYear")]
        public IWebElement yearDropdown { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div.three.wide.field > select > option:nth-child(8)")]
        public IWebElement yearOption { get; set; }

        //Identify the Certification Add button
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > div > div.five.wide.field > input.ui.teal.button")]
        public IWebElement certificationAddButton { get; set; }

        string xCertificationTab = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(4)";
        public void AddCertification(string certificate, string certified_from, string year)
        {

            Wait.WaitForvisible(driver, "CssSelector", xCertificationTab, 2);
            certificationTab.Click();
            addNewCertification.Click();
            addCertificationAward.SendKeys(certificate);
            certifiedFrom.SendKeys(certified_from);
            yearDropdown.SendKeys(year);
            certificationAddButton.Click();
            Thread.Sleep(2000);

        }

        //Identify and Get the Certification
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > table > tbody:last-child > tr > td:nth-child(1)")]
        public IWebElement actualCertificate { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > table > tbody:last-child > tr > td:nth-child(2)")]
        public IWebElement actualcertified_from { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > table > tbody:last-child > tr > td:nth-child(3)")]
        public IWebElement actualyear { get; set; }


        public string GetCertification()
        {
            return actualCertificate.Text;
        }
        public string Getcertified_from()
        {
            return actualcertified_from.Text;
        }
        public string Getyear()
        {
            return actualyear.Text;
        }
    }

}

