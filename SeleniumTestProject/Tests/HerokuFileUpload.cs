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

        //NOTE: The pants.txt file needs to be on the Desktop for this test to work!
        [Fact]
        public void UploadFile()
        {
            // Navigate to the upload page
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/upload");

            // Find the file input element
            IWebElement fileInput = driver.FindElement(By.Id("file-upload"));

            // Set the path to the file you want to upload
            string filePath = Path.Combine("Desktop", "pants.txt");
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string fileName = "pants.txt";
            string absoluteFilePath = Path.Combine(desktopPath, fileName);
            
            //NOTE: The pants.txt file will be within
            

            // Send the file path to the file input element
            fileInput = driver.FindElement(By.Id("file-upload"));
            fileInput.SendKeys(absoluteFilePath);
            //fileInput.SendKeys(filePath);

            // Find the submit button and click it
            IWebElement submitButton = driver.FindElement(By.Id("file-submit"));
            submitButton.Click();

            // Verify that the file was uploaded successfully
            IWebElement uploadedFile = driver.FindElement(By.Id("uploaded-files"));
            Assert.Equal("pants.txt", uploadedFile.Text);
            //IWebElement successMessage = driver.FindElement(By.XPath("//h3[text()='File Uploaded!']"));
            //Assert.Equal("File Uploaded!", successMessage.Text);
        }

        public void Dispose()
        {
            driver.Quit();
        }
    }
}
