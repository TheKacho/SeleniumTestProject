using OpenQA.Selenium;
using System;
using System.Collections.Generic;
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

        }
    }
}
