using OpenQA.Selenium;
using Specflow_Automation.Hooks;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class Employee_ContactStepDefinitions

    { 
        [When(@"I click on My Info")]
        public void WhenIClickOnMyInfo()
        {
            AutomationHooks.driver.FindElement(By.XPath("//span[text()='My Info']")).Click();

        }

        [When(@"I click on Emergency Contacts")]
        public void WhenIClickOnEmergencyContacts()
        {
            
        }

        [When(@"I click on Add")]
        public void WhenIClickOnAdd()
        {
          
        }

        [When(@"I click on emergency contact")]
        public void WhenIClickOnEmergencyContact(Table table)
        {
           
        }

        [When(@"I click on save")]
        public void WhenIClickOnSave()
        {
           
        }

        [Then(@"I should navigate to emergency conact details")]
        public void ThenIShouldNavigateToEmergencyConactDetails()
        {
            
        }
    }
}
