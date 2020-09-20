using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
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

        public IWebDriver GetDriver() { return driver; }

        public BasePage GetBasePage() { return new BasePage(GetDriver()); }
       
        public HomePage GetHomePage() { return new HomePage(GetDriver()); }

        public BbcNewsPage GetBBCNewsPage() { return new BbcNewsPage(GetDriver()); }

        public SearchResultPage GetSearchResultPage() { return new SearchResultPage(GetDriver()); }

        public CoronavirusPage GetCoronavirusPage() { return new CoronavirusPage(GetDriver()); }

        public HaveYourSayPage GetHaveYourSayPage() { return new HaveYourSayPage(GetDriver()); }
        
    }
}
