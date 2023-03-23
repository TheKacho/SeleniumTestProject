using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTestProject.PageObjectModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.Tests
{
    public class PikadayTest : IDisposable
    {
        private IWebDriver driver;
        private PikadayPageObject pikadayPage;

        public PikadayTest()
        {
            driver = new ChromeDriver();
            pikadayPage = new PikadayPageObject(driver);
        }

        [Fact]
        public void SelectDateTest()
        {
            driver.Navigate().GoToUrl("https://pikaday.com/");

            pikadayPage.SelectDate(DateTime.ParseExact("2023-03-22", "yyyy-MM-dd", CultureInfo.InvariantCulture));

            Assert.Equal("2023-03-22", pikadayPage.SelectedDate);
        }


        public void Dispose()
        {
            driver.Dispose();
            driver.Quit();
        }
    }
}
