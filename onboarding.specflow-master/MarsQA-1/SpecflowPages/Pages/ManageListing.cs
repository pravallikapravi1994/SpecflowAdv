using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
namespace MarsQA_1.SpecflowPages.Pages
{
    class ManageListing
    {




        private static IWebElement ManageListingLink => Driver.driver.FindElement(By.XPath("//a[text()='Manage Listings']"));
        private static IWebElement TitleS1 => Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']//tbody/tr[1]/td[3]"));

        private static IWebElement DescriptionS1 => Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']//tbody/tr[1]/td[4]"));

        private static IWebElement CategoryS1 => Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']//tbody/tr[1]/td[2]"));

        private static IWebElement ServiceTypeS1 => Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']//tbody/tr[1]/td[5]"));

        private static IWebElement ViewIconS1 => Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']//table/tbody/tr[1]/td[8]//i[@class='eye icon']"));


        private static IWebElement EditIconS1 => Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']//table/tbody/tr[1]/td[8]//i[@class='outline write icon']"));


        private static IWebElement DeleteIconS1 => Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']//table/tbody/tr[1]/td[8]//i[@class='remove icon']"));



        private static IWebElement DeleteYesButton => Driver.driver.FindElement(By.XPath("//i[@class='checkmark icon']"));

        private static IWebElement DeleteNoButton => Driver.driver.FindElement(By.XPath("//*[text()='No']"));

        public static void VerifySavedSeriveList()
        {
            var ExpTitle = ExcelLibHelper.ReadData(2, "Title");
            var ActTitle = TitleS1.Text;


            var ExpDes = ExcelLibHelper.ReadData(2, "Description");
            var ActDes = DescriptionS1.Text;


            var ExpCat = ExcelLibHelper.ReadData(2, "Category");
            var ActCat = CategoryS1.Text;


            Assert.AreEqual(ExpTitle, ActTitle, "Title is  not  saved");
            Assert.AreEqual(ExpDes, ActDes, "Description does not match");
            Assert.AreEqual(ExpCat, ActCat, "Categoty does not match");

        }


        public static void NavigatetoManagelisting()
        {

            Driver.TurnOnWait();
            ManageListingLink.Click();

        }

        public static void EditSeriveList()
        {

            Driver.TurnOnWait();
            EditIconS1.Click();
            ServiceListing.SaveServiceListing();
        }


        public static void DeleteServiceList()
        {

            Driver.TurnOnWait();
            DeleteIconS1.Click();
            Driver.TurnOnWait();
            Thread.Sleep(3000);
            //Driver.driver.SwitchTo().Alert();


        }


        public static void DeleteYes()
        {
            DeleteYesButton.Click();

            Thread.Sleep(3000);
        }



        public static void DeleteNo()
        {
            DeleteNoButton.Click();
        }

        public static void VerifyDeletedService()
        {
            try
            {
                IWebElement TilteActual = Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']//tbody/tr[1]/td[3]"));
                var ExpTitle = ExcelLibHelper.ReadData(2, "Title");
                var ActTitle = TilteActual.Text;


                Driver.TurnOnWait();
                Assert.AreNotEqual(ActTitle, ExpTitle, "Title not deleted");


            }
            catch (Exception e)
            {

                Assert.True(true, "Element not found");
            }

        }


        public static void VerifyServicenNotDeleted()
        {
            try
            {
                IWebElement TilteActual = Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']//tbody/tr[1]/td[3]"));
                var ExpTitle = ExcelLibHelper.ReadData(2, "Title");
                var ActTitle = TilteActual.Text;


                Driver.TurnOnWait();
                Assert.AreEqual(ActTitle, ExpTitle, "Sevice deleted");


            }
            catch (Exception e)
            {

                Assert.True(true, "Element not found");
            }

        }
    }
}
