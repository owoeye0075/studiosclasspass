using StudoClasspath.PageObject;
using System;
using TechTalk.SpecFlow;

namespace StudoClasspath.StepDefinitions
{
    [Binding]
    public class StudoClasspathSteps
    {
        StudiosClasspath studiosClasspath;

        public StudoClasspathSteps()
        {
            studiosClasspath = new StudiosClasspath();
        }
        [Given(@"the user navigate to ""(.*)""")]
        public void GivenTheUserNavigateTo(string url)
        {
            studiosClasspath.NavigateUrl(url);
        }

        
        [Given(@"the user enter the first name ""(.*)""")]
        public void GivenTheUserEnterTheFirstName(string fname)
        {
            studiosClasspath.setFirstName(fname);
        }
        
        [Given(@"the user enter the last name ""(.*)""")]
        public void GivenTheUserEnterTheLastName(string lname)
        {
            studiosClasspath.SetLastName(lname);
        }
        
        [Given(@"the user eneter email address ""(.*)""")]
        public void GivenTheUserEneterEmailAddress(string eAddress)
        {
            studiosClasspath.EnterEmail(eAddress);
        }
        
        [Given(@"the user enter website ""(.*)""")]
        public void GivenTheUserEnterWebsite(string webA)
        {
            studiosClasspath.EnterWeb(webA);
        }
        
        [Given(@"the user click Sign Up for Free")]
        public void GivenTheUserClickSignUpForFree()
        {
            studiosClasspath.ClickSignUp();
        }

        [Given(@"the user select country")]
        public void GivenTheUserSelectCountry()
        {
            studiosClasspath.SelectMobileCountry();
        }

        [Given(@"the user enter phone number ""(.*)""")]
        public void GivenTheUserEnterPhoneNumber(String mobileNo)
        {
            studiosClasspath.EnterNumb(mobileNo);
        }
        
        [Given(@"Click next button")]
        public void GivenClickNextButton()
        {
            studiosClasspath.ClicknexButton();
        }
        
        [Given(@"the user click individual")]
        public void GivenTheUserClickIndividual()
        {
            studiosClasspath.EnterPersonBusiness();
        }
        
        [Given(@"the user click next")]
        public void GivenTheUserClickNext()
        {
            studiosClasspath.ClickBusinessnextButton();
        }
        
        [Given(@"the user enter partner name ""(.*)""")]
        public void GivenTheUserEnterPartnerName(string ppname)
        {
            studiosClasspath.EnterPartnerProfileName(ppname);
        }
        
        [Given(@"the user enter the city and Country of operation ""(.*)""")]
        public void GivenTheUserEnterTheCityAndCountryOfOperation(string stname)
        {
            studiosClasspath.EnterCityofCompany(stname);
        }
        
        [Given(@"the user click the Business Next button")]
        public void GivenTheUserClickTheBusinessNextButton()
        {
            studiosClasspath.ClickNextbutton();
        }
        
        [Given(@"the user select the type of services off")]
        public void GivenTheUserSelectTheTypeOfServicesOff()
        {
            studiosClasspath.EnterServiceProvided();
        }
        
        [Given(@"the user click the services Next button")]
        public void GivenTheUserClickTheServicesNextButton()
        {
            studiosClasspath.ClickserviceNextButton();
        }
        
        [Given(@"the user should confirm Yes or No for who has legal entity")]
        public void GivenTheUserShouldConfirmYesOrNoForWhoHasLegalEntity()
        {
            studiosClasspath.ClicktermAgree();
        }
        
        [Given(@"the user enter the legal entity name ""(.*)""")]
        public void GivenTheUserEnterTheLegalEntityName(string eName)
        {
            studiosClasspath.EnterentityName(eName);
        }
        
        [Given(@"the user should tick the agreement box")]
        public void GivenTheUserShouldTickTheAgreementBox()
        {
            studiosClasspath.AgreeClick();
        }
        
        [When(@"the user click the Agree button")]
        public void WhenTheUserClickTheAgreeButton()
        {
            studiosClasspath.ClickagreeButton();
        }
        
        [Then(@"the user should be successfully registered")]
        public void ThenTheUserShouldBeSuccessfullyRegistered()
        {
            studiosClasspath.Confirmdisplay();
        }
    }
}
