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
        Profilepageloc Profilepageloc;
        Profilepageloc Profilepagelocobj;
        ManageLanguage ManageLanguage;
        ManageLanguage ManageLanguageObj;
        Manageskills Manageskills;
        Manageskills ManageskillsObj;
        ManageEducation ManageEducation;
        ManageEducation ManageEducationObj;
        ManageCertification ManageCertification;
        ManageCertification ManageCertificationObj;
        ManageDescription ManageDescription;
        ManageDescription ManageDescriptionObj;
        ShareSkills ShareSkills;
        ShareSkills ShareSkillsObj;
        Managelistings Managelistings;
        Managelistings ManagelistingsObj;
        Loginpage Loginpage;

        public AdvTaskFeatureStepDefinitions()
        {
            Profilepageloc = new Profilepageloc();
            Profilepagelocobj = new Profilepageloc();
            ManageLanguage = new ManageLanguage();
            ManageLanguageObj = new ManageLanguage();
            Manageskills = new Manageskills();
            ManageskillsObj = new Manageskills();
            ManageEducation = new ManageEducation();
            ManageEducationObj = new ManageEducation();
            ManageCertification = new ManageCertification();
            ManageCertificationObj = new ManageCertification();
            ManageDescription = new ManageDescription();
            ManageDescriptionObj = new ManageDescription();
            ShareSkills = new ShareSkills();
            ShareSkillsObj = new ShareSkills();
            Managelistings = new Managelistings();
            ManagelistingsObj = new Managelistings();
            Loginpage = new Loginpage();
        }

        [Given(@"I log in to the MAR QA website successfully")]

        public void GivenILogInToTheMARQAWebsiteSuccessfully()
        {
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
        }

        [When(@"I want to add Profile details")]
        public void WhenIWantToAddProfileDetails()
        {
            PageFactory.InitElements(driver, Profilepageloc);
            Profilepageloc.Profilemanageloc();
        }

        [Then(@"The Profile Location data should be created successfully")]
        public void ThenTheProfileLocationDataShouldBeCreatedSuccessfully()
        {
            PageFactory.InitElements(driver, Profilepagelocobj);
            string newavailability = Profilepagelocobj.Getavailability();
            Assert.That(newavailability == "Full Time", "Actual availability and Expected availability does not match");
        }


        [Given(@"I log in to the MAR QA website successfully for add language")]
        public void GivenILogInToTheMARQAWebsiteSuccessfullyForAddLanguage()
        {
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
        }

        [When(@"I want to add '([^']*)' and '([^']*)' details")]
        public void WhenIWantToAddAndDetails(string p1, string p2)
        {
            PageFactory.InitElements(driver, ManageLanguage);
            ManageLanguage.addLanguage(p1, p2);
        }

        [Then(@"The Language data should be created successfully '([^']*)' and '([^']*)' details")]
        public void ThenTheLanguageDataShouldBeCreatedSuccessfullyAndDetails(string p1, string p2)
        {
            PageFactory.InitElements(driver, ManageLanguageObj);

            string newLanguage = ManageLanguageObj.GetLanguage();
            string newLevel = ManageLanguageObj.GetlanguageLevelDropdown();
            
            Assert.That(newLanguage == p1, "Actual language and Expected language does not match");
            Assert.That(newLevel == p2, "Actual Level and Expected Level does not match");
        }

        [Given(@"I log in to the MAR QA website for add skills")]
        public void GivenILogInToTheMARQAWebsiteForAddSkills()
        {
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
        }

        [When(@"I want to add '([^']*)' and '([^']*)' details in")]
        public void WhenIWantToAddAndDetailsIn(string p0, string p1)
        {
            PageFactory.InitElements(driver, Manageskills);
            Manageskills.AddSkills(p0,p1);
        }

        [Then(@"The skills records should be created successfully '([^']*)' and '([^']*)' details")]
        public void ThenTheSkillsRecordsShouldBeCreatedSuccessfullyAndDetails(string p0, string p1)
        {
            PageFactory.InitElements(driver, ManageskillsObj);
            string newSkill = ManageskillsObj.GetSkills();
            string newLevel = ManageskillsObj.GetLevel();
            
            Assert.That(newSkill == p0, "Actual Skill and Expected Skill does not match");
            Assert.That(newLevel == p1, "Actual Skill level and Expected Skill level does not match");
        }

      

        [Given(@"I log in to the MAR QA website to add education details")]
        public void GivenILogInToTheMARQAWebsiteToAddEducationDetails()
        {            
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
        }
       
        
        [When(@"I want to add '([^']*)','([^']*)','([^']*)' and '([^']*)' details")]
        public void WhenIWantToAddAndDetails(string p0, string p1, string p2, string p3)
        {
            PageFactory.InitElements(driver, ManageEducation);
            ManageEducation.addEducation(p0, p1, p2, p3);
        }

        [Then(@"The education records '([^']*)','([^']*)','([^']*)' and '([^']*)' details should be created successfully")]
        public void ThenTheEducationRecordsAndDetailsShouldBeCreatedSuccessfully(string p0, string p1, string p2, string p3)
        {
            PageFactory.InitElements(driver, ManageEducationObj);
            string newUniversity = ManageEducationObj.GetUniversity();
            string newCountry = ManageEducationObj.GetCountry();
            string newDegree = ManageEducationObj.GetDegree();
            string newYear = ManageEducationObj.GetYear();

            Assert.That(newUniversity == p1, "Actual University and Expected University does not match");
            Assert.That(newCountry == p0, "Actual Country and Expected Country does not match");
            Assert.That(newDegree == p2, "Actual Degree and Expected Degree does not match");
            Assert.That(newYear == p3, "Actual Year and Expected Year does not match");
        }


       

        [Given(@"I log in to the MAR QA website to add Certification details")]
        public void GivenILogInToTheMARQAWebsiteToAddCertificationDetails()
        {
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
        }

        [When(@"I want to add the '([^']*)' , '([^']*)' and '([^']*)' details")]
        public void WhenIWantToAddTheAndDetails(string p0, string p1, string p2)
        {
            PageFactory.InitElements(driver, ManageCertification);
            ManageCertification.AddCertification(p0,p1,p2);
        }

        [Then(@"The Certification records '([^']*)' , '([^']*)' and '([^']*)' should be created successfully")]
        public void ThenTheCertificationRecordsAndShouldBeCreatedSuccessfully(string p0, string p1, string p2)
        {
            PageFactory.InitElements(driver, ManageCertificationObj);
            string newCertification = ManageCertificationObj.GetCertification();
            string newcertified_from = ManageCertificationObj.Getcertified_from();
            string newyear = ManageCertificationObj.Getyear();

            Assert.That(newCertification == p0, "Actual Certification and Expected Certification does not match");
            Assert.That(newcertified_from == p1, "Actual certified_from and Expected certified_from does not match");
            Assert.That(newyear == p2, "Actual year and Expected year does not match");
        }

        


        [Given(@"I log in to the MAR QA website for add Description")]
        public void GivenILogInToTheMARQAWebsiteForAddDescription()
        {
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
        }

        [When(@"I want to add Description details")]
        public void WhenIWantToAddDescriptionDetails()
        {
            PageFactory.InitElements(driver, ManageDescription);
            ManageDescription.AddDescription();
        }

        [Then(@"The description records should be created successfully")]
        public void ThenTheDescriptionRecordsShouldBeCreatedSuccessfully()
        {
            PageFactory.InitElements(driver, ManageDescriptionObj);
            string newDescription = ManageDescriptionObj.GetDescription();
            Assert.That(newDescription == "Design expertise who creates solutions", "Actual Description and Expected Description does not match");
        }


        [Given(@"I log in to the MAR QA website to add Share skill data")]
        public void GivenILogInToTheMARQAWebsiteToAddShareSkillData()
        {
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
        }

        [When(@"I want to add the Share skill data")]
        public void WhenIWantToAddTheShareSkillData()
        {
            PageFactory.InitElements(driver, ShareSkills);
            ShareSkills.ManageSkills();
        }

        [Then(@"The Share skill data records should be created successfully")]
        public void ThenTheShareSkillDataRecordsShouldBeCreatedSuccessfully()
        {
            PageFactory.InitElements(driver, ShareSkillsObj);
            string Category = ShareSkillsObj.GetCategory();
            Assert.That(Category == "Programming & Tech", "Actual Category and Expected Category does not match");
        }


        [Given(@"I log in to the MAR QA website to edit details in the managelistings")]
        public void GivenILogInToTheMARQAWebsiteToEditDetailsInTheManagelistings()
        {
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
        }


        [When(@"I want to edit the data '([^']*)' and '([^']*)' in the managelistings")]
        public void WhenIWantToEditTheDataAndInTheManagelistings(string p0, string p1)
        {
            PageFactory.InitElements(driver, Managelistings);
            Managelistings.EditSkillfunction(p0, p1);
        }

        [Then(@"The managelistings data  '([^']*)'and '([^']*)' should be edited successfully")]
        public void ThenTheManagelistingsDataAndShouldBeEditedSuccessfully(string p0, string p1)
        {
            PageFactory.InitElements(driver, ManagelistingsObj);
            string newEditedskill = ManagelistingsObj.GetEditedSkill();
            string newskillexchangetag = ManagelistingsObj.Getskilexchangetag();

            Assert.That(newEditedskill == p0, "Actual Edited skill and Expected Edited skill does not match");
            Assert.That(newskillexchangetag == p1, "Actual Edited skillexchangetag and Expected Edited skillexchangetag does not match");
        }

       
       

        [Given(@"I log in to the MAR QA website to Delete details in the managelistings")]
        public void GivenILogInToTheMARQAWebsiteToDeleteDetailsInTheManagelistings()
        {
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
        }

        [When(@"I want to Delete the data in the managelistings")]
        public void WhenIWantToDeleteTheDataInTheManagelistings()
        {
            PageFactory.InitElements(driver, Managelistings);
            Managelistings.DeleteSkillsFunction();
        }

        [Then(@"The managelistings data should be Deleted successfully")]
        public void ThenTheManagelistingsDataShouldBeDeletedSuccessfully()
        {
            PageFactory.InitElements(driver, ManagelistingsObj);
            string newdeletedTitle = ManagelistingsObj.GetdeletedSkill();
            Assert.That(newdeletedTitle != "Test Analyst", "Actual deletedTitle and Expected deletedTitle does not match");
        }
    }
}
