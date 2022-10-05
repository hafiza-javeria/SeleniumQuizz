using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumQuiz
{
    [TestClass]
    public class LogoutFunctioality : BaseCommonMethods
    {
        By SelectLogin = By.XPath("//*[@id=\"header\"]/div/div/div/div[2]/div/ul/li[4]/a");
        By email = By.XPath("//*[@id=\"form\"]/div/div/div[1]/div/form/input[2]");
        By password = By.XPath("//*[@id=\"form\"]/div/div/div[1]/div/form/input[3]");
        By loginButton = By.XPath("//*[@id=\"form\"]/div/div/div[1]/div/form/button");
        By HomePage = By.XPath("/html/body/section[2]/div/div/div[2]/div[1]/h2");
        By verifytitle = By.XPath("//*[@id=\"form\"]/div/div/div[1]/div/h2");
        //Verify User name 
        By verify = By.XPath("//b");
        By logout = By.CssSelector("#header > div > div > div > div.col-sm-8 > div > ul > li:nth-child(4) > a > i");
        public LogoutFunctioality(IWebDriver DDriver)
        {
            driver = DDriver;

        }
        void SelectloginMethod() //Open form for login
        {
            ClickAction(SelectLogin);
        }
        void EnterEmail(String inputemail) //
        {
            SetValue(email, inputemail);
        }
        void EnterPassword(String Inputpassword)
        {
            SetValue(password, Inputpassword);
        }
        void ClickLoginBtn()
        {
            ClickAction(loginButton);
        }
        void ClickLogoutBtn()
        {
            ClickAction(logout);
        }
        public void Logout(string emaill, string pass, string verifyysignup)
        {
            OpenURL();
            homepagevisible(HomePage);
            SelectloginMethod();
            assertelement(verifytitle, "Login to your account");
            Wait(email);
            EnterEmail(emaill);
            Wait(password);
            EnterPassword(pass);
            Wait(loginButton);
            ClickLoginBtn();
            string actualvalue = GetText(verify);
            Assert.AreEqual(verifyysignup, actualvalue);
            ClickLogoutBtn();
            Threadwait();
            DriverClose();
        }
    }
   
}
