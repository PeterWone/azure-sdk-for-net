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
using Microsoft.WindowsAzure;

namespace Microsoft.WindowsAzure.Management.ExpressRoute.Models
{
    /// <summary>
    /// The Get Cross Connection Operation Response.
    /// </summary>
    public partial class CrossConnectionGetResponse : OperationResponse
    {
        private int _bandwidth;
        
        /// <summary>
        /// Specifies the bandwidth that is assigned to the circuit.
        /// </summary>
        public int Bandwidth
        {
            get { return this._bandwidth; }
            set { this._bandwidth = value; }
        }
        
        private string _primaryAzurePort;
        
        /// <summary>
        /// Specifies the name of the primary port. Only available when the
        /// provisioning state is Provisioning or Provisioned.
        /// </summary>
        public string PrimaryAzurePort
        {
            get { return this._primaryAzurePort; }
            set { this._primaryAzurePort = value; }
        }
        
        private string _provisioningState;
        
        /// <summary>
        /// Provisioning state of the cross connection. Can be Provisioned,
        /// NotProvisioned, Provisioning or Deprovisioning.
        /// </summary>
        public string ProvisioningState
        {
            get { return this._provisioningState; }
            set { this._provisioningState = value; }
        }
        
        private string _secondaryAzurePort;
        
        /// <summary>
        /// Specifies the name of the secondary port. Only available when the
        /// provisioning state is Provisioning or Provisioned.
        /// </summary>
        public string SecondaryAzurePort
        {
            get { return this._secondaryAzurePort; }
            set { this._secondaryAzurePort = value; }
        }
        
        private int _sTag;
        
        /// <summary>
        /// Specifies the identifier of circuit traffic.
        /// </summary>
        public int STag
        {
            get { return this._sTag; }
            set { this._sTag = value; }
        }
        
        private string _status;
        
        /// <summary>
        /// The current status of the circuit. Possible values are: Disabled,
        /// Disabling, Enabling, Enabled.
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the CrossConnectionGetResponse class.
        /// </summary>
        public CrossConnectionGetResponse()
        {
        }
    }
}
