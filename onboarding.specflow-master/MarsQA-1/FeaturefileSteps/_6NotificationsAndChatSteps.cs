using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    public class _6NotificationsAndChatSteps
    {
        [Given(@"User is in Profile or Home page")]
        public void GivenUserIsInProfileOrHomePage()
        {
            
        }
        
        [When(@"User navigates to notifications")]
        public void WhenUserNavigatesToNotifications()
        {
            Home.Notifications();
        }
        
        [When(@"User navigates to Chat page")]
        public void WhenUserNavigatesToChatPage()
        {
            Home.ChatMethod();
        }
        
        [Then(@"Verify for Notifications")]
        public void ThenVerifyForNotifications()
        {
            Home.VerifyNotifications();
        }
        
        [Then(@"Verify for Chats")]
        public void ThenVerifyForChats()
        {
            Home.VerifyChatPage();
        }
    }
}
