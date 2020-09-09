using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Threading;
using UnitTestProject.test.pages;
using UnitTestProject.test.tests;

namespace UnitTestProject
{
    [TestClass]
    public class ArticleTests : BaseTest

    {
        private readonly List<string> expectedSecondaryArticles = new List<string>()
        {
            "Migrant camp fire leaves 13,000 without shelter",
            "Diplomats surround 'harassed' Belarus Nobel winner",
            "US to withdraw 2,200 troops from Iraq within weeks",
            "Terminally ill man backs down on vow to starve",
            "Smoke from California wildfires turns skies orange"
        };

        public string EXPECTED_TOP_HEADLINE = "Book says Trump deliberately downplayed virus";
        public string HEADLINE_OF_THE_ARTICLE_SEARCH_BY_Category_LINK = "Americans, go home: Tension at Canada-US border";
        
        [TestMethod]
        public void checkNameOfTheHeadlineArticle()
        {
            getHomePage().clickOnNews();
            getBasePage().implicitWait(10);
            //getBBCNewsPage().clickOnSighExitButton();
            Assert.AreEqual(EXPECTED_TOP_HEADLINE, getBBCNewsPage().getTextOfTopHeadline());
        }

        [TestMethod]
        public void checkSecondaryArticleTitles()
        {
              getHomePage().clickOnNews();
              getBasePage().implicitWait(10);
            //  getBBCNewsPage().clickOnSighExitButton();
              for(int i=0; i < getBBCNewsPage().getSecondaryArticles().Count; i++)
              {
                Assert.AreEqual(expectedSecondaryArticles[i], getBBCNewsPage().getSecondaryArticles()[i].Text);
              }
        }


        [TestMethod]
        public void checkNameOfArticleSearchedByCategoryLink()
        {
            //IWebDriver driver = new ChromeDriver();
            //IWebElement news = driver.FindElement(By.XPath("//nav//a[contains(@href, 'news')]"));
            //news.Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //IWebElement signInExitButton = driver.FindElement(By.XPath("//button[@class = 'sign_in-exit']"));
            //signInExitButton.Click();
            //IWebElement categoryLink = driver.FindElement(By.XPath("//div[@data-entityid = 'container-top-stories#1']//div[contains(@class, 'promo')]//a[contains(@aria-label, 'World')]//span"));
            //string getTextcategoryLink = categoryLink.Text;
            //driver.FindElement(By.XPath("//input[@id='orb-search-q']")).SendKeys(getTextcategoryLink);
            //driver.FindElement(By.XPath("//input[@id='orb-search-q']")).SendKeys(Keys.Enter);
            //Assert.AreEqual(NAME_OF_THE_HEADLINE_ARTICLE_AFTER_SEARCH_BY_Category_LINK, driver.FindElement(By.XPath("//a[contains(@href,'World')]//span")).Text);

            getHomePage().clickOnNews();
            getBasePage().implicitWait(10);
            getBBCNewsPage().clickOnSighExitButton();
            getBBCNewsPage().searchByKeyword(getBBCNewsPage().getTextOfCategoryLink());
            getBBCNewsPage().searchByKeyword(Keys.Enter);
            Assert.AreEqual(HEADLINE_OF_THE_ARTICLE_SEARCH_BY_Category_LINK, getSearchResultPage().getNameOfArticleOnSearchPage());
        }

    }
    [TestClass]
    public class CoronovirusStoryTests : BaseTest
    {
        public string STORY = "I have coronavirus";
        public string NAME = "Li";
        public string EMAIL = "Li@gmail.com";
        public string CONTACT_NUMBER = "102030";
        public string LOCATION = "China";

        [TestMethod]
        public void checkErrorMessageWhenSubmitEmptyName()
        {
            //    driver.Navigate().GoToUrl(URL);
            //    driver.FindElement(By.XPath("//nav[@role = 'navigation']//a[contains(@href, 'news')]")).Click();
            //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //    driver.FindElement(By.XPath("//button[@class = 'sign_in-exit']")).Click();
            //    driver.FindElement(By.XPath("//nav[@role = 'navigation']//a[contains(@href, 'coronavirus')]  ")).Click();
            //    driver.FindElement(By.XPath("//span[contains(text(),'Your Coronavirus Stories')]")).Click();
            //    driver.FindElement(By.XPath("//a[@href = '/news/10725415']")).Click();
            //    driver.FindElement(By.XPath("//p[contains(text(),'over 16')]")).Click();
            //    driver.FindElement(By.XPath("//p[contains(text(),'accept')]")).Click();
           
            //    driver.FindElement(By.XPath("//textarea[contains(@id,'hearken')]")).SendKeys(STORY);
            //    driver.FindElement(By.XPath("//input[@aria-label ='Name']")).SendKeys("");
            //    driver.FindElement(By.XPath("//input[@aria-label ='Email address']")).SendKeys(EMAIL);
            //    driver.FindElement(By.XPath("//input[@aria-label ='Contact number ']")).SendKeys(CONTACT_NUMBER);
            //    driver.FindElement(By.XPath("//input[@aria-label ='Location ']")).SendKeys(LOCATION);
            //    driver.FindElement(By.XPath("//button[@class='button']")).Click();
            //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //    Assert.AreEqual("Name can't be blank", driver.FindElement(By.XPath("//div[@class='text-input--error']//div[@class='input-error-message']")).Text);
            getHomePage().clickOnNews();
            getBasePage().implicitWait(10);
            getBBCNewsPage().clickOnSighExitButton();
            getBBCNewsPage().clickOnCoronavirusTab();
            getCoronavirusPage().clickOnYourCoronavirusStoryTab();
            getCoronavirusPage().clickOnhowToShareWithBBC();
            getHaveYourSayPage().clickOnOver16CheckBox();
            getHaveYourSayPage().clickOnacceptTermsCheckBox();
            getHaveYourSayPage().fillStoryTextArea(STORY);
            getHaveYourSayPage().fillNameInput("");
            getHaveYourSayPage().fillEmailInput(EMAIL);
            getHaveYourSayPage().fillTelInput(CONTACT_NUMBER);
            getHaveYourSayPage().filllocationInput(LOCATION);
            getHaveYourSayPage().clickOnSubmitButton();
            getBasePage().implicitWait(10);
            Assert.AreEqual("Name can't be blank", getHaveYourSayPage().getBlankNameErrorMessage());
        }

        [TestMethod]
        public void checkErrorMessageWhenSubmitEmptyStory()
        {
            //    driver.Navigate().GoToUrl(URL);
            //    driver.FindElement(By.XPath("//nav[@role = 'navigation']//a[contains(@href, 'news')]")).Click();
            //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //    driver.FindElement(By.XPath("//button[@class = 'sign_in-exit']")).Click();
            //    driver.FindElement(By.XPath("//nav[@role = 'navigation']//a[contains(@href, 'coronavirus')]  ")).Click();
            //    driver.FindElement(By.XPath("//span[contains(text(),'Your Coronavirus Stories')]")).Click();
            //    driver.FindElement(By.XPath("//a[@href = '/news/10725415']")).Click();
            //    driver.FindElement(By.XPath("//p[contains(text(),'over 16')]")).Click();
            //    driver.FindElement(By.XPath("//p[contains(text(),'accept')]")).Click();
            //    driver.FindElement(By.XPath("//textarea[contains(@id,'hearken')]")).SendKeys("");
            //    driver.FindElement(By.XPath("//input[@aria-label ='Name']")).SendKeys(NAME);
            //    driver.FindElement(By.XPath("//input[@aria-label ='Email address']")).SendKeys(EMAIL);
            //    driver.FindElement(By.XPath("//input[@aria-label ='Contact number ']")).SendKeys(CONTACT_NUMBER);
            //    driver.FindElement(By.XPath("//input[@aria-label ='Location ']")).SendKeys(LOCATION);
            //    driver.FindElement(By.XPath("//button[@class='button']")).Click();
            //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //    Assert.AreEqual("can't be blank", driver.FindElement(By.XPath("//div[@class='long-text-input-container']//div[@class='input-error-message'] ")).Text);
            getHomePage().clickOnNews();
            getBasePage().implicitWait(10);
            getBBCNewsPage().clickOnSighExitButton();
            getBBCNewsPage().clickOnCoronavirusTab();
            getCoronavirusPage().clickOnYourCoronavirusStoryTab();
            getCoronavirusPage().clickOnhowToShareWithBBC();
            getHaveYourSayPage().clickOnOver16CheckBox();
            getHaveYourSayPage().clickOnacceptTermsCheckBox();
            getHaveYourSayPage().fillStoryTextArea("");
            getHaveYourSayPage().fillNameInput(NAME);
            getHaveYourSayPage().fillEmailInput(EMAIL);
            getHaveYourSayPage().fillTelInput(CONTACT_NUMBER);
            getHaveYourSayPage().filllocationInput(LOCATION);
            getHaveYourSayPage().clickOnSubmitButton();
            getBasePage().implicitWait(10);
            Assert.AreEqual("can't be blank", getHaveYourSayPage().getBlankStoryErrorMessage());
        }

        [TestMethod]
        public void checkErrorMessageWhenSubmitWithoutClickCheckBoxOver16()
        {
            //    driver.Navigate().GoToUrl(URL);
            //    driver.FindElement(By.XPath("//nav[@role = 'navigation']//a[contains(@href, 'news')]")).Click();
            //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //    driver.FindElement(By.XPath("//button[@class = 'sign_in-exit']")).Click();
            //    driver.FindElement(By.XPath("//nav[@role = 'navigation']//a[contains(@href, 'coronavirus')]  ")).Click();
            //    driver.FindElement(By.XPath("//span[contains(text(),'Your Coronavirus Stories')]")).Click();
            //    driver.FindElement(By.XPath("//a[@href = '/news/10725415']")).Click();
            //    driver.FindElement(By.XPath("//p[contains(text(),'accept')]")).Click();
            //    driver.FindElement(By.XPath("//textarea[contains(@id,'hearken')]")).SendKeys(STORY);
            //    driver.FindElement(By.XPath("//input[@aria-label ='Name']")).SendKeys(NAME);
            //    driver.FindElement(By.XPath("//input[@aria-label ='Email address']")).SendKeys(EMAIL);
            //    driver.FindElement(By.XPath("//input[@aria-label ='Contact number ']")).SendKeys(CONTACT_NUMBER);
            //    driver.FindElement(By.XPath("//input[@aria-label ='Location ']")).SendKeys(LOCATION);
            //    driver.FindElement(By.XPath("//button[@class='button']")).Click();
            //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //    Assert.AreEqual("must be accepted", driver.FindElement(By.XPath("//div[contains(text(),'must be accepted')]")).Text);
            getHomePage().clickOnNews();
            getBasePage().implicitWait(10);
            getBBCNewsPage().clickOnSighExitButton();
            getBBCNewsPage().clickOnCoronavirusTab();
            getCoronavirusPage().clickOnYourCoronavirusStoryTab();
            getCoronavirusPage().clickOnhowToShareWithBBC();
            getHaveYourSayPage().clickOnacceptTermsCheckBox();
            getHaveYourSayPage().fillStoryTextArea(STORY);
            getHaveYourSayPage().fillNameInput("");
            getHaveYourSayPage().fillEmailInput(EMAIL);
            getHaveYourSayPage().fillTelInput(CONTACT_NUMBER);
            getHaveYourSayPage().filllocationInput(LOCATION);
            getHaveYourSayPage().clickOnSubmitButton();
            getBasePage().implicitWait(10);
            Assert.AreEqual("must be accepted", getHaveYourSayPage().getSubmitWithoutClickCheckBoxOver16ErrorMessage());
        }
    }
}

































