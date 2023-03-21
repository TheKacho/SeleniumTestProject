using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.Tests
{
    public class DiscordStatus
    {
        [Fact]
        public void NavToStatusPage_AssertStatus()
        {
            var driver = new ChromeDriver();
            driver.Url = "https://status.discordapp.com/";

            try
            {
                var statusField = driver.FindElement(By.CssSelector("span.status"));
                Assert.NotNull(statusField.Text);
                Assert.Equal("all systems operational", statusField.Text.ToLower());
            }
            finally
            {
                Thread.Sleep(2000);
                driver.Dispose();
            }
        }
    }
}
