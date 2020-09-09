using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject.test.pages
{
    public class HaveYourSayPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'over 16')]")]
        private IWebElement over16CheckBox;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'accept')]")]
        private IWebElement acceptTermsCheckBox;

        [FindsBy(How = How.XPath, Using = "//textarea[contains(@id,'hearken')]")]
        private IWebElement storyTextArea;

        [FindsBy(How = How.XPath, Using = "//input[@aria-label ='Name']")]
        private IWebElement nameInput;

        [FindsBy(How = How.XPath, Using = "//input[@aria-label ='Email address']")]
        private IWebElement emailInput;

        [FindsBy(How = How.XPath, Using = "//input[@aria-label ='Contact number ']")]
        private IWebElement telInput;

        [FindsBy(How = How.XPath, Using = "//input[@aria-label ='Location ']")]
        private IWebElement locationInput;

        [FindsBy(How = How.XPath, Using = "//button[@class='button']")]
        private IWebElement submitButton;

        [FindsBy(How = How.XPath, Using = "//div[@class='text-input--error']//div[@class='input-error-message']")]
        private IWebElement blankNameErrorMessage;

        [FindsBy(How = How.XPath, Using = "//div[@class='long-text-input-container']//div[@class='input-error-message'] ")]
        private IWebElement blankStoryErrorMessage;

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'must be accepted')]")]
        private IWebElement SubmitWithoutClickCheckBoxOver16ErrorMessage;
        
        //div[contains(text(),'must be accepted')]
        public HaveYourSayPage(IWebDriver driver) : base(driver) { }

        public void clickOnOver16CheckBox() { over16CheckBox.Click(); }

        public void clickOnacceptTermsCheckBox() { acceptTermsCheckBox.Click(); }

        public void fillStoryTextArea(string keyword) { storyTextArea.SendKeys(keyword); }

        public void fillNameInput(string keyword) { nameInput.SendKeys(keyword); }

        public void fillEmailInput(string keyword) { emailInput.SendKeys(keyword); }

        public void fillTelInput(string keyword) { telInput.SendKeys(keyword); }

        public void filllocationInput(string keyword) { locationInput.SendKeys(keyword); }

        public void clickOnSubmitButton() { submitButton.Click(); }

        public string getBlankNameErrorMessage() { return blankNameErrorMessage.Text ; }

        public string getBlankStoryErrorMessage() { return blankStoryErrorMessage.Text; }

        public string getSubmitWithoutClickCheckBoxOver16ErrorMessage() { return SubmitWithoutClickCheckBoxOver16ErrorMessage.Text; }
    }
}
