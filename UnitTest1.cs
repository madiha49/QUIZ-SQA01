using Microsoft.VisualStudio.TestTools.UnitTesting;
using QUIZ_SQA01.automationAccess;
using System;

namespace QUIZ_SQA01
{
    [TestClass]
    public class baseClass:commonMethods
    {
        [TestMethod]
        //Register User
        public void testCase1()
        {
            register objregister = new register();
            objregister.newUserRegister();
        }
        [TestMethod]
        //Login 
        public void testCase2()
        {
            homePage objhomePage = new homePage();
            objhomePage.homepageMethod();
            signIn objsignIn = new signIn();
            objsignIn.clickLogInBtn();
        }
        
        [TestMethod]
        //Logout User
        public void testCase3()
        {
            //object
            homePage objhomePage = new homePage();
            objhomePage.homepageMethod();
            //object
            signIn objsignIn = new signIn();
            objsignIn.clickLogInBtn();
            //object
            signOut objsignOut = new signOut();
            objsignOut.signout();
            //
            objhomePage.clickhomeBtn();
        }
        [TestMethod]
        //Search Product
        public void testCase4()
        {
            homePage objhomePage = new homePage();
            objhomePage.clickhomeBtn1();
            searchProduct objsearchProduct = new searchProduct();
            objsearchProduct.searchMethod();
        }
        [TestMethod]
        //Add Products in Cart
        public void testCase5()
        {
            homePage objhomePage = new homePage();
            objhomePage.clickhomeBtn1();
            addToCart objaddToCart = new addToCart();
            objaddToCart.addToCartMethod();
            signIn objsignIn = new signIn();
            objsignIn.clickLogInBtn();
            objaddToCart.cartMethod();

        }
        //Download Invoice after purchase order
        [TestMethod]
        public void testCase6()
        {
            homePage objhomePage = new homePage();
            objhomePage.clickhomeBtn1();
            addToCart objaddToCart = new addToCart();
            objaddToCart.addToCartMethod();
            signIn objsignIn = new signIn();
            objsignIn.clickLogInBtn();
            objaddToCart.cartMethod();
            objaddToCart.downloadInvoiceMethod();
        }
        //Place Order: Register while Checkout
        [TestMethod]
        public void testCase7()
        {
            homePage objhomePage = new homePage();
            objhomePage.clickhomeBtn1();
            addToCart objaddToCart = new addToCart();
            objaddToCart.addToCartMethod();
            register objregister = new register();
            objregister.newUserRegister1();


        }


    }
}
