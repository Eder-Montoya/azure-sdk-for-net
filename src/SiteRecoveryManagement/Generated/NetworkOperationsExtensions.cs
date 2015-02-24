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
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Management.SiteRecovery;
using Microsoft.WindowsAzure.Management.SiteRecovery.Models;

namespace Microsoft.WindowsAzure.Management.SiteRecovery
{
    public static partial class NetworkOperationsExtensions
    {
        /// <summary>
        /// Get the list of all networks under the vault.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.SiteRecovery.INetworkOperations.
        /// </param>
        /// <param name='serverId'>
        /// Required. Network query parameter.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the list networks operation.
        /// </returns>
        public static NetworkListResponse List(this INetworkOperations operations, string serverId, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((INetworkOperations)s).ListAsync(serverId, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the list of all networks under the vault.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.SiteRecovery.INetworkOperations.
        /// </param>
        /// <param name='serverId'>
        /// Required. Network query parameter.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the list networks operation.
        /// </returns>
        public static Task<NetworkListResponse> ListAsync(this INetworkOperations operations, string serverId, CustomRequestHeaders customRequestHeaders)
        {
            return operations.ListAsync(serverId, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the list of all Azure VM networks under the vault.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.SiteRecovery.INetworkOperations.
        /// </param>
        /// <param name='subscriptionId'>
        /// Optional.
        /// </param>
        /// <returns>
        /// The response structure for the Network Operations List operation.
        /// </returns>
        public static AzureNetworkListResponse ListAzureNetworks(this INetworkOperations operations, string subscriptionId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((INetworkOperations)s).ListAzureNetworksAsync(subscriptionId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the list of all Azure VM networks under the vault.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.SiteRecovery.INetworkOperations.
        /// </param>
        /// <param name='subscriptionId'>
        /// Optional.
        /// </param>
        /// <returns>
        /// The response structure for the Network Operations List operation.
        /// </returns>
        public static Task<AzureNetworkListResponse> ListAzureNetworksAsync(this INetworkOperations operations, string subscriptionId)
        {
            return operations.ListAzureNetworksAsync(subscriptionId, CancellationToken.None);
        }
    }
}
