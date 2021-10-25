﻿using System;
using System.Collections.Generic;
using System.IO;
using DocuSign.eSign.Api;
using DocuSign.eSign.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SdkTests462
{
    class CreateEnvelopeMethod
    {
        public static void CreateEnvelope_CorrectAccountIdAndEnvelopeDefinition_ReturnEnvelopeSummary(ref TestConfig testConfig, string status = "sent")
        {
            const string signTest1File = @"../../docs/SignTest1.pdf";

            byte[] fileBytes = File.ReadAllBytes(signTest1File);

            EnvelopeDefinition envDef = new EnvelopeDefinition
            {
                EmailSubject = "[DocuSign C# SDK] - Please sign this doc"
            };

            Document doc = new Document
            {
                DocumentBase64 = Convert.ToBase64String(fileBytes),
                Name = "TestFile.pdf",
                DocumentId = "1"
            };

            envDef.Documents = new List<Document> { doc };

            Signer signer = new Signer
            {
                Email = testConfig.RecipientEmail,
                Name = testConfig.RecipientName,
                RecipientId = "1",
                ClientUserId = "1234",
                Tabs = new Tabs
                {
                    SignHereTabs = new List<SignHere>()
                }
            };

            SignHere signHere = new SignHere
            {
                DocumentId = "1",
                PageNumber = "1",
                RecipientId = "1",
                XPosition = "100",
                YPosition = "100",
                ScaleValue = ".5"
            };
            signer.Tabs.SignHereTabs.Add(signHere);

            envDef.Recipients = new Recipients
            {
                Signers = new List<Signer> { signer }
            };

            envDef.Status = status;

            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient);
            EnvelopeSummary envelopeSummary = envelopesApi.CreateEnvelope(testConfig.AccountId, envDef);

            Assert.IsNotNull(envelopeSummary?.EnvelopeId);

            testConfig.EnvelopeId = envelopeSummary.EnvelopeId;
        }
    }
}
