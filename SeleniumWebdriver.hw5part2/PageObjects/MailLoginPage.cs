using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace SeleniumWebdriver.hw5.PageObjects
{
    class MailLoginPage 
    {
        private IWebDriver _driver;

        WebDriverWait waitTime;
        public MailLoginPage NavigateToMainPage()
        {
            _driver.Navigate().GoToUrl("https://mail.ru/");
            return this;
        }

        public MailLoginPage(IWebDriver driver)
        {
            _driver = driver;
            waitTime = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public IWebElement txtUserName => waitTime.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("mailbox:login")));

        public IWebElement txtPassword => waitTime.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("mailbox:password")));

        public void PerformLogin(string Username,string Password)
        {
            txtUserName.SendKeys(Username + Keys.Enter);
            txtPassword.SendKeys(Password + Keys.Enter);
        }
    }
}
