using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ_SQA01.automationAccess
{
    public class signOut: commonMethods
    {
        By logoutBtn = By.XPath("//a[@href='/logout'][1]");
        commonMethods c1 = new commonMethods();
        public void signout()
        {
            c1.clickBtn(logoutBtn);
        }

    }
}
