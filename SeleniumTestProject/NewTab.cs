using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject
{
    public class NewTab
    {
        [Fact]
        public void NewTabTest()
        {
            string url = "https://demoqa.com/books";
            //to reduce failure rate, simplify the links to the source that you're targeting

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            string id = "see-book-Git Pocket Guide";
            //string xpath = "(//span[contains(@id, 'see-book-')])";
            //for Xpath, it is generally best to search for ID first

            //var bookLink = driver.FindElements(By.XPath(xpath));

            var bookLink = driver.FindElement(By.Id(id));
            bookLink.Click();

            string url2 = "https://demoqa.com/books?book=9781449325862";

            driver.Url.Should().Contain("books?book=");

            string id2 = "userName-value";
            var websiteLink = driver.FindElement(By.Id(id2));
            websiteLink.Click();

            driver.WindowHandles.Should().HaveCount(1);

            driver.Quit();

        }
    }
}
