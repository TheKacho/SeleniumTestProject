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


        [Fact]
        public void SelectDate()
        {
            //Arrange
            // Navigate to the Date Picker page
            _driver.Navigate().GoToUrl("https://demoqa.com/date-picker");

            //Act
            // Find and click the date input field
            IWebElement dateInput = _driver.FindElement(By.Id("datePickerMonthYearInput"));
            dateInput.Click();

            // Find and click the desired date in the date picker
            IWebElement date = _driver.FindElement(By.XPath("//div[@class='react-datepicker__month']//div[text()='15']"));
            date.Click();

            //Assert
            // Verifies that the selected date "03/15/2023" is displayed correctly
            string selectedDate = dateInput.GetAttribute("value");
            Assert.Equal("03/15/2023", selectedDate);
        }

        [Fact]
        public void SelectPreviousMonthDate()
        {
            //Arrange           
            _driver.Navigate().GoToUrl("https://demoqa.com/date-picker");

            //Act           
            var datePicker = _driver.FindElement(By.Id("datePickerMonthYearInput"));
            datePicker.Click();

            // Find and click the "Previous" button to switch to that month
            var previousButton = _driver.FindElement(By.CssSelector(".react-datepicker__navigation--previous"));
            previousButton.Click();

            // Find and click the 10th day of the chosen previous month
            var day10 = _driver.FindElement(By.XPath("//div[@class='react-datepicker__day react-datepicker__day--010']"));
            day10.Click();

            //Assert
            // Verifies that the selected date "02/10/2023" is displayed correctly
            Assert.Equal("02/10/2023", datePicker.GetAttribute("value"));
        }

        [Fact]
        public void SelectFutureDate()
        {
            //Arrange           
            _driver.Navigate().GoToUrl("https://demoqa.com/date-picker");

            //Act
            var datePicker = _driver.FindElement(By.Id("datePickerMonthYearInput"));
            datePicker.Click();

            // Find and click the "Next" button to switch to the next month
            var nextButton = _driver.FindElement(By.CssSelector(".react-datepicker__navigation--next"));
            nextButton.Click();

            // Find and click the 25th day of the month
            var day25 = _driver.FindElement(By.XPath("//div[@class='react-datepicker__day react-datepicker__day--025']"));
            day25.Click();

            //Assert
            // Verifies that "04/25/2023" is displayed correctly
            Assert.Equal("04/25/2023", datePicker.GetAttribute("value"));
        }

        public void Dispose()
        {
            _driver.Dispose();
            _driver.Quit();
        }
    }
}
