using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;

class HelloSelenium
{
    static void Main()
    {
        using IWebDriver driver = new EdgeDriver(Environment.CurrentDirectory);
        WebDriverWait wait = new(driver, TimeSpan.FromSeconds(10));
        driver.Navigate().GoToUrl("https://www.google.com/ncr");
        driver.FindElement(By.Name("q")).SendKeys("cheese" + Keys.Enter);
        wait.Until(webDriver => webDriver.FindElement(By.CssSelector("h3")).Displayed);
        IWebElement firstResult = driver.FindElement(By.CssSelector("h3"));
        Console.WriteLine(firstResult.GetAttribute("textContent"));
    }
}