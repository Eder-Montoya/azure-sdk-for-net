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
using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.Automation.Models;

namespace Microsoft.WindowsAzure.Management.Automation
{
    /// <summary>
    /// Service operation for automation variables.  (see
    /// http://aka.ms/azureautomationsdk/variableoperations for more
    /// information)
    /// </summary>
    public partial interface IVariableOperations
    {
        /// <summary>
        /// Create a variable.  (see
        /// http://aka.ms/azureautomationsdk/variableoperations for more
        /// information)
        /// </summary>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// The parameters supplied to the create variable operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the create variable operation.
        /// </returns>
        Task<VariableCreateResponse> CreateAsync(string automationAccount, VariableCreateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Delete the variable.  (see
        /// http://aka.ms/azureautomationsdk/variableoperations for more
        /// information)
        /// </summary>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='variableName'>
        /// The name of variable.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteAsync(string automationAccount, string variableName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieve the variable identified by variable name.  (see
        /// http://aka.ms/azureautomationsdk/variableoperations for more
        /// information)
        /// </summary>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='variableName'>
        /// The name of variable.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the get variable operation.
        /// </returns>
        Task<VariableGetResponse> GetAsync(string automationAccount, string variableName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieve a list of variables.  (see
        /// http://aka.ms/azureautomationsdk/variableoperations for more
        /// information)
        /// </summary>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list variables operation.
        /// </returns>
        Task<VariableListResponse> ListAsync(string automationAccount, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieve next list of variables.  (see
        /// http://aka.ms/azureautomationsdk/variableoperations for more
        /// information)
        /// </summary>
        /// <param name='nextLink'>
        /// The link to retrieve next set of items.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list variables operation.
        /// </returns>
        Task<VariableListResponse> ListNextAsync(string nextLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Update a variable.  (see
        /// http://aka.ms/azureautomationsdk/variableoperations for more
        /// information)
        /// </summary>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// The parameters supplied to the update variable operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> UpdateAsync(string automationAccount, VariableUpdateParameters parameters, CancellationToken cancellationToken);
    }
}
