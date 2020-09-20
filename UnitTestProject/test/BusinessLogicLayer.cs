using OpenQA.Selenium;
using System;
using UnitTestProject.test.pages;

namespace UnitTestProject.test
{
    class BusinessLogicLayer
    {
        private readonly IWebDriver driver;

        public BusinessLogicLayer(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SubmitStoryToBBC()
        {
            new HomePage(driver).ClickOnNews();
            new BasePage(driver).ImplicitWait(10);
            if(new BasePage(driver).ElementIsVisible(new BbcNewsPage(driver).GetSignInPopUP()))
                new BbcNewsPage(driver).ClickOnSighExitButton();
            new BbcNewsPage(driver).ClickOnCoronavirusTab();
            new CoronavirusPage(driver).ClickOnYourCoronavirusStoryTab();
            new CoronavirusPage(driver).ClickOnhowToShareWithBBC();
        }
    }
}
