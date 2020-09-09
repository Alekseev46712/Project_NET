using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;



namespace UnitTestProject.test.pages
{
    public class BBCNewsPage : BasePage
    {

        [FindsBy(How = How.XPath, Using = "//button[@class = 'sign_in-exit']")]
        private IWebElement sighExitButton;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'top')]//h3[contains(@class, 'paragon-bold')]")]
        private IWebElement topHeadline;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'top-stories__secondary-item')]//h3")]
        private IList<IWebElement> secondaryArticles;

        [FindsBy(How = How.XPath, Using = "//div[@data-entityid = 'container-top-stories#1']//div[contains(@class, 'promo')]//a[contains(@aria-label, 'US')]//span")]
        private IWebElement categoryLink;

        [FindsBy(How = How.XPath, Using = "//input[@id='orb-search-q']")]
        private IWebElement searchInput;

        [FindsBy(How = How.XPath, Using = "//nav[@role = 'navigation']//a[contains(@href, 'coronavirus')]  ")]
        private IWebElement coronavirusTab;


        public BBCNewsPage(IWebDriver driver) : base(driver) {}

        public string getTextOfTopHeadline() { return topHeadline.Text; }

        public void clickOnSighExitButton() { sighExitButton.Click(); }

        public IList<IWebElement> getSecondaryArticles() { return secondaryArticles; }

        public string getTextOfCategoryLink() { return categoryLink.Text; }

        public void searchByKeyword(string keyword) { searchInput.SendKeys(keyword); }

        public void clickOnCoronavirusTab() { coronavirusTab.Click(); }
    }
}
