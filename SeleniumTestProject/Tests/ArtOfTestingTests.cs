using FluentAssertions.Execution;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTestProject.PageObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.Tests
{
    public class ArtOfTestingTests : IDisposable
    {
        private readonly IWebDriver _driver;

        public ArtOfTestingTests()
        {
            _driver = new ChromeDriver();
        }

        [Fact]
        public void TestHomePageTitle() // This test makes sure the homepage loads properly
        {
            //arrange
            var homePage = new ArtOfTestingHomePage(_driver);


            //act
            homePage.GoToPage();

            //assert
            using(new AssertionScope())
            {
                homePage.AssertTitle("Learn Testing Online with Free Tutorials - ArtOfTesting");
            }
        }

        [Fact]
        public void TestSearch()
        {
            //arrange
            var homePage = new ArtOfTestingHomePage(_driver);

            //act
            homePage.GoToPage();
            homePage.SearchFor("Selenium");

            //assert
            using (new AssertionScope())
            {
                homePage.AssertSearchResultDisplayed();
            }
        }


        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}
