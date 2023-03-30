using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.PageObjectModels
{
    public class LumaPage
    {
        private IWebDriver driver;
        private By emailField = By.Id("email");
        private By passwordField = By.Id("pass");
        private By loginButton = By.Id("send2");

        public LumaPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Login(string email, string password)
        {
            driver.FindElement(emailField).SendKeys(email);
            driver.FindElement(passwordField).SendKeys(password);
            driver.FindElement(loginButton).Click();
        }

    }
    public class ShirtPage
    {
        private IWebDriver driver;
        private By addToCartBtn = By.CssSelector("[data-id='2'] .product-item-actions .action.tocart");

        public ShirtPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void AddShirtToCart()
        {
            driver.FindElement(addToCartBtn).Click();
        }      
        
    }

    public class ShopCartPage
    {
        private IWebDriver driver;
        private By quantityField = By.CssSelector("#shopping-cart-table tbody tr:nth-child(1) td:nth-child(4) input");
        private By updateQuantityBtn = By.CssSelector("#shopping-cart-table tbody tr:nth-child(1) td:nth-child(4) button");

        public ShopCartPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void UpdateQuantity(int quantity)
        {
            driver.FindElement(quantityField).Clear();
            driver.FindElement(quantityField).SendKeys(quantity.ToString());
            driver.FindElement(updateQuantityBtn).Click();
        }


    }
}
