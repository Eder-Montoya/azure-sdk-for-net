// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The shared keys for a workspace.
    /// </summary>
    public partial class SharedKeys
    {
        /// <summary>
        /// Initializes a new instance of the SharedKeys class.
        /// </summary>
        public SharedKeys()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SharedKeys class.
        /// </summary>
        /// <param name="primarySharedKey">The primary shared key of a
        /// workspace.</param>
        /// <param name="secondarySharedKey">The secondary shared key of a
        /// workspace.</param>
        public SharedKeys(string primarySharedKey = default(string), string secondarySharedKey = default(string))
        {
            PrimarySharedKey = primarySharedKey;
            SecondarySharedKey = secondarySharedKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the primary shared key of a workspace.
        /// </summary>
        [JsonProperty(PropertyName = "primarySharedKey")]
        public string PrimarySharedKey { get; set; }

        /// <summary>
        /// Gets or sets the secondary shared key of a workspace.
        /// </summary>
        [JsonProperty(PropertyName = "secondarySharedKey")]
        public string SecondarySharedKey { get; set; }

    }
}
