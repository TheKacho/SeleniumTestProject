using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumTestProject.PageObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestProject.Tests
{
    public class BlazeCartTest : IDisposable
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;
        private readonly DemoBlazePageObjects blazeObjects;

        public BlazeCartTest()
        {
            
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            blazeObjects = new DemoBlazePageObjects(driver);

            // Navigates to the home page
            driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
        }

        [Fact]
        public void CanAddProductToCart()
        {
            //Arrange
            // Clicks the "Laptops" link on the home page
            blazeObjects.BlazeMain.ClickLaptopsLink();

            //Act
            // It will then click the "Dell i7 8gb" product on the laptops page
            blazeObjects.LaptopsPage.ClickProductLink("Dell i7 8gb");

            // Click the "Add to cart" button on the product page
            blazeObjects.ProductPage.ClickAddToCartButton();

            //Assert

            // Wait for the alert to appear and verifies that
            // the "Product added" message appears containing the correct text
            IAlert alert = wait.Until(driver => driver.SwitchTo().Alert());
            Assert.Contains("Product added", alert.Text);

            // Accept the alert that pops up
            alert.Accept();
            
        }


        public void Dispose()
        {
            driver.Dispose();
            driver.Quit();
        }
    }
}
