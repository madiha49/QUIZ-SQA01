using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ_SQA01.automationAccess
{
    public class signIn: commonMethods
    {
        By emailAddress = By.XPath("//input[@data-qa='login-email']"); 
        By password = By.XPath("//input[@placeholder='Password']");
        By loginBtn = By.XPath("//button[text()='Login'][1]");
        commonMethods c1 = new commonMethods();
        public void clickLogInBtn()
        {
            //valid email,password
            c1.write(emailAddress, "madihakauser27@gmail.com");
            c1.write(password, "#mk12345");
            c1.clickBtn(loginBtn);
            c1.implicitWait();  

        }
        

    }
}
