using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebdriver.hw5.PageObjects
{
    class YandexLoginPage
    {
        private IWebDriver _driver;

        WebDriverWait waitTime1;
        public YandexLoginPage NavigateToMainPage()
        {
            _driver.Navigate().GoToUrl("https://passport.yandex.by/auth/list?origin=home_desktop_by&retpath=https%3A%2F%2Fmail.yandex.by%2F&backpath=https%3A%2F%2Fyandex.by");
            return this;
        }

        public YandexLoginPage(IWebDriver driver1)
        {
            _driver = driver1;
            waitTime1 = new WebDriverWait(driver1, TimeSpan.FromSeconds(10));
        }

        public IWebElement txtUserName => waitTime1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("passp-field-login")));

        public IWebElement txtPassword => waitTime1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("passp-field-passwd")));

        public void PerformLogin(string Username, string Password)
        {
            txtUserName.SendKeys(Username + Keys.Enter);
            txtPassword.SendKeys(Password + Keys.Enter);
        }
    }
}
