using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebdriver.hw5.PageObjects
{
    class YandexMainPage
    {
        private IWebDriver _driver;

        WebDriverWait waitTime1;
        public YandexMainPage(IWebDriver driver1)
        {
            _driver = driver1;
            waitTime1 = new WebDriverWait(driver1, TimeSpan.FromSeconds(10));
        }

        public IWebElement answrMessage => waitTime1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[@title='testwebdriverfordev4@mail.ru']")));

        public IWebElement btnAnswer => waitTime1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("mail-QuickReply-Placeholder_text")));

        public IWebElement wrtMessage => waitTime1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@role='textbox']")));

        public void AnswerMessage(string Message)
        {
            answrMessage.Click();
            btnAnswer.Click();
            wrtMessage.SendKeys(Message + Keys.Control + Keys.Enter);
        }

    }
}
