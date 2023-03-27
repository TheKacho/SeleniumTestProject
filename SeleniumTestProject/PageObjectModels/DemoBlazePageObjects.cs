using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.PageObjectModels
{
    public class DemoBlazePageObjects
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public DemoBlazePageObjects(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public BlazeMain BlazeMain => new BlazeMain(driver, wait);
        public LaptopsPage LaptopsPage => new LaptopsPage(driver, wait);
        public ProductPage ProductPage => new ProductPage(driver, wait);
        public ContactPage ContactPage => new ContactPage(driver);
    }

    public class BlazeMain
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public BlazeMain(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;

            //This waits for "Labtops" link to be present and visible
            wait.Until(driver => driver.FindElement(By.LinkText("Laptops")));
        }

        public void ClickLaptopsLink()
        {
            // Clicks the "Laptops" link
            driver.FindElement(By.LinkText("Laptops")).Click();
        }

    }
    public class LaptopsPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public LaptopsPage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;

            // Wait for the "Dell i7 8gb" product to be present
            wait.Until(driver => driver.FindElement(By.LinkText("Dell i7 8gb")));
        }

        public void ClickProductLink(string productName)
        {
            // Click the product link with the given name
            driver.FindElement(By.LinkText(productName)).Click();
        }
    }

    public class ProductPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public ProductPage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;

            // Wait for the "Add to cart" button to be present
            wait.Until(driver => driver.FindElement(By.XPath("//a[contains(text(),'Add to cart')]")));
        }

        public void ClickAddToCartButton()
        {
            // Click the "Add to cart" button
            driver.FindElement(By.XPath("//a[contains(text(),'Add to cart')]")).Click();
        }

        public string GetSuccessMessage()
        {
            // Wait for the success message to be present and return its text
            return wait.Until(driver => driver.FindElement(By.ClassName("alert-success")).Text);
        }
    }
    public class ContactPage
    {
        private readonly IWebDriver driver;

        public ContactPage(IWebDriver driver)
        {
            this.driver = driver;
        }

    }
}
