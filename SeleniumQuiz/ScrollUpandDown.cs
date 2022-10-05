using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumQuiz
{
    public class ScrollUpandDown : BaseCommonMethods
    {
        // Home Page
        By HomePage = By.XPath("/html/body/section[2]/div/div/div[2]/div[1]/h2");

        // Sub
        By subscription = By.CssSelector("#footer > div.footer-widget > div > div > div.col-sm-3.col-sm-offset-1 > div > h2");

        // After Scrollup verify
        By verifytext = By.XPath("//*[@id=\"slider-carousel\"]/div/div[1]/div[1]/h2");

        public ScrollUpandDown(IWebDriver DDriver)
        {
            driver = DDriver;

        }
        void subcription()
        {
            string actualvalue = GetText(subscription);
            Assert.AreEqual("Subscription", actualvalue);

        }
        void asertafterup()
        {
            assertelement(verifytext, "Full-Fledged practice website for Automation Engineers");
        }
        public void scroll()
        {
            OpenURL();
            homepagevisible(HomePage);
            Wait(HomePage);
            scrolldown(subscription);
            Threadwait();
            subcription();
            scrollup();
            Threadwait();
            asertafterup();
            Threadwait();
            DriverClose();
        }
    }
}
