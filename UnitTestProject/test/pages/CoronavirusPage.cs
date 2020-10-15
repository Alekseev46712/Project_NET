using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace UnitTestProject.test.pages
{
    public class CoronavirusPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Your Coronavirus Stories')]")]
        private IWebElement YourCoronavirusStoryTab;

        [FindsBy(How = How.XPath, Using = "//a[@href = '/news/10725415']")]
        private IWebElement HowToShareWithBBC;


        public CoronavirusPage(IWebDriver driver) : base(driver) { }

        public void ClickOnYourCoronavirusStoryTab() { YourCoronavirusStoryTab.Click(); }

        public void ClickOnhowToShareWithBBC() { HowToShareWithBBC.Click(); }


    }
}
