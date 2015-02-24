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
using Microsoft.Azure.Management.DataFactories.Models;

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// A reference to a data slice run. It contains the fields necessary to
    /// identify a single run.
    /// </summary>
    public partial class RunRecordReference : DataFactoryReference
    {
        private string _activityName;
        
        /// <summary>
        /// Optional. The activity name.
        /// </summary>
        public string ActivityName
        {
            get { return this._activityName; }
            set { this._activityName = value; }
        }
        
        private DateTime _dataSliceEnd;
        
        /// <summary>
        /// Optional. End time for corresponding data slice.
        /// </summary>
        public DateTime DataSliceEnd
        {
            get { return this._dataSliceEnd; }
            set { this._dataSliceEnd = value; }
        }
        
        private string _dataSliceRunName;
        
        /// <summary>
        /// Optional. The data slice run name.
        /// </summary>
        public string DataSliceRunName
        {
            get { return this._dataSliceRunName; }
            set { this._dataSliceRunName = value; }
        }
        
        private DateTime _dataSliceStart;
        
        /// <summary>
        /// Optional. Start time for corresponding data slice.
        /// </summary>
        public DateTime DataSliceStart
        {
            get { return this._dataSliceStart; }
            set { this._dataSliceStart = value; }
        }
        
        private string _pipelineName;
        
        /// <summary>
        /// Optional. The pipeline name.
        /// </summary>
        public string PipelineName
        {
            get { return this._pipelineName; }
            set { this._pipelineName = value; }
        }
        
        private string _tableName;
        
        /// <summary>
        /// Optional. The table name.
        /// </summary>
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RunRecordReference class.
        /// </summary>
        public RunRecordReference()
        {
        }
    }
}
