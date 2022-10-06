using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumQuiz
{
    public class DownloadInvoice : BaseCommonMethods
    {
        public DownloadInvoice(IWebDriver DDriver)
        {
            driver = DDriver;
        }
    }
}
