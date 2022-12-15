﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using JPetStoreWebImplementation;
using System.Security.Policy;

namespace JPetStoreTestCases
{
    [TestClass]
    public class UnitTests
    {
        private BaseClass _page;

        [TestInitialize]
        public void TestInitialize()
        {
            _page = new BaseClass();
        }

        [TestMethod]
        public void EndToEndTC()
        {
            HomePage homePageVar = _page.LaunchBrowser("chrome");
            SignInPage signInPageVar = homePageVar.NavigateToSignInPage();
            UserRegistrationPage userRegistrationPageVar = signInPageVar.NavigateToUserRegistration();
            userRegistrationPageVar.EnterUserData();
            homePageVar.NavigateToSignInPage();
            signInPageVar.EnterUserCred();
        }

        [TestMethod]
        public void SampleTestCase()
        {
            HomePage homePageVar = _page.LaunchBrowser("chrome");
            SignInPage signInPageVar = homePageVar.NavigateToSignInPage();
            signInPageVar.EnterUserCred(); 
        }

        [TestCleanup] public void TestCleanup() 
        {
            // _page.CloseBrowser();
        }
    }
}
