using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QUIZ_SQA01.automationAccess
{
    public class addToCart: commonMethods
    {
        By clickProducts = By.XPath("//a[@href='/products']");
        By selectProduct1 = By.XPath("(//i[@class='fa fa-shopping-cart'])[2]");
        By selectProduct2 = By.XPath("(//i[@class='fa fa-shopping-cart'])[4]");
        By continueShoppingButton = By.XPath("//button[contains(text(),'Continue Shopping')]");
        By viewCart = By.XPath("//u[normalize-space()='View Cart']");
        By checkOutButton = By.XPath("//a[text()='Proceed To Checkout']");
        By registerLogin = By.XPath("//u[text()='Register / Login']");
        By cartBtn = By.XPath("//a[@href=\"/view_cart\"]");
        By addComment = By.XPath("//textarea[@name='message']");
        By placeOrder = By.XPath("//a[text()='Place Order']");
        By nameOnCard = By.XPath("//input[@name='name_on_card']");
        By cardNumber = By.XPath("//input[@name='card_number']");
        By cvc = By.XPath("//input[@placeholder='ex. 311']");
        By expiration = By.XPath("//input[@placeholder='MM']");
        By year = By.XPath("//input[@placeholder='YYYY']");
        By placeOrderr = By.XPath("(//button[text()='Pay and Confirm Order'])[1]");
        By downloadInvoice = By.XPath("//a[text()='Download Invoice']");

        commonMethods c1 = new commonMethods();
        public void cartMethod()
        {
            c1.clickBtn(cartBtn);
            c1.clickBtn(checkOutButton);
            c1.write(addComment, "No comment");
            c1.clickBtn(placeOrder);
            c1.write(nameOnCard,"madiha");
            c1.write(cardNumber, "35303-2345678-2");
            c1.write(cvc, "312");
            c1.write(expiration, "05");
            c1.write(year, "2023");
            c1.clickBtn(placeOrderr);

        }
        public void addToCartMethod()
        {
            c1.clickBtn(clickProducts);
            c1.actionMethod1(selectProduct1);
            //c1.implicitWait();
            Thread.Sleep(2000);

            c1.clickBtn(continueShoppingButton);
            c1.actionMethod1(selectProduct2);
            //c1.implicitWait();
            Thread.Sleep(2000);

            c1.clickBtn(viewCart);
            //c1.implicitWait();
            //Thread.Sleep(2000);
            Thread.Sleep(2000);
            c1.clickBtn(checkOutButton);
            Thread.Sleep(2000);

            c1.clickBtn(registerLogin);
        }
        public void downloadInvoiceMethod()
        {
            c1.clickBtn(downloadInvoice);
        }
       

    }
}
