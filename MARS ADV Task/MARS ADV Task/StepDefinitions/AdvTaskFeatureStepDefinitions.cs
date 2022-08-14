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
        [Given(@"\[I log in to the MAR QA website successfully]")]
        public void GivenILogInToTheMARQAWebsiteSuccessfully()
        {
            //Open chromedriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Login page object initializing and defining
            var Loginpage = new Loginpage();
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
        }

        [When(@"\[I want to add Profile details]")]
        public void WhenIWantToAddProfileDetails()
        {
            // Profile page object initializing and defining
            var Profilepageloc  = new Profilepageloc();
            PageFactory.InitElements(driver, Profilepageloc);
            Profilepageloc.Profilemanageloc();
        }

        [Then(@"\[The Profile Location data should be created successfully]")]
        public void ThenTheProfileLocationDataShouldBeCreatedSuccessfully()
        {
            Profilepageloc Profilepagelocobj = new Profilepageloc();
            PageFactory.InitElements(driver, Profilepagelocobj);
            string newavailability = Profilepagelocobj.Getavailability(driver);
            Assert.That(newavailability == "Full Time", "Actual availability and Expected availability does not match");
            driver.Close();
        }


        [Given(@"\[I log in to the MAR QA website successfully for add language]")]
        public void GivenILogInToTheMARQAWebsiteSuccessfullyForAddLanguage()
        {
            //Open chromedriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Login page object initializing and defining
            var Loginpage = new Loginpage();
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
        }

        [When(@"\[I want to add Language details]")]
        public void WhenIWantToAddLanguageDetails()
        {
            var ManageLanguage = new ManageLanguage();
            PageFactory.InitElements(driver, ManageLanguage);
            ManageLanguage.addLanguage();
        }


        [Then(@"\[The Language data should be created successfully]")]
        public void ThenTheLanguageDataShouldBeCreatedSuccessfully()
        {
            ManageLanguage ManageLanguageObj = new ManageLanguage();
            PageFactory.InitElements(driver, ManageLanguageObj);
            string newLanguage = ManageLanguageObj.GetLanguage(driver);
            Assert.That(newLanguage == "Spanish", "Actual language and Expected language does not match");
            driver.Close();
        }



        [Given(@"\[I log in to the MAR QA website for add skills]")]
        public void GivenILogInToTheMARQAWebsiteForAddSkills()
        {
            //Open chromedriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Login page object initializing and defining
            var Loginpage = new Loginpage();
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
        }

        [When(@"\[I want to add Skillls details]")]
        public void WhenIWantToAddSkilllsDetails()
        {
            var Manageskills = new Manageskills();
            PageFactory.InitElements(driver, Manageskills);
            Manageskills.AddSkills();
        }

        [Then(@"\[The skills records should be created successfully]")]
        public void ThenTheSkillsRecordsShouldBeCreatedSuccessfully()
        {
            Manageskills ManageskillsObj = new Manageskills();
            PageFactory.InitElements(driver, ManageskillsObj);
            string newSkill = ManageskillsObj.GetSkills(driver);
            Assert.That(newSkill == "Designing", "Actual Skill and Expected Skill does not match");
            driver.Close();
        }


        [Given(@"\[I log in to the MAR QA website to add education details]")]
        public void GivenILogInToTheMARQAWebsiteToAddEducationDetails()
        {

            //Open chromedriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Login page object initializing and defining
            var Loginpage = new Loginpage();
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
        }

        [When(@"\[I want to add the Education details]")]
        public void WhenIWantToAddTheEducationDetails()
        {
            var ManageEducation = new ManageEducation();
            PageFactory.InitElements(driver, ManageEducation);
            ManageEducation.addEducation();
        }

        [Then(@"\[The education records should be created successfully]")]
        public void ThenTheEducationRecordsShouldBeCreatedSuccessfully()
        {
            ManageEducation ManageEducationObj = new ManageEducation();
            PageFactory.InitElements(driver, ManageEducationObj);
            string newEducation = ManageEducationObj.GetEducation(driver);
            Assert.That(newEducation == "Otago", "Actual Education and Expected Education does not match");
            driver.Close();
        }

        [Given(@"\[I log in to the MAR QA website to add Certification details]")]
        public void GivenILogInToTheMARQAWebsiteToAddCertificationDetails()
        {
            //Open chromedriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Login page object initializing and defining
            var Loginpage = new Loginpage();
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
        }

        [When(@"\[I want to add the Certification details]")]
        public void WhenIWantToAddTheCertificationDetails()
        {
            var ManageCertification = new ManageCertification();
            PageFactory.InitElements(driver, ManageCertification);
            ManageCertification.AddCertification();
        }

        [Then(@"\[The Certification records should be created successfully]")]
        public void ThenTheCertificationRecordsShouldBeCreatedSuccessfully()
        {
            ManageCertification ManageCertificationObj = new ManageCertification();
            PageFactory.InitElements(driver, ManageCertificationObj);
            string newCertification = ManageCertificationObj.GetCertification(driver);
            Assert.That(newCertification == "Diploma", "Actual Certification and Expected Certification does not match");
            driver.Close();
        }

        [Given(@"\[I log in to the MAR QA website for add Description]")]
        public void GivenILogInToTheMARQAWebsiteForAddDescription()
        {
            //Open chromedriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Login page object initializing and defining
            var Loginpage = new Loginpage();
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
        }

        [When(@"\[I want to add Description details]")]
        public void WhenIWantToAddDescriptionDetails()
        {
            var ManageDescription = new ManageDescription();
            PageFactory.InitElements(driver, ManageDescription);
            ManageDescription.AddDescription();
        }

        [Then(@"\[The description records should be created successfully]")]
        public void ThenTheDescriptionRecordsShouldBeCreatedSuccessfully()
        {
            ManageDescription ManageDescriptionObj = new ManageDescription();
            PageFactory.InitElements(driver, ManageDescriptionObj);
            string newDescription = ManageDescriptionObj.GetDescription(driver);
            Assert.That(newDescription == "Design expertise who creates solutions", "Actual Description and Expected Description does not match");
            driver.Close();
        }

        [Given(@"\[I log in to the MAR QA website to add Share skill data]")]
        public void GivenILogInToTheMARQAWebsiteToAddShareSkillData()
        {
            //Open chromedriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Login page object initializing and defining
            var Loginpage = new Loginpage();
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
        }

        [When(@"\[I want to add the Share skill data]")]
        public void WhenIWantToAddTheShareSkillData()
        {
            var ShareSkills = new ShareSkills();
            PageFactory.InitElements(driver, ShareSkills);
            ShareSkills.ManageSkills();
        }

        [Then(@"\[The Share skill data records should be created successfully]")]
        public void ThenTheShareSkillDataRecordsShouldBeCreatedSuccessfully()
        {
            ShareSkills ShareSkillsObj = new ShareSkills();
            PageFactory.InitElements(driver, ShareSkillsObj);
            string Category = ShareSkillsObj.GetCategory(driver);
            Assert.That(Category == "Programming & Tech", "Actual Category and Expected Category does not match");
            driver.Close();
        }

        
        [Given(@"\[I log in to the MAR QA website to edit details in the managelistings]")]
        public void GivenILogInToTheMARQAWebsiteToEditDetailsInTheManagelistings()
        {
            //Open chromedriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Login page object initializing and defining
            var Loginpage = new Loginpage();
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
        }

        [When(@"\[I want to edit the data in the managelistings]")]
        public void WhenIWantToEditTheDataInTheManagelistings()
        {
            var Managelistings = new Managelistings();
            PageFactory.InitElements(driver, Managelistings);
            Managelistings.EditSkillfunction();
        }

        [Then(@"\[The managelistings data should be edited successfully]")]
        public void ThenTheManagelistingsDataShouldBeEditedSuccessfully()
        {
            Managelistings ManagelistingsObj = new Managelistings();
            PageFactory.InitElements(driver, ManagelistingsObj);

            string newEditedskill = ManagelistingsObj.GetEditedSkill(driver);
            Assert.That(newEditedskill == "Test Analyst", "Actual Edited skill and Expected Edited skill does not match");
            driver.Close();        
        }


        [Given(@"\[I log in to the MAR QA website to Delete details in the managelistings]")]
        public void GivenILogInToTheMARQAWebsiteToDeleteDetailsInTheManagelistings()
        {
            //Open chromedriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Login page object initializing and defining
            var Loginpage = new Loginpage();
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
        }

        [When(@"\[I want to Delete the data in the managelistings]")]
        public void WhenIWantToDeleteTheDataInTheManagelistings()
        {
            var Managelistings = new Managelistings();
            PageFactory.InitElements(driver, Managelistings);
            Managelistings.DeleteSkillsFunction();
        }

        [Then(@"\[The managelistings data should be Deleted successfully]")]
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
