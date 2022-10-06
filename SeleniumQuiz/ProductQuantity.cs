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

        public ProductQuantity(IWebDriver DDriver)
       {
        driver = DDriver;

        }
        void ClickviewProduct()
        {
            ClickAction(viewproduct);
        }
        public void productquantity()
        {
            OpenURL();
            homepagevisible(HomePage);
            scrolldown(viewproduct);
            ClickviewProduct();

        }

    }
}
