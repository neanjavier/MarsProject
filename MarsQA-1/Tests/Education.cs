using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace MarsQA_1.Tests
{
    [TestFixture]
    [Parallelizable]
    class Education : Driver
    {


        [Test, Order(1), Description("Check if user is able to Add Education")]
        public void AddEducation()
        {
            //homepage object init and def
            HomePage homePagObj = new HomePage();
            homePagObj.GoToProfilePage(driver);

            //profile page object init and def
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.AddEducation(driver);

        }

        [Test, Order(2), Description("Check if user is able to Edit Education")]
        public void EditEducation()
        {
            //homepage object init and def
            HomePage homePagObj = new HomePage();
            homePagObj.GoToProfilePage(driver);

            //profile page object init and def
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.EditEducation(driver);
        }

        [Test, Order(3), Description("Check if user is able to Delete Education")]
        public void DeleteEducation()
        {
            //homepage object init and def
            HomePage homePagObj = new HomePage();
            homePagObj.GoToProfilePage(driver);

            //profile page object init and def
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.DeleteLanguage(driver);

        }
    }
}
