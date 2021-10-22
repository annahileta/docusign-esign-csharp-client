﻿using System.Collections.Generic;
using System.Linq;
using DocuSign.eSign.Api;
using DocuSign.eSign.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace SdkTests462
{
    [TestClass]
    public class UsersApiUnitTests
    {
        private TestConfig _testConfig;

        [ClassInitialize]
        public void ClassInitialize()
        {
            _testConfig = new TestConfig();
            JwtLoginMethod.RequestJWTUserToken_CorrectInputParameters_ReturnsOAuthToken(ref _testConfig);
        }

        [TestMethod]
        public void JwtGetUsers_CorrectAccountId_ReturnUserInformationList()
        {
            UsersApi usersApi = new UsersApi(_testConfig.ApiClient);
            UserInformationList userInformationList = usersApi.List(_testConfig.AccountId);
            
            Assert.IsNotNull(userInformationList);
            Assert.IsNotNull(userInformationList.Users);
            Assert.IsNotNull(userInformationList.Users.FirstOrDefault()?.UserId);
        }

        [TestMethod]
        public void JwtPostUsers_CorrectAccountIdAndNewUsersDefinition_ReturnNewUsersSummary()
        {
            UsersApi usersApi = new UsersApi(_testConfig.ApiClient);

            UserInformation user = new UserInformation
            {
                Email = "test@test.com",
                UserName = "Test User"
            };
            List<UserInformation> userInformation = new List<UserInformation> { user };
            NewUsersDefinition usersDefinition = new NewUsersDefinition
            {
                NewUsers = userInformation
            };

            NewUsersSummary userInformationList = usersApi.Create(_testConfig.AccountId, usersDefinition);
            
            Assert.IsNotNull(userInformationList);
            Assert.IsNotNull(userInformationList.NewUsers);
            Assert.IsNotNull(userInformationList.NewUsers.Exists(x => x.Email == user.Email && x.UserName == user.UserName));
        }
    }
}
