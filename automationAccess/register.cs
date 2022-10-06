using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ_SQA01.automationAccess
{
    public class register: commonMethods
    {
        By signUpBtn = By.XPath("//a[normalize-space()='Signup / Login']");
        By userName= By.XPath("//input[@placeholder='Name']");
        By emailAddress = By.XPath("//input[@data-qa='signup-email']");
        By clickSignUpBtn = By.XPath("//button[normalize-space()='Signup']");
        //ENTER ACCOUNT INFORMATION

        By title = By.XPath("//input[@id='id_gender2']");
        By password = By.XPath("//input[@id='password']");
        By dayofDOB = By.XPath("//select[@id='days']");
        By monthofDOB = By.XPath("//select[@id='months']");
        By yearofDOB = By.XPath("//select[@id='years']");
        By newsletterBtn = By.XPath("//input[@id='newsletter']");
        By specialofferBtn = By.XPath("//input[@id='optin']");
        By firstName = By.XPath("//input[@id='first_name']");
        By lastName = By.XPath("//input[@id='last_name']");
        By address = By.XPath("//input[@id='address1']");
        By address2 = By.XPath("//input[@id='address2']");
        By country = By.XPath("//select[@id='country']");
        By state = By.XPath("//input[@id='state']");
        By city = By.XPath("//input[@id='city']");
        By zipcode = By.XPath("//input[@id='zipcode']");
        By mobileNumber = By.XPath("//input[@id='mobile_number']");
        By createAccountBtn = By.XPath("//button[text()='Create Account']");
        By continueBtn = By.XPath("//a[text()='Continue']");
        By cart = By.XPath("(//a[@href=\"/view_cart\"])[1]");
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

        commonMethods c1 = new commonMethods();
        //Register User
        public void newUserRegister()
        {
            c1.driverMethod("Chrome", "https://www.automationexercise.com/");
            c1.clickBtn(signUpBtn);
            c1.write(userName, "madiha");
            c1.write(emailAddress, "madihakauser27@gmail.com");
            c1.clickBtn(clickSignUpBtn);
            c1.clickBtn(title);
            c1.write(password, "#mk12345");
            c1.DropDownByValue(dayofDOB, "5");
            c1.DropDownByValue(monthofDOB, "5");
            c1.DropDownByValue(yearofDOB, "1997");
            c1.clickBtn(newsletterBtn);
            c1.clickBtn(specialofferBtn);
            c1.write(firstName,"madiha");
            c1.write(lastName,"kauser");
            c1.write(address,"Lahore Pakistan");
            c1.write(address2,"Gulberg-3 Lahore");
            c1.DropDownByValue(country, "Canada");
            c1.write(state, "Pakistan");
            c1.write(city, "Lahore");
            c1.write(zipcode, "54660");
            c1.write(mobileNumber, "03002345678");
            c1.clickBtn(createAccountBtn);
            c1.implicitWait();
            c1.clickBtn(continueBtn);
            //c1.close();
        }
        //Place Order: Register while Checkout

        public void newUserRegister1()
        {
            c1.write(userName, "shanzy");
            c1.write(emailAddress, "madihakauser77@gmail.com");
            c1.clickBtn(clickSignUpBtn);
            c1.clickBtn(title);
            c1.write(password, "#mk1234567");
            c1.DropDownByValue(dayofDOB, "5");
            c1.DropDownByValue(monthofDOB, "5");
            c1.DropDownByValue(yearofDOB, "1999");
            c1.clickBtn(newsletterBtn);
            c1.clickBtn(specialofferBtn);
            c1.write(firstName, "shanzy");
            c1.write(lastName, "Haiqa");
            c1.write(address, "Lahore Pakistan");
            c1.write(address2, "Gulberg-3 Lahore");
            c1.DropDownByValue(country, "Canada");
            c1.write(state, "Pakistan");
            c1.write(city, "Karachi");
            c1.write(zipcode, "54660");
            c1.write(mobileNumber, "03002345678");
            c1.clickBtn(createAccountBtn);
            c1.implicitWait();
            c1.clickBtn(continueBtn);
            c1.clickBtn(cart);
            c1.clickBtn(checkOutButton);
            c1.write(addComment, "No comment");
            c1.clickBtn(placeOrder);
            c1.write(nameOnCard, "madiha");
            c1.write(cardNumber, "35303-2345678-2");
            c1.write(cvc, "312");
            c1.write(expiration, "05");
            c1.write(year, "2023");
            c1.clickBtn(placeOrderr);
        }



    }
}


//updated 