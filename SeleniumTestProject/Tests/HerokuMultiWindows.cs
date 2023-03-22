using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.Tests
{
    public class HerokuMultiWindows : IDisposable
    {
        private IWebDriver driver;
        private const string url = "http://the-internet.herokuapp.com/";

        public HerokuMultiWindows()
        {
            driver = new ChromeDriver();
        }

        [Fact]
        public void TestMultipleWindows()
        {
            // Navigate to the Multiple Windows page
            driver.Navigate().GoToUrl(url + "windows");

            // Click the link to open a new window
            driver.FindElement(By.LinkText("Click Here")).Click();

            // Switch to the new window
            string currentWindowHandle = driver.CurrentWindowHandle;
            foreach (string windowHandle in driver.WindowHandles)
            {
                if (windowHandle != currentWindowHandle)
                {
                    driver.SwitchTo().Window(windowHandle);
                    break;
                }
            }

            // Verify the text on the page in the new window
            string pageText = driver.FindElement(By.TagName("h3")).Text;
            Assert.Equal("New Window", pageText);
        }

        public void Dispose()
        {
            driver.Dispose();
            driver.Quit();
        }
    }
}
