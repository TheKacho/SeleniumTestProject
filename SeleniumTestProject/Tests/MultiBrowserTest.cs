using OpenQA.Selenium;
using SeleniumTestProject.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SeleniumTestProject.Utilities.Browser;

namespace SeleniumTestProject.Tests
{
    //public class MultiBrowseTest
    //{
    //    String test_url = "https://lambdatest.github.io/sample-todo-app/";
    //    String itemName = "It's a pajama pants party!";

    //    [Theory]
    //    [InlineData(BrowserType.Chrome)]
    //    [InlineData(BrowserType.Firefox)]

    //    public void NavTest(BrowserType browserType)
    //    {
    //        using (var driver = WebDriverInf.Create_Browser(browserType))
    //        {
    //            driver.Navigate().GoToUrl(test_url);

    //            driver.Manage().Window.Maximize();

    //            Assert.Equal("Sample page - lambdatest.com", driver.Title);
    //            // Click on First Check box
    //            IWebElement firstCheckBox = driver.FindElement(By.Name("li1"));
    //            firstCheckBox.Click();

    //            // Click on Second Check box
    //            IWebElement secondCheckBox = driver.FindElement(By.Name("li2"));
    //            secondCheckBox.Click();

    //            // Enter Item name
    //            IWebElement textfield = driver.FindElement(By.Id("sampletodotext"));
    //            textfield.SendKeys(itemName);

    //            // Click on Add button
    //            IWebElement addButton = driver.FindElement(By.Id("addbutton"));
    //            addButton.Click();

    //            // Verified Added Item name
    //            IWebElement itemtext = driver.FindElement(By.XPath("/html/body/div/div/div/ul/li[6]/span"));
    //            String getText = itemtext.Text;
    //            Assert.Contains(getText, itemName);


    //            Console.WriteLine("LT_ToDo_Test Passed");

    //            driver.Quit();
    //        }
    //    }
    //}
}
