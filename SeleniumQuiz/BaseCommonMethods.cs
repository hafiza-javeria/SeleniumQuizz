using AventStack.ExtentReports.Reporter;
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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.Extensions;
using AventStack.ExtentReports;

namespace SeleniumQuiz
{
    public class BaseCommonMethods:ExtentReport
    {
        public ExtentHtmlReporter report = new ExtentHtmlReporter("C://Users//CA//source//repos//SeleniumQuiz//Report//" + DateTime.Now.ToString("ddMMyyyy"));
        public AventStack.ExtentReports.ExtentReports extent = new AventStack.ExtentReports.ExtentReports();
        public IWebDriver driver;
        Actions action;
        public void driverint(String browser) // for Browser 
        {
            if (browser == "Chrome")
            {
                driver = new ChromeDriver();
            }
            else if (browser == "Firefox")
            {
                driver = new FirefoxDriver();
            }
            else if (browser == "MSEdge")
            {
                driver = new EdgeDriver();
            }
        }
        public void OpenURL() // Open Website with Link 
        {

            driver.Navigate().GoToUrl("https://automationexercise.com/");
        }
        public void homepagevisible(By value)
        {
            string actualvalue = GetText(value);
            Assert.AreEqual("Features Items", actualvalue);
        }
        public bool PageReady(IWebDriver driver) // For page Ready means Load complete page
        {

            return ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete");
        }
        public IWebElement FindElementt(By value) //Find Element with locators 
        {
            IWebElement element = driver.FindElement(value);
            return element;
        }
        public bool ElementVisible(By element) // If element enable or displayed 
        {
            if (driver.FindElement(element).Displayed || driver.FindElement(element).Enabled)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Clickable(By by)

        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }
        public IWebElement Wait(By element)
        {
            IWebElement element_1 = null;
            try
            {
                element_1 = driver.FindElement(element);
            }
            catch
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                wait.Until(driver => PageReady(driver) == true || ElementVisible(element) == true || Clickable(element) == true);
                element_1 = driver.FindElement(element);
            }
            return element_1;
        }
        public void Threadwait()
        {
            Thread.Sleep(3000);
        }
        public void remove(IWebElement ele) // Clear Field before Writing anything
        {
            int a = ele.Text.Length;
            while (a > 0)
            {
                ele.SendKeys(Keys.Backspace);
            }
        }
        public void SetValue(By Field, string value) //Write Values in the fields 
        {
            IWebElement neww = FindElementt(Field);
            neww.Clear();
            neww.SendKeys(value);
            neww.SendKeys(Keys.Tab);
        }
        public string GetText(By path)
        {
            string st = " ";
            IWebElement neww = FindElementt(path);
            st = neww.GetAttribute("innerHTML");
            return st;
        }
        public void ClickAction(By loc) // Click Function
        {
            action = new Actions(driver);
            action.Click(FindElementt(loc)).Build().Perform();
        }
        public void assertelement(By value, String expected)
        {
            string actual = GetText(value);
            Assert.AreEqual(expected, actual);
        }
        public void scrolldown(By locc)
        {
            var el = FindElementt(locc);
            ((IJavaScriptExecutor)driver)
            .ExecuteScript("arguments[0].scrollIntoView(true);", el);
        }
        public void scrollup()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 0)");
        }
        public void DriverClose()
        {
           driver.Close();
        }
       
    }
}
