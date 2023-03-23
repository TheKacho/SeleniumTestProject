using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.Tests
{
    public class HoverOver : IDisposable
    {
        private readonly IWebDriver driver;
        public HoverOver()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/tool-tips");
        }


        [Fact]
        public void HoverOverElement_ShouldDisplayTooltip()
        {
            // Wait for the page to load
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //var elementToHover = wait.Until(driver => driver.FindElement(By.XPath("//input[@id='toolTipButton']")));
            var elementToHover = wait.Until(driver => driver.FindElement(By.Id("toolTipButton")));


            // Create an instance of the Actions class and move the mouse to the element
            Actions action = new Actions(driver);
            action.MoveToElement(elementToHover).Perform();

            // Wait for the tooltip to be visible
            var tooltip = wait.Until(driver => driver.FindElement(By.Id("toolTipButton")));

            // Verify that the tooltip is displayed
            Assert.True(tooltip.Displayed);
        }
        public void Dispose()
        {
            driver.Dispose();
            driver.Quit();
        }
    }
}
