using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.Tests
{
    public class DemoQADatePickTest : IDisposable
    {
        private readonly IWebDriver _driver;

        public DemoQADatePickTest()
        {
            _driver = new ChromeDriver();
        }
        public void Dispose()
        {
            _driver.Dispose();
            _driver.Quit();
        }

        [Fact]
        public void SelectDate()
        {
            // Navigate to the Date Picker page
            _driver.Navigate().GoToUrl("https://demoqa.com/date-picker");

            // Find and click the date input field
            IWebElement dateInput = _driver.FindElement(By.Id("datePickerMonthYearInput"));
            dateInput.Click();

            // Find and click the desired date in the date picker
            IWebElement date = _driver.FindElement(By.XPath("//div[@class='react-datepicker__month']//div[text()='15']"));
            date.Click();

            // Verify that the selected date is displayed in the input field
            string selectedDate = dateInput.GetAttribute("value");
            Assert.Equal("03/15/2023", selectedDate);
        }

        [Fact]
        public void SelectPreviousMonthDate()
        {
            // Navigate to the demo page
            _driver.Navigate().GoToUrl("https://demoqa.com/date-picker");

            // Find the date picker element and click it
            var datePicker = _driver.FindElement(By.Id("datePickerMonthYearInput"));
            datePicker.Click();

            // Find and click the "Previous" button to switch to the previous month
            var previousButton = _driver.FindElement(By.CssSelector(".react-datepicker__navigation--previous"));
            previousButton.Click();

            // Find and click the 10th day of the month
            var day10 = _driver.FindElement(By.XPath("//div[@class='react-datepicker__day react-datepicker__day--010']"));
            day10.Click();

            // Verify that the selected date is displayed in the input field
            Assert.Equal("02/10/2023", datePicker.GetAttribute("value"));
        }

        [Fact]
        public void SelectFutureDate()
        {
            // Navigate to the demo page
            _driver.Navigate().GoToUrl("https://demoqa.com/date-picker");

            // Find the date picker element and click it
            var datePicker = _driver.FindElement(By.Id("datePickerMonthYearInput"));
            datePicker.Click();

            // Find and click the "Next" button to switch to the next month
            var nextButton = _driver.FindElement(By.CssSelector(".react-datepicker__navigation--next"));
            nextButton.Click();

            // Find and click the 25th day of the month
            var day25 = _driver.FindElement(By.XPath("//div[@class='react-datepicker__day react-datepicker__day--025']"));
            day25.Click();

            // Verify that the selected date is displayed in the input field
            Assert.Equal("04/25/2023", datePicker.GetAttribute("value"));
        }
    }
}
