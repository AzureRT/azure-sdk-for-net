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
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;

namespace Microsoft.Azure.Management.Compute
{
    /// <summary>
    /// The Compute Management Client.
    /// </summary>
    public static partial class VirtualMachineScaleSetOperationsExtensions
    {
        /// <summary>
        /// The operation to create or update a virtual machine scale set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Create Virtual Machine Scale
        /// Set operation.
        /// </param>
        /// <returns>
        /// The Create Virtual Machine Scale Set operation response.
        /// </returns>
        public static VirtualMachineScaleSetCreateOrUpdateResponse BeginCreatingOrUpdating(this IVirtualMachineScaleSetOperations operations, string resourceGroupName, VirtualMachineScaleSet parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineScaleSetOperations)s).BeginCreatingOrUpdatingAsync(resourceGroupName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The operation to create or update a virtual machine scale set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Create Virtual Machine Scale
        /// Set operation.
        /// </param>
        /// <returns>
        /// The Create Virtual Machine Scale Set operation response.
        /// </returns>
        public static Task<VirtualMachineScaleSetCreateOrUpdateResponse> BeginCreatingOrUpdatingAsync(this IVirtualMachineScaleSetOperations operations, string resourceGroupName, VirtualMachineScaleSet parameters)
        {
            return operations.BeginCreatingOrUpdatingAsync(resourceGroupName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// The operation to deallocate a virtual machine scale set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// Required. The name of the virtual machine scale set.
        /// </param>
        /// <returns>
        /// The compute long running operation response.
        /// </returns>
        public static ComputeOperationResponse BeginDeallocating(this IVirtualMachineScaleSetOperations operations, string resourceGroupName, string vmScaleSetName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineScaleSetOperations)s).BeginDeallocatingAsync(resourceGroupName, vmScaleSetName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The operation to deallocate a virtual machine scale set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// Required. The name of the virtual machine scale set.
        /// </param>
        /// <returns>
        /// The compute long running operation response.
        /// </returns>
        public static Task<ComputeOperationResponse> BeginDeallocatingAsync(this IVirtualMachineScaleSetOperations operations, string resourceGroupName, string vmScaleSetName)
        {
            return operations.BeginDeallocatingAsync(resourceGroupName, vmScaleSetName, CancellationToken.None);
        }
        
        /// <summary>
        /// The operation to delete a virtual machine scale set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// Required. The name of the virtual machine scale set.
        /// </param>
        /// <returns>
        /// The compute long running operation response.
        /// </returns>
        public static DeleteOperationResponse BeginDeleting(this IVirtualMachineScaleSetOperations operations, string resourceGroupName, string vmScaleSetName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineScaleSetOperations)s).BeginDeletingAsync(resourceGroupName, vmScaleSetName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The operation to delete a virtual machine scale set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// Required. The name of the virtual machine scale set.
        /// </param>
        /// <returns>
        /// The compute long running operation response.
        /// </returns>
        public static Task<DeleteOperationResponse> BeginDeletingAsync(this IVirtualMachineScaleSetOperations operations, string resourceGroupName, string vmScaleSetName)
        {
            return operations.BeginDeletingAsync(resourceGroupName, vmScaleSetName, CancellationToken.None);
        }
        
        /// <summary>
        /// The operation to power off (stop) a virtual machine scale set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// Required. The name of the virtual machine scale set.
        /// </param>
        /// <returns>
        /// The compute long running operation response.
        /// </returns>
        public static ComputeOperationResponse BeginPoweringOff(this IVirtualMachineScaleSetOperations operations, string resourceGroupName, string vmScaleSetName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineScaleSetOperations)s).BeginPoweringOffAsync(resourceGroupName, vmScaleSetName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The operation to power off (stop) a virtual machine scale set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// Required. The name of the virtual machine scale set.
        /// </param>
        /// <returns>
        /// The compute long running operation response.
        /// </returns>
        public static Task<ComputeOperationResponse> BeginPoweringOffAsync(this IVirtualMachineScaleSetOperations operations, string resourceGroupName, string vmScaleSetName)
        {
            return operations.BeginPoweringOffAsync(resourceGroupName, vmScaleSetName, CancellationToken.None);
        }
        
        /// <summary>
        /// The operation to restart a virtual machine scale set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// Required. The name of the virtual machine scale set.
        /// </param>
        /// <returns>
        /// The compute long running operation response.
        /// </returns>
        public static ComputeOperationResponse BeginRestarting(this IVirtualMachineScaleSetOperations operations, string resourceGroupName, string vmScaleSetName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineScaleSetOperations)s).BeginRestartingAsync(resourceGroupName, vmScaleSetName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The operation to restart a virtual machine scale set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// Required. The name of the virtual machine scale set.
        /// </param>
        /// <returns>
        /// The compute long running operation response.
        /// </returns>
        public static Task<ComputeOperationResponse> BeginRestartingAsync(this IVirtualMachineScaleSetOperations operations, string resourceGroupName, string vmScaleSetName)
        {
            return operations.BeginRestartingAsync(resourceGroupName, vmScaleSetName, CancellationToken.None);
        }
        
        /// <summary>
        /// The operation to start a virtual machine scale set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// Required. The name of the virtual machine scale set.
        /// </param>
        /// <returns>
        /// The compute long running operation response.
        /// </returns>
        public static ComputeOperationResponse BeginStarting(this IVirtualMachineScaleSetOperations operations, string resourceGroupName, string vmScaleSetName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineScaleSetOperations)s).BeginStartingAsync(resourceGroupName, vmScaleSetName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The operation to start a virtual machine scale set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// Required. The name of the virtual machine scale set.
        /// </param>
        /// <returns>
        /// The compute long running operation response.
        /// </returns>
        public static Task<ComputeOperationResponse> BeginStartingAsync(this IVirtualMachineScaleSetOperations operations, string resourceGroupName, string vmScaleSetName)
        {
            return operations.BeginStartingAsync(resourceGroupName, vmScaleSetName, CancellationToken.None);
        }
        
        /// <summary>
        /// The operation to create or update a virtual machine scale set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Create Virtual Machine Scale
        /// Set operation.
        /// </param>
        /// <returns>
        /// The Compute service response for long-running operations.
        /// </returns>
        public static ComputeLongRunningOperationResponse CreateOrUpdate(this IVirtualMachineScaleSetOperations operations, string resourceGroupName, VirtualMachineScaleSet parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineScaleSetOperations)s).CreateOrUpdateAsync(resourceGroupName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The operation to create or update a virtual machine scale set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Create Virtual Machine Scale
        /// Set operation.
        /// </param>
        /// <returns>
        /// The Compute service response for long-running operations.
        /// </returns>
        public static Task<ComputeLongRunningOperationResponse> CreateOrUpdateAsync(this IVirtualMachineScaleSetOperations operations, string resourceGroupName, VirtualMachineScaleSet parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// The operation to deallocate a virtual machine scale set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// Required. The name of the virtual machine scale set.
        /// </param>
        /// <returns>
        /// The Compute service response for long-running operations.
        /// </returns>
        public static ComputeLongRunningOperationResponse Deallocate(this IVirtualMachineScaleSetOperations operations, string resourceGroupName, string vmScaleSetName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineScaleSetOperations)s).DeallocateAsync(resourceGroupName, vmScaleSetName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The operation to deallocate a virtual machine scale set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// Required. The name of the virtual machine scale set.
        /// </param>
        /// <returns>
        /// The Compute service response for long-running operations.
        /// </returns>
        public static Task<ComputeLongRunningOperationResponse> DeallocateAsync(this IVirtualMachineScaleSetOperations operations, string resourceGroupName, string vmScaleSetName)
        {
            return operations.DeallocateAsync(resourceGroupName, vmScaleSetName, CancellationToken.None);
        }
        
        /// <summary>
        /// The operation to delete a virtual machine scale set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// Required. The name of the virtual machine scale set.
        /// </param>
        /// <returns>
        /// The compute long running operation response.
        /// </returns>
        public static DeleteOperationResponse Delete(this IVirtualMachineScaleSetOperations operations, string resourceGroupName, string vmScaleSetName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineScaleSetOperations)s).DeleteAsync(resourceGroupName, vmScaleSetName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The operation to delete a virtual machine scale set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// Required. The name of the virtual machine scale set.
        /// </param>
        /// <returns>
        /// The compute long running operation response.
        /// </returns>
        public static Task<DeleteOperationResponse> DeleteAsync(this IVirtualMachineScaleSetOperations operations, string resourceGroupName, string vmScaleSetName)
        {
            return operations.DeleteAsync(resourceGroupName, vmScaleSetName, CancellationToken.None);
        }
        
        /// <summary>
        /// The operation to get a virtual machine scale set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// Required. The name of the virtual machine scale set.
        /// </param>
        /// <returns>
        /// The GetVirtualMachineScaleSet operation response.
        /// </returns>
        public static VirtualMachineScaleSetGetResponse Get(this IVirtualMachineScaleSetOperations operations, string resourceGroupName, string vmScaleSetName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineScaleSetOperations)s).GetAsync(resourceGroupName, vmScaleSetName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The operation to get a virtual machine scale set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// Required. The name of the virtual machine scale set.
        /// </param>
        /// <returns>
        /// The GetVirtualMachineScaleSet operation response.
        /// </returns>
        public static Task<VirtualMachineScaleSetGetResponse> GetAsync(this IVirtualMachineScaleSetOperations operations, string resourceGroupName, string vmScaleSetName)
        {
            return operations.GetAsync(resourceGroupName, vmScaleSetName, CancellationToken.None);
        }
        
        /// <summary>
        /// The operation to list virtual machine scale sets under a resource
        /// group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <returns>
        /// The List Virtual Machine operation response.
        /// </returns>
        public static VirtualMachineScaleSetListResponse List(this IVirtualMachineScaleSetOperations operations, string resourceGroupName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineScaleSetOperations)s).ListAsync(resourceGroupName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The operation to list virtual machine scale sets under a resource
        /// group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <returns>
        /// The List Virtual Machine operation response.
        /// </returns>
        public static Task<VirtualMachineScaleSetListResponse> ListAsync(this IVirtualMachineScaleSetOperations operations, string resourceGroupName)
        {
            return operations.ListAsync(resourceGroupName, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the list of Virtual Machine Scale Sets in the subscription.
        /// Use nextLink property in the response to get the next page of
        /// Virtual Machine Scale Sets. Do this till nextLink is not null to
        /// fetch all the Virtual Machine Scale Sets.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='parameters'>
        /// Optional.
        /// </param>
        /// <returns>
        /// The List Virtual Machine operation response.
        /// </returns>
        public static VirtualMachineScaleSetListResponse ListAll(this IVirtualMachineScaleSetOperations operations, ListParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineScaleSetOperations)s).ListAllAsync(parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the list of Virtual Machine Scale Sets in the subscription.
        /// Use nextLink property in the response to get the next page of
        /// Virtual Machine Scale Sets. Do this till nextLink is not null to
        /// fetch all the Virtual Machine Scale Sets.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='parameters'>
        /// Optional.
        /// </param>
        /// <returns>
        /// The List Virtual Machine operation response.
        /// </returns>
        public static Task<VirtualMachineScaleSetListResponse> ListAllAsync(this IVirtualMachineScaleSetOperations operations, ListParameters parameters)
        {
            return operations.ListAllAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the next page of Virtual Machine Scale Sets. NextLink is
        /// obtained by making a ListAll() callwhich fetches the first page of
        /// Virtual Machine Scale Sets and a link to fetch the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. NextLink from the previous successful call to
        /// ListVirtualMachineScaleSets operation.
        /// </param>
        /// <returns>
        /// The List Virtual Machine operation response.
        /// </returns>
        public static VirtualMachineScaleSetListResponse ListNext(this IVirtualMachineScaleSetOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineScaleSetOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the next page of Virtual Machine Scale Sets. NextLink is
        /// obtained by making a ListAll() callwhich fetches the first page of
        /// Virtual Machine Scale Sets and a link to fetch the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. NextLink from the previous successful call to
        /// ListVirtualMachineScaleSets operation.
        /// </param>
        /// <returns>
        /// The List Virtual Machine operation response.
        /// </returns>
        public static Task<VirtualMachineScaleSetListResponse> ListNextAsync(this IVirtualMachineScaleSetOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
        
        /// <summary>
        /// The operation to list available skus for a virtual machine scale
        /// set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// Required. The name of the virtual machine scale set.
        /// </param>
        /// <returns>
        /// The Virtual Machine Scale Set List Skus operation response.
        /// </returns>
        public static VirtualMachineScaleSetListSkusResponse ListSkus(this IVirtualMachineScaleSetOperations operations, string resourceGroupName, string vmScaleSetName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineScaleSetOperations)s).ListSkusAsync(resourceGroupName, vmScaleSetName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The operation to list available skus for a virtual machine scale
        /// set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// Required. The name of the virtual machine scale set.
        /// </param>
        /// <returns>
        /// The Virtual Machine Scale Set List Skus operation response.
        /// </returns>
        public static Task<VirtualMachineScaleSetListSkusResponse> ListSkusAsync(this IVirtualMachineScaleSetOperations operations, string resourceGroupName, string vmScaleSetName)
        {
            return operations.ListSkusAsync(resourceGroupName, vmScaleSetName, CancellationToken.None);
        }
        
        /// <summary>
        /// The operation to power off (stop) a virtual machine scale set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// Required. The name of the virtual machine scale set.
        /// </param>
        /// <returns>
        /// The Compute service response for long-running operations.
        /// </returns>
        public static ComputeLongRunningOperationResponse PowerOff(this IVirtualMachineScaleSetOperations operations, string resourceGroupName, string vmScaleSetName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineScaleSetOperations)s).PowerOffAsync(resourceGroupName, vmScaleSetName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The operation to power off (stop) a virtual machine scale set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// Required. The name of the virtual machine scale set.
        /// </param>
        /// <returns>
        /// The Compute service response for long-running operations.
        /// </returns>
        public static Task<ComputeLongRunningOperationResponse> PowerOffAsync(this IVirtualMachineScaleSetOperations operations, string resourceGroupName, string vmScaleSetName)
        {
            return operations.PowerOffAsync(resourceGroupName, vmScaleSetName, CancellationToken.None);
        }
        
        /// <summary>
        /// The operation to restart a virtual machine scale set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// Required. The name of the virtual machine scale set.
        /// </param>
        /// <returns>
        /// The Compute service response for long-running operations.
        /// </returns>
        public static ComputeLongRunningOperationResponse Restart(this IVirtualMachineScaleSetOperations operations, string resourceGroupName, string vmScaleSetName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineScaleSetOperations)s).RestartAsync(resourceGroupName, vmScaleSetName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The operation to restart a virtual machine scale set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// Required. The name of the virtual machine scale set.
        /// </param>
        /// <returns>
        /// The Compute service response for long-running operations.
        /// </returns>
        public static Task<ComputeLongRunningOperationResponse> RestartAsync(this IVirtualMachineScaleSetOperations operations, string resourceGroupName, string vmScaleSetName)
        {
            return operations.RestartAsync(resourceGroupName, vmScaleSetName, CancellationToken.None);
        }
        
        /// <summary>
        /// The operation to start a virtual machine scale set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// Required. The name of the virtual machine scale set.
        /// </param>
        /// <returns>
        /// The Compute service response for long-running operations.
        /// </returns>
        public static ComputeLongRunningOperationResponse Start(this IVirtualMachineScaleSetOperations operations, string resourceGroupName, string vmScaleSetName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineScaleSetOperations)s).StartAsync(resourceGroupName, vmScaleSetName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The operation to start a virtual machine scale set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineScaleSetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// Required. The name of the virtual machine scale set.
        /// </param>
        /// <returns>
        /// The Compute service response for long-running operations.
        /// </returns>
        public static Task<ComputeLongRunningOperationResponse> StartAsync(this IVirtualMachineScaleSetOperations operations, string resourceGroupName, string vmScaleSetName)
        {
            return operations.StartAsync(resourceGroupName, vmScaleSetName, CancellationToken.None);
        }
    }
}