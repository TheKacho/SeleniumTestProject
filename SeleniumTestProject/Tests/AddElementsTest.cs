using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.Tests
{
    public class AddElementsTest : IDisposable
    {
        private readonly IWebDriver _driver;

        public AddElementsTest()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }

        [Fact]
        public void AddElementTest()
        {
            // Navigate to the webpage
            _driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/add_remove_elements/");

            // Click the "Add Element" button
            var addButton = _driver.FindElement(By.XPath("//button[contains(text(),'Add Element')]"));
            addButton.Click();

            // Verify that a new element has been added
            var addedElement = _driver.FindElement(By.XPath("//div[@id='elements']/*[last()]"));
            Assert.True(addedElement.Displayed);
        }

        [Fact]
        public void AddMultipleElementsTest()
        {
            // Navigate to the webpage
            _driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/add_remove_elements/");

            // Click the "Add Element" button three times
            for (int i = 0; i < 3; i++)
            {
                var addButton = _driver.FindElement(By.XPath("//button[contains(text(),'Add Element')]"));
                addButton.Click();
            }

            // Verify that three new elements have been added
            var addedElements = _driver.FindElements(By.XPath("//div[@id='elements']/*"));
            Assert.Equal(3, addedElements.Count);
        }



        public void Dispose()
        {
            _driver.Dispose();
            _driver.Quit();
        }
    }
}
