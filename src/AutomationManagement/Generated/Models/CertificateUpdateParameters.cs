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
using Microsoft.WindowsAzure.Management.Automation.Models;

namespace Microsoft.WindowsAzure.Management.Automation.Models
{
    /// <summary>
    /// The parameters supplied to the update certificate operation.
    /// </summary>
    public partial class CertificateUpdateParameters
    {
        private string _name;
        
        /// <summary>
        /// Required. Gets or sets the name of the certificate.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private CertificateUpdateProperties _properties;
        
        /// <summary>
        /// Optional. Gets or sets the properties of the certificate.
        /// </summary>
        public CertificateUpdateProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the CertificateUpdateParameters class.
        /// </summary>
        public CertificateUpdateParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the CertificateUpdateParameters class
        /// with required arguments.
        /// </summary>
        public CertificateUpdateParameters(string name)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            this.Name = name;
        }
    }
}
