using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using UnitTestProject.test;
using UnitTestProject.test.tests;

namespace UnitTestProject
{
    [TestClass]
    public class TitleTests : BaseTest
    {
        public string EXPECTED_TOP_HEADLINE = "Trump denies minimising Covid risk: I 'up-played' it";
        
        [TestMethod]
        public void CheckTitleOfMainArticle()
        {
            GetHomePage().ClickOnNews();
            GetBasePage().ImplicitWait(10);
            if (GetBasePage().ElementIsVisible(GetBBCNewsPage().GetSignInPopUP()))
                GetBBCNewsPage().ClickOnSighExitButton();
            Assert.AreEqual(EXPECTED_TOP_HEADLINE, GetBBCNewsPage().GetTextOfTopHeadline());
        }


        private readonly List<string> ExpectedSecondaryArticles = new List<string>()
        {
            "UK teachers 'must get priority access to tests'",
            "UN accuses Venezuela of crimes against humanity",
            "Former athletics head jailed for corruption",
            "Self-driving car operator charged over fatal crash",
            "Barbados to remove Queen as head of state"
        };

        [TestMethod]
        public void CheckSecondaryArticleTitles()
        {
            GetHomePage().ClickOnNews();
            GetBasePage().ImplicitWait(10);
            if (GetBasePage().ElementIsVisible(GetBBCNewsPage().GetSignInPopUP()))
                GetBBCNewsPage().ClickOnSighExitButton();
            for (int i=0; i < GetBBCNewsPage().GetSecondaryArticles().Count; i++)
            {
                Assert.AreEqual(ExpectedSecondaryArticles[i], GetBBCNewsPage().GetSecondaryArticles()[i].Text);
            }
        }


        public string TITLE_OF_THE_ARTICLE_SEARCH_BY_Category_LINK = "US election 2020 polls: Who is ahead - Trump or Biden?";

        [TestMethod]
        public void CheckTitleOfArticleSearchedByCategoryLink()
        {
            GetHomePage().ClickOnNews();
            GetBasePage().ImplicitWait(10);
            if(GetBasePage().ElementIsVisible(GetBBCNewsPage().GetSignInPopUP()))
                GetBBCNewsPage().ClickOnSighExitButton();
            GetBBCNewsPage().SearchByKeyword(GetBBCNewsPage().GetTextOfCategoryLink() + Keys.Enter);
            Assert.AreEqual(TITLE_OF_THE_ARTICLE_SEARCH_BY_Category_LINK, GetSearchResultPage().GetNameOfArticleOnSearchPage());
        }
    }


    [TestClass]
    public class CoronovirusStoryTests : BaseTest
    {
        readonly Dictionary<string, string> FORM_TO_BBC_WITH_EMPTY_STORY_FIELD = new Dictionary<string, string>()
        {
            {"Tell us", "" },
            {"Name", "Li" },
            {"Email", "Li@gmail.com" },
            {"Contact", "1" },
            {"Location", "China" },
        };

        //readonly IList<int> AllCheckBoxesAreSelected = new List<int>() { 1, 2 };
        readonly IList<int> AllCheckBoxesAreSelected = new List<int>() { 1, 2, 3 };

        [TestMethod]
        public void CheckErrorMessageWhenSubmitWithEmptyStory()
        {
            new BusinessLogicLayer(GetDriver()).SubmitStoryToBBC();
            new Form(GetDriver()).FillForm(FORM_TO_BBC_WITH_EMPTY_STORY_FIELD, AllCheckBoxesAreSelected, GetHaveYourSayPage().GetHowToShareForm());
            Assert.AreEqual("can't be blank", GetHaveYourSayPage().GetBlankStoryErrorMessage());
        }


        readonly Dictionary<string, string> FORM_TO_BBC_WITH_EMPTY_NAME_FIELD = new Dictionary<string, string>()
        {
            {"Tell us", "Story" },
            {"Name", "" },
            {"Email", "Email" },
            //{"Age", "20" },
            {"Contact", "10" },
            //{"Postcode", "10" },
            {"Location", "China" },
        };
         
        [TestMethod]
        public void CheckErrorMessageWhenSubmitWithEmptyName()
        {
            new BusinessLogicLayer(GetDriver()).SubmitStoryToBBC();
            new Form(GetDriver()).FillForm(FORM_TO_BBC_WITH_EMPTY_NAME_FIELD, AllCheckBoxesAreSelected, GetHaveYourSayPage().GetHowToShareForm());
            Assert.AreEqual("Name can't be blank", GetHaveYourSayPage().GetBlankNameErrorMessage());
        }


        readonly IList<int> AllCheckBoxesWithoutOver16AreSelected = new List<int>() { 1 };

        [TestMethod]
        public void CheckErrorMessageWhenSubmitWithoutClickCheckBoxOver16()
        {
            new BusinessLogicLayer(GetDriver()).SubmitStoryToBBC();
            new Form(GetDriver()).FillForm(FORM_TO_BBC_WITH_EMPTY_STORY_FIELD, AllCheckBoxesWithoutOver16AreSelected, GetHaveYourSayPage().GetHowToShareForm());
            Assert.AreEqual("must be accepted", GetHaveYourSayPage().GetSubmitWithoutClickCheckBoxOver16ErrorMessage());
        }
    }
}















//public void checkErrorMessageWhenSubmitEmptyName()
//{
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
//
//    getHomePage().clickOnNews();
//    getBasePage().implicitWait(10);
//    getBBCNewsPage().clickOnSighExitButton();
//    getBBCNewsPage().clickOnCoronavirusTab();
//    getCoronavirusPage().clickOnYourCoronavirusStoryTab();
//    getCoronavirusPage().clickOnhowToShareWithBBC();
//    getHaveYourSayPage().clickOnOver16CheckBox();
//    getHaveYourSayPage().clickOnacceptTermsCheckBox();
//    getHaveYourSayPage().fillStoryTextArea("");
//    getHaveYourSayPage().fillNameInput(NAME);
//    getHaveYourSayPage().fillEmailInput(EMAIL);
//    getHaveYourSayPage().fillTelInput(CONTACT_NUMBER);
//    getHaveYourSayPage().filllocationInput(LOCATION);
//    getHaveYourSayPage().clickOnSubmitButton();
//    getBasePage().implicitWait(10);
//    Assert.AreEqual("can't be blank", getHaveYourSayPage().getBlankStoryErrorMessage());
//}
//
//public void checkNameOfArticleSearchedByCategoryLink()
//{
//    IWebDriver driver = new ChromeDriver();
//    IWebElement news = driver.FindElement(By.XPath("//nav//a[contains(@href, 'news')]"));
//    news.Click();
//    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
//    IWebElement signInExitButton = driver.FindElement(By.XPath("//button[@class = 'sign_in-exit']"));
//    signInExitButton.Click();
//    IWebElement categoryLink = driver.FindElement(By.XPath("//div[@data-entityid = 'container-top-stories#1']//div[contains(@class, 'promo')]//a[contains(@aria-label, 'World')]//span"));
//    string getTextcategoryLink = categoryLink.Text;
//    driver.FindElement(By.XPath("//input[@id='orb-search-q']")).SendKeys(getTextcategoryLink);
//    driver.FindElement(By.XPath("//input[@id='orb-search-q']")).SendKeys(Keys.Enter);
//    Assert.AreEqual(NAME_OF_THE_HEADLINE_ARTICLE_AFTER_SEARCH_BY_Category_LINK, driver.FindElement(By.XPath("//a[contains(@href,'World')]//span")).Text);
//}























