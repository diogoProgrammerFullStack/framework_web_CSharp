using Mark7.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Drawing;
using OpenQA.Selenium.Support.UI;

namespace Mark7.Common
{
    public class BaseSteps : IDisposable
    {
        public IWebDriver driver;
        public LoginPage loginPage;
        public TarefasPage tarefasPage;
        public IWebDriver Current;

        public BaseSteps()
        {
            driver = new ChromeDriver();

            driver.Manage().Window.Size = new Size(1440, 900);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://mark7-sandbox.herokuapp.com/login");

            loginPage = new LoginPage(driver);
            tarefasPage = new TarefasPage(driver);
        }
        
        private WebDriverWait _wait;
        
        public WebDriverWait Wait
        {
            get
            {
                if(_wait == null)
                {
                    this._wait = new WebDriverWait(Current, TimeSpan.FromSeconds(10));
                }
                return _wait;
            }
        }

        public void Dispose()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
    }
}
