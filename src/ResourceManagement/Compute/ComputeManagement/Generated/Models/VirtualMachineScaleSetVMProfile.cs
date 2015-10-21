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
using Microsoft.Azure.Management.Compute.Models;

namespace Microsoft.Azure.Management.Compute.Models
{
    /// <summary>
    /// Describes a virtual machine scale set virtual machine profile.
    /// </summary>
    public partial class VirtualMachineScaleSetVMProfile
    {
        private VirtualMachineScaleSetExtensionProfile _extensionProfile;
        
        /// <summary>
        /// Optional. Gets the virtual machine scale set extension profile.
        /// </summary>
        public VirtualMachineScaleSetExtensionProfile ExtensionProfile
        {
            get { return this._extensionProfile; }
            set { this._extensionProfile = value; }
        }
        
        private VirtualMachineScaleSetNetworkProfile _networkProfile;
        
        /// <summary>
        /// Optional. Gets or sets the virtual machine scale set network
        /// profile.
        /// </summary>
        public VirtualMachineScaleSetNetworkProfile NetworkProfile
        {
            get { return this._networkProfile; }
            set { this._networkProfile = value; }
        }
        
        private VirtualMachineScaleSetOSProfile _oSProfile;
        
        /// <summary>
        /// Optional. Gets or sets the virtual machine scale set OS profile.
        /// </summary>
        public VirtualMachineScaleSetOSProfile OSProfile
        {
            get { return this._oSProfile; }
            set { this._oSProfile = value; }
        }
        
        private VirtualMachineScaleSetStorageProfile _storageProfile;
        
        /// <summary>
        /// Optional. Gets or sets the virtual machine scale set storage
        /// profile.
        /// </summary>
        public VirtualMachineScaleSetStorageProfile StorageProfile
        {
            get { return this._storageProfile; }
            set { this._storageProfile = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSetVMProfile
        /// class.
        /// </summary>
        public VirtualMachineScaleSetVMProfile()
        {
        }
    }
}