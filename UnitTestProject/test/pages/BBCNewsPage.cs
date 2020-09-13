using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;



namespace UnitTestProject.test.pages
{
    public class BbcNewsPage : BasePage
    {

        [FindsBy(How = How.XPath, Using = "//button[@class = 'sign_in-exit']")]
        private IWebElement SighExitButton;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'top')]//h3[contains(@class, 'paragon-bold')]")]
        private IWebElement TopHeadline;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'top-stories__secondary-item')]//h3")]
        private IList<IWebElement> SecondaryArticles;

        [FindsBy(How = How.XPath, Using = "//div[@data-entityid = 'container-top-stories#1']//div[contains(@class, 'promo')]//a//span")]
        private IWebElement CategoryLink;

        [FindsBy(How = How.XPath, Using = "//input[@id='orb-search-q']")]
        private IWebElement SearchInput;

        [FindsBy(How = How.XPath, Using = "//nav[@role = 'navigation']//a[contains(@href, 'coronavirus')]  ")]
        private IWebElement CoronavirusTab;

        [FindsBy(How = How.XPath, Using = "//div[@id='sign_in']")]
        private IWebElement SignInPopUP;

        public BbcNewsPage(IWebDriver driver) : base(driver) { }

        public string GetTextOfTopHeadline() { return TopHeadline.Text; }

        public void ClickOnSighExitButton() { SighExitButton.Click(); }

        public IList<IWebElement> GetSecondaryArticles() { return SecondaryArticles; }

        public string GetTextOfCategoryLink() { return CategoryLink.Text; }

        public void SearchByKeyword(string keyword) { SearchInput.SendKeys(keyword); }

        public void ClickOnCoronavirusTab() { CoronavirusTab.Click(); }

        public IWebElement GetSignInPopUP() { return SignInPopUP; }
    }       
}
