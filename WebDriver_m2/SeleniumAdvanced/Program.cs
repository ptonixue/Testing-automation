using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumAdvanced
{
    [TestFixture]
    public class Program
    {
        static void Main(string[] args)
        {
        }

        IWebDriver driver;

        [SetUp]
        public void SetUpDriver()
        {
            driver = new ChromeDriver();
            driver.Url = "http://192.168.99.100:3030/admin";

            //login
        }

        [TearDown]
        public void TearDownDriver()
        {
            Thread.Sleep(3000);
            driver.Quit();
        }

        [Test]
        public void LoginTest()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("admin", "admin");
            Assert.IsTrue(loginPage.isLoginPerformedSuccessfully(), "Login failed");
        }

        [Test]
        public void NewPostTest()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("admin", "admin");

            NewPost newpost = new NewPost(driver);
            newpost.newpost("New head", "Link", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Assumenda, cum.");

            //Проверка, что пост создан успешно
            driver.Navigate().GoToUrl("http://192.168.99.100:3030");
            Assert.IsTrue(newpost.isNewPostPerformedSuccessfully(), "New post failed");
        }

        [Test]
        public void LogoutTest()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("admin", "admin");

            LogoutPage logoutPage = new LogoutPage(driver);
            logoutPage.Logout();

            Assert.IsTrue(logoutPage.isLogoutPerformedSuccessfully(), "Logout failed");
        }
    }
}
