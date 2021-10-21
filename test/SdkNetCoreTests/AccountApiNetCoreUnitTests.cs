﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocuSign.eSign.Model;
using DocuSign.eSign.Client;
using DocuSign.eSign.Api;
using System.IO;
using System.Collections.Generic;
using DocuSign.eSign.Client.Auth;
using SdkTests;

namespace SdkNetCoreTests
{
    [TestClass]
    public class AccountApiNetCoreUnitTests
    {
        TestConfig testConfig = new TestConfig();

        [TestInitialize()]
        [TestMethod]
        public void JwtLoginTest()
        {
            testConfig.ApiClient = new ApiClient(testConfig.Host);

            byte[] privateKeyStream = testConfig.PrivateKey;

            List<string> scopes = new List<string>();
            scopes.Add(OAuth.Scope_SIGNATURE);
            scopes.Add(OAuth.Scope_IMPERSONATION);

            OAuth.OAuthToken tokenInfo = testConfig.ApiClient.RequestJWTUserToken(testConfig.IntegratorKey, testConfig.UserId, testConfig.OAuthBasePath, privateKeyStream, testConfig.ExpiresInHours, scopes);
            // Disposing the stream...

            // the authentication api uses the apiClient (and X-DocuSign-Authentication header) that are set in Configuration object
            OAuth.UserInfo userInfo = testConfig.ApiClient.GetUserInfo(tokenInfo.access_token);

            Assert.IsNotNull(userInfo);
            Assert.IsNotNull(userInfo.Accounts);

            foreach (var item in userInfo.Accounts)
            {
                if (item.IsDefault == "true")
                {
                    testConfig.AccountId = item.AccountId;
                    testConfig.ApiClient.SetBasePath(item.BaseUri + "/restapi");
                    break;
                }
            }

            Assert.IsNotNull(testConfig.AccountId);
            JwtRequestSignatureOnDocumentTest();
        }

        private void JwtRequestSignatureOnDocumentTest(string status = "sent")
        {
            // the document (file) we want signed
            const string SignTest1File = @"../../../docs/SignTest1.pdf";

            // Read a file from disk to use as a document.
            byte[] fileBytes = File.ReadAllBytes(SignTest1File);

            EnvelopeDefinition envDef = new EnvelopeDefinition();
            envDef.EmailSubject = "[DocuSign C# SDK] - Please sign this doc";

            // Add a document to the envelope
            Document doc = new Document();
            doc.DocumentBase64 = System.Convert.ToBase64String(fileBytes);
            doc.Name = "TestFile.pdf";
            doc.DocumentId = "1";

            envDef.Documents = new List<Document>();
            envDef.Documents.Add(doc);

            // Add a recipient to sign the documeent
            Signer signer = new Signer();
            signer.Email = testConfig.RecipientEmail;
            signer.Name = testConfig.RecipientName;
            signer.RecipientId = "1";
            signer.ClientUserId = "1234";

            // Create a |SignHere| tab somewhere on the document for the recipient to sign
            signer.Tabs = new Tabs();
            signer.Tabs.SignHereTabs = new List<SignHere>();
            SignHere signHere = new SignHere();
            signHere.DocumentId = "1";
            signHere.PageNumber = "1";
            signHere.RecipientId = "1";
            signHere.XPosition = "100";
            signHere.YPosition = "100";
            signHere.ScaleValue = ".5";
            signer.Tabs.SignHereTabs.Add(signHere);

            envDef.Recipients = new Recipients();
            envDef.Recipients.Signers = new List<Signer>();
            envDef.Recipients.Signers.Add(signer);


            TemplateTabs templateTabs = new TemplateTabs();
            templateTabs.DateTabs = new List<Date>();

            Tabs tabs = new Tabs();
            tabs.DateTabs = new List<Date>();

            SignerAttachment signerAttachment = new SignerAttachment();
            signerAttachment.ScaleValue = "";

            // set envelope status to "sent" to immediately send the signature request
            envDef.Status = status;

            // |EnvelopesApi| contains methods related to creating and sending Envelopes (aka signature requests)
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient);
            EnvelopeSummary envelopeSummary = envelopesApi.CreateEnvelope(testConfig.AccountId, envDef);

            Assert.IsNotNull(envelopeSummary);
            Assert.IsNotNull(envelopeSummary.EnvelopeId);

            testConfig.EnvelopeId = envelopeSummary.EnvelopeId;
        }

        [TestMethod]
        public void JwtListBrandTest()
        {
            AccountsApi accApi = new AccountsApi(testConfig.ApiClient);
            var brandsResponse = accApi.ListBrands(testConfig.AccountId);

            Assert.IsNotNull(brandsResponse);
        }

        [TestMethod]
        public void JwtUploadBrandLogoTest()
        {
            AccountsApi accApi = new AccountsApi(testConfig.ApiClient);

            if (string.IsNullOrEmpty(testConfig.BrandId))
            {
                CreateBrandTest();
            }

            try
            {
                byte[] brandLogoByteArray = Convert.FromBase64String(testConfig.BrandLogo);
                accApi.UpdateBrandLogoByType(testConfig.AccountId, testConfig.BrandId, "primary", brandLogoByteArray);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void JwtGetBrandLogoByBrandIdTest()
        {
            AccountsApi accApi = new AccountsApi(testConfig.ApiClient);
            if (string.IsNullOrEmpty(testConfig.BrandId))
            {
                CreateBrandTest();
            }

            byte[] brandLogoByteArray = Convert.FromBase64String(testConfig.BrandLogo);

            //Check if C# png just got uploaded
            Stream stream = accApi.GetBrandLogoByType(testConfig.AccountId, testConfig.BrandId, "primary");

            Assert.IsNotNull(stream);

            using (MemoryStream ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                byte[] brandLogofromApi = ms.ToArray();
                Assert.AreEqual(Convert.ToBase64String(brandLogoByteArray), Convert.ToBase64String(brandLogofromApi));
            }
        }

        private void CreateBrandTest()
        {
            AccountsApi accApi = new AccountsApi(testConfig.ApiClient);
            Brand brand = new Brand
            {
                BrandName = "C# Brand"
            };

            var brands = accApi.CreateBrand(testConfig.AccountId, brand);

            foreach (var brnds in brands.Brands)
            {
                if (brnds.BrandName == brand.BrandName)
                {
                    testConfig.BrandId = brnds.BrandId;
                }
            }
        }

        [TestMethod]
        public void JwtGetAccountInformation_CorrectAccountId_ReturnAccountInformation()
        {
            AccountsApi accountsApi = new AccountsApi(testConfig.ApiClient);
            AccountInformation accountInformation = accountsApi.GetAccountInformation(testConfig.AccountId);
            
            Assert.IsNotNull(accountInformation);
            Assert.IsNotNull(accountInformation.AccountIdGuid);
            Assert.IsNotNull(accountInformation.AccountName);
            Assert.IsNotNull(accountInformation.BillingProfile);
        }
    }
}
