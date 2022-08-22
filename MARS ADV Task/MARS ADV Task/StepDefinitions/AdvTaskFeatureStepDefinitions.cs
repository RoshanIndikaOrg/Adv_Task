using MARS_ADV_Task.Pages;
using MARS_ADV_Task.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace MARS_ADV_Task.StepDefinitions 
{
    [Binding]
    public class AdvTaskFeatureStepDefinitions : Commondriver
    {
        [Given(@"I log in to the MAR QA website successfully")]

        public void GivenILogInToTheMARQAWebsiteSuccessfully()
        {
            driver = new ChromeDriver(); 
            driver.Manage().Window.Maximize();
            Loginpage Loginpage = new Loginpage();
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
        }

        [When(@"I want to add Profile details")]
        public void WhenIWantToAddProfileDetails()
        {
            Profilepageloc Profilepageloc = new Profilepageloc();
            PageFactory.InitElements(driver, Profilepageloc);
            Profilepageloc.Profilemanageloc();
        }

        [Then(@"The Profile Location data should be created successfully")]
        public void ThenTheProfileLocationDataShouldBeCreatedSuccessfully()
        {
            Profilepageloc Profilepagelocobj = new Profilepageloc();
            PageFactory.InitElements(driver, Profilepagelocobj);
            string newavailability = Profilepagelocobj.Getavailability(driver);
            Assert.That(newavailability == "Full Time", "Actual availability and Expected availability does not match");
            driver.Close();
        }


        [Given(@"I log in to the MAR QA website successfully for add language")]
        public void GivenILogInToTheMARQAWebsiteSuccessfullyForAddLanguage()
        {
            driver = new ChromeDriver(); 
            driver.Manage().Window.Maximize();
            Loginpage Loginpage = new Loginpage(); 
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
        }

        [When(@"I want to add '([^']*)' and '([^']*)' details")]
        public void WhenIWantToAddAndDetails(string p1, string p2)
        {
            ManageLanguage ManageLanguage = new ManageLanguage();
            PageFactory.InitElements(driver, ManageLanguage);
            ManageLanguage.addLanguage(p1, p2);
        }

        [Then(@"The Language data should be created successfully '([^']*)' and '([^']*)' details")]
        public void ThenTheLanguageDataShouldBeCreatedSuccessfullyAndDetails(string p1, string p2)
        {
            ManageLanguage ManageLanguageObj = new ManageLanguage();
            PageFactory.InitElements(driver, ManageLanguageObj);

            string newLanguage = ManageLanguageObj.GetLanguage(driver);
            string newLevel = ManageLanguageObj.GetlanguageLevelDropdown(driver);
            
            Assert.That(newLanguage == p1, "Actual language and Expected language does not match");
            Assert.That(newLevel == p2, "Actual Level and Expected Level does not match");
            driver.Close();
        }

        [Given(@"I log in to the MAR QA website for add skills")]
        public void GivenILogInToTheMARQAWebsiteForAddSkills()
        {
            driver = new ChromeDriver(); 
            driver.Manage().Window.Maximize();
            Loginpage Loginpage = new Loginpage();
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
        }

        [When(@"I want to add '([^']*)' and '([^']*)' details in")]
        public void WhenIWantToAddAndDetailsIn(string p0, string p1)
        {
            Manageskills Manageskills = new Manageskills();
            PageFactory.InitElements(driver, Manageskills);
            Manageskills.AddSkills(p0,p1);
        }

        [Then(@"The skills records should be created successfully '([^']*)' and '([^']*)' details")]
        public void ThenTheSkillsRecordsShouldBeCreatedSuccessfullyAndDetails(string p0, string p1)
        {
            Manageskills ManageskillsObj = new Manageskills();
            PageFactory.InitElements(driver, ManageskillsObj);
            string newSkill = ManageskillsObj.GetSkills(driver);
            string newLevel = ManageskillsObj.GetLevel(driver);
            
            Assert.That(newSkill == p0, "Actual Skill and Expected Skill does not match");
            Assert.That(newLevel == p1, "Actual Skill level and Expected Skill level does not match");
            driver.Close();
        }

      

        [Given(@"I log in to the MAR QA website to add education details")]
        public void GivenILogInToTheMARQAWebsiteToAddEducationDetails()
        {

            driver = new ChromeDriver(); 
            driver.Manage().Window.Maximize();
            Loginpage Loginpage = new Loginpage(); 
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
        }
       
        
        [When(@"I want to add '([^']*)','([^']*)','([^']*)' and '([^']*)' details")]
        public void WhenIWantToAddAndDetails(string p0, string p1, string p2, string p3)
        {
            ManageEducation ManageEducation = new ManageEducation();
            PageFactory.InitElements(driver, ManageEducation);
            ManageEducation.addEducation(p0, p1, p2, p3);
        }

        [Then(@"The education records '([^']*)','([^']*)','([^']*)' and '([^']*)' details should be created successfully")]
        public void ThenTheEducationRecordsAndDetailsShouldBeCreatedSuccessfully(string p0, string p1, string p2, string p3)
        {
            ManageEducation ManageEducationObj = new ManageEducation();
            PageFactory.InitElements(driver, ManageEducationObj);
            string newUniversity = ManageEducationObj.GetUniversity(driver);
            string newCountry = ManageEducationObj.GetCountry(driver);
            string newDegree = ManageEducationObj.GetDegree(driver);
            string newYear = ManageEducationObj.GetYear(driver);

            Assert.That(newUniversity == p1, "Actual University and Expected University does not match");
            Assert.That(newCountry == p0, "Actual Country and Expected Country does not match");
            Assert.That(newDegree == p2, "Actual Degree and Expected Degree does not match");
            Assert.That(newYear == p3, "Actual Year and Expected Year does not match");
            driver.Close();
        }


       

        [Given(@"I log in to the MAR QA website to add Certification details")]
        public void GivenILogInToTheMARQAWebsiteToAddCertificationDetails()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            Loginpage Loginpage = new Loginpage();
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
        }

        [When(@"I want to add the '([^']*)' , '([^']*)' and '([^']*)' details")]
        public void WhenIWantToAddTheAndDetails(string p0, string p1, string p2)
        {
            ManageCertification ManageCertification = new ManageCertification();
            PageFactory.InitElements(driver, ManageCertification);
            ManageCertification.AddCertification(p0,p1,p2);
        }

        [Then(@"The Certification records '([^']*)' , '([^']*)' and '([^']*)' should be created successfully")]
        public void ThenTheCertificationRecordsAndShouldBeCreatedSuccessfully(string p0, string p1, string p2)
        {
            ManageCertification ManageCertificationObj = new ManageCertification();
            PageFactory.InitElements(driver, ManageCertificationObj);
            string newCertification = ManageCertificationObj.GetCertification(driver);
            string newcertified_from = ManageCertificationObj.Getcertified_from(driver);
            string newyear = ManageCertificationObj.Getyear(driver);

            Assert.That(newCertification == p0, "Actual Certification and Expected Certification does not match");
            Assert.That(newcertified_from == p1, "Actual certified_from and Expected certified_from does not match");
            Assert.That(newyear == p2, "Actual year and Expected year does not match");
           // driver.Close();
        }

        


        [Given(@"I log in to the MAR QA website for add Description")]
        public void GivenILogInToTheMARQAWebsiteForAddDescription()
        {
            driver = new ChromeDriver(); 
            driver.Manage().Window.Maximize();
            Loginpage Loginpage = new Loginpage();
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
        }

        [When(@"I want to add Description details")]
        public void WhenIWantToAddDescriptionDetails()
        {
            ManageDescription ManageDescription = new ManageDescription();
            PageFactory.InitElements(driver, ManageDescription);
            ManageDescription.AddDescription();
        }

        [Then(@"The description records should be created successfully")]
        public void ThenTheDescriptionRecordsShouldBeCreatedSuccessfully()
        {
            ManageDescription ManageDescriptionObj = new ManageDescription();
            PageFactory.InitElements(driver, ManageDescriptionObj);
            string newDescription = ManageDescriptionObj.GetDescription(driver);
            Assert.That(newDescription == "Design expertise who creates solutions", "Actual Description and Expected Description does not match");
            driver.Close();
        }


        [Given(@"I log in to the MAR QA website to add Share skill data")]
        public void GivenILogInToTheMARQAWebsiteToAddShareSkillData()
        {
            driver = new ChromeDriver(); 
            driver.Manage().Window.Maximize();
            Loginpage Loginpage = new Loginpage();
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
        }

        [When(@"I want to add the Share skill data")]
        public void WhenIWantToAddTheShareSkillData()
        {
            ShareSkills ShareSkills = new ShareSkills();
            PageFactory.InitElements(driver, ShareSkills);
            ShareSkills.ManageSkills();
        }

        [Then(@"The Share skill data records should be created successfully")]
        public void ThenTheShareSkillDataRecordsShouldBeCreatedSuccessfully()
        {
            ShareSkills ShareSkillsObj = new ShareSkills();
            PageFactory.InitElements(driver, ShareSkillsObj);
            string Category = ShareSkillsObj.GetCategory(driver);
            Assert.That(Category == "Programming & Tech", "Actual Category and Expected Category does not match");
            driver.Close();
        }


        [Given(@"I log in to the MAR QA website to edit details in the managelistings")]
        public void GivenILogInToTheMARQAWebsiteToEditDetailsInTheManagelistings()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            Loginpage Loginpage = new Loginpage();
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
        }


        [When(@"I want to edit the data '([^']*)' and '([^']*)' in the managelistings")]
        public void WhenIWantToEditTheDataAndInTheManagelistings(string p0, string p1)
        {
            Managelistings Managelistings = new Managelistings();
            PageFactory.InitElements(driver, Managelistings);
            Managelistings.EditSkillfunction(p0, p1);
        }

        [Then(@"The managelistings data  '([^']*)'and '([^']*)' should be edited successfully")]
        public void ThenTheManagelistingsDataAndShouldBeEditedSuccessfully(string p0, string p1)
        {
            Managelistings ManagelistingsObj = new Managelistings(); 
            PageFactory.InitElements(driver, ManagelistingsObj);
            string newEditedskill = ManagelistingsObj.GetEditedSkill(driver);
            string newskillexchangetag = ManagelistingsObj.Getskilexchangetag(driver);

            Assert.That(newEditedskill == p0, "Actual Edited skill and Expected Edited skill does not match");
            Assert.That(newskillexchangetag == p1, "Actual Edited skillexchangetag and Expected Edited skillexchangetag does not match");
            driver.Close();
        }

       
       

        [Given(@"I log in to the MAR QA website to Delete details in the managelistings")]
        public void GivenILogInToTheMARQAWebsiteToDeleteDetailsInTheManagelistings()
        {
            driver = new ChromeDriver(); 
            driver.Manage().Window.Maximize();
            Loginpage Loginpage = new Loginpage();
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
        }

        [When(@"I want to Delete the data in the managelistings")]
        public void WhenIWantToDeleteTheDataInTheManagelistings()
        {
            Managelistings Managelistings = new Managelistings(); 
            PageFactory.InitElements(driver, Managelistings);
            Managelistings.DeleteSkillsFunction();
        }

        [Then(@"The managelistings data should be Deleted successfully")]
        public void ThenTheManagelistingsDataShouldBeDeletedSuccessfully()
        {
            Managelistings ManagelistingsObj = new Managelistings(); 
            PageFactory.InitElements(driver, ManagelistingsObj);
            string newdeletedTitle = ManagelistingsObj.GetdeletedSkill(driver);
            Assert.That(newdeletedTitle != "Test Analyst", "Actual deletedTitle and Expected deletedTitle does not match");
            driver.Close();
        }
    }
}
