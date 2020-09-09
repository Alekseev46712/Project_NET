using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using UnitTestProject.test.pages;

namespace UnitTestProject.test.tests
{
    [TestFixture]
    public class BaseTest
    {
        private IWebDriver driver;
        [TestInitialize]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.bbc.com");
            

        }
        [TestCleanup]
        public void RunAfterAnytests() { driver.Close(); }

        public IWebDriver getDriver() { return driver; }

        public BasePage getBasePage() { return new BasePage(getDriver()); }
       
        public HomePage getHomePage() { return new HomePage(getDriver()); }

        public BBCNewsPage getBBCNewsPage() { return new BBCNewsPage(getDriver()); }

        public SearchResultPage getSearchResultPage() { return new SearchResultPage(getDriver()); }

        public CoronavirusPage getCoronavirusPage() { return new CoronavirusPage(getDriver()); }

        public HaveYourSayPage getHaveYourSayPage() { return new HaveYourSayPage(getDriver()); }
        
    }
}
