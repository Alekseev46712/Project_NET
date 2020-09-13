using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;

namespace UnitTestProject
{
    class Form
    {
        private readonly IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//button[@class='button']")]
        private IWebElement SubmitButton;

        public Form(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void FillForm(Dictionary<string, string> values, IList<int> checkboxNumbers, IWebElement form)
        {
            foreach (var value in values)
            {
                if (value.Value != null)
                    form.FindElement(By.XPath("//*[contains(@aria-label, '" + value.Key + "')]")).SendKeys(value.Value);
            }
                foreach (int checkbox in checkboxNumbers)
            {
                form.FindElement(By.XPath("//div[@class='checkbox'][" + checkbox + "]//p")).Click();
            }

            SubmitButton.Click();
        }
    }
}

