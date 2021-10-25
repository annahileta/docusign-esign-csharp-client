﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using DocuSign.eSign.Model;
using DocuSign.eSign.Api;
using System.Linq;

namespace SdkTests
{
    [TestClass]
    public class TemplatesApiUnitTests
    {
        private TestConfig _testConfig;
        private TemplatesApi _templatesApi;

        [TestInitialize]
        public void TestInitialize()
        {
            _testConfig = new TestConfig();
            JwtLoginMethod.RequestJWTUserToken_CorrectInputParameters_ReturnsOAuthToken(ref _testConfig);
            _templatesApi = new TemplatesApi(_testConfig.ApiClient);
        }

        [TestMethod]
        public void JwtGetTemplates_CorrectAccountId_ReturnEnvelopeTemplateResults()
        {
            EnvelopeTemplateResults envelopeTemplateResults = _templatesApi.ListTemplates(_testConfig.AccountId);

            Assert.IsNotNull(envelopeTemplateResults.EnvelopeTemplates.FirstOrDefault()?.TemplateId);
        }

        [TestMethod]
        public void JwtGetTemplate_CorrectAccountIdAndTemplateId_ReturnEnvelopeTemplate()
        {
            EnvelopeTemplateResults envelopeTemplateResults = _templatesApi.ListTemplates(_testConfig.AccountId);
            string templateId = envelopeTemplateResults.EnvelopeTemplates.FirstOrDefault()?.TemplateId;

            Assert.IsNotNull(envelopeTemplateResults);
            Assert.IsNotNull(envelopeTemplateResults.EnvelopeTemplates);
            Assert.IsNotNull(templateId);

            EnvelopeTemplate envelopeTemplate = _templatesApi.Get(_testConfig.AccountId, templateId);

            Assert.IsNotNull(envelopeTemplate);
            Assert.AreEqual(envelopeTemplate.TemplateId, templateId);
        }
    }
}
