using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using CacheLookAttribute = SeleniumExtras.PageObjects.CacheLookupAttribute;



namespace UnitTestProject.test.pages
{
    public class BasePage
    {
        readonly IWebDriver driver;
        private WebDriverWait wait;
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//nav//a[contains(@href, 'news')]")]
        private IWebElement news;

        public void implicitWait(long timeToWait)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeToWait);
        }

        public void clickOnNews() { news.Click(); }
    }
}
