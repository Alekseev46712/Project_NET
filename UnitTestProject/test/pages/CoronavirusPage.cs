using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject.test.pages
{
    public class CoronavirusPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Your Coronavirus Stories')]")]
        private IWebElement yourCoronavirusStoryTab;

        [FindsBy(How = How.XPath, Using = "//a[@href = '/news/10725415']")]
        private IWebElement howToShareWithBBC;
        

        public CoronavirusPage(IWebDriver driver) : base(driver) { }

        public void clickOnYourCoronavirusStoryTab() { yourCoronavirusStoryTab.Click(); }

        public void clickOnhowToShareWithBBC() { howToShareWithBBC.Click(); }


    }
}
