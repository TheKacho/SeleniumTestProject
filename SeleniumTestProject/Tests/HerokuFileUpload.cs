using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//IMPORTANT: The pants.txt file needs to be on the Desktop for this test to work!
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
        public void UploadFileFromDesktop()
        {
            //Arrange
            // Navigate to the upload page
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/upload");

            //Act
            // Find the file input element
            IWebElement fileInput = driver.FindElement(By.Id("file-upload"));
           

            // Sets the path to the file you want to upload (The path to the file is set to the desktop)
            string filePath = Path.Combine("Desktop", "pants.txt");
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string fileName = "pants.txt";
            string absoluteFilePath = Path.Combine(desktopPath, fileName);
                    

            // Send the file path to the file input element
            fileInput = driver.FindElement(By.Id("file-upload"));
            fileInput.SendKeys(absoluteFilePath);
            //fileInput.SendKeys(filePath);

            // Finds the submit button and click it
            IWebElement submitButton = driver.FindElement(By.Id("file-submit"));
            submitButton.Click();

            ///Assert
            // Verifies that the file was uploaded successfully
            IWebElement uploadedFile = driver.FindElement(By.Id("uploaded-files"));
            Assert.Equal("pants.txt", uploadedFile.Text);
            
        }


        public void Dispose()
        {
            driver.Dispose();
            driver.Quit();
        }
    }
}
