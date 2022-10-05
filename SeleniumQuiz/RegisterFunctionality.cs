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
            OpenURL(); // Open URL
            homepagee(); // HomePage Visibility 
            Selectregister(); // Click on Signup/Login
            Wait(signupverify);
            newusersignup(); // Veirfy New User Signup
            Wait(Namee); // wait for element name field
            Entername(nameee); // Enter name
            EnterEmail(emailll); // Enter email
            ClickSignup(); // Signup button
            Selecttitle(); 
            EnterPassword(passwordd);
            dropdowndayy(); 
            dropdownmonthh();
            dropdownyearr();
            checkboxx();
            fname(fffname);
            lname(lllname);
            Companyy(companyyy);
            Address11(address1111);
            Address22(address2222);
            contouryy();
            Stateeee(stateeeee);
            Cityyy(cityyyy);
            Zipco(zippp);
            Mobilenumber(phonenumebr);
            Clickcreatebtn();
            Clickcpntbtn();
            Wait(verify);
            string actualvalue = GetText(verify);
            Assert.AreEqual(verifyysignup, actualvalue);
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
