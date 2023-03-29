using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.Tests
{
    public class DemoQATestBgColor : IDisposable
    {
        private IWebDriver driver;

        public DemoQATestBgColor()
        {
            driver = new ChromeDriver();
        }

        [Fact]
        public void TestChangeBGColor()
        {
            //Arrange
            // Navigate to demoqa.com
            driver.Navigate().GoToUrl("https://demoqa.com/");

            // This finds the body element
            IWebElement body = driver.FindElement(By.TagName("body"));

            //Act
            // Modifies the background color of the body element
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].style.backgroundColor = 'purple';", body);

            // Wait for 2 seconds to observe the change
            System.Threading.Thread.Sleep(2000);

            //Assert
            // Asserts that the background color has changed to red
            string backgroundColor = body.GetCssValue("background-color");
            Assert.Equal("rgba(128, 0, 128, 1)", backgroundColor);
        }


        [Fact]
        public void TestChangeBackgroundColorWithRGB()
        {
            //Arrange
            // Navigates to demoqa.com url
            driver.Navigate().GoToUrl("https://demoqa.com/");

            //Act
            // Finds the body element
            IWebElement body = driver.FindElement(By.TagName("body"));
        
            // Modifies the background color of the body element using RGBA color codes
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].style.backgroundColor = 'rgba(0, 0, 100)';", body);

            // Wait for 2 seconds to observe the change
            System.Threading.Thread.Sleep(2000);

            //Assert
            // Asserts that the background color has changed to the chosen RGBA color
            string backgroundColor = body.GetCssValue("background-color");
            Assert.Equal("rgba(0, 0, 100, 1)", backgroundColor);
        }



        public void Dispose()
        {
            driver.Dispose();
            driver.Quit();
        }
    }
}
