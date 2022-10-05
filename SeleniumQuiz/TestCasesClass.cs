using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumQuiz
{
    [TestClass]
    public class TestCasesClass : ExtentReport
    {
        BaseCommonMethods obj = new BaseCommonMethods();
        public TestContext instance;
        public TestContext TestContext { get; set; }
        
        [ClassInitialize]
        public static void GetTestContext(TestContext test)
        {
            LogReport("TestReport");
        }
        [ClassCleanup]
        public static void ClassCleanUp()
        {
            extentReports.Flush();
        }
        [TestInitialize]
        public void Testint()
        {
            obj.driverint("Chrome");
            LogReport(TestContext.TestName);

        }
        [TestCategory("Register")]
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "MyTestCaseData.xml", "RegisterValid", DataAccessMethod.Sequential)]
        public void TestCase1_Register()
        {
            RegisterFunctionality RegObject = new RegisterFunctionality(obj.driver);
            ExtentTest test = obj.extent.CreateTest("Test Case 1: Valid Email and Password Credentails");

            string valuename = TestContext.DataRow["name"].ToString();
            string valueemail = TestContext.DataRow["email"].ToString();
            string valuepassword = TestContext.DataRow["password"].ToString();

            string valuefname = TestContext.DataRow["fname1"].ToString();
            string valuelname = TestContext.DataRow["lname2"].ToString();
            string valuecompany = TestContext.DataRow["companyy1"].ToString();
            string valueaddress1 = TestContext.DataRow["Address111"].ToString();
            string valueaddress2 = TestContext.DataRow["Address222"].ToString();
            string valuestate = TestContext.DataRow["Stateeee1"].ToString();
            string valuecity = TestContext.DataRow["Cityyy1"].ToString();
            string valuezip = TestContext.DataRow["Zipco1"].ToString();
            string valuephone = TestContext.DataRow["Mobilenumber1"].ToString();
            string valueusername = TestContext.DataRow["username"].ToString();
            RegObject.Regitser(valuename, valueemail, valuepassword, valuefname, valuelname, valuecompany, valueaddress1, 
            valueaddress2, valuestate, valuecity, valuezip, valuephone, valueusername);      
        }
        [TestCategory("Login")]
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "MyTestCaseData.xml", "ValidCredentailsLogin", DataAccessMethod.Sequential)]
        public void TestCase2_Login()
        {
            exParentTest = extentReports.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("TestCase2_Login");

            LoginFunctionality LogObject = new LoginFunctionality(obj.driver);
            string validemail = TestContext.DataRow["email"].ToString();
            string validPass = TestContext.DataRow["password"].ToString();
            string valueusername = TestContext.DataRow["username"].ToString();
            LogObject.LoginwithValid(validemail, validPass, valueusername);
        }
        [TestCategory("Logout")]
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "MyTestCaseData.xml", "Logout", DataAccessMethod.Sequential)]
        public void TestCase3_logout()
        {
            LogoutFunctioality logout1 = new LogoutFunctioality(obj.driver);

            string validemail = TestContext.DataRow["email"].ToString();
            string validPass = TestContext.DataRow["password"].ToString();
            string valueusername = TestContext.DataRow["username"].ToString();
            logout1.Logout(validemail, validPass, valueusername);
        }
        [TestCategory("Register")]
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "MyTestCaseData.xml", "RegisterValidRegitserwithexisting", DataAccessMethod.Sequential)]
        public void TestCase7_Regitserwithexisting()
        {

            RegisterFunctionality RegObject1 = new RegisterFunctionality(obj.driver);

            string valuename = TestContext.DataRow["name"].ToString();
            string valueemail = TestContext.DataRow["email"].ToString();
            string Verifytext = TestContext.DataRow["Verifytext"].ToString();
            RegObject1.Regitserwithexisting(valuename, valueemail, Verifytext);
        }
        [TestCategory("Scroll")]
        [TestMethod]
        public void TestCase8_Scrolldownup()
        {

            ScrollUpandDown scrObj = new ScrollUpandDown(obj.driver);
            scrObj.scroll();
        }


        [TestCleanup]
        public void Testcleanup()
        {
            obj.extent.Flush();
            obj.driver.Quit();
        }
    }
}
