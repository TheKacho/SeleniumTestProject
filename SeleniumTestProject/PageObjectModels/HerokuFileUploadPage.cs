using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.PageObjectModels
{
    public class HerokuFileUploadPage
    {
        private readonly IWebDriver driver;

        public HerokuFileUploadPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement ChooseFileButton => driver.FindElement(By.Id("file-upload"));
        public IWebElement UploadButton => driver.FindElement(By.Id("file-submit"));

        public void UploadFile(string filePath)
        {
            ChooseFileButton.SendKeys(filePath);
            UploadButton.Click();
        }
    }
}
