using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.PageObjectModels
{
    public class ArtOfTestingResults
    {
        private IWebDriver driver;

        public ArtOfTestingResults(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement ResultsCount => driver.FindElement(By.ClassName("s-result-count"));

        public bool IsResultsCountDisplayed()
        {
            return ResultsCount.Displayed;
        }
    }
}
