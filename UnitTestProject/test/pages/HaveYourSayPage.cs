using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace UnitTestProject.test.pages
{
    public class HaveYourSayPage : BasePage
    {
        //[FindsBy(How = How.XPath, Using = "//div[@id='hearken-embed-module-4787-1272e']")]
        //private IWebElement HowToShareForm;

        [FindsBy(How = How.Id, Using = "hearken-curiosity-6173")]
        private IWebElement HowToShareForm;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'over 16')]")]
        private IWebElement Over16CheckBox;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'accept')]")]
        private IWebElement AcceptTermsCheckBox;

        [FindsBy(How = How.XPath, Using = "//textarea[contains(@id,'hearken')]")]
        private IWebElement StoryTextArea;

        [FindsBy(How = How.XPath, Using = "//input[@aria-label ='Name']")]
        private IWebElement NameInput;

        [FindsBy(How = How.XPath, Using = "//input[@aria-label ='Email address']")]
        private IWebElement EmailInput;

        [FindsBy(How = How.XPath, Using = "//input[@aria-label ='Age']")]
        private IWebElement AgeInput;

        [FindsBy(How = How.XPath, Using = "//input[@aria-label ='Telephone number']")]
        private IWebElement TelInput;

        [FindsBy(How = How.XPath, Using = "//input[@aria-label ='Postcode']")]
        private IWebElement PostcodeInput;

        [FindsBy(How = How.XPath, Using = "//input[@aria-label ='Location']")]
        private IWebElement LocationInput;

        [FindsBy(How = How.XPath, Using = "//button[@class='button']")]
        private IWebElement SubmitButton;

        [FindsBy(How = How.XPath, Using = "//div[@class='text-input--error']//div[@class='input-error-message']")]
        private IWebElement BlankNameErrorMessage;

        [FindsBy(How = How.XPath, Using = "//div[@class='long-text-input-container']//div[@class='input-error-message'] ")]
        private IWebElement BlankStoryErrorMessage;

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'must be accepted')]")]
        private IWebElement SubmitWithoutClickCheckBoxOver16ErrorMessage;


       // public void FillForm(Dictionary<string, string> values, IList<int> checkboxNumbers, IWebElement form) { form.FillForm(values, checkboxNumbers, form); }


        public HaveYourSayPage(IWebDriver driver) : base(driver) { }

        public void ClickOnOver16CheckBox() { Over16CheckBox.Click(); }

        public void ClickOnacceptTermsCheckBox() { AcceptTermsCheckBox.Click(); }

        public void FillStoryTextArea(string keyword) { StoryTextArea.SendKeys(keyword); }

        public void FillNameInput(string keyword) { NameInput.SendKeys(keyword); }

        public void FillEmailInput(string keyword) { EmailInput.SendKeys(keyword); }

        public void FillAgeInput(string keyword) { AgeInput.SendKeys(keyword); }

        public void FillTelInput(string keyword) { TelInput.SendKeys(keyword); }

        public void FillPostcodeInput(string keyword) { PostcodeInput.SendKeys(keyword); }

        public void FilllocationInput(string keyword) { LocationInput.SendKeys(keyword); }

        public void ClickOnSubmitButton() { SubmitButton.Click(); }

        public string GetBlankNameErrorMessage() { return BlankNameErrorMessage.Text ; }

        public string GetBlankStoryErrorMessage() { return BlankStoryErrorMessage.Text; }

        public string GetSubmitWithoutClickCheckBoxOver16ErrorMessage() { return SubmitWithoutClickCheckBoxOver16ErrorMessage.Text; }
        
        public IWebElement GetHowToShareForm() { return HowToShareForm; }
    }
}
