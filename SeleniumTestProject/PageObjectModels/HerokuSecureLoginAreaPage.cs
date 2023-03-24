using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.PageObjectModels
{
    public class HerokuSecureLoginAreaPage : BasePage
    {
        public HerokuSecureLoginAreaPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement SuccessMessage => driver.FindElement(By.CssSelector("#flash.success"));
        
        public bool IsSecureLoginAreaPageDisplayed()
        {
            return SuccessMessage.Displayed && SuccessMessage.Text.Contains("You logged in a secure area!");
        }
    }
}
