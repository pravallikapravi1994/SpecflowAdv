using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    public class _5ManageRequestsSteps
    {

        [Given(@"User Navigates to ManageListing page")]
        public void GivenUserNavigatesToManageListingPage()
        {
            ManageRequest.NavigateToManageRequest();
            Driver.TurnOnWait();
        }
        
        [When(@"User is in SentRequests")]
        public void WhenUserIsInSentRequests()
        {
            ManageRequest.NavigateToSentRequest();
        }
        
        [When(@"User is in Received Request")]
        public void WhenUserIsInReceivedRequest()
        {
            ManageRequest.NavigateToReceivedRequest();
        }
        
        [Then(@"verify SentRequestContent")]
        public void ThenVerifySentRequestContent()
        {
            ManageRequest.verifySentRequestcontent();
        }
        
        [Then(@"verify ReceivedRequest Content")]
        public void ThenVerifyReceivedRequestContent()
        {
            ManageRequest.verifyRecievedRequestcontent();
        }




    }
}
