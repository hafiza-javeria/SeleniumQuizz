using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumQuiz
{
    [TestClass]
    public class RegisterFunctionality : BaseCommonMethods
    {
        BaseCommonMethods Baseobj = new BaseCommonMethods();
        // Home Page
        By HomePage = By.XPath("/html/body/section[2]/div/div/div[2]/div[1]/h2");

        // Verify New User Signup
        By signupverify = By.XPath("//*[@id=\"form\"]/div/div/div[3]/div/h2");
        //Signup Page with 2 Fields
        By SelectSignup = By.XPath("//*[@id=\"header\"]/div/div/div/div[2]/div/ul/li[4]/a");
        By Namee = By.XPath("//*[@id=\"form\"]/div/div/div[3]/div/form/input[2]");
        By email = By.XPath("//*[@id=\"form\"]/div/div/div[3]/div/form/input[3]");
        By SignupBtn = By.XPath("//*[@id=\"form\"]/div/div/div[3]/div/form/button");
        
        //Next Information 
        By Titleradio = By.Id("id_gender2");
        By password = By.Id("password");
        By dropdownday = By.Id("days");
        By dropdownmonth = By.Id("months");
        By dropdownYear = By.Id("years");
        By checkboxnew = By.Id("newsletter");

        By firstname = By.Id("first_name");
        By Lastname = By.Id("last_name");
        By Company = By.Id("company");
        By Address1 = By.Id("address1");
        By Address2 = By.Id("address2");
        By Country = By.Id("country");
        By statee = By.Id("state");
        By Cityy = By.Id("city");
        By zipcodee = By.Id("zipcode");
        By Phonee = By.Id("mobile_number");

        By CreateAccountButton = By.XPath("//*[@id=\"form\"]/div/div/div/div/form/button");

        // Continue Button agter create account 
        By cont = By.XPath("//*[@id=\"form\"]/div/div/div/div/a");
        //Verify User name 
        By verify = By.XPath("//b");
        //Signup with existing User
        By existing = By.XPath("//*[@id=\"form\"]/div/div/div[3]/div/form/p");
        public RegisterFunctionality(IWebDriver DDriver)
        {
            driver = DDriver;

        }
        void homepagee()
        {
            homepagevisible(HomePage);
        }
        void newusersignup()
        {
            string actualvalue = GetText(signupverify);
            Assert.AreEqual("New User Signup!", actualvalue);

        }
        // Sign Page 1 Functions 
        void Selectregister() 
        {
            ClickAction(SelectSignup);
        }
        void Entername(String inputname) 
        {
            SetValue(Namee, inputname);
        }
        void EnterEmail(String inputemail) 
        {
            SetValue(email, inputemail);
        }
        void ClickSignup() 
        {
            ClickAction(SignupBtn);
        }

        //Signup Page 2 Functions
        void Selecttitle()
        {
            ClickAction(Titleradio);
        }
        void EnterPassword(String inputpass)
        {
            SetValue(password, inputpass);
        }
        void dropdowndayy()
        {
            var drop1 = driver.FindElement(dropdownday);
            var selectdropdown1 = new SelectElement(drop1);
            selectdropdown1.SelectByValue("4");
        }
        void dropdownmonthh()
        {
            var drop1 = driver.FindElement(dropdownmonth);
            var selectdropdown1 = new SelectElement(drop1);
            selectdropdown1.SelectByValue("2");
        }
        void dropdownyearr()
        {
            var drop1 = driver.FindElement(dropdownYear);
            var selectdropdown1 = new SelectElement(drop1);
            selectdropdown1.SelectByValue("1995");
        }
        void checkboxx()
        {
            ClickAction(checkboxnew);
        }
        void fname(string ffname)
        {
            SetValue(firstname, ffname);
        }
        void lname(string llname)
        {
            SetValue(Lastname, llname);
        }
        void Companyy(string comp)
        {
            SetValue(Company, comp);
        }
        void Address11(string add1)
        {
            SetValue(Address1, add1);
        }
        void Address22(string add2)
        {
            SetValue(Address2, add2);
        }
        void contouryy()
        {
            var drop1 = driver.FindElement(Country);
            var selectdropdown1 = new SelectElement(drop1);
            selectdropdown1.SelectByValue("Canada");
        }
        void Stateeee(string stateee)
        {
            SetValue(statee, stateee);
        }
        void Cityyy(string cityyyyy)
        {
            SetValue(Cityy, cityyyyy);
        }
        void Zipco(string zipcodeee)
        {
            SetValue(zipcodee, zipcodeee);
        }
        void Mobilenumber(string mobilee)
        {
            SetValue(Phonee, mobilee);
        }
        void Clickcreatebtn()
        {
            ClickAction(CreateAccountButton);
        }
        void Clickcpntbtn()
        {
            ClickAction(cont);
        }
        //Register User
        public void Regitser(string nameee, string emailll,string passwordd, string fffname, string lllname, string companyyy,
            string address1111, string address2222, string stateeeee,string cityyyy, string zippp, string phonenumebr, string verifyysignup)
        {
            OpenURL();
            exChildTest.Log(Status.Pass, "Step 1: Open URL https://automationexercise.com/");
            homepagee();
            exChildTest.Log(Status.Pass, "Step 2: Verify that home page is visible successfully");
            Selectregister();
            exChildTest.Log(Status.Pass, "Step 3: Verify that home page is visible successfully");
            Wait(signupverify);
            newusersignup();
            exChildTest.Log(Status.Pass, "Step 4: Verify that home page is visible successfully");
            Wait(Namee); 
            Entername(nameee);
            exChildTest.Log(Status.Pass, "Step 5: Verify that home page is visible successfully");
            EnterEmail(emailll);
            exChildTest.Log(Status.Pass, "Step 6: Verify that home page is visible successfully");
            ClickSignup();
            exChildTest.Log(Status.Pass, "Step 7: Verify that home page is visible successfully");
            Selecttitle();
            exChildTest.Log(Status.Pass, "Step 8: Verify that home page is visible successfully");
            EnterPassword(passwordd);
            exChildTest.Log(Status.Pass, "Step 9: Verify that home page is visible successfully");
            dropdowndayy();
            exChildTest.Log(Status.Pass, "Step 10: Verify that home page is visible successfully");
            dropdownmonthh();
            exChildTest.Log(Status.Pass, "Step 11: Verify that home page is visible successfully");
            dropdownyearr();
            exChildTest.Log(Status.Pass, "Step 12: Verify that home page is visible successfully");
            checkboxx();
            exChildTest.Log(Status.Pass, "Step 13: Verify that home page is visible successfully");
            fname(fffname);
            exChildTest.Log(Status.Pass, "Step 14: Verify that home page is visible successfully");
            lname(lllname);
            exChildTest.Log(Status.Pass, "Step 15: Verify that home page is visible successfully");
            Companyy(companyyy);
            exChildTest.Log(Status.Pass, "Step 16: Verify that home page is visible successfully");
            Address11(address1111);
            exChildTest.Log(Status.Pass, "Step 17: Verify that home page is visible successfully");
            Address22(address2222);
            exChildTest.Log(Status.Pass, "Step 18: Verify that home page is visible successfully");
            contouryy();
            exChildTest.Log(Status.Pass, "Step 19: Verify that home page is visible successfully");
            Stateeee(stateeeee);
            exChildTest.Log(Status.Pass, "Step 20: Verify that home page is visible successfully");
            Cityyy(cityyyy);
            exChildTest.Log(Status.Pass, "Step 21: Verify that home page is visible successfully");
            Zipco(zippp);
            exChildTest.Log(Status.Pass, "Step 22: Verify that home page is visible successfully");
            Mobilenumber(phonenumebr);
            exChildTest.Log(Status.Pass, "Step 23: Verify that home page is visible successfully");
            Clickcreatebtn();
            exChildTest.Log(Status.Pass, "Step 24: Verify that home page is visible successfully");
            Clickcpntbtn();
            exChildTest.Log(Status.Pass, "Step 25: Verify that home page is visible successfully");
            Wait(verify);
            string actualvalue = GetText(verify);
            Assert.AreEqual(verifyysignup, actualvalue);
            exChildTest.Log(Status.Pass, "Step 26: Verify that home page is visible successfully");
            Threadwait();
            DriverClose();
        }
        public void Regitserwithexisting(string nameee, string emailll, string verifyy)
        {
            OpenURL();
            Selectregister();
            Entername(nameee);
            EnterEmail(emailll);
            ClickSignup();
            ClickSignup();
            string actualvalue = GetText(existing);
            Assert.AreEqual(verifyy, actualvalue);
            Threadwait();
            DriverClose();
        }
    }
}
