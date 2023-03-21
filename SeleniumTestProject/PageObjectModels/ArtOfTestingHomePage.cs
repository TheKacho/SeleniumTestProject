using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.PageObjectModels
{
    public class ArtOfTestingHomePage
    {
        private readonly IWebDriver _driver;
        private string url = "https://artoftesting.com";

        public ArtOfTestingHomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void GoToPage()
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void SearchFor(string searchTerm)
        {
            _driver.FindElement(By.Id("s")).SendKeys(searchTerm);
            _driver.FindElement(By.Name("submit_search")).Submit();
        }

        public void AssertTitle(string expectedTitle)
        {
            Assert.Equal(expectedTitle, _driver.Title);
        }

        public void AssertSearchResultDisplayed()
        {
            Assert.True(_driver.FindElement(By.ClassName("search-results")).Displayed);
        }
     
    }
}
