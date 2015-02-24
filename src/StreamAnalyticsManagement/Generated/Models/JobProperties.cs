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
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.StreamAnalytics.Models;

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    /// <summary>
    /// The properties of the stream analytics job.
    /// </summary>
    public partial class JobProperties
    {
        private System.DateTime? _createdDate;
        
        /// <summary>
        /// Optional. Gets the created date of the stream analytics job.
        /// </summary>
        public System.DateTime? CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }
        
        private string _etag;
        
        /// <summary>
        /// Optional. Gets the etag of the stream analytics job.
        /// </summary>
        public string Etag
        {
            get { return this._etag; }
            set { this._etag = value; }
        }
        
        private int? _eventsOutOfOrderMaxDelayInSeconds;
        
        /// <summary>
        /// Optional. Gets or sets the max delay time of the out of order
        /// policy of the stream analytics job. It is in Milliseconds
        /// </summary>
        public int? EventsOutOfOrderMaxDelayInSeconds
        {
            get { return this._eventsOutOfOrderMaxDelayInSeconds; }
            set { this._eventsOutOfOrderMaxDelayInSeconds = value; }
        }
        
        private string _eventsOutOfOrderPolicy;
        
        /// <summary>
        /// Optional. Gets or sets the out of order policy of the stream
        /// analytics job.
        /// </summary>
        public string EventsOutOfOrderPolicy
        {
            get { return this._eventsOutOfOrderPolicy; }
            set { this._eventsOutOfOrderPolicy = value; }
        }
        
        private IList<Input> _inputs;
        
        /// <summary>
        /// Optional. Gets or sets a list of one or more inputs.
        /// </summary>
        public IList<Input> Inputs
        {
            get { return this._inputs; }
            set { this._inputs = value; }
        }
        
        private string _jobId;
        
        /// <summary>
        /// Optional. Gets the id of the stream analytics job.
        /// </summary>
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }
        
        private string _jobState;
        
        /// <summary>
        /// Optional. Gets the running state of the stream analytics job.
        /// </summary>
        public string JobState
        {
            get { return this._jobState; }
            set { this._jobState = value; }
        }
        
        private System.DateTime? _lastOutputEventTime;
        
        /// <summary>
        /// Optional. Gets the last output event time of the stream analytics
        /// job.
        /// </summary>
        public System.DateTime? LastOutputEventTime
        {
            get { return this._lastOutputEventTime; }
            set { this._lastOutputEventTime = value; }
        }
        
        private IList<Output> _outputs;
        
        /// <summary>
        /// Optional. Gets or sets a list of outputs.
        /// </summary>
        public IList<Output> Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }
        
        private string _outputStartMode;
        
        /// <summary>
        /// Optional. Gets or sets the output start mode of the stream
        /// analytics job.
        /// </summary>
        public string OutputStartMode
        {
            get { return this._outputStartMode; }
            set { this._outputStartMode = value; }
        }
        
        private System.DateTime? _outputStartTime;
        
        /// <summary>
        /// Optional. Gets or sets the output start time of the stream
        /// analytics job.
        /// </summary>
        public System.DateTime? OutputStartTime
        {
            get { return this._outputStartTime; }
            set { this._outputStartTime = value; }
        }
        
        private string _provisioningState;
        
        /// <summary>
        /// Optional. Gets the provisioning state of the stream analytics job.
        /// </summary>
        public string ProvisioningState
        {
            get { return this._provisioningState; }
            set { this._provisioningState = value; }
        }
        
        private Sku _sku;
        
        /// <summary>
        /// Optional. Gets or sets the Sku of the stream analytics job.
        /// </summary>
        public Sku Sku
        {
            get { return this._sku; }
            set { this._sku = value; }
        }
        
        private Transformation _transformation;
        
        /// <summary>
        /// Optional. Gets or sets the transformation definition, including the
        /// query and the streaming unit count.
        /// </summary>
        public Transformation Transformation
        {
            get { return this._transformation; }
            set { this._transformation = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the JobProperties class.
        /// </summary>
        public JobProperties()
        {
            this.Inputs = new LazyList<Input>();
            this.Outputs = new LazyList<Output>();
        }
    }
}
