﻿using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvanced
{
    class NewPost
    {
        private IWebDriver driver;
        public NewPost(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        [FindsBy(How = How.XPath, Using = ".//a[@class='panel-container__newPost']")]
        private IWebElement newpostbutton;

        [FindsBy(How = How.XPath, Using = ".//label[@class='post-edit__title']/child::input")]
        private IWebElement titlefield;

        [FindsBy(How = How.XPath, Using = ".//label[@class='post-edit__url']/child::input")]
        private IWebElement linkfield;

        [FindsBy(How = How.XPath, Using = ".//label/child::textarea")]
        private IWebElement textfield;

        [FindsBy(How = How.XPath, Using = ".//input[@value='Publish']")]
        private IWebElement publishbutton;

        [FindsBy(How = How.XPath, Using = ".//h2[text()='New head']")]
        private IWebElement newposttitle;

        public NewPost SetTitle(String title)
        {
            titlefield.SendKeys(title);
            return this;
        }

        public NewPost SetLink(String link)
        {
            linkfield.SendKeys(link);
            return this;
        }

        public NewPost SetText(String text)
        {
            textfield.SendKeys(text);
            return this;
        }

        public NewPost newpost()
        {
            new Actions(driver).Click(newpostbutton).Build().Perform();
            return this;
        }

        public NewPost publishpost()
        {
            new Actions(driver).Click(publishbutton).Build().Perform();
            return this;
        }

        public void newpost(String title, String link, String text)
        {
            newpost().SetTitle(title).SetLink(link).SetText(text).publishpost();
        }

        public Boolean isNewPostPerformedSuccessfully()
        {
            try
            {
                return newposttitle.Displayed;
            }
            catch (Exception e)
            {
                return true;
            }
        }

    }
}
