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
    class Languages : Driver
    {

        [Test, Order (1), Description("Check if user is able to Add Language")]
        public void AddLangugaes()
        {
            //homepage object init and def
            HomePage homePagObj = new HomePage();
            homePagObj.GoToProfilePage(driver);

            //profile page object init and def
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.AddLanguages(driver);

        }

        [Test, Order(2), Description("Check if user is able to Edit Language")]
        public void EditLanguages()
        {
            //homepage object init and def
            HomePage homePagObj = new HomePage();
            homePagObj.GoToProfilePage(driver);

            //profile page object init and def
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.EditLanguages(driver);
        }

        [Test, Order(3), Description("Check if user is able to Delete Language")]
        public void DeleteLanguage()
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
