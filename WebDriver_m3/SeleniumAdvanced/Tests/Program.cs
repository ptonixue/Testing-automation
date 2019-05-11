using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumAdvanced.BO;
using SeleniumAdvanced.BusinessFunctions;
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

            User user = TestUsersGenerator.GenerateValidUser();
            LoginFunctions loginFunc = new LoginFunctions(driver);
            loginFunc.Login(user);
        }

        [TearDown]
        public void TearDownDriver()
        {
            Thread.Sleep(2000);
            driver.Quit();
        }

        [Test]
        public void LoginTest()
        {
            LoginPage loginPage = new LoginPage(driver);
            Assert.IsTrue(loginPage.isLoginPerformedSuccessfully(), "Login failed");
        }

        [Test]
        public void LogoutTest()
        {
            LoginPage loginPage = new LoginPage(driver);

            LogoutPage logoutPage = new LogoutPage(driver);
            logoutPage.Logout();

            Assert.IsTrue(logoutPage.isLogoutPerformedSuccessfully(), "Logout failed");
        }

        [Test]
        public void NewPostTest()
        {
            LoginPage loginPage = new LoginPage(driver);

            Post post = TestPostGenerator.GeneratePostNum2();

            PostFunctions postFunc = new PostFunctions(driver);
            postFunc.Post(post);

            NewPostPage newpost = new NewPostPage(driver);

            //Проверка, что пост создан успешно
            driver.Navigate().GoToUrl("http://192.168.99.100:3030");
            Assert.IsTrue(newpost.isNewPostPerformedSuccessfully(), "New post failed");
        }
    }
}
