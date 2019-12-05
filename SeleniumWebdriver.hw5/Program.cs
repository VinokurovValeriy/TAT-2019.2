using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebdriver.hw5
{
    class ForwardMessages
    {
        static void Main(string[] args)
        {
            //open and log in mail.ru 
             IWebDriver driver = new ChromeDriver();
             driver.Manage().Window.Maximize();
             WebDriverWait waitTime = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

             driver.Navigate().GoToUrl("https://mail.ru");
             driver.FindElement(By.Id("mailbox:login")).SendKeys("TestWebDriverForDev4" + Keys.Enter);

             waitTime.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("mailbox:password"))).SendKeys("Homework4" + Keys.Enter);

            //write message
             waitTime.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("compose-button__wrapper"))).Click();
             waitTime.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//input[@tabindex='100']"))).SendKeys("TestWebDriverForDev5@mail.ru");
             waitTime.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("cke_widget_editable"))).SendKeys("Hello" + Keys.Control + Keys.Enter);

            //open and log in second mail
             IWebDriver driver1 = new ChromeDriver();
             driver1.Manage().Window.Maximize();
             WebDriverWait waitTime1 = new WebDriverWait(driver1, TimeSpan.FromSeconds(30));


             driver1.Navigate().GoToUrl("https://mail.ru");
             driver1.FindElement(By.Id("mailbox:login")).SendKeys("TestWebDriverForDev5" + Keys.Enter);

            //reply to the message 
             waitTime1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("mailbox:password"))).SendKeys("Homework5" + Keys.Enter);

             waitTime1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='llc__item llc__item_correspondent']"))).Click();
             waitTime1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html[1]/body[1]/div[6]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/table[1]/tbody[1]/tr[1]/td[1]/div[6]/span[1]/span[1]"))).Click();
             waitTime1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("cke_widget_editable"))).SendKeys("How are you" + Keys.Control + Keys.Enter);

             driver1.Quit();

            //read the answer from second mail
             waitTime.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='nav__folder nav__folder_parent']//div[@class='nav__folder-name__txt']"))).Click();
             waitTime.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html[1]/body[1]/div[6]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/a[1]/div[4]/div[1]/div[1]/span[1]"))).Click();

             driver.Quit();
        }
    }
}
