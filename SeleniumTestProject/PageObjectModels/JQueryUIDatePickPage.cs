using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.PageObjectModels
{
  
    public class JQueryUIDatePickPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public JQueryUIDatePickPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public IWebElement DateInput => wait.Until(driver => driver.FindElement(By.Id("datepicker")));

        public IWebElement SelectedDate => wait.Until(driver => driver.FindElement(By.CssSelector(".ui-state-active")));

        public IWebElement TermsCheckbox => wait.Until(driver => driver.FindElement(By.Id("terms")));

        public IWebElement SubmitButton => wait.Until(driver => driver.FindElement(By.Id("submit")));

        public void SelectDate(int day)
        {
            // This clicks on the date input field to open the datepicker
            DateInput.Click();

            // This finds the date to select and clicks on it
            var dateToSelect = driver.FindElement(By.XPath($"//table[@class='ui-datepicker-calendar']//td/a[text()='{day}']"));
            dateToSelect.Click();
        }

        public void CheckTermsAndSubmit()
        {
            // Check the terms of checkbox
            TermsCheckbox.Click();

            // Clicks on the submit button
            SubmitButton.Click();
        }

    }
}
