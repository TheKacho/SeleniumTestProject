using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.Tests
{
    public class HerokuCheckBox : IDisposable
    {
        private IWebDriver driver;
        private const string url = "http://the-internet.herokuapp.com/";

        public HerokuCheckBox()
        {
            driver = new ChromeDriver();
        }
        [Fact]
        public void TestCheckboxes()
        {
            //Arrange
            // Navigates to the Checkboxes page
            driver.Navigate().GoToUrl(url + "checkboxes");

            //Act & Assert 1
            // Verifies the initial checkbox state
            IWebElement checkbox1 = driver.FindElement(By.CssSelector("input[type='checkbox']:first-of-type"));
            IWebElement checkbox2 = driver.FindElement(By.CssSelector("input[type='checkbox']:nth-of-type(2)"));
            Assert.False(checkbox1.Selected);
            Assert.True(checkbox2.Selected);

            // Toggles the checkboxes
            checkbox1.Click();
            checkbox2.Click();

            //Assert 2
            // Verifies the updated checkbox state
            Assert.True(checkbox1.Selected);
            Assert.False(checkbox2.Selected);
        }
        public void Dispose()
        {
            driver.Dispose();
            driver.Quit();
        }
    }
}
