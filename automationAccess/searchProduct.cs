using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ_SQA01.automationAccess
{
    public class searchProduct: commonMethods
    {
        By clickProducts = By.XPath("//a[@href='/products']");
        By searchBox = By.XPath("//input[@id='search_product']");
        By submitSearch = By.XPath("//button[@id='submit_search']");
        //By clickProducts = By.XPath("");
        //By clickProducts = By.XPath("");
        //By clickProducts = By.XPath("");
        //By clickProducts = By.XPath("");
        //By clickProducts = By.XPath("");

        commonMethods c1 = new commonMethods();
        public void searchMethod()
        {
            c1.clickBtn(clickProducts);
            c1.write(searchBox, "winter top");
            c1.clickBtn(submitSearch);
        }
    }
}
