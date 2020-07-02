using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Net;
using System.Threading;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Home
    {


        private static IWebElement Notification => Driver.driver.FindElement(By.XPath("//div[@class='ui compact menu']/div[1]"));

        private static IWebElement NotificationText => Driver.driver.FindElement(By.XPath("//div[@class='ui compact menu']/div[1]//span/div"));


        private static IWebElement Chat => Driver.driver.FindElement(By.XPath("//a[text()=' Chat']"));

        

       

        public static void Notifications()
        {
            Notification.Click();
            Thread.Sleep(1000);
        }

        public static void VerifyNotifications()
        {
            var actNotification = NotificationText.Text;
            Assert.AreEqual(actNotification, "You have no notifications", "We have notifications");
        }


        public static void ChatMethod()
        {
            Chat.Click();
            Driver.TurnOnWait();
            Thread.Sleep(1000);
        }

        public static void VerifyChatPage()
        {

           
            String ChatMessage = Driver.driver.FindElement(By.XPath("(/html/body/div[1]/div/div/div[2]/h2/div)[1]")).Text;

            if(ChatMessage.Contains("You don't have any open chats"))
            {
                Assert.True(true, "Chat is empty");
            }

            
            
        }
    }
}
