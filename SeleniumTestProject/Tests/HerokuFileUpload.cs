using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.Tests
{
    public class HerokuFileUpload : IDisposable
    {

        private readonly IWebDriver driver;

        public HerokuFileUpload()
        {
            driver = new ChromeDriver();

        }

        [Fact]
        public void UploadFile()
        {
            // Navigate to the upload page
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/upload");

            // Find the file input element
            IWebElement fileInput = driver.FindElement(By.Id("file-upload"));

            // Set the path to the file you want to upload
            string filePath = Path.GetFullPath("pants.txt");
            //NOTE: The pants.txt file will be within
            //the "..\SeleniumTestProject\SeleniumTestProject\bin\Debug\net6.0" folder!

            // Send the file path to the file input element
            fileInput.SendKeys(filePath);

            // Find the submit button and click it
            IWebElement submitButton = driver.FindElement(By.Id("file-submit"));
            submitButton.Click();

            // Verify that the file was uploaded successfully
            IWebElement successMessage = driver.FindElement(By.XPath("//h3[text()='File Uploaded!']"));
            Assert.Equal("File Uploaded!", successMessage.Text);
        }

        public void Dispose()
        {
            driver.Quit();
        }
    }
}
