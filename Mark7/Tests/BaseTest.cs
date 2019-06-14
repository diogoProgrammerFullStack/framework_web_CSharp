using Mark7.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Drawing;

namespace Mark7.Tests
{
    public class BaseTest
    {

        public IWebDriver driver;
        public LoginPage loginPage;
        public TarefasPage tarefasPage;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();

            driver.Manage().Window.Size = new Size(1440, 900);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://mark7-sandbox.herokuapp.com/login");

            loginPage = new LoginPage(driver);
            tarefasPage = new TarefasPage(driver);

        }

        [TearDown]
        public void Finish()
        {
            driver.Quit();
        }
    }
}
