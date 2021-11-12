using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;

namespace MarsQA_1.Tests
{
    [TestFixture]
    [Parallelizable]
    class Certifications : Driver
    {


        [Test, Order(1), Description("Check if user is able to Add Certification")]
        public void AddCertifications()
        {
            //homepage object init and def
            HomePage homePagObj = new HomePage();
            homePagObj.GoToProfilePage(driver);

            //profile page object init and def
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.AddCertifications(driver);

        }

        [Test, Order(2), Description("Check if user is able to Edit Certification")]
        public void EditCertification()
        {
            //homepage object init and def
            HomePage homePagObj = new HomePage();
            homePagObj.GoToProfilePage(driver);

            //profile page object init and def
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.EditCertification(driver);
        }

        [Test, Order(3), Description("Check if user is able to Delete Certification")]
        public void DeleteCertification()
        {
            //homepage object init and def
            HomePage homePagObj = new HomePage();
            homePagObj.GoToProfilePage(driver);

            //profile page object init and def
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.DeleteCertification(driver);

        }
    }
}
