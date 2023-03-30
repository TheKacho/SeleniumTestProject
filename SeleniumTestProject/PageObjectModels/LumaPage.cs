using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
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

    public class ShoppingCartPage
    {
        private IWebDriver driver;
        private By quantityField = By.CssSelector("#shopping-cart-table tbody tr:nth-child(1) td:nth-child(4) input");
        private By updateQuantityBtn = By.CssSelector("#shopping-cart-table tbody tr:nth-child(1) td:nth-child(4) button");

        public ShoppingCartPage(IWebDriver driver)
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

    public class CheckoutPage
    {
        private IWebDriver driver;
        private By continueShippingButton = By.CssSelector("#co-shipping-method-form .action.continue");
        private By paymentMethodCheckmo = By.CssSelector("#co-payment-form input[value='checkmo']");
        private By continuePaymentButton = By.CssSelector("#co-payment-form .action.continue");

        public CheckoutPage(IWebDriver driver)
        {
            this.driver= driver;
        }

        public void ContinueToShipping()
        {
            driver.FindElement(continueShippingButton).Click();
        }

        public void SelectPaymentMethod()
        {
            driver.FindElement(paymentMethodCheckmo).Click();
        }

        public void ContinueToPayment()
        {
            driver.FindElement(continuePaymentButton).Click();
        }
    }

    public class ConfirmationPage
    {
        private IWebDriver driver;
        private By confirmationMessage = By.CssSelector(".page-title");

        public ConfirmationPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public bool IsConfirmationMessageDisplayed()
        {
            return driver.FindElement(confirmationMessage).Text.Contains("Thank you for your purchase!");
        }
    }
}
