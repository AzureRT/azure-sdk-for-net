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
using Microsoft.Azure;
using Microsoft.Azure.Management.Compute.Models;

namespace Microsoft.Azure.Management.Compute.Models
{
    /// <summary>
    /// The List Virtual Machine Scale Set VMs operation response.
    /// </summary>
    public partial class VirtualMachineScaleSetVMListResponse : AzureOperationResponse, IEnumerable<VirtualMachineScaleSetVM>
    {
        private IList<VirtualMachineScaleSetVM> _virtualMachineScaleSetVMs;
        
        /// <summary>
        /// Optional. Gets or sets the list of virtual machine scale sets VMs.
        /// </summary>
        public IList<VirtualMachineScaleSetVM> VirtualMachineScaleSetVMs
        {
            get { return this._virtualMachineScaleSetVMs; }
            set { this._virtualMachineScaleSetVMs = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetVMListResponse class.
        /// </summary>
        public VirtualMachineScaleSetVMListResponse()
        {
            this.VirtualMachineScaleSetVMs = new LazyList<VirtualMachineScaleSetVM>();
        }
        
        /// <summary>
        /// Gets the sequence of VirtualMachineScaleSetVMs.
        /// </summary>
        public IEnumerator<VirtualMachineScaleSetVM> GetEnumerator()
        {
            return this.VirtualMachineScaleSetVMs.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of VirtualMachineScaleSetVMs.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}