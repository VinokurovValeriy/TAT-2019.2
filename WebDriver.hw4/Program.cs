using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WebDriverTest.hw4
{
    class UnreadMessages //displays the number of unread messages
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            WebDriverWait waitTime = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://mail.ru");
            driver.FindElement(By.Id("mailbox:login")).SendKeys("TestWebDriverForDev4" + Keys.Enter);

            IWebElement password = waitTime.Until(ExpectedConditions.ElementIsVisible(By.Id("mailbox:password"))); 
            password.SendKeys("Homework4" + Keys.Enter); 

            IWebElement unread_messages = waitTime.Until(ExpectedConditions.ElementIsVisible(By.Id("g_mail_events")));
            Console.Write("The number of unread messages: " + unread_messages.Text + "\n");

            driver.Quit();

        }
    }
}
