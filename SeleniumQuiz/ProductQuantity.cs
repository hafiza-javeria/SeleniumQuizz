using AventStack.ExtentReports.Model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumQuiz
{
    public class ProductQuantity : BaseCommonMethods
    {

        By HomePage = By.XPath("/html/body/section[2]/div/div/div[2]/div[1]/h2");

        By viewproduct = By.XPath("/html/body/section[2]/div/div/div[2]/div[1]/div[2]/div/div[2]/ul/li/a");

        By verifyviewdetails = By.XPath("/html/body/section/div/div/div[1]/div[1]/h2");

        
        public ProductQuantity(IWebDriver DDriver)
       {
        driver = DDriver;

        }
        void ClickviewProduct()
        {
            ClickAction(viewproduct);
        }
        void viewassertion()
        {
            assertelement(verifyviewdetails, "Category");
        }
        public void productquantity()
        {
            OpenURL();
            homepagevisible(HomePage);
            scrolldown(viewproduct);
            ClickviewProduct();
            viewassertion();
        }

    }
}
