using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTestProject.PageObjectModels
{
    internal class HomePage
    {
        readonly IWebDriver _driver;
        readonly WebDriverWait _wait;
        public string Url = "https://www.google.com";
        public string Title = "Google";

        public HomePage(IWebDriver driver)
        {
            //this method calls the web driver, waits for 6 seconds to load to the page and maximizes the browser window
            _driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(6));
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(Url);
            EnsurePageLoad();
        }

        private void EnsurePageLoad()
        {
            throw new NotImplementedException();
        }
    }
}