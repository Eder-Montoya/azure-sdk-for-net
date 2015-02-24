// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Hyak.Common;
using Microsoft.WindowsAzure.Management.SiteRecovery;
using Microsoft.WindowsAzure.Management.SiteRecovery.Models;

namespace Microsoft.WindowsAzure.Management.SiteRecovery
{
    /// <summary>
    /// Definition of Protection Container operations for the Site Recovery
    /// extension.
    /// </summary>
    internal partial class ProtectionContainerOperations : IServiceOperations<SiteRecoveryManagementClient>, IProtectionContainerOperations
    {
        /// <summary>
        /// Initializes a new instance of the ProtectionContainerOperations
        /// class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal ProtectionContainerOperations(SiteRecoveryManagementClient client)
        {
            this._client = client;
        }
        
        private SiteRecoveryManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.WindowsAzure.Management.SiteRecovery.SiteRecoveryManagementClient.
        /// </summary>
        public SiteRecoveryManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Get the protected container by Id.
        /// </summary>
        /// <param name='protectionContainerId'>
        /// Required. Protection Container ID.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the Protection Container object.
        /// </returns>
        public async Task<ProtectionContainerResponse> GetAsync(string protectionContainerId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken)
        {
            // Validate
            if (protectionContainerId == null)
            {
                throw new ArgumentNullException("protectionContainerId");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("protectionContainerId", protectionContainerId);
                tracingParameters.Add("customRequestHeaders", customRequestHeaders);
                TracingAdapter.Enter(invocationId, this, "GetAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/cloudservices/";
            url = url + Uri.EscapeDataString(this.Client.CloudServiceName);
            url = url + "/resources/";
            url = url + "WAHyperVRecoveryManager";
            url = url + "/~/";
            url = url + "HyperVRecoveryManagerVault";
            url = url + "/";
            url = url + Uri.EscapeDataString(this.Client.ResourceName);
            url = url + "/ProtectionContainers/";
            url = url + Uri.EscapeDataString(protectionContainerId);
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2015-02-10");
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept", "application/xml");
                httpRequest.Headers.Add("x-ms-client-request-id", customRequestHeaders.ClientRequestId);
                httpRequest.Headers.Add("x-ms-version", "2013-03-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    ProtectionContainerResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new ProtectionContainerResponse();
                        XDocument responseDoc = XDocument.Parse(responseContent);
                        
                        XElement protectionContainerElement = responseDoc.Element(XName.Get("ProtectionContainer", "http://schemas.microsoft.com/windowsazure"));
                        if (protectionContainerElement != null)
                        {
                            ProtectionContainer protectionContainerInstance = new ProtectionContainer();
                            result.ProtectionContainer = protectionContainerInstance;
                            
                            XElement serverIdElement = protectionContainerElement.Element(XName.Get("ServerId", "http://schemas.microsoft.com/windowsazure"));
                            if (serverIdElement != null)
                            {
                                string serverIdInstance = serverIdElement.Value;
                                protectionContainerInstance.ServerId = serverIdInstance;
                            }
                            
                            XElement fabricObjectIdElement = protectionContainerElement.Element(XName.Get("FabricObjectId", "http://schemas.microsoft.com/windowsazure"));
                            if (fabricObjectIdElement != null)
                            {
                                string fabricObjectIdInstance = fabricObjectIdElement.Value;
                                protectionContainerInstance.FabricObjectId = fabricObjectIdInstance;
                            }
                            
                            XElement roleElement = protectionContainerElement.Element(XName.Get("Role", "http://schemas.microsoft.com/windowsazure"));
                            if (roleElement != null)
                            {
                                string roleInstance = roleElement.Value;
                                protectionContainerInstance.Role = roleInstance;
                            }
                            
                            XElement fabricTypeElement = protectionContainerElement.Element(XName.Get("FabricType", "http://schemas.microsoft.com/windowsazure"));
                            if (fabricTypeElement != null)
                            {
                                string fabricTypeInstance = fabricTypeElement.Value;
                                protectionContainerInstance.FabricType = fabricTypeInstance;
                            }
                            
                            XElement typeElement = protectionContainerElement.Element(XName.Get("Type", "http://schemas.microsoft.com/windowsazure"));
                            if (typeElement != null)
                            {
                                string typeInstance = typeElement.Value;
                                protectionContainerInstance.Type = typeInstance;
                            }
                            
                            XElement availableProtectionProfilesSequenceElement = protectionContainerElement.Element(XName.Get("AvailableProtectionProfiles", "http://schemas.microsoft.com/windowsazure"));
                            if (availableProtectionProfilesSequenceElement != null)
                            {
                                foreach (XElement availableProtectionProfilesElement in availableProtectionProfilesSequenceElement.Elements(XName.Get("ProtectionProfile", "http://schemas.microsoft.com/windowsazure")))
                                {
                                    ProtectionProfile protectionProfileInstance = new ProtectionProfile();
                                    protectionContainerInstance.AvailableProtectionProfiles.Add(protectionProfileInstance);
                                    
                                    XElement protectedEntityCountElement = availableProtectionProfilesElement.Element(XName.Get("ProtectedEntityCount", "http://schemas.microsoft.com/windowsazure"));
                                    if (protectedEntityCountElement != null)
                                    {
                                        int protectedEntityCountInstance = int.Parse(protectedEntityCountElement.Value, CultureInfo.InvariantCulture);
                                        protectionProfileInstance.ProtectedEntityCount = protectedEntityCountInstance;
                                    }
                                    
                                    XElement replicationProviderElement = availableProtectionProfilesElement.Element(XName.Get("ReplicationProvider", "http://schemas.microsoft.com/windowsazure"));
                                    if (replicationProviderElement != null)
                                    {
                                        string replicationProviderInstance = replicationProviderElement.Value;
                                        protectionProfileInstance.ReplicationProvider = replicationProviderInstance;
                                    }
                                    
                                    XElement replicationProviderSettingElement = availableProtectionProfilesElement.Element(XName.Get("ReplicationProviderSetting", "http://schemas.microsoft.com/windowsazure"));
                                    if (replicationProviderSettingElement != null)
                                    {
                                        string replicationProviderSettingInstance = replicationProviderSettingElement.Value;
                                        protectionProfileInstance.ReplicationProviderSetting = replicationProviderSettingInstance;
                                    }
                                    
                                    XElement canDissociateElement = availableProtectionProfilesElement.Element(XName.Get("CanDissociate", "http://schemas.microsoft.com/windowsazure"));
                                    if (canDissociateElement != null)
                                    {
                                        bool canDissociateInstance = bool.Parse(canDissociateElement.Value);
                                        protectionProfileInstance.CanDissociate = canDissociateInstance;
                                    }
                                    
                                    XElement associationDetailSequenceElement = availableProtectionProfilesElement.Element(XName.Get("AssociationDetail", "http://schemas.microsoft.com/windowsazure"));
                                    if (associationDetailSequenceElement != null)
                                    {
                                        foreach (XElement associationDetailElement in associationDetailSequenceElement.Elements(XName.Get("ProtectionProfileAssociationDetails", "http://schemas.microsoft.com/windowsazure")))
                                        {
                                            ProtectionProfileAssociationDetails protectionProfileAssociationDetailsInstance = new ProtectionProfileAssociationDetails();
                                            protectionProfileInstance.AssociationDetail.Add(protectionProfileAssociationDetailsInstance);
                                            
                                            XElement primaryProtectionContainerIdElement = associationDetailElement.Element(XName.Get("PrimaryProtectionContainerId", "http://schemas.microsoft.com/windowsazure"));
                                            if (primaryProtectionContainerIdElement != null)
                                            {
                                                string primaryProtectionContainerIdInstance = primaryProtectionContainerIdElement.Value;
                                                protectionProfileAssociationDetailsInstance.PrimaryProtectionContainerId = primaryProtectionContainerIdInstance;
                                            }
                                            
                                            XElement recoveryProtectionContainerIdElement = associationDetailElement.Element(XName.Get("RecoveryProtectionContainerId", "http://schemas.microsoft.com/windowsazure"));
                                            if (recoveryProtectionContainerIdElement != null)
                                            {
                                                string recoveryProtectionContainerIdInstance = recoveryProtectionContainerIdElement.Value;
                                                protectionProfileAssociationDetailsInstance.RecoveryProtectionContainerId = recoveryProtectionContainerIdInstance;
                                            }
                                            
                                            XElement associationStatusElement = associationDetailElement.Element(XName.Get("AssociationStatus", "http://schemas.microsoft.com/windowsazure"));
                                            if (associationStatusElement != null)
                                            {
                                                string associationStatusInstance = associationStatusElement.Value;
                                                protectionProfileAssociationDetailsInstance.AssociationStatus = associationStatusInstance;
                                            }
                                        }
                                    }
                                    
                                    XElement nameElement = availableProtectionProfilesElement.Element(XName.Get("Name", "http://schemas.microsoft.com/windowsazure"));
                                    if (nameElement != null)
                                    {
                                        string nameInstance = nameElement.Value;
                                        protectionProfileInstance.Name = nameInstance;
                                    }
                                    
                                    XElement idElement = availableProtectionProfilesElement.Element(XName.Get("ID", "http://schemas.microsoft.com/windowsazure"));
                                    if (idElement != null)
                                    {
                                        string idInstance = idElement.Value;
                                        protectionProfileInstance.ID = idInstance;
                                    }
                                }
                            }
                            
                            XElement nameElement2 = protectionContainerElement.Element(XName.Get("Name", "http://schemas.microsoft.com/windowsazure"));
                            if (nameElement2 != null)
                            {
                                string nameInstance2 = nameElement2.Value;
                                protectionContainerInstance.Name = nameInstance2;
                            }
                            
                            XElement idElement2 = protectionContainerElement.Element(XName.Get("ID", "http://schemas.microsoft.com/windowsazure"));
                            if (idElement2 != null)
                            {
                                string idInstance2 = idElement2.Value;
                                protectionContainerInstance.ID = idInstance2;
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Get the list of all ProtectionContainers for the given server.
        /// </summary>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list ProtectionContainers operation.
        /// </returns>
        public async Task<ProtectionContainerListResponse> ListAsync(CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken)
        {
            // Validate
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("customRequestHeaders", customRequestHeaders);
                TracingAdapter.Enter(invocationId, this, "ListAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/cloudservices/";
            url = url + Uri.EscapeDataString(this.Client.CloudServiceName);
            url = url + "/resources/";
            url = url + "WAHyperVRecoveryManager";
            url = url + "/~/";
            url = url + "HyperVRecoveryManagerVault";
            url = url + "/";
            url = url + Uri.EscapeDataString(this.Client.ResourceName);
            url = url + "/ProtectionContainers";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2015-02-10");
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept", "application/xml");
                httpRequest.Headers.Add("x-ms-client-request-id", customRequestHeaders.ClientRequestId);
                httpRequest.Headers.Add("x-ms-version", "2013-03-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    ProtectionContainerListResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new ProtectionContainerListResponse();
                        XDocument responseDoc = XDocument.Parse(responseContent);
                        
                        XElement arrayOfProtectionContainerSequenceElement = responseDoc.Element(XName.Get("ArrayOfProtectionContainer", "http://schemas.microsoft.com/windowsazure"));
                        if (arrayOfProtectionContainerSequenceElement != null)
                        {
                            foreach (XElement arrayOfProtectionContainerElement in arrayOfProtectionContainerSequenceElement.Elements(XName.Get("ProtectionContainer", "http://schemas.microsoft.com/windowsazure")))
                            {
                                ProtectionContainer protectionContainerInstance = new ProtectionContainer();
                                result.ProtectionContainers.Add(protectionContainerInstance);
                                
                                XElement serverIdElement = arrayOfProtectionContainerElement.Element(XName.Get("ServerId", "http://schemas.microsoft.com/windowsazure"));
                                if (serverIdElement != null)
                                {
                                    string serverIdInstance = serverIdElement.Value;
                                    protectionContainerInstance.ServerId = serverIdInstance;
                                }
                                
                                XElement fabricObjectIdElement = arrayOfProtectionContainerElement.Element(XName.Get("FabricObjectId", "http://schemas.microsoft.com/windowsazure"));
                                if (fabricObjectIdElement != null)
                                {
                                    string fabricObjectIdInstance = fabricObjectIdElement.Value;
                                    protectionContainerInstance.FabricObjectId = fabricObjectIdInstance;
                                }
                                
                                XElement roleElement = arrayOfProtectionContainerElement.Element(XName.Get("Role", "http://schemas.microsoft.com/windowsazure"));
                                if (roleElement != null)
                                {
                                    string roleInstance = roleElement.Value;
                                    protectionContainerInstance.Role = roleInstance;
                                }
                                
                                XElement fabricTypeElement = arrayOfProtectionContainerElement.Element(XName.Get("FabricType", "http://schemas.microsoft.com/windowsazure"));
                                if (fabricTypeElement != null)
                                {
                                    string fabricTypeInstance = fabricTypeElement.Value;
                                    protectionContainerInstance.FabricType = fabricTypeInstance;
                                }
                                
                                XElement typeElement = arrayOfProtectionContainerElement.Element(XName.Get("Type", "http://schemas.microsoft.com/windowsazure"));
                                if (typeElement != null)
                                {
                                    string typeInstance = typeElement.Value;
                                    protectionContainerInstance.Type = typeInstance;
                                }
                                
                                XElement availableProtectionProfilesSequenceElement = arrayOfProtectionContainerElement.Element(XName.Get("AvailableProtectionProfiles", "http://schemas.microsoft.com/windowsazure"));
                                if (availableProtectionProfilesSequenceElement != null)
                                {
                                    foreach (XElement availableProtectionProfilesElement in availableProtectionProfilesSequenceElement.Elements(XName.Get("ProtectionProfile", "http://schemas.microsoft.com/windowsazure")))
                                    {
                                        ProtectionProfile protectionProfileInstance = new ProtectionProfile();
                                        protectionContainerInstance.AvailableProtectionProfiles.Add(protectionProfileInstance);
                                        
                                        XElement protectedEntityCountElement = availableProtectionProfilesElement.Element(XName.Get("ProtectedEntityCount", "http://schemas.microsoft.com/windowsazure"));
                                        if (protectedEntityCountElement != null)
                                        {
                                            int protectedEntityCountInstance = int.Parse(protectedEntityCountElement.Value, CultureInfo.InvariantCulture);
                                            protectionProfileInstance.ProtectedEntityCount = protectedEntityCountInstance;
                                        }
                                        
                                        XElement replicationProviderElement = availableProtectionProfilesElement.Element(XName.Get("ReplicationProvider", "http://schemas.microsoft.com/windowsazure"));
                                        if (replicationProviderElement != null)
                                        {
                                            string replicationProviderInstance = replicationProviderElement.Value;
                                            protectionProfileInstance.ReplicationProvider = replicationProviderInstance;
                                        }
                                        
                                        XElement replicationProviderSettingElement = availableProtectionProfilesElement.Element(XName.Get("ReplicationProviderSetting", "http://schemas.microsoft.com/windowsazure"));
                                        if (replicationProviderSettingElement != null)
                                        {
                                            string replicationProviderSettingInstance = replicationProviderSettingElement.Value;
                                            protectionProfileInstance.ReplicationProviderSetting = replicationProviderSettingInstance;
                                        }
                                        
                                        XElement canDissociateElement = availableProtectionProfilesElement.Element(XName.Get("CanDissociate", "http://schemas.microsoft.com/windowsazure"));
                                        if (canDissociateElement != null)
                                        {
                                            bool canDissociateInstance = bool.Parse(canDissociateElement.Value);
                                            protectionProfileInstance.CanDissociate = canDissociateInstance;
                                        }
                                        
                                        XElement associationDetailSequenceElement = availableProtectionProfilesElement.Element(XName.Get("AssociationDetail", "http://schemas.microsoft.com/windowsazure"));
                                        if (associationDetailSequenceElement != null)
                                        {
                                            foreach (XElement associationDetailElement in associationDetailSequenceElement.Elements(XName.Get("ProtectionProfileAssociationDetails", "http://schemas.microsoft.com/windowsazure")))
                                            {
                                                ProtectionProfileAssociationDetails protectionProfileAssociationDetailsInstance = new ProtectionProfileAssociationDetails();
                                                protectionProfileInstance.AssociationDetail.Add(protectionProfileAssociationDetailsInstance);
                                                
                                                XElement primaryProtectionContainerIdElement = associationDetailElement.Element(XName.Get("PrimaryProtectionContainerId", "http://schemas.microsoft.com/windowsazure"));
                                                if (primaryProtectionContainerIdElement != null)
                                                {
                                                    string primaryProtectionContainerIdInstance = primaryProtectionContainerIdElement.Value;
                                                    protectionProfileAssociationDetailsInstance.PrimaryProtectionContainerId = primaryProtectionContainerIdInstance;
                                                }
                                                
                                                XElement recoveryProtectionContainerIdElement = associationDetailElement.Element(XName.Get("RecoveryProtectionContainerId", "http://schemas.microsoft.com/windowsazure"));
                                                if (recoveryProtectionContainerIdElement != null)
                                                {
                                                    string recoveryProtectionContainerIdInstance = recoveryProtectionContainerIdElement.Value;
                                                    protectionProfileAssociationDetailsInstance.RecoveryProtectionContainerId = recoveryProtectionContainerIdInstance;
                                                }
                                                
                                                XElement associationStatusElement = associationDetailElement.Element(XName.Get("AssociationStatus", "http://schemas.microsoft.com/windowsazure"));
                                                if (associationStatusElement != null)
                                                {
                                                    string associationStatusInstance = associationStatusElement.Value;
                                                    protectionProfileAssociationDetailsInstance.AssociationStatus = associationStatusInstance;
                                                }
                                            }
                                        }
                                        
                                        XElement nameElement = availableProtectionProfilesElement.Element(XName.Get("Name", "http://schemas.microsoft.com/windowsazure"));
                                        if (nameElement != null)
                                        {
                                            string nameInstance = nameElement.Value;
                                            protectionProfileInstance.Name = nameInstance;
                                        }
                                        
                                        XElement idElement = availableProtectionProfilesElement.Element(XName.Get("ID", "http://schemas.microsoft.com/windowsazure"));
                                        if (idElement != null)
                                        {
                                            string idInstance = idElement.Value;
                                            protectionProfileInstance.ID = idInstance;
                                        }
                                    }
                                }
                                
                                XElement nameElement2 = arrayOfProtectionContainerElement.Element(XName.Get("Name", "http://schemas.microsoft.com/windowsazure"));
                                if (nameElement2 != null)
                                {
                                    string nameInstance2 = nameElement2.Value;
                                    protectionContainerInstance.Name = nameInstance2;
                                }
                                
                                XElement idElement2 = arrayOfProtectionContainerElement.Element(XName.Get("ID", "http://schemas.microsoft.com/windowsazure"));
                                if (idElement2 != null)
                                {
                                    string idInstance2 = idElement2.Value;
                                    protectionContainerInstance.ID = idInstance2;
                                }
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
