/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace DocuSign.eSign.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOrganizationsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieves org level report by correlation id and site.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId"></param>/// <param name="reportCorrelationId"></param>
        
        
        /// <returns></returns>
        void GetReportV2 (string organizationId, string reportCorrelationId);

        /// <summary>
        /// Retrieves org level report by correlation id and site.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId"></param>/// <param name="reportCorrelationId"></param>
        
        
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetReportV2WithHttpInfo (string organizationId, string reportCorrelationId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Retrieves org level report by correlation id and site.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId"></param>/// <param name="reportCorrelationId"></param>
        
        
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetReportV2Async (string organizationId, string reportCorrelationId);

        /// <summary>
        /// Retrieves org level report by correlation id and site.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId"></param>/// <param name="reportCorrelationId"></param>
        
        
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetReportV2AsyncWithHttpInfo (string organizationId, string reportCorrelationId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OrganizationsApi : IOrganizationsApi
    {
        private DocuSign.eSign.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationsApi"/> class
        /// using AplClient object
        /// </summary>
        /// <param name="aplClient">An instance of AplClient</param>
        /// <returns></returns>
        public OrganizationsApi(ApiClient aplClient)
        {
            this.ApiClient = aplClient;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Gets or sets the ApiClient object
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public DocuSign.eSign.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }



        /// <summary>
        /// Retrieves org level report by correlation id and site. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId"></param>/// <param name="reportCorrelationId"></param>
        
        
        /// <returns></returns>
        public void GetReportV2 (string organizationId, string reportCorrelationId)
        {
             GetReportV2WithHttpInfo(organizationId, reportCorrelationId);
        }

        /// <summary>
        /// Retrieves org level report by correlation id and site. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId"></param>/// <param name="reportCorrelationId"></param>
        
        
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetReportV2WithHttpInfo (string organizationId, string reportCorrelationId)
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null)
                throw new ApiException(400, "Missing required parameter 'organizationId' when calling OrganizationsApi->GetReportV2");
            // verify the required parameter 'reportCorrelationId' is set
            if (reportCorrelationId == null)
                throw new ApiException(400, "Missing required parameter 'reportCorrelationId' when calling OrganizationsApi->GetReportV2");

            var localVarPath = "/v2.1/organization_reporting/{organizationId}/reportsv2/{reportCorrelationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(this.ApiClient.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (organizationId != null) localVarPathParams.Add("organizationId", this.ApiClient.ParameterToString(organizationId)); // path parameter
            if (reportCorrelationId != null) localVarPathParams.Add("reportCorrelationId", this.ApiClient.ParameterToString(reportCorrelationId)); // path parameter



            // authentication (docusignAccessCode) required
            // oauth required
            if (!String.IsNullOrEmpty(this.ApiClient.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.ApiClient.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetReportV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Retrieves org level report by correlation id and site. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId"></param>/// <param name="reportCorrelationId"></param>
        
        
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetReportV2Async (string organizationId, string reportCorrelationId)
        {
             await GetReportV2AsyncWithHttpInfo(organizationId, reportCorrelationId);

        }

        /// <summary>
        /// Retrieves org level report by correlation id and site. 
        /// </summary>
        /// <exception cref="DocuSign.eSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId"></param>/// <param name="reportCorrelationId"></param>
        
        
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetReportV2AsyncWithHttpInfo (string organizationId, string reportCorrelationId)
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null)
                throw new ApiException(400, "Missing required parameter 'organizationId' when calling OrganizationsApi->GetReportV2");
            // verify the required parameter 'reportCorrelationId' is set
            if (reportCorrelationId == null)
                throw new ApiException(400, "Missing required parameter 'reportCorrelationId' when calling OrganizationsApi->GetReportV2");

            var localVarPath = "/v2.1/organization_reporting/{organizationId}/reportsv2/{reportCorrelationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(this.ApiClient.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (organizationId != null) localVarPathParams.Add("organizationId", this.ApiClient.ParameterToString(organizationId)); // path parameter
            if (reportCorrelationId != null) localVarPathParams.Add("reportCorrelationId", this.ApiClient.ParameterToString(reportCorrelationId)); // path parameter



            // authentication (docusignAccessCode) required
            // oauth required
            if (!String.IsNullOrEmpty(this.ApiClient.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.ApiClient.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetReportV2", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}