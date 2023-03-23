using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.PageObjectModels
{
    public class PikadayPageObject
    {
        private readonly IWebDriver driver;

        public PikadayPageObject(IWebDriver driver)
        {
            this.driver = driver;

            DatePicker = driver.FindElement(By.CssSelector(".datepicker-input"));
            SelectedDate = driver.FindElement(By.CssSelector(".datepicker-input")).GetAttribute("value");
            PreviousMonthButton = driver.FindElement(By.CssSelector(".prev"));
            NextMonthButton = driver.FindElement(By.CssSelector(".next"));
        }


        public IWebElement DatePicker { get; }

        public string SelectedDate { get; }

        public IWebElement PreviousMonthButton { get; }

        public IWebElement NextMonthButton { get; }

        public void SelectDate(DateTime date)
        {
            // Click the datepicker to open it
            DatePicker.Click();

            // Navigate to the correct month and year
            while (!SelectedDate.Contains(date.ToString("MMMM yyyy")))
            {
                if (date < DateTime.Parse(SelectedDate))
                {
                    PreviousMonthButton.Click();
                }
                else
                {
                    NextMonthButton.Click();
                }
            }

            // Select the day
            var dayButton = driver.FindElement(By.XPath($"//td[@data-day='{date:dd}']"));

        }
    }
}
