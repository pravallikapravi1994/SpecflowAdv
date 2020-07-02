using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    public class _4ShareSkillSteps
    {
        [Given(@"User clicks navigates Service Listing page")]
        public void GivenUserClicksNavigatesServiceListingPage()
        {
            Profile.NavigatetoServiceListingPage();
        }
        
        [Given(@"Add Service listing data")]
        public void GivenAddServiceListingData()
        {
            ServiceListing.SaveServiceListing();
        }
        
        [Given(@"User navigates to Manage Listing page")]
        public void GivenUserNavigatesToManageListingPage()
        {
            ManageListing.NavigatetoManagelisting();
            
        }
        
        [Given(@"Clicks on Edit icon and edits data")]
        public void GivenClicksOnEditIconAndEditsData()
        {
            ManageListing.EditSeriveList();
        }
        
        [Given(@"Clicks on Delete icon")]
        public void GivenClicksOnDeleteIcon()
        {
            ManageListing.DeleteServiceList();
        }
        
        [When(@"User press Save button")]
        public void WhenUserPressSaveButton()
        {
            
        }
        
        [When(@"Press save button")]
        public void WhenPressSaveButton()
        {
            
        }
        
        [When(@"User press Ok button")]
        public void WhenUserPressOkButton()
        {
            ManageListing.DeleteYes();
        }
        
        [Then(@"Skill should be added in Manage listing page")]
        public void ThenSkillShouldBeAddedInManageListingPage()
        {
            Driver.TurnOnWait();
            ManageListing.VerifySavedSeriveList();
        }
        
        [Then(@"Skill should be updated in Manage listing page")]
        public void ThenSkillShouldBeUpdatedInManageListingPage()
        {
           
        }
        
        [Then(@"Skill should be deleted in Manage listing page")]
        public void ThenSkillShouldBeDeletedInManageListingPage()
        {
            ManageListing.VerifyDeletedService();
        }
    }
}
