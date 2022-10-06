using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QUIZ_SQA01.automationAccess
{
    public class commonMethods
    {
        public static IWebDriver driver;
        public void driverMethod(string browser, string url)
        {

            if (browser == "Chrome")
            {

                driver = new ChromeDriver();


            }
            else if (browser == "Firefox")
            {

                driver = new FirefoxDriver();

            }
            else if (browser == "Edge")
            {

                driver = new EdgeDriver();

            }
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

        }
        public void actionMethod(By by)
        {
            var menue = driver.FindElement(by);
            Actions actions = new Actions(driver);
            actions.MoveToElement(menue).Perform();
        }
        public void actionMethod1(By by)
        {
            var menue = driver.FindElement(by);
            Actions actions = new Actions(driver);
            actions.MoveToElement(menue).Click().Perform();

        }
      
        public void  findElement(By by)
        {
            driver.FindElement(by);
        }

        public void implicitWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

        }

        public void close()
        {
            driver.Close();
        }
        public void write(By by, string value)
        {
            driver.FindElement(by).SendKeys(value);
        }
        public void clickBtn(By by)
        {
            driver.FindElement(by).Click();
        }
        public void DropDownByValue(By by, string value)
        {
            var dropdown = driver.FindElement(by);

            var drpElement = new SelectElement(dropdown);

            drpElement.SelectByValue(value);

        }
        public void DropDownByText(By by, string text)
        {
            var dropdown = driver.FindElement(by);

            var drpElement = new SelectElement(dropdown);

            drpElement.SelectByText(text);

        }
        public void DropDownByIndex(By by, int index)
        {
            var dropdown = driver.FindElement(by);

            var drpElement = new SelectElement(dropdown);

            drpElement.SelectByIndex(index);


        }
        public void textbox(By by, string text)
        {
            driver.FindElement(by).SendKeys(text + Keys.Enter);
        }
    }
}
