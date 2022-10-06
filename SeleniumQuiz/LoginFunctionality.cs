using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumQuiz
{
    [TestClass]
    public class LoginFunctionality : BaseCommonMethods
    {

        By SelectLogin = By.XPath("//*[@id=\"header\"]/div/div/div/div[2]/div/ul/li[4]/a");
        By email = By.XPath("//*[@id=\"form\"]/div/div/div[1]/div/form/input[2]");
        By password = By.XPath("//*[@id=\"form\"]/div/div/div[1]/div/form/input[3]");
        By loginButton = By.XPath("//*[@id=\"form\"]/div/div/div[1]/div/form/button");


        By HomePage = By.XPath("/html/body/section[2]/div/div/div[2]/div[1]/h2");
        By verifytitle = By.XPath("//*[@id=\"form\"]/div/div/div[1]/div/h2");
        By Del = By.XPath("//a[text()=' Delete Account']");


        //Verify User name 
        By verify = By.XPath("//b");
        public LoginFunctionality(IWebDriver DDriver)
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
        public void LoginwithValid(string emaill, string pass, string verifyysignup)
        {
            string path = @"C:\Users\CA\source\repos\SeleniumQuiz\Report\Extent\";
            OpenURL();
            exChildTest.Log(Status.Pass, "Step 1: Open URL https://automationexercise.com/");
            Screenshot image_username = ((ITakesScreenshot)driver).GetScreenshot();
            image_username.SaveAsFile(path + "Step 1.png", ScreenshotImageFormat.Png);
            homepagevisible(HomePage);
            exChildTest.Log(Status.Pass, "Step 2: Verify that home page is visible successfully");
            Screenshot image_username1 = ((ITakesScreenshot)driver).GetScreenshot();
            image_username1.SaveAsFile(path + "Step 2.png", ScreenshotImageFormat.Png);
            SelectloginMethod();
            exChildTest.Log(Status.Pass, "Step 3: Click on 'Signup / Login' button");
            assertelement(verifytitle, "Login to your account");
            exChildTest.Log(Status.Pass, "Step 4: Verify 'Login to your account' is visible");
            Wait(email);
            EnterEmail(emaill);
            exChildTest.Log(Status.Pass, "Step 5: Enter correct email address");
            Wait(password);
            EnterPassword(pass);
            exChildTest.Log(Status.Pass, "Step 6: Enter correct password");
            Wait(loginButton);
            ClickLoginBtn();
            exChildTest.Log(Status.Pass, "Step 7: Click 'Signup' button");
            string actualvalue = GetText(verify);
            Assert.AreEqual(verifyysignup, actualvalue);
            exChildTest.Log(Status.Pass, "Step 8: Verify that 'Logged in as username' is visible");
            ClickAction(Del);
            exChildTest.Log(Status.Pass, "Step 9: Click 'Delete Account' button");
            exChildTest.Log(Status.Pass, "Step 10: Verify that 'ACCOUNT DELETED!' is visible");
            Threadwait();
            DriverClose();
        }

    }
}
