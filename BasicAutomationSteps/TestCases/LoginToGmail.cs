﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using NUnit.Framework;
using AutomationLibrary;

namespace BasicAutomationSteps.TestCases
{
    [TestFixture]
    class LoginToGmail:BaseWebTest
    {
        [TestCase(TestName = "logintoGmail")]
        [Category("Regression")]
        public void LoginTo()
        {
            driver.Navigate().GoToUrl("http://www.gmail.com");

            if(driver.FindElement(By.Id
                ("identifierId")).Displayed)
            {
                Console.WriteLine("test passed");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            

            


        }
    }
}
