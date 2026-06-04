using Reqnroll;
using System;
using System.Collections.Generic;
using System.Text;

namespace Partices.Reqnroll.StepDefination
{
    [Binding]
    public class basicstepdeficnation
    {
        [Given("I login to vanquis app")]
        public void GivenILoginToVanquisApp()
        {
            throw new PendingStepException();
        }

        [Given("I provide the username {string} and password {string}")]
        public void GivenIProvideTheUsernameAndPassword(string p0, string password)
        {
            throw new PendingStepException();
        }

        [When("I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            throw new PendingStepException();
        }

        [Then("I redirect to Home page")]
        public void ThenIRedirectToHomePage()
        {
            throw new PendingStepException();
        }
        [Given("I redirect to Login Url")]
        public void GivenIRedirectToLoginUrl()
        {
            throw new PendingStepException();
        }

        [When("I enter username and password")]
        public void WhenIEnterUsernameAndPassword(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<users>();
        }

    }
    public class users
    {
        public string username {  get; set; }
        public string password { get; set; }
    }
}
