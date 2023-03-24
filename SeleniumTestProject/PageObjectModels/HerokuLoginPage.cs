using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.PageObjectModels
{
    public class HerokuLoginPage : BasePage
    {
        public HerokuLoginPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement UserNameInput => driver.FindElement(By.Id("username"));
        private IWebElement PasswordInput => driver.FindElement(By.Id("password"));
        private IWebElement SubmitButton => driver.FindElement(By.CssSelector("button[type='submit']"));
        private IWebElement ErrorMessage => driver.FindElement(By.CssSelector("#flash.error"));

        public void Login(string username, string password)
        {
            UserNameInput.SendKeys(username);
            PasswordInput.SendKeys(password);
            SubmitButton.Click();
        }

        public bool IsErrorMessageDisplayed()
        {
            return ErrorMessage.Displayed;
        }
    }
}
