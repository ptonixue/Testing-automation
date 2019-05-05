using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SelenimBasicsDemo
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
            IWebElement loginField = driver.FindElement(By.XPath(".//*[@type='text']"));
            loginField.SendKeys("admin");
            driver.FindElement(By.XPath(".//*[@type='password']")).SendKeys("admin");
            driver.FindElement(By.XPath(".//*[@type='submit']")).Click();

        }

        [TearDown]
        public void TearDownDriver()
        {
            driver.Quit();
        }

        [Test]
        public void step1()
        {
            //Проверка, что логин прошел успешно
            IWebElement newPostButton = driver.FindElement(By.CssSelector(".panel-container__newPost"));
            Assert.IsTrue(newPostButton.Displayed, "Login is failed");
        }

        [Test]
        public void step2()
        {
            //create new post
            driver.FindElement(By.XPath(".//a[@class='panel-container__newPost']")).Click();
            driver.FindElement(By.XPath(".//label[@class='post-edit__title']/child::input")).SendKeys("Заголовок статьи");
            driver.FindElement(By.XPath(".//label[@class='post-edit__url']/child::input")).SendKeys("Ссылка");
            driver.FindElement(By.XPath(".//label/child::textarea")).SendKeys("Lorem ipsum dolor sit amet, consectetur adipisicing elit. Assumenda, cum.");
            driver.FindElement(By.XPath(".//input[@value='Publish']")).Click();

            //Проверка, что пост создан успешно
            driver.Navigate().GoToUrl("http://192.168.99.100:3030");
            IWebElement newPost = driver.FindElement(By.XPath(".//h2[text()='Заголовок статьи']"));
            Assert.IsTrue(newPost.Displayed, "New post is failed");
        }

        [Test]
        public void step3()
        {
            //logout
            driver.FindElement(By.XPath(".//button[@class='header-logout']")).Click();

            //Проверка, что выход прошел успешно
            IWebElement loginButton = driver.FindElement(By.XPath(".//input[@type='submit']"));
            Assert.IsTrue(loginButton.Displayed, "Logout is failed");
        }
    }
}
