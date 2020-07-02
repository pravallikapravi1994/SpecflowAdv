using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;


namespace MarsQA_1.SpecflowPages.Pages
{
    class ManageRequest
    {

        private static IWebElement ManageRequestsLink => Driver.driver.FindElement(By.XPath("//div[text()= 'Manage Requests']"));

        private static IWebElement RecievedRequests => Driver.driver.FindElement(By.XPath("//a[text()= 'Received Requests']"));

        private static IWebElement SentRequests => Driver.driver.FindElement(By.XPath("//a[text()= 'Sent Requests']"));

        private static IWebElement SentRequestsContent => Driver.driver.FindElement(By.XPath("//h2[text()='Sent Requests']/../h3"));

        private static IWebElement RecievedRequestContent => Driver.driver.FindElement(By.XPath("//h2[text()= 'Received Requests']/../h3"));


        public static void  NavigateToManageRequest()
        {
            ManageRequestsLink.Click();
            Driver.TurnOnWait();

        }



        public static void NavigateToReceivedRequest()
        {
            RecievedRequests.Click();
            Driver.TurnOnWait();

        }



        public static void NavigateToSentRequest()
        {
            SentRequests.Click();
            Driver.TurnOnWait();

        }


        public static void verifyRecievedRequestcontent()
        {
            var ActCont = RecievedRequestContent.Text;


            Assert.AreEqual(ActCont, "You do not have any received requests!", "Request does not match");


        }


        public static void verifySentRequestcontent()
        {
            var ActCont = SentRequestsContent.Text;


            Assert.AreEqual(ActCont, "You do not have any sent requests!", "Request does not match");
        }


    }
}
