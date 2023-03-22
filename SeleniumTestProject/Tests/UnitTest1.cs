using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTestProject.PageObjectModels;
using FluentAssertions;
using System;
using Xunit.Abstractions;

namespace SeleniumTestProject.Tests
{
    public class UnitTest1
    {
        readonly ITestOutputHelper _output;
        readonly string testUrl = "http://www.google.com";
        readonly string eventTitle = "Google";
        readonly string eventPlace = "Home";
        readonly string eventDesc = "Pajama Pants Party!";

        public UnitTest1(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void PageLoadSuccess()
        {
            using IWebDriver driver = new ChromeDriver();
            HomePage homePage = new HomePage(driver);
            driver.Title.Should().Be(homePage.Title);
        }

        // ** May modify or delete **
        [Fact]
        public void GoogleConfirm()
        {
            IWebDriver driver = new ChromeDriver();
            string url = "https://www.google.com";
            driver.Navigate().GoToUrl(url);
            driver.Title.Should().Be("Google");

            //this goes to google and confirms if the logo matches
            //the title that the driver looks for
            string logoXPath = "/html/body/div[1]/div[2]/div/img";
            var element = driver.FindElement(By.XPath(logoXPath));

            element.Displayed.Should().BeTrue();
            //if the element displayed is true, then the test succeeds
            // as the browser closes after the test is done

            driver.Quit();
        }

        // ** May modify or delete **

        [Fact]
        public void GoogleGamba()
        {
            IWebDriver driver = new ChromeDriver();
            string url = "https://google.com";
            driver.Navigate().GoToUrl(url);

            string feelingLuckyId = "gbqfbb";
            var element = driver.FindElement(By.Id(feelingLuckyId));
            element.Click();
            element.Click();

            driver.Title.Should().NotBe("Google");
        }

        [Fact]
        public void NavigatePage()
        {
            var driver = new ChromeDriver();
            driver.Url = "https://www.google.com";
            Thread.Sleep(3000);
            driver.Dispose();
        }

        
    }
}