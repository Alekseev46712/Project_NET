using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using System;

namespace UnitTestProject.test.pages
{
    public class HomePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//nav//a[contains(@href, 'news')]")]
        private readonly IWebElement news;

        public HomePage(IWebDriver driver) : base(driver) { }
        
        public void ClickOnNews() { news.Click(); }
    }
}
