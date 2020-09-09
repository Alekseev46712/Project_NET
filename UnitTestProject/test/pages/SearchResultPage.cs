using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;

namespace UnitTestProject.test.pages
{
    public class SearchResultPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//a[contains(@href,'us')]//span")]
        private IWebElement nameOfArticleOnSearchPage;
        public SearchResultPage(IWebDriver driver) : base(driver) { }
        
        public string getNameOfArticleOnSearchPage() {return nameOfArticleOnSearchPage.Text; }

    }
}
