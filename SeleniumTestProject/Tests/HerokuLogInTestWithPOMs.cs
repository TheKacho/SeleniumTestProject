using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTestProject.PageObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.Tests
{
    public class HerokuLogInTestWithPOMs : IDisposable
    {

        private readonly IWebDriver driver;
        private readonly HerokuLoginPage loginPage;
        private readonly HerokuSecureLoginAreaPage secureLoginAreaPage;

        public HerokuLogInTestWithPOMs()
        {
            driver = new ChromeDriver();
            loginPage = new HerokuLoginPage(driver);
            secureLoginAreaPage = new HerokuSecureLoginAreaPage(driver);
        }

        [Fact]
        public void InvalidLoginTest()
        {
            //Arrange
            // Navigates to the login page
            loginPage.NavigateTo("http://the-internet.herokuapp.com/login");

            //Act
            // Enters an invalid username and password
            loginPage.Login("invalid", "invalid");

            //Assert
            // Asserts and verifys that the login failed and an error message is displayed
            Assert.True(loginPage.IsErrorMessageDisplayed());
        }

        [Fact]
        public void ValidLoginTest()
        {
            //Arrange
            // Navigates to the login page
            loginPage.NavigateTo("http://the-internet.herokuapp.com/login");

            //Act
            // Enters a valid username and password
            loginPage.Login("tomsmith", "SuperSecretPassword!");

            //Assert
            // Verifies that the login succeeded and the secure area page is displayed
            Assert.False(secureLoginAreaPage.IsSecureLoginAreaPageDisplayed());
        }

        public void Dispose()
        {
            driver.Dispose();
            driver.Quit();
        }
    }
}
