using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace SeleniumWebdriver.hw5.PageObjects
{
    class MailMainPage
    {
        private IWebDriver _driver;

        WebDriverWait waitTime;
        public MailMainPage(IWebDriver driver)
        {
            _driver = driver;
            waitTime = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public IWebElement btnMessage => waitTime.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("compose-button__wrapper")));

        public IWebElement wrtRecipient => waitTime.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//input[@tabindex='100']")));

        public IWebElement wrtMessage => waitTime.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("cke_widget_editable")));

        public void PerformMessage(string Recipient,string Message)
        {
            btnMessage.Click();
            wrtRecipient.SendKeys(Recipient);
            wrtMessage.SendKeys(Message + Keys.Control + Keys.Enter);
        }

        public IWebElement btnInbox => waitTime.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='nav__folder nav__folder_parent']//div[@class='nav__folder-name__txt']")));
        public IWebElement readAnswer => waitTime.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[@title='Валерий Пупкин <testwebdriverfordev5@yandex.by>']")));
        public void ReadAnswer()
        {
            btnInbox.Click();
            readAnswer.Click();
        }
    }
}
