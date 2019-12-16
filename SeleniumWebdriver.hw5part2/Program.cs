using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumWebdriver.hw5.PageObjects;

namespace SeleniumWebdriver.hw5
{
    class ForwardMessages
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            WebDriverWait waitTime = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            MailLoginPage LoginPage = new MailLoginPage(driver);
            LoginPage.NavigateToMainPage();
            LoginPage.PerformLogin("TestWebDriverForDev4","Homework4");
            MailMainPage MainPage = new MailMainPage(driver);
            MainPage.PerformMessage("testwebdriverfordev5@yandex.by", "Hello");

            IWebDriver driver1 = new ChromeDriver();
            driver1.Manage().Window.Maximize();

            YandexLoginPage LoginPage1 = new YandexLoginPage(driver1);
            LoginPage1.NavigateToMainPage();
            LoginPage1.PerformLogin( "testwebdriverfordev5", "homework5");
            YandexMainPage MainPage1 = new YandexMainPage(driver1);
            MainPage1.AnswerMessage("You are welcom");

            driver1.Quit();

            MainPage.ReadAnswer();

            driver.Quit();
        }
    }
}
