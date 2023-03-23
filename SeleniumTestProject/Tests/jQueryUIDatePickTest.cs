using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumTestProject.PageObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.Tests
{
    public class jQueryUIDatePickTest : IDisposable
    {
        private readonly IWebDriver driver;
        private readonly JQueryUIDatePickPage jQueryUIDatePickPage;

        public jQueryUIDatePickTest()
        {
            driver = new ChromeDriver();
            jQueryUIDatePickPage = new JQueryUIDatePickPage(driver);
        }

        [Fact]
        public void SelectDateAndAcceptTerms()
        {
            driver.Navigate().GoToUrl("https://jqueryui.com/datepicker/");

            jQueryUIDatePickPage.SelectDate(15);
            jQueryUIDatePickPage.CheckTermsAndSubmit();

            // Wait for the selected date to be displayed on the next page
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(driver => jQueryUIDatePickPage.SelectedDate.Displayed);

            // Verify that the selected date is displayed on the next page
            Assert.Equal("15", jQueryUIDatePickPage.SelectedDate.Text);
        }

        public void Dispose()
        {
            driver.Dispose();
            driver.Quit();
        }
    }
}
