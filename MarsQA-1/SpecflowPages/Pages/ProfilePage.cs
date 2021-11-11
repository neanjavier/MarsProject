using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MarsQA_1.Helpers;
using OpenQA.Selenium;

namespace MarsQA_1.SpecflowPages.Pages
{
    class ProfilePage
    {
        public void Description(IWebDriver driver)
        {
            //click edit icon in Description
            IWebElement editDescriptionIcon = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            editDescriptionIcon.Click();

            //input Description text
            IWebElement editDescriptionTextbox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textare"));
            editDescriptionTextbox.SendKeys("test");

            //click save button
            IWebElement saveDescription = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            saveDescription.Click();

        }

        public void AddLanguages(IWebDriver driver)
        {
            //click on Languages tab
            IWebElement languagesTab = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            languagesTab.Click();

            //click on Add New Button
            IWebElement addNewLanguageBtn = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewLanguageBtn.Click();

            //click on Language textbox
            IWebElement languageTextbox = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            languageTextbox.Click();

            //input Language
            IWebElement languageValue = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            languageValue.SendKeys(ExcelLibHelper.ReadData(2, "Language"));

            //click on Choose Language Level dropdown list
            IWebElement languageLevelDropdown = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            languageLevelDropdown.Click();
            Thread.Sleep(1000);

            //select language level
            IWebElement languageLevel = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            languageLevel.SendKeys(""); 

            //click Add button in Language tab
            IWebElement addLanguageBtn = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addLanguageBtn.Click();

        }

        public void EditLanguages(IWebDriver driver)
        {
            //click on edit language Icon
            IWebElement editLanguageIcon = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            editLanguageIcon.Click();

            //click on Language textbox
            IWebElement languageTextbox1 = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            languageTextbox1.Click();

            //input Language
            IWebElement languageValue1 = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            languageValue1.SendKeys(ExcelLibHelper.ReadData(3, "Language"));

            //click on Choose Language Level dropdown list
            IWebElement languageLevelDropdown1 = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            languageLevelDropdown1.Click();
            Thread.Sleep(1000);

            //select language level
            IWebElement languageLevel1 = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            languageLevel1.SendKeys("");

            //click Update button in Language tab
            IWebElement updateLanguageBtn = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updateLanguageBtn.Click();

            //click Cancel button

        }

        public void DeleteLanguage(IWebDriver driver)
        {
            //click delete Icon on Language tab
            IWebElement deleteLanguageIcon = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            deleteLanguageIcon.Click();
        }

        public void AddSkills(IWebDriver driver)
        {
            //click on Skills tab
            IWebElement skillsTab = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillsTab.Click();

            //click on Add New Button
            IWebElement addNewSkillsBtn = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewSkillsBtn.Click();

            //click on Skills textbox
            IWebElement skillTextbox = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            skillTextbox.Click();

            //input Skill
            IWebElement skillValue = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            skillValue.SendKeys(ExcelLibHelper.ReadData(3, "Skill"));

            //click on Choose Skill Level dropdown list
            IWebElement skillLevelDropdown = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            skillLevelDropdown.Click();
            Thread.Sleep(1000);

            //select skill level
            IWebElement skillLevel = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            skillLevel.SendKeys(ExcelLibHelper.ReadData(3, "SkillLevel"));

            //click Add button in skill tab
            IWebElement addSkillBtn = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addSkillBtn.Click();

        }

        public void EditSkills(IWebDriver driver)
        {
            //click on edit skill Icon
            IWebElement editSkillIcon = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            editSkillIcon.Click();

            //click on Skill textbox
            IWebElement skillTextbox1 = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            skillTextbox1.Click();

            //input Skill
            IWebElement skillValue1 = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            skillValue1.SendKeys(ExcelLibHelper.ReadData(3, "Skill"));

            //click on Choose Skill Level dropdown list
            IWebElement skillLevelDropdown1 = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
            skillLevelDropdown1.Click();
            Thread.Sleep(1000);

            //select skill level
            IWebElement skillLevel1 = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
            skillLevel1.SendKeys(ExcelLibHelper.ReadData(3, "SkillLevel"));

            //click Update button in Skill tab
            IWebElement updateSkillBtn = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updateSkillBtn.Click();

            //click Cancel button

        }

        public void DeleteSkill(IWebDriver driver)
        {
            //click delete Icon on Skill tab
            IWebElement deleteSkillIcon = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            deleteSkillIcon.Click();
        }

        public void AddEducation(IWebDriver driver)
        {
            //click on Education tab
            IWebElement educationTab = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationTab.Click();

            //click on Add New Button
            IWebElement addNewEducationBtn = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            addNewEducationBtn.Click();

            //click on Uni textbox
            IWebElement uniTextbox = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            uniTextbox.Click();

            //input Uni
            IWebElement uniValue = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            uniValue.SendKeys(ExcelLibHelper.ReadData(3, "Uni"));

            //click on Choose Uni Country dropdown list
            IWebElement uniCountryDropdown = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            uniCountryDropdown.Click();
            Thread.Sleep(1000);

            //select uni Country
            IWebElement uniCountry = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            uniCountry.SendKeys(ExcelLibHelper.ReadData(3, "UniCountry"));

            //click on Choose Title in dropdown list
            IWebElement titleDropdown = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            titleDropdown.Click();
            Thread.Sleep(1000);

            //select Title
            IWebElement title = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            title.SendKeys(ExcelLibHelper.ReadData(3, "Title"));

            //click Degree Textbox
            IWebElement degreeTextbox = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            degreeTextbox.Click();

            //input degree
            IWebElement degreeValue = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            degreeValue.SendKeys(ExcelLibHelper.ReadData(3, "Degree"));

            //click year of Gradutaion dropdown list
            IWebElement graduationYearDropdown = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            graduationYearDropdown.Click();

            //select year of Graduation
            IWebElement graduationYear = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            graduationYear.Click();

            //click Add button in education tab
            IWebElement addEducationBtn = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            addEducationBtn.Click();

        }

        public void EditEducation(IWebDriver driver)
        {

            //click on Edit Education Icon
            IWebElement editEducationIcon = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i"));
            editEducationIcon.Click();

            //click on Uni textbox
            IWebElement uniTextbox1 = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input"));
            uniTextbox1.Click();

            //input Uni
            IWebElement uniValue1 = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input"));
            uniValue1.SendKeys(ExcelLibHelper.ReadData(3, "Uni"));

            //click on Choose Uni Country dropdown list
            IWebElement uniCountryDropdown1 = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[2]/select"));
            uniCountryDropdown1.Click();
            Thread.Sleep(1000);

            //select uni Country
            IWebElement uniCountry1 = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[2]/select"));
            uniCountry1.SendKeys(ExcelLibHelper.ReadData(3, "UniCountry"));

            //click on Choose Title in dropdown list
            IWebElement titleDropdown1 = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[1]/select"));
            titleDropdown1.Click();
            Thread.Sleep(1000);

            //select Title
            IWebElement title = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[1]/select"));
            title.SendKeys(ExcelLibHelper.ReadData(3, "Title"));

            //click Degree textbox
            IWebElement degreeTextbox1 = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[2]/input"));
            degreeTextbox1.Click();

            //input degree
            IWebElement degreeValue = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[2]/input"));
            degreeValue.SendKeys(ExcelLibHelper.ReadData(3, "Degree"));

            //click year of Gradutaion dropdown list
            IWebElement graduationYearDropdown1 = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[3]/select"));
            graduationYearDropdown1.Click();

            //select year of Graduation
            IWebElement graduationYear1 = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[3]/select"));
            graduationYear1.Click();

            //click Update button in Education tab
            IWebElement updateEducationBtn = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updateEducationBtn.Click();

            //click Cancel button

        }

        public void DeleteEducation(IWebDriver driver)
        {
            //click delete Icon on Skill tab
            IWebElement deleteEducationIcon = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[3]/tr/td[6]/span[2]/i"));
            deleteEducationIcon.Click();
        }
        public void AddCertifications(IWebDriver driver)
        {
            //click on Certifications tab
            IWebElement certificationsTab = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationsTab.Click();

            //click on Add New Button
            IWebElement addNewCertificationBtn = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            addNewCertificationBtn.Click();

            //click on Certificate textbox
            IWebElement certificateTextbox = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            certificateTextbox.Click();

            //input Cedtificate
            IWebElement certificateValue = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            certificateValue.SendKeys(ExcelLibHelper.ReadData(3, "Certificate"));

            //click Certified from Textbox
            IWebElement certifiedFromTextbox = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            certifiedFromTextbox.Click();

            //input Certified From
            IWebElement certifiedFromValue = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            certifiedFromValue.SendKeys(ExcelLibHelper.ReadData(3, "CertifiedFrom"));

            //click year of Year dropdown list
            IWebElement yearDropdown = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
            yearDropdown.Click();

            //select year of Year
            IWebElement certifiedYear = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
            certifiedYear.Click();

            //click Add button in certification tab
            IWebElement addCertificationBtn = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            addCertificationBtn.Click();

        }

        public void EditCertification(IWebDriver driver)
        {

            //click on Certifications tab
            IWebElement editCertificationsIcon = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[4]/span[1]/i"));
            editCertificationsIcon.Click();

            //click on Certificate textbox
            IWebElement certificateTextbox1 = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            certificateTextbox1.Click();

            //input Cedtificate
            IWebElement certificateValue1 = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            certificateValue1.SendKeys(ExcelLibHelper.ReadData(3, "Certificate"));

            //click Certified from Textbox
            IWebElement certifiedFromTextbox1 = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            certifiedFromTextbox1.Click();

            //input Certified From
            IWebElement certifiedFromValue1 = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            certifiedFromValue1.SendKeys(ExcelLibHelper.ReadData(3, "CertifiedFrom"));

            //click year of Year dropdown list
            IWebElement yearDropdown1 = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
            yearDropdown1.Click();

            //select year of Year
            IWebElement certifiedYear1 = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
            certifiedYear1.Click();

            //click Update button in certification tab
            IWebElement updateCertificationBtn = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
            updateCertificationBtn.Click();

        }

        public void DeleteCertification(IWebDriver driver)
        {
            //click delete Icon on Skill tab
            IWebElement deleteCertificationIcon = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[2]/tr/td[4]/span[2]/i"));
            deleteCertificationIcon.Click();
        }

    }
}
