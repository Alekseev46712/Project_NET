using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestPart1
    {
        public string NAME_OF_THE_HEADLINE_ARTICLE = "Portland suspect shot dead by police during arrest";
        public string NAME_OF_THE_HEADLINE_ARTICLE_AFTER_SEARCH_BY_Category_LINK = "Americans, go home: Tension at Canada-US border";
        public string URL = "https://www.bbc.com";

        [TestMethod]
        public void checkNameOfTheHeadlineArticle()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(URL);
            driver.FindElement(By.XPath("//nav[@role = 'navigation']//a[contains(@href, 'news')]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//button[@class = 'sign_in-exit']")).Click();
            Assert.AreEqual(driver.FindElement(By.XPath("//div[contains(@class, 'top')]//h3[contains(@class, 'paragon-bold')]")).Text, NAME_OF_THE_HEADLINE_ARTICLE);
            driver.Close();
        }

        [TestMethod]
        public void checkSecondaryArticleTitles()
        {
            Collection<string> SECONDARY_ARTICLES_TITLES = new Collection<string>() { "US unemployment rate falls below 10%" };
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(URL);
            driver.FindElement(By.XPath("//nav[@role = 'navigation']//a[contains(@href, 'news')]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IList<IWebElement> SECONDARY_ARTICLES_TITLES_LIST = driver.FindElements(By.XPath("//div[contains(@class, 'top-stories__secondary-item')]//h3[contains(@class,'gs')]"));
            foreach(IWebElement element in SECONDARY_ARTICLES_TITLES_LIST)
            {
                
                Assert.AreEqual(SECONDARY_ARTICLES_TITLES, element);
            }
        }

        [TestMethod]
        public void checkNameOfArticleSearchedByCategoryLink()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(URL);
            driver.FindElement(By.XPath("//nav[@role = 'navigation']//a[contains(@href, 'news')]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//button[@class = 'sign_in-exit']")).Click();
            string CATEGORY_LINK_OF_THE_HEADLINE_ARTICLE = driver.FindElement(By.XPath("//div[@data-entityid = 'container-top-stories#1']//div[contains(@class, 'promo')]//a[contains(@aria-label, 'US')]//span")).Text;
            driver.FindElement(By.XPath("//input[@id='orb-search-q']")).SendKeys(CATEGORY_LINK_OF_THE_HEADLINE_ARTICLE);
            driver.FindElement(By.XPath("//input[@id='orb-search-q']")).SendKeys(Keys.Enter);
            Assert.AreEqual(NAME_OF_THE_HEADLINE_ARTICLE_AFTER_SEARCH_BY_Category_LINK, driver.FindElement(By.XPath("//a[contains(@href,'us-canada')]//span")).Text);
            driver.Close();
        }
    }
    [TestClass]
    public class UnitTestPart2
    {
        public string URL = "https://www.bbc.com";
        public string STORY = "I have coronavirus";
        public string NAME = "Li";
        public string EMAIL = "Li@gmail.com";
        public string CONTACT_NUMBER = "102030";
        public string LOCATION = "China";

        [TestMethod]
        public void checkErrorMessageWhenSubmitEmptyName()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(URL);
            driver.FindElement(By.XPath("//nav[@role = 'navigation']//a[contains(@href, 'news')]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//button[@class = 'sign_in-exit']")).Click();
            driver.FindElement(By.XPath("//nav[@role = 'navigation']//a[contains(@href, 'coronavirus')]  ")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'Your Coronavirus Stories')]")).Click();
            driver.FindElement(By.XPath("//a[@href = '/news/10725415']")).Click();
            driver.FindElement(By.XPath("//p[contains(text(),'over 16')]")).Click();
            driver.FindElement(By.XPath("//p[contains(text(),'accept')]")).Click();
            driver.FindElement(By.XPath("//textarea[contains(@id,'hearken')]")).SendKeys(STORY);
            driver.FindElement(By.XPath("//input[@aria-label ='Name']")).SendKeys("");
            driver.FindElement(By.XPath("//input[@aria-label ='Email address']")).SendKeys(EMAIL);
            driver.FindElement(By.XPath("//input[@aria-label ='Contact number ']")).SendKeys(CONTACT_NUMBER);
            driver.FindElement(By.XPath("//input[@aria-label ='Location ']")).SendKeys(LOCATION);
            driver.FindElement(By.XPath("//button[@class='button']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Assert.AreEqual("Name can't be blank", driver.FindElement(By.XPath("//div[@class='text-input--error']//div[@class='input-error-message']")).Text);
            driver.Close();
        }

        [TestMethod]
        public void checkErrorMessageWhenSubmitEmptyStory()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(URL);
            driver.FindElement(By.XPath("//nav[@role = 'navigation']//a[contains(@href, 'news')]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//button[@class = 'sign_in-exit']")).Click();
            driver.FindElement(By.XPath("//nav[@role = 'navigation']//a[contains(@href, 'coronavirus')]  ")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'Your Coronavirus Stories')]")).Click();
            driver.FindElement(By.XPath("//a[@href = '/news/10725415']")).Click();
            driver.FindElement(By.XPath("//p[contains(text(),'over 16')]")).Click();
            driver.FindElement(By.XPath("//p[contains(text(),'accept')]")).Click();
            driver.FindElement(By.XPath("//textarea[contains(@id,'hearken')]")).SendKeys("");
            driver.FindElement(By.XPath("//input[@aria-label ='Name']")).SendKeys(NAME);
            driver.FindElement(By.XPath("//input[@aria-label ='Email address']")).SendKeys(EMAIL);
            driver.FindElement(By.XPath("//input[@aria-label ='Contact number ']")).SendKeys(CONTACT_NUMBER);
            driver.FindElement(By.XPath("//input[@aria-label ='Location ']")).SendKeys(LOCATION);
            driver.FindElement(By.XPath("//button[@class='button']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Assert.AreEqual("can't be blank", driver.FindElement(By.XPath("//div[@class='long-text-input-container']//div[@class='input-error-message'] ")).Text);
            driver.Close();
        }

        [TestMethod]
        public void checkErrorMessageWhenSubmitWithoutClickCheckBoxOver16()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(URL);
            driver.FindElement(By.XPath("//nav[@role = 'navigation']//a[contains(@href, 'news')]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//button[@class = 'sign_in-exit']")).Click();
            driver.FindElement(By.XPath("//nav[@role = 'navigation']//a[contains(@href, 'coronavirus')]  ")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'Your Coronavirus Stories')]")).Click();
            driver.FindElement(By.XPath("//a[@href = '/news/10725415']")).Click();
            driver.FindElement(By.XPath("//p[contains(text(),'accept')]")).Click();
            driver.FindElement(By.XPath("//textarea[contains(@id,'hearken')]")).SendKeys(STORY);
            driver.FindElement(By.XPath("//input[@aria-label ='Name']")).SendKeys(NAME);
            driver.FindElement(By.XPath("//input[@aria-label ='Email address']")).SendKeys(EMAIL);
            driver.FindElement(By.XPath("//input[@aria-label ='Contact number ']")).SendKeys(CONTACT_NUMBER);
            driver.FindElement(By.XPath("//input[@aria-label ='Location ']")).SendKeys(LOCATION);
            driver.FindElement(By.XPath("//button[@class='button']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Assert.AreEqual("must be accepted", driver.FindElement(By.XPath("//div[contains(text(),'must be accepted')]")).Text);
            driver.Close();
        }
    }
}
