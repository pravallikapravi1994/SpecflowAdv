using System;
using TechTalk.SpecFlow;
using MarsQA_1.Utils;
using MarsQA_1.SpecflowPages.Pages;
using MarsQA_1.Helpers;
using System.Threading;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;

namespace MarsQA_1
{
    [Binding]
    public class _3ProfileSteps
    {

/// <summary>
/// Education Steps 
/// </summary>


        [Given(@"User Navigates to Education Tab")]
        public void GivenUserNavigatesToEducationTab()
        {
            

            //SCenario

            //steps



            Profile.NavigateToEducationTab();
            
        }
        
        [When(@"User adds Educations")]
        public void WhenUserAddsEducations()
        {
            Profile.AddEducation();
           
        }
        
        [Then(@"Verify if Education is added")]
        public void ThenVerifyIfEducationIsAdded()
        {
            Profile.VerifyAddEducation();
        }

        [When(@"User edits Educations")]
        public void WhenUserEditsEducations()
        {
            Profile.EditEducation();
        }

        [Then(@"Verify if Education is Edited")]
        public void ThenVerifyIfEducationIsEdited()
        {
            Profile.VerifyEditEducation();
        }


        [When(@"User Deletes Education")]
        public void WhenUserDeletesEducation()
        {
            Profile.DeleteEducation();
        }

        [Then(@"Verify if Education is Deleted")]
        public void ThenVerifyIfEducationIsDeleted()
        {
            Profile.VerifyDeleteEducation();
        }



/// <summary>
/// Certification Steps
/// </summary>

        [Given(@"User Navigates to Certificate Tab")]
        public void GivenUserNavigatesToCertificateTab()
        {
            Profile.NavigateToCertification();
            Driver.TurnOnWait();
        }

        [When(@"User adds Certificate")]
        public void WhenUserAddsCertificate()
        {
            Profile.AddCertification();
            Driver.TurnOnWait();
        }

        [Then(@"Verify if Certificate is added")]
        public void ThenVerifyIfCertificateIsAdded()
        {
            Profile.VerifyAddCertification();
        }

        [When(@"User edits Certificate")]
        public void WhenUserEditsCertificate()
        {
            Profile.EditCertification();
            Driver.TurnOnWait();
        }

        [Then(@"Verify if Certificate is Edited")]
        public void ThenVerifyIfCertificateIsEdited()
        {
            Driver.TurnOnWait();
            Profile.VerifyEditCertification();

        }

        [When(@"User Deletes Certificate")]
        public void WhenUserDeletesCertificate()
        {
            Profile.DeleteCertification();
        }

        [Then(@"Verify if Certificate is Deleted")]
        public void ThenVerifyIfCertificateIsDeleted()
        {
            Driver.TurnOnWait();
            Profile.VerifyDeleteCertification();
        }


 /// <summary>
        /// Description Steps 
        /// </summary>


        [Given(@"User is in Profile page")]
        public void GivenUserIsInProfilePage()
        {
            
        }

        [When(@"Users updates description")]
        public void WhenUsersUpdatesDescription()
        {
            
            Profile.EditDescription();
            
        }

        [Then(@"Verify if Description is updated")]
        public void ThenVerifyIfDescriptionIsUpdated()
        {
            Profile.VerifyDescription();

        }






        #region Username steps
        [Given(@"user clicks on username expand button and modifies username")]
        public void GivenUserClicksOnUsernameExpandButtonAndModifiesUsername()
        {

            Profile.ClickonuserNamedrop();
            Driver.TurnOnWait();
            Profile.Updateusername();
        }

        [When(@"user clicks on Save button")]
        public void WhenUserClicksOnSaveButton()
        {
            Profile.Savename();
        }

        [Then(@"Username should be updated")]
        public void ThenUsernameShouldBeUpdated()
        {
            Profile.VerifyUsername();
        }

        #endregion



        #region Availability steps

        [Given(@"user clicks edit icon of Availability")]
        public void GivenUserClicksEditIconOfAvailability()
        {
            Profile.EditAvailablity();
            Driver.TurnOnWait();
           
        }

        [When(@"user edits Availability")]
        public void WhenUserEditsAvailability()
        {
            Profile.SelectAvailabilityvalue();
            Driver.TurnOnWait();
        }

        [Then(@"Availability should be updated")]
        public void ThenAvailabilityShouldBeUpdated()
        {
            Profile.VerifyAvailability();
        }

        #endregion



        #region Search and Filter skill

        [Given(@"user performs search for Category and SubCategory")]
        public void GivenUserPerformsSearchForCategoryAndSubCategory()
        {

            Driver.TurnOnWait();
            Profile.Searchclick();
            Driver.TurnOnWait();

            Profile.Catsearch();
            Driver.TurnOnWait();

            Profile.Subcatsearch();
            Driver.TurnOnWait();
        }

        [When(@"User Filters search results")]
        public void WhenUserFiltersSearchResults()
        {
            Profile.Filter();
            Driver.TurnOnWait();
        }

        [Then(@"Verify result for Search")]
        public void ThenVerifyResultForSearch()
        {

            Profile.VerifyCatSearch();
            Driver.TurnOnWait();

            Profile.VerifySubCatSearch();
            Driver.TurnOnWait();
        }

        #endregion
    }
}
