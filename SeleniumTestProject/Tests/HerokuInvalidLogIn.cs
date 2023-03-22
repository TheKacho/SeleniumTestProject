using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.Tests
{
    public class HerokuInvalidLogIn : IDisposable
    {
        private readonly IWebDriver driver;

        public HerokuInvalidLogIn()
        {
            driver = new ChromeDriver();
        }

        [Fact]
        public void InvalidLoginTest()
        {
            // Navigate to the login page
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/login");

            // Enter an invalid username and password
            driver.FindElement(By.Id("username")).SendKeys("invalid");
            driver.FindElement(By.Id("password")).SendKeys("invalid");

            // Submit the form
            driver.FindElement(By.CssSelector("button[type='submit']")).Click();

            // Verify that the login failed
            Assert.Contains("Your username is invalid!", driver.PageSource);
        }


        public void Dispose()
        {
            driver.Dispose();
            driver.Quit();
        }
    }
}
