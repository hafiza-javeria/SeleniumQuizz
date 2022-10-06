using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumQuiz
{
    public class DownloadInvoice : BaseCommonMethods
    {
        // Home Page
        By HomePage = By.XPath("/html/body/section[2]/div/div/div[2]/div[1]/h2");

        By Productt = By.XPath("/html/body/section[2]/div/div/div[2]/div/div[2]/div/div[2]/ul/li/a");
        By Addtocart = By.XPath("/html/body/section[2]/div/div/div[2]/div[1]/div[2]/div/div[1]/div[1]/a");
        By viewProCart = By.XPath("//*[@id=\"cartModal\"]/div/div/div[2]/p[2]/a/u");
        By Checkoutbtn = By.LinkText("Proceed To Checkout");

        By Registerbtn = By.XPath("//*[@id='checkoutModal']/div/div/div[2]/p[2]/a/u");


        public DownloadInvoice(IWebDriver DDriver)
        {
            driver = DDriver;
        }
        void homepagee()
        {
            homepagevisible(HomePage);
        }
        void ProductintoCart()
        {
            ClickAction(Productt);
        }
        void Intocart()
        {
            ClickAction(Addtocart);
        }

        void ViewProductinCart()
        {
            ClickAction(viewProCart);
        }

        void Clickcheckoutbtn()
        {
            ClickAction(Checkoutbtn);
        }
        void ClickRegister()
        {
            ClickAction(Registerbtn);
        }
      
        public void InvoiceDownload()
        {
            RegisterFunctionality RegObject = new RegisterFunctionality(driver);
            OpenURL();
            homepagee();
            scrolldown(Addtocart);
            Threadwait();
            Intocart();
            //ProductintoCart();
            Wait(viewProCart);
            ViewProductinCart();
            Clickcheckoutbtn();

            Threadwait();
        }
    }
}
