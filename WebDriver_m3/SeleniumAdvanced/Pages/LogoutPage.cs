using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvanced
{
    class LogoutPage
    {
        private IWebDriver driver;
        public LogoutPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        [FindsBy(How = How.XPath, Using = ".//*[@type='submit']")]
        private IWebElement loginButton;

        [FindsBy(How = How.XPath, Using = ".//button[@class='header-logout']")]
        private IWebElement logoutButton;

        public void Logout()
        {
            new Actions(driver).Click(logoutButton).Build().Perform();
        }

        public Boolean isLogoutPerformedSuccessfully()
        {
            try
            {
                return loginButton.Displayed;
            }
            catch (Exception e)
            {
                return true;
            }
        }
    }
}
