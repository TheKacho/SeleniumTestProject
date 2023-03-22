using FluentAssertions;
using FluentAssertions.Execution;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using SeleniumTestProject.PageObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SeleniumTestProject.Tests
{
    //do not run this test!
    //
    //it creates a bunch of browser windows without stopping
    //public class NewTab : IDisposable
    //{
    //    IWebDriver _driver;
    //    BooksPage _booksPage;

    //    public NewTab()
    //    {
    //        IWebDriver driver = new ChromeDriver();
    //        _driver = driver;

    //        BooksPage booksPage = new BooksPage();
    //        _booksPage = booksPage;
    //    }


    //    [Fact]
    //    public void NewTabTest()
    //    {
    //        //arrange

    //        //to reduce failure rate, simplify the links to the source that you're targeting
    //        string newTabTitle = "O'Reilly Media - Technology and Business Training";



    //        _driver.Manage().Window.Maximize();
    //        _driver.Navigate().GoToUrl(_booksPage.Url);

    //        //act


    //        //string xpath = "(//span[contains(@id, 'see-book-')])";
    //        //for Xpath, it is generally best to search for ID first

    //        //var bookLink = driver.FindElements(By.XPath(xpath));

    //        var bookLink = _driver.FindElement(_booksPage.GitPocketGuideLink);
    //        bookLink.Click();

    //        _driver.Url.Should().Contain("books?book=");


    //        string websiteLinkXpath = "//div[@id=\"website-wrapper\"]//label[@id='userName-value']";
    //        var websiteLink = _driver.FindElement(By.XPath(websiteLinkXpath));
    //        var script = "arguments[0].scrollIntoView(true);";
    //        IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
    //        js.ExecuteScript(script, websiteLink);
    //        websiteLink.Click();

    //        _driver.SwitchTo().Window(_driver.WindowHandles.Last());

    //        //assert
    //        using (new AssertionScope())
    //        {
    //            _driver.WindowHandles.Should().HaveCount(2);
    //            _driver.Title.Should().Be(newTabTitle);
    //        }

    //    }
    //    public void Dispose()
    //    {
    //        _driver.Quit();
    //    }
    //}
}
