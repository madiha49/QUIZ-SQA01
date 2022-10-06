using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ_SQA01.automationAccess
{
    public class homePage: commonMethods
    {
        By signUpBtn = By.XPath("//a[normalize-space()='Signup / Login']");
        By homeBtn = By.XPath("//a[normalize-space()='Home'][1]");
        commonMethods c1 = new commonMethods();
        public void homepageMethod()
        {
            c1.driverMethod("Chrome", "https://www.automationexercise.com/");
            c1.clickBtn(signUpBtn);
        }
        public void clickhomeBtn()
        {
            c1.clickBtn(homeBtn);
        }
        public void clickhomeBtn1()
        {
            c1.driverMethod("Chrome", "https://www.automationexercise.com/");
        }

    }
}
