using NUnit.Framework;
using OpenQA.Selenium;
using StudoClasspath.StepDefinitions;
using StudoClasspath.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace StudoClasspath.PageObject
{
    class StudiosClasspath
    {
        public StudiosClasspath()
        {
            driver = Hooks1.driver;
        }
        IWebDriver driver;

        IWebElement firstName => driver.FindElement(By.Name("name.firstName"));

        IWebElement lastname => driver.FindElement(By.Name("name.lastName"));

        IWebElement emailAdd => driver.FindElement(By.Name("email"));

        IWebElement websitelink => driver.FindElement(By.Name("website"));

        IWebElement SignUpButton => driver.FindElement(By.XPath("//button[@class='button contact-module__button bt bt--tertiary']"));


        IWebElement pickCountry => driver.FindElement(By.XPath("//option[contains(text(),'United Kingdom')]"));

        IWebElement phoneNumber => driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/main[1]/div[1]/div[1]/div[1]/div[1]/form[1]/div[1]/div[1]/input[1]"));

        IWebElement nexButton => driver.FindElement(By.XPath("//button[@class='button phone-module__button bt bt--tertiary']"));

        IWebElement PersonOrBusiness => driver.FindElement(By.XPath("//span[contains(text(),'Individual')]"));

        IWebElement BusinessEntitynextButton => driver.FindElement(By.XPath("//button[@class='button business-entity-module__button bt bt--tertiary']"));

        IWebElement PartnerProfileName => driver.FindElement(By.XPath("//input[@id='city-based-address-company']"));

        IWebElement CityofCompany => driver.FindElement(By.Id("city-based-address-location"));

        IWebElement CityNextButton => driver.FindElement(By.XPath("//button[@class='button address-module__button bt bt--tertiary']"));

        IWebElement serviceProvided => driver.FindElement(By.XPath("//body/div[@id='root']/main[@class='app app--no-side-nav']/div[@class='column-layout']/div[@class='column-layout__container column-layout__container--visible-column-0 column-layout__container--public']/div[@class='column-layout__column column-layout__column--active']/div[@class='path-to-partnership']/form[@class='business-category-module']/ul[@class='business-category-module__business-category-list']/li[2]/button[1]/div[1]"));

        IWebElement serviceNextButton => driver.FindElement(By.XPath("//button[@class='button business-category-module__button bt bt--tertiary']"));

        IWebElement termAgree => driver.FindElement(By.XPath("//div[@class='accept-terms-module__options']//button[1]//*[local-name()='svg']"));
        IWebElement agreeClick => driver.FindElement(By.Id("agreesToTermsAndConditions"));

        IWebElement entityName => driver.FindElement(By.Id("legalEntity"));

        IWebElement agreeButton => driver.FindElement(By.XPath("//button[@class='button accept-terms-module__button bt bt--tertiary']"));

        IWebElement homeAssert => driver.FindElement(By.XPath("//h2[@class='app__title']"));





        public void NavigateUrl(String url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void setFirstName(String fname)
        {
            firstName.SendKeys(fname);
        }


        public void SetLastName(String lname)
        {
            lastname.SendKeys(lname);
        }

        public void EnterEmail(String eAddress)
        {
            emailAdd.SendKeys(eAddress);
        }

        public void EnterWeb(String webA)
        {
            websitelink.SendKeys(webA);
        }

        public void ClickSignUp()
        {
            SignUpButton.Click();
            Thread.Sleep(3000);
        }

        
        public void SelectMobileCountry()
        {
            pickCountry.Click();
        }

        public void EnterNumb(String mobileNo)
        {
            phoneNumber.SendKeys(mobileNo);
        }
        
        public void ClicknexButton()
        {
            nexButton.Click();

            Thread.Sleep(3000);

        }

        public void EnterPersonBusiness()

        {
            PersonOrBusiness.Click();
        }

        public void ClickBusinessnextButton()
        {
            BusinessEntitynextButton.Click();
            Thread.Sleep(3000);
        }

        public void EnterPartnerProfileName(String ppname)
        {
            PartnerProfileName.SendKeys(ppname);
        }

        public void EnterCityofCompany(String stname)
        {
            CityofCompany.SendKeys(stname);

            Thread.Sleep(2000);
            
            CityofCompany.SendKeys(Keys.ArrowDown);

           Thread.Sleep(2000);
           CityofCompany.SendKeys(Keys.Enter);
        }

        public void ClickNextbutton()
        {
            CityNextButton.Click();
            Thread.Sleep(3000);
        }


        public void EnterServiceProvided()
        {
            serviceProvided.Click();
        }


        public void ClickserviceNextButton()
        {
            serviceNextButton.Click();
            Thread.Sleep(3000);
        }

        public void ClicktermAgree()
        {
            termAgree.Click();
        }

        public void EnterentityName(String eName)
        {
            entityName.SendKeys(eName);
        }


        public void AgreeClick()
        {
            agreeClick.Click();
        }
        public void ClickagreeButton()
        {
            agreeButton.Click();
        }

       public void Confirmdisplay()
        {
            Assert.That(homeAssert.Displayed);


        }


    }
}
