using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace MarsQA_1.SpecflowPages.Pages
{
    class HomePage
    {
        public void GoToProfilePage(IWebDriver driver)
        {
            //hover to Menu tab
            IWebElement accountNameDropdown = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div[2]/div/span"));
            Actions action = new Actions(driver);
            action.MoveToElement(accountNameDropdown).Perform();

            //click on Go to Profile
            IWebElement profilePage = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div[2]/div/span/div/a[1]"));
            profilePage.Click();
        }
    }
}
