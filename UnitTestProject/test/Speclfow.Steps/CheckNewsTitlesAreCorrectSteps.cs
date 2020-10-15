using System;
using TechTalk.SpecFlow;

namespace UnitTestProject.test.Speclfow.Steps
{
    [Binding]
    public class CheckNewsTitlesAreCorrectSteps
    {
        [Given(@"the main page of the website is opened")]
        public void GivenTheMainPageOfTheWebsiteIsOpened()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the news page of the website is opened")]
        public void GivenTheNewsPageOfTheWebsiteIsOpened()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on News tab")]
        public void WhenIClickOnNewsTab()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"close ""(.*)"" pop-up")]
        public void WhenClosePop_Up(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I searched article by Category link")]
        public void WhenISearchedArticleByCategoryLink()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see the main news at the top of the site is relevant for today")]
        public void ThenISeeTheMainNewsAtTheTopOfTheSiteIsRelevantForToday()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see the secondary news below the top of the site is relevant for today")]
        public void ThenISeeTheSecondaryNewsBelowTheTopOfTheSiteIsRelevantForToday()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see the first searched article equal expected one")]
        public void ThenISeeTheFirstSearchedArticleEqualExpectedOne()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
