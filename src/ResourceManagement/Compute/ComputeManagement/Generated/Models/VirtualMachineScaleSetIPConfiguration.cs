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
using Microsoft.Azure.Management.Compute.Models;

namespace Microsoft.Azure.Management.Compute.Models
{
    /// <summary>
    /// Describes a virtual machine scale set network profile's IP
    /// configuration.
    /// </summary>
    public partial class VirtualMachineScaleSetIPConfiguration
    {
        private IList<VirtualMachineScaleSetIPConfigurationLoadBalancerAddressPool> _loadBalancerBackendAddressPools;
        
        /// <summary>
        /// Optional. Gets or set the load balancer backend address pools.
        /// </summary>
        public IList<VirtualMachineScaleSetIPConfigurationLoadBalancerAddressPool> LoadBalancerBackendAddressPools
        {
            get { return this._loadBalancerBackendAddressPools; }
            set { this._loadBalancerBackendAddressPools = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Required. Gets or set the IP configuration name.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private ApiEntityReference _subnet;
        
        /// <summary>
        /// Required. Gets or set the subnet.
        /// </summary>
        public ApiEntityReference Subnet
        {
            get { return this._subnet; }
            set { this._subnet = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetIPConfiguration class.
        /// </summary>
        public VirtualMachineScaleSetIPConfiguration()
        {
            this.LoadBalancerBackendAddressPools = new LazyList<VirtualMachineScaleSetIPConfigurationLoadBalancerAddressPool>();
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetIPConfiguration class with required
        /// arguments.
        /// </summary>
        public VirtualMachineScaleSetIPConfiguration(string name, ApiEntityReference subnet)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (subnet == null)
            {
                throw new ArgumentNullException("subnet");
            }
            this.Name = name;
            this.Subnet = subnet;
        }
    }
}