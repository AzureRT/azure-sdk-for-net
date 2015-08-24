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
using Microsoft.Azure;
using Microsoft.Azure.Management.Compute.Models;

namespace Microsoft.Azure.Management.Compute.Models
{
    /// <summary>
    /// Describes a Virtual Machine Scale Set.
    /// </summary>
    public partial class VirtualMachineScaleSet : ResourceBaseExtended
    {
        private VirtualMachineScaleSetNetworkProfile _networkProfile;
        
        /// <summary>
        /// Optional. Gets or sets the network profile.
        /// </summary>
        public VirtualMachineScaleSetNetworkProfile NetworkProfile
        {
            get { return this._networkProfile; }
            set { this._networkProfile = value; }
        }
        
        private string _provisioningState;
        
        /// <summary>
        /// Optional. Gets or sets the provisioning state, which only appears
        /// in the response.
        /// </summary>
        public string ProvisioningState
        {
            get { return this._provisioningState; }
            set { this._provisioningState = value; }
        }
        
        private Sku _sku;
        
        /// <summary>
        /// Optional. Gets or sets the virtual machine scale set sku.
        /// </summary>
        public Sku Sku
        {
            get { return this._sku; }
            set { this._sku = value; }
        }
        
        private UpgradePolicy _upgradePolicy;
        
        /// <summary>
        /// Optional. Gets or sets the upgrade policy.
        /// </summary>
        public UpgradePolicy UpgradePolicy
        {
            get { return this._upgradePolicy; }
            set { this._upgradePolicy = value; }
        }
        
        private VirtualMachineScaleSetVMProfile _virtualMachineProfile;
        
        /// <summary>
        /// Optional. Gets or sets the virtual machine profile.
        /// </summary>
        public VirtualMachineScaleSetVMProfile VirtualMachineProfile
        {
            get { return this._virtualMachineProfile; }
            set { this._virtualMachineProfile = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSet class.
        /// </summary>
        public VirtualMachineScaleSet()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSet class with
        /// required arguments.
        /// </summary>
        public VirtualMachineScaleSet(string location)
            : this()
        {
            if (location == null)
            {
                throw new ArgumentNullException("location");
            }
            this.Location = location;
        }
    }
}
