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
    public class HerokuDropdown : IDisposable
    {
        private IWebDriver driver;
        private const string url = "http://the-internet.herokuapp.com/";

        public HerokuDropdown()
        {
            driver = new ChromeDriver();
        }

        [Fact]
        public void TestDropdown()
        {
            //act
            // Navigate to the Dropdown page
            driver.Navigate().GoToUrl(url + "dropdown");

            //arrange
            // Find the dropdown element and select the second option
            SelectElement dropdown = new SelectElement(driver.FindElement(By.Id("dropdown")));
            dropdown.SelectByIndex(1);

            //assert
            // Verifies that the selected option matches the expected value, "Option 1"
            string selectedOption = dropdown.SelectedOption.Text;
            Assert.Equal("Option 1", selectedOption);
        }

        public void Dispose()
        {
            driver.Dispose();
            driver.Quit();
        }
    }
}
