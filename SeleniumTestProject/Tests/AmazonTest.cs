using FluentAssertions;
using FluentAssertions.Execution;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTestProject.PageObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.Tests

    ///Might delete
{
    //public class AmazonTest : IDisposable
    //{

    //    private IWebDriver _driver;
    //    private AmazonHomePage _amazonHomePage;

    //    public AmazonTest() // the constructor
    //    {
    //        _driver = new ChromeDriver();
    //        _amazonHomePage = new AmazonHomePage(_driver);
    //    }
       
    //    [Fact]
    //    public void Search_Non_Exist_Product()
    //    {
    //        //navigates to the Amazon home/main page
    //        _amazonHomePage.NavHomePage();

    //        _amazonHomePage.SearchProduct("UnknownProductNonExistant.");
    //        _amazonHomePage.ClickSearchBtn();

    //        using (var assertionScope = new AssertionScope())
    //        {
    //            var resultCount = _driver.FindElements(By.CssSelector(".s-result-item")).Count;
    //            resultCount.Should().Be(54, "because no results shoulld be returned on a non-existent product search.");

    //            var noResultMsg = _driver.FindElement(By.CssSelector(".a-section.a-spacing-small.a-spacing-top-small"));
    //            noResultMsg.Text.Should().Contain("1-48 of over 70,000 results for", "because the page should indicate that no results are found.");
    //        }

            
    //    }


    //    public void Dispose()
    //    {
    //        _driver.Quit();
    //        _driver.Dispose();
    //    }
    //}
}
