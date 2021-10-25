﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocuSign.eSign.Model;
using DocuSign.eSign.Api;

namespace SdkNetCoreTests
{
    [TestClass]
    public class DiagnosticApiNetCoreUnitTests
    {
        private TestConfig _testConfig;

        [TestInitialize]
        public void TestInitialize()
        {
            _testConfig = new TestConfig();
            JwtLoginMethod.RequestJWTUserToken_CorrectInputParameters_ReturnsOAuthToken(ref _testConfig);
        }

        [TestMethod]
        public void GetSetting_ReturnDiagnosticsSettingsInformation()
        {
            DiagnosticsApi diagnosticsApi = new DiagnosticsApi(_testConfig.ApiClient);
            DiagnosticsSettingsInformation diagnosticsSettingsInformation = diagnosticsApi.GetRequestLogSettings();

            Assert.IsNotNull(diagnosticsSettingsInformation);
            Assert.IsNotNull(diagnosticsSettingsInformation.ApiRequestLogMaxEntries);
            Assert.IsNotNull(diagnosticsSettingsInformation.ApiRequestLogRemainingEntries);
            Assert.IsNotNull(diagnosticsSettingsInformation.ApiRequestLogging);
        }
    }
}
