using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace UnitTestProject.test.pages
{
    public class SearchResultPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'PromoContent')]//a[contains(@href,'bbc')]//span")]
        private IWebElement nameOfArticleOnSearchPage;
        public SearchResultPage(IWebDriver driver) : base(driver) { }
        
        public string GetNameOfArticleOnSearchPage() {return nameOfArticleOnSearchPage.Text; }

    }
}
