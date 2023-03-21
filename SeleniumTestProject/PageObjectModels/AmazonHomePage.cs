using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.PageObjectModels
{
    public class AmazonHomePage
    {
        private readonly IWebDriver _driver;

        public AmazonHomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavHomePage()
        {
            _driver.Navigate().GoToUrl("http://www.amazon.com");
        }

        public void SearchProduct(string searchTerm)
        {
            var searchBox = _driver.FindElement(By.Id("twotabsearchtextbox"));

            searchBox.SendKeys(searchTerm);
            //searchBox.Submit();

            //return new AmazonResultPage(_driver);

        }
        public void ClickSearchBtn()
        {
            var searchButton = _driver.FindElement(By.XPath("//input[@value='Go']"));
            searchButton.Click();
        }
    }
}
