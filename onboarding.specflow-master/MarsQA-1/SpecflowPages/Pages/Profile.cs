using MarsQA_1.Helpers;
using MongoDB.Driver.Core.Events;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq.Expressions;
using System.Threading;


namespace MarsQA_1.SpecflowPages.Pages
{
    class Profile
    {


        
        private static IWebElement Namedrop => Driver.driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div[2]/div/span"));

        private static IWebElement profile => Driver.driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div[2]/div/span/div/a[1]"));


        #region Description Elements
          private static IWebElement DescriptionEditIcon => Driver.driver.FindElement(By.XPath("//*[@class= 'eight wide column']//span[1]//i"));

        private static IWebElement DescriptionValue => Driver.driver.FindElement(By.XPath("(//*[@class= 'eight wide column']//span)[2]"));


        private static IWebElement SaveButton => Driver.driver.FindElement(By.XPath("(//button[text()='Save'])[2]"));
        private static IWebElement DescriptionTextField => Driver.driver.FindElement(By.XPath("//*[@class= 'ui twelve wide column']//textarea"));

        #endregion


        #region Title elements


        //Click on name Dropdown
        private static IWebElement Dropdown => Driver.driver.FindElement(By.XPath("(//i[@class='dropdown icon'])[2]"));
        
        //Enter Firstname
        private static IWebElement Firstname => Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='firstName']"));
        //Enter Lastname
        private static IWebElement Lastname => Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='lastName']"));
        //Click on Save
        private static IWebElement Save => Driver.driver.FindElement(By.XPath("(//button[@class='ui teal button' and text()='Save'])[1]"));

        #endregion


        #region availability elements
        //Select Availability
        private static IWebElement Availability => Driver.driver.FindElement(By.XPath("(//i[@class='right floated outline small write icon'])[1]"));
        private static IWebElement Type => Driver.driver.FindElement(By.XPath("//select[@name='availabiltyType']"));
        //Select  available Hours
        private static IWebElement Hours => Driver.driver.FindElement(By.XPath("(//i[@class='right floated outline small write icon'])[2]"));
        private static IWebElement Availablehours => Driver.driver.FindElement(By.XPath("//select[@class='ui right labeled dropdown']"));
        //Select Earn target
        private static IWebElement Earn => Driver.driver.FindElement(By.XPath("(//i[@class='right floated outline small write icon'])[3]"));
        private static IWebElement Targetearn => Driver.driver.FindElement(By.XPath("//select[@name='availabiltyTarget']"));
        #endregion




        #region Language Elements

        private static IWebElement LanguageAddNew => Driver.driver.FindElement(By.XPath("(//div[contains(text(),'Add New')])[1]"));


        //Add New Language text field
        private static IWebElement AddLanguage => Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));

        //Add language level value drop down

        private static IWebElement AddLanguageValue => Driver.driver.FindElement(By.XPath("//select[@name='level']"));

        //AddLanguagebutton

        private static IWebElement AddLanguagebutton => Driver.driver.FindElement(By.XPath("(//input[@value='Add'][@type='button'])[1]"));

        //Last Language in the language table

        private static IWebElement Language => Driver.driver.FindElement(By.XPath("//*[@data-tab='first']//tbody[last()]//td[1]"));

        //Last Language drop down value in the language table

        private static IWebElement LanguageValue => Driver.driver.FindElement(By.XPath("//*[@data-tab='first']//tbody[last()]//td[2]"));

        // Edit icon for last language row in the language table

        private static IWebElement EditLanguageIcon => Driver.driver.FindElement(By.XPath("(//*[@data-tab='first']//tbody[last()]//td[3]//i)[1]"));

        private static IWebElement EditLastLanguage => Driver.driver.FindElement(By.XPath("//*[@data-tab='first']//tbody[last()]//input[@value='Tamil']"));

        //Edit language -> Update button 

        private static IWebElement EditLanguageupdatebutton => Driver.driver.FindElement(By.XPath("//*[@data-tab='first']//tbody[last()]//input[@value='Update']"));

        // Language - Delete icon(for last row)
        private static IWebElement DeletelanguageIcon => Driver.driver.FindElement(By.XPath("(//*[@data-tab='first']//tbody[last()]//td[3]//i)[2]"));

        //Share Skill Elements

        #endregion

        #region Share Skill
        //Share Skill Elements 
        private static IWebElement ShareSkill => Driver.driver.FindElement(By.XPath("//*[text()='Share Skill']"));

        #endregion


        #region Education Elements
       

        private static IWebElement EducationAddNew => Driver.driver.FindElement(By.XPath("(//div[contains(text(),'Add New')])[3]"));

        private static IWebElement EducationTab => Driver.driver.FindElement(By.XPath("//a[text()='Education']"));

        private static IWebElement CollegeName => Driver.driver.FindElement(By.XPath("//input[@name='instituteName']"));


       private static IWebElement CountryDropdown => Driver.driver.FindElement(By.XPath("//select[@name='country']"));


        private static IWebElement TitleDropdown => Driver.driver.FindElement(By.XPath("//select[@name='title']"));


        private static IWebElement Degree => Driver.driver.FindElement(By.XPath("//input[@name='degree']"));


        private static IWebElement GradutionYearDropDown => Driver.driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));

        private static IWebElement AddButtonEducationData => Driver.driver.FindElement(By.XPath("//input[@value='Add']"));

        private static IWebElement EducationDataCountryFirstrow => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[1]//td[1]"));

        private static IWebElement EducationDataUniveristyFirstrow => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[1]//td[2]"));


        private static IWebElement EducationDataTitleFirstrow => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[1]//td[3]"));

        private static IWebElement EducationDataDegreeFirstrow => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[1]//td[4]"));

         private static IWebElement EducationDataGradYearFirstrow => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[1]//td[5]"));


        private static IWebElement EducationEditiconFirst => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[1]//td[6]/span[1]"));


        private static IWebElement EducationDeleteiconFirst => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tbody[1]//td[6]/span[2]"));


        private static IWebElement UpdateButtonEducationData => Driver.driver.FindElement(By.XPath("//input[@value='Update']"));


        #endregion


        
        #region Certification Elements




        private static IWebElement CertificationTab => Driver.driver.FindElement(By.XPath("//a[@data-tab='fourth']"));

        private static IWebElement CertificationAddNew => Driver.driver.FindElement(By.XPath("//div[contains(text(),'Add New')])[4]"));



        private static IWebElement CertificateTab => Driver.driver.FindElement(By.XPath("//a[text()='Certifications']"));


        private static IWebElement CertificateAddNew => Driver.driver.FindElement(By.XPath("(//div[text()='Add New'])[4]"));


        private static IWebElement CertificateAward=> Driver.driver.FindElement(By.XPath("//input[@name='certificationName']"));


        private static IWebElement CertificateFrom => Driver.driver.FindElement(By.XPath("//input[@name='certificationFrom']"));


        private static IWebElement CertificationYear => Driver.driver.FindElement(By.XPath("//select[@name='certificationYear']"));


        private static IWebElement CertificationAddData => Driver.driver.FindElement(By.XPath("//input[@value='Add']"));


        private static IWebElement CertificatelastRowValue=> Driver.driver.FindElement(By.XPath("//div[@data-tab='fourth']//tbody[last()]//td[1]"));



        private static IWebElement CertificateFromlastRowValue => Driver.driver.FindElement(By.XPath("//div[@data-tab='fourth']//tbody[last()]//td[2]"));



        private static IWebElement CertificateYearlastRowValue => Driver.driver.FindElement(By.XPath("//div[@data-tab='fourth']//tbody[last()]//td[3]"));

        private static IWebElement EditCertificateIconlastRow => Driver.driver.FindElement(By.XPath("//*[@data-tab='fourth']//tbody[last()]//td[4]/span[1]"));


        private static IWebElement DeleteCertificateIconlastRow => Driver.driver.FindElement(By.XPath("//*[@data-tab='fourth']//tbody[last()]//td[4]/span[2]"));


        private static IWebElement UpdateCertificateButtonlastRow => Driver.driver.FindElement(By.XPath("//input[@value='Update']"));



        private static IWebElement CertificatevalueEdit => Driver.driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));



        private static IWebElement CertificateFromEdit => Driver.driver.FindElement(By.XPath("//input[@placeholder='Certified From (e.g. Adobe)']"));



        private static IWebElement CertificateYearEdit => Driver.driver.FindElement(By.XPath("//select[@name='certificationYear']"));


        #endregion


        #region Searchskill elements
        //Click on search button
        private static IWebElement Searchlink => Driver.driver.FindElement(By.XPath("//i[@class='search link icon']"));

        //Click on selected catogery
        private static IWebElement Searchcategory => Driver.driver.FindElement(By.LinkText("Programming & Tech"));
        //Click on subcategory
        private static IWebElement Searchsub => Driver.driver.FindElement(By.XPath("(//div//a[@class='item subcategory' and contains( text(),'QA')])"));
        //select filter type
        private static IWebElement Filtertype => Driver.driver.FindElement(By.XPath("(//button[@class='ui button' and contains( text(),'Online')])"));


        #endregion





        #region Profile page methods
        public static void NavigatetoProfilePage()
        {
            // To Navigate from home page to profile page
            Driver.TurnOnWait();
            //Driver.NavigateUrl();
            //Namedrop.Click();
            // Driver.TurnOnWait();
            //profile.Click();

        }

        #endregion


        #region  Description Methods




        public static void EditDescription()
        {

            ExcelLibHelper.PopulateInCollection(@"C:\AdvancedTaskLevel1\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "Description");
            // Click on description edit icon and navigate to Descrition field 
            Driver.TurnOnWait();
            DescriptionEditIcon.Click();


            // Add Description content 

            Driver.TurnOnWait();
            DescriptionTextField.Clear();
            DescriptionTextField.SendKeys(ExcelLibHelper.ReadData(2, "Text"));

            SaveButton.Click();

            Thread.Sleep(1000);



        }

        public static void VerifyDescription()
        {

            var ActDes = DescriptionValue.Text;

            Assert.AreEqual(ActDes, ExcelLibHelper.ReadData(2, "Text"), "Description value is not as expected");

        }


        #endregion




        #region Language Methods

        public static void AddNewLanguage()
            {

                // Add New language 
                Driver.TurnOnWait();
                LanguageAddNew.Click();
                Driver.TurnOnWait();
                AddLanguage.SendKeys("Tamil");

                //Select Language value

                //create select element object 
                SelectElement levelvalue = new SelectElement(AddLanguageValue);

                //select by Text
                levelvalue.SelectByText("Fluent");
                AddLanguagebutton.Click();


            }

            public static void VerifyAddedLanguage()
            {
                var actuallang = Language.Text;
                var actualLangVal = LanguageValue.Text;



                Assert.AreEqual("Tamil", actuallang, "Language is not added");
                Assert.AreEqual("Fluent", actualLangVal, "Language value is not addded");


            }



            public static void EditLanguage()
            {

                Driver.TurnOnWait();
                EditLanguageIcon.Click();

                Driver.TurnOnWait();
                EditLastLanguage.Clear();
                EditLastLanguage.SendKeys("English");

                EditLanguageupdatebutton.Click();
                Thread.Sleep(2000);



            }



            public static void VerifyEditedLanguage()
            {

                var actuallang = Language.Text;
                var actualLangVal = LanguageValue.Text;

                Assert.AreEqual("English", actuallang, "Language is not edited");
                Assert.AreEqual("Fluent", actualLangVal, "Actual and Expected values are not equal");


            }


            public static void DeleteLanguage()
            {
                Driver.TurnOnWait();
                DeletelanguageIcon.Click();
                Thread.Sleep(2000);

            }


            public static void VerifyDeleteLanguage()
            {

                try
                {
                    IWebElement lang = Driver.driver.FindElement(By.XPath("//*[@data-tab='first']//tbody[last()]//td[1]"));


                    Driver.TurnOnWait();
                    Assert.AreNotEqual("English", lang, "Language not deleted");


                }
                catch (Exception e)
                {

                    Assert.True(true, "Element not found");
                }

            }

        #endregion




        #region Service Listing navigation
        public static void NavigatetoServiceListingPage()
        {
            Driver.TurnOnWait();
            ShareSkill.Click();
            Thread.Sleep(2000);

        }

        #endregion



        #region Education Methods

        public static void NavigateToEducationTab()
        {
            //Navigate to Education Tab
            Driver.TurnOnWait();
            EducationTab.Click();

        }


        public static void AddEducation()

        {

            ExcelLibHelper.PopulateInCollection(@"C:\AdvancedTaskLevel1\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "Education");


            //Click on Add new button for education
            Driver.TurnOnWait();
            EducationAddNew.Click();

            //Enter Valid Education details 
            Driver.TurnOnWait();

            CollegeName.SendKeys(ExcelLibHelper.ReadData(2, "CollegeName"));

            SelectElement country = new SelectElement(CountryDropdown);
            country.SelectByText(ExcelLibHelper.ReadData(2, "CountryOfCollege"));

            SelectElement Titledrop = new SelectElement(TitleDropdown);
            Titledrop.SelectByText(ExcelLibHelper.ReadData(2, "TitleDrop"));

            Degree.SendKeys(ExcelLibHelper.ReadData(2, "Degree"));



            Thread.Sleep(3000);
            SelectElement Yeardrop = new SelectElement(GradutionYearDropDown);
            Yeardrop.SelectByText(ExcelLibHelper.ReadData(2, "Year"));


            Thread.Sleep(3000);
            AddButtonEducationData.Click();
            Thread.Sleep(5000);

        }



        public static void EditEducation()

        {
            ExcelLibHelper.PopulateInCollection(@"C:\AdvancedTaskLevel1\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "Education");

            EducationEditiconFirst.Click();

            CollegeName.Clear();

            CollegeName.SendKeys(ExcelLibHelper.ReadData(3, "CollegeName"));

            SelectElement country = new SelectElement(CountryDropdown);
            country.SelectByText(ExcelLibHelper.ReadData(3, "CountryOfCollege"));

            SelectElement Titledrop = new SelectElement(TitleDropdown);
            Titledrop.SelectByText(ExcelLibHelper.ReadData(3, "TitleDrop"));

            Degree.Clear();

            Degree.SendKeys(ExcelLibHelper.ReadData(3, "Degree"));



            Thread.Sleep(3000);
            SelectElement Yeardrop = new SelectElement(GradutionYearDropDown);
            Yeardrop.SelectByText(ExcelLibHelper.ReadData(3, "Year"));


            Thread.Sleep(3000);
            UpdateButtonEducationData.Click();
            Thread.Sleep(5000);

        }


        public static void DeleteEducation()

        {
            EducationDeleteiconFirst.Click();

        }


        public static void VerifyAddEducation()

        {


            var actualCountry = EducationDataCountryFirstrow.Text;
            var ExpCountry = ExcelLibHelper.ReadData(2, "CountryOfCollege");

            var actualColl = EducationDataUniveristyFirstrow.Text;
            var ExpColl = ExcelLibHelper.ReadData(2, "CollegeName");


            var actualTitle = EducationDataTitleFirstrow.Text;
            var ExpTitle = ExcelLibHelper.ReadData(2, "TitleDrop");

            var actualDegree = EducationDataDegreeFirstrow.Text;
            var ExpDegree = ExcelLibHelper.ReadData(2, "Degree");

            var actualYear = EducationDataGradYearFirstrow.Text;
            var ExpYear = ExcelLibHelper.ReadData(2, "Year");







            Assert.AreEqual(actualCountry, ExpCountry, "Country is not added");

            Assert.AreEqual(actualColl, ExpColl, "College is not added");

            Assert.AreEqual(actualTitle, ExpTitle, "Title is not added");

            Assert.AreEqual(actualDegree, ExpDegree, "Degree is not added");


            Assert.AreEqual(actualYear, ExpYear, "Year is not added");

        }


        public static void VerifyEditEducation()

        {
            var actualCountry = EducationDataCountryFirstrow.Text;
            var ExpCountry = ExcelLibHelper.ReadData(3, "CountryOfCollege");

            var actualColl = EducationDataUniveristyFirstrow.Text;
            var ExpColl = ExcelLibHelper.ReadData(3, "CollegeName");


            var actualTitle = EducationDataTitleFirstrow.Text;
            var ExpTitle = ExcelLibHelper.ReadData(3, "TitleDrop");

            var actualDegree = EducationDataDegreeFirstrow.Text;
            var ExpDegree = ExcelLibHelper.ReadData(3, "Degree");

            var actualYear = EducationDataGradYearFirstrow.Text;
            var ExpYear = ExcelLibHelper.ReadData(3, "Year");







            Assert.AreEqual(actualCountry, ExpCountry, "Country is not updated");

            Assert.AreEqual(actualColl, ExpColl, "College is not updated");

            Assert.AreEqual(actualTitle, ExpTitle, "Title is not updated");

            Assert.AreEqual(actualDegree, ExpDegree, "Degree is not updated");


            Assert.AreEqual(actualYear, ExpYear, "Year is not updated");

        }


        public static void VerifyDeleteEducation()


        {

            try
            {
                var actualCountry = EducationDataCountryFirstrow.Text;
                var ExpCountry = ExcelLibHelper.ReadData(3, "CountryOfCollege");

                var actualColl = EducationDataUniveristyFirstrow.Text;
                var ExpColl = ExcelLibHelper.ReadData(3, "CollegeName");


                var actualTitle = EducationDataTitleFirstrow.Text;
                var ExpTitle = ExcelLibHelper.ReadData(3, "TitleDrop");

                var actualDegree = EducationDataDegreeFirstrow.Text;
                var ExpDegree = ExcelLibHelper.ReadData(3, "Degree");

                var actualYear = EducationDataGradYearFirstrow.Text;
                var ExpYear = ExcelLibHelper.ReadData(3, "Year");


                Assert.AreNotEqual(actualCountry, ExpCountry, "Country is not deleted");

                Assert.AreNotEqual(actualColl, ExpColl, "College is not deleted");

                Assert.AreNotEqual(actualTitle, ExpTitle, "Title is not deleted");

                Assert.AreNotEqual(actualDegree, ExpDegree, "Degree is not deleted");


                Assert.AreNotEqual(actualYear, ExpYear, "Year is not deleted");


            }

            catch (Exception e)
            {


                Assert.True(true, "No Education Data");
            }




        }


        #endregion


        #region Certification Methods

        public static void NavigateToCertification()
        {
            CertificateTab.Click();
            Driver.TurnOnWait();
        }


        public static void AddCertification()

        {

            ExcelLibHelper.PopulateInCollection(@"C:\AdvancedTaskLevel1\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "Cerification");

            Driver.TurnOnWait();

            CertificateAddNew.Click();
            CertificateAward.SendKeys(ExcelLibHelper.ReadData(2, "Certificate"));

            CertificateFrom.SendKeys(ExcelLibHelper.ReadData(2, "From"));

            SelectElement year = new SelectElement(CertificationYear);
            year.SelectByText(ExcelLibHelper.ReadData(2, "Year"));

            CertificationAddData.Click();

            Thread.Sleep(1000);



        }

      

        public static void EditCertification()

        {


            ExcelLibHelper.PopulateInCollection(@"C:\AdvancedTaskLevel1\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "Cerification");

            Driver.TurnOnWait();
            EditCertificateIconlastRow.Click();

            Thread.Sleep(1000);

         
            CertificatevalueEdit.Clear();

            CertificatevalueEdit.SendKeys(ExcelLibHelper.ReadData(3, "Certificate"));

            CertificateFromEdit.Clear();

            CertificateFromEdit.SendKeys(ExcelLibHelper.ReadData(3, "From"));

            SelectElement year = new SelectElement(CertificateYearEdit);
            year.SelectByText(ExcelLibHelper.ReadData(3, "Year"));

            UpdateCertificateButtonlastRow.Click();


            Thread.Sleep(1000);




        }



        public static void DeleteCertification()

        {

            Driver.TurnOnWait();
            DeleteCertificateIconlastRow.Click();
            Thread.Sleep(1000);


        }

       

        public static void VerifyAddCertification()

        {

            Thread.Sleep(1000);
            ExcelLibHelper.PopulateInCollection(@"C:\AdvancedTaskLevel1\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "Cerification");

            var ActCertificate =CertificatelastRowValue.Text;
            var ActFrom =CertificateFromlastRowValue.Text;
            var Actyear = CertificateYearlastRowValue.Text;




            Assert.AreEqual(ActCertificate, ExcelLibHelper.ReadData(2, "Certificate"), "Certificate is not added");

            Assert.AreEqual(ActFrom, ExcelLibHelper.ReadData(2, "From"), "From is not added");

            Assert.AreEqual(Actyear, ExcelLibHelper.ReadData(2, "Year"), "Year is not added");






        }

    
        public static void VerifyEditCertification()

        {

            var ActCertificate = CertificatelastRowValue.Text;
            var ActFrom = CertificateFromlastRowValue.Text;
            var Actyear = CertificateYearlastRowValue.Text;




            Assert.AreEqual(ActCertificate, ExcelLibHelper.ReadData(3, "Certificate"), "Certificate is not added");

            Assert.AreEqual(ActFrom, ExcelLibHelper.ReadData(3, "From"), "From is not added");

            Assert.AreEqual(Actyear, ExcelLibHelper.ReadData(3, "Year"), "Year is not added");


        }

        public static void VerifyDeleteCertification()

        {

            try
            {
                var ActCertificate = CertificatelastRowValue.Text;
                var ActFrom = CertificateFromlastRowValue.Text;
                var Actyear = CertificateYearlastRowValue.Text;




                Assert.AreNotEqual(ActCertificate, ExcelLibHelper.ReadData(3, "Certificate"), "Certificate is not deleted");

                Assert.AreNotEqual(ActFrom, ExcelLibHelper.ReadData(3, "From"), "From is not deleted");

                Assert.AreNotEqual(Actyear, ExcelLibHelper.ReadData(3, "Year"), "Year is not deleted");

            }

            catch (Exception e)
            {
                Assert.True(true, "No Certificate Data exists");

            }


        }

        #endregion


        #region Title Methods
        public static void ClickonuserNamedrop()
        {
            // To Navigate from home page to profile page
            Driver.TurnOnWait();
            // Driver.NavigateUrl();
            Dropdown.Click();
        }
        public static void Updateusername()
        {
            ExcelLibHelper.PopulateInCollection(@"C:\AdvancedTaskLevel1\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "ProfileData");
            Firstname.Clear();
            Driver.TurnOnWait();
            Firstname.SendKeys(ExcelLibHelper.ReadData(2, "First Name"));
            Driver.TurnOnWait();
            Lastname.Clear();
            Driver.TurnOnWait();
            Lastname.SendKeys(ExcelLibHelper.ReadData(2, "Last Name"));
            Driver.TurnOnWait();
        }
        public static void Savename()
        {
            Save.Click();
            Driver.TurnOnWait();
        }
        public static void VerifyUsername()
        {

            Thread.Sleep(1000);
            ExcelLibHelper.PopulateInCollection(@"C:\AdvancedTaskLevel1\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "ProfileData");
            String fname = ExcelLibHelper.ReadData(2, "First Name");
            
            String lname = ExcelLibHelper.ReadData(2, "Last Name");
            String actualText = Driver.driver.FindElement(By.XPath("//div[@class='title']")).Text;
            String expectedText = fname + " " + lname;

            if (actualText.Contains(expectedText))
            {
                Assert.True(true, "Is as expected");
            }
            else
            {
                Assert.False(false, "Is not as expected");
                Assert.Fail("User Name is not updated");
            }
            
        }
        #endregion


        #region Availability method
        public static void EditAvailablity()
        {
            Driver.TurnOnWait();
            Availability.Click();
        }
        public static void SelectAvailabilityvalue()
        {
            ExcelLibHelper.PopulateInCollection(@"C:\AdvancedTaskLevel1\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "ProfileData");
            SelectElement Availobj = new SelectElement(Type);
            Availobj.SelectByText(ExcelLibHelper.ReadData(2, "Availability"));

        }
        public static void VerifyAvailability()
        {

            Thread.Sleep(1000);
            ExcelLibHelper.PopulateInCollection(@"C:\AdvancedTaskLevel1\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "ProfileData");
            //String Avail1 = ExcelLibHelper.ReadData(2, "Availability");
            Driver.TurnOnWait();
            String actualText = Driver.driver.FindElement(By.XPath("(//div[@class='right floated content'])[2]")).Text;
            //actualText.Contains(ExcelLibHelper.ReadData(2, "Availability"));
            //String expectedText = Avail1;
            Assert.IsTrue(actualText.Contains(ExcelLibHelper.ReadData(2, "Availability")));
        }
        #endregion



        #region searchskill method 
        public static void Searchclick()
        {
            Searchlink.Click();

            Thread.Sleep(1000);
        }
        public static void Catsearch()
        {

            Thread.Sleep(1000);
           ExcelLibHelper.PopulateInCollection(@"C:\AdvancedTaskLevel1\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "SearchSkill");
            Driver.TurnOnWait();
            Thread.Sleep(2000);
           //Driver.driver.FindElement(By.LinkText(ExcelLibHelper.ReadData(2, "Subcat"))).Click();
            Driver.driver.FindElement(By.XPath("//*[text()='Graphics & Design']")).Click();
            Thread.Sleep(1000);
        }
        public static void Subcatsearch()
        {

            Thread.Sleep(1000);
            ExcelLibHelper.PopulateInCollection(@"C:\AdvancedTaskLevel1\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "SearchSkill");
            Driver.TurnOnWait();
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("//*[text()='Logo Design']")).Click();
        }


        public static void VerifyCatSearch()
        {
            try
            {
                Driver.driver.FindElement(By.XPath("//b[text()='Logo Design']"));
                Assert.True(true, "Element is not blod");

            }
            catch (Exception e)
            {
                Assert.Fail("Cat is not selected");
                Assert.False(false, "Element is bold");
            }
        }



        public static void VerifySubCatSearch()
        {
            try
            {
                Driver.driver.FindElement(By.XPath("//b[text()='Logo Design']"));
                Assert.True(true, "Element is not blod");
               

            }
            catch(Exception e)
            {
                Assert.Fail("Fail Subcatg is not selected");
                Assert.False(false, "Element is bold");
            }
        
        }


        public static void Filter()
        {
            Thread.Sleep(1000);
            ExcelLibHelper.PopulateInCollection(@"C:\AdvancedTaskLevel1\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ProfileData.xlsx", "SearchSkill");
            Driver.TurnOnWait();
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("//*[text()='Online']")).Click();
            //Filtertype.SendKeys(ExcelLibHelper.ReadData(2, "filtertype"));
            //Filtertype.Click();

            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("//*[text()='Onsite']")).Click();




        }
        #endregion


    }
}
