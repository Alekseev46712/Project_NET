using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;


namespace UnitTestProject.test.pages
{
    public class BasePage
    {
        readonly IWebDriver driver;
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        public void ImplicitWait(long timeToWait)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeToWait);
        }

        public void WaitForPageLoadComplete(long timeToWait)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(timeToWait))
                .Until(webDriver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
        }

        public bool ElementIsVisible(IWebElement element)
        {
            return element.Displayed && element.Enabled;
        }
    }
}
