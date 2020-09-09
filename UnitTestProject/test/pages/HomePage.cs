using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using CacheLookAttribute = SeleniumExtras.PageObjects.CacheLookupAttribute;

namespace UnitTestProject.test.pages
{
    public class HomePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//nav//a[contains(@href, 'news')]")]
        private IWebElement news;

        public HomePage(IWebDriver driver) : base(driver) { }
        
        public void clickOnNews(){ news.Click(); }

       

    }
}
