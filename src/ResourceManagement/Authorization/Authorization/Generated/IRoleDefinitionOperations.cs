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
using Microsoft.Azure.Management.Authorization.Models;

namespace Microsoft.Azure.Management.Authorization
{
    /// <summary>
    /// TBD  (see http://TBD for more information)
    /// </summary>
    public partial interface IRoleDefinitionOperations
    {
        /// <summary>
        /// Creates or updates a role definition.
        /// </summary>
        /// <param name='roleDefinitionId'>
        /// Role definition id.
        /// </param>
        /// <param name='parameters'>
        /// Role definition.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Role definition create or update operation result.
        /// </returns>
        Task<RoleDefinitionCreateOrUpdateResult> CreateOrUpdateAsync(Guid roleDefinitionId, RoleDefinitionCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes the role definition.
        /// </summary>
        /// <param name='roleDefinitionId'>
        /// Role definition id.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Role definition delete operation result.
        /// </returns>
        Task<RoleDefinitionDeleteResult> DeleteAsync(string roleDefinitionId, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get role definition by name (GUID).
        /// </summary>
        /// <param name='roleDefinitionName'>
        /// Role definition name (GUID).
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Role definition get operation result.
        /// </returns>
        Task<RoleDefinitionGetResult> GetAsync(Guid roleDefinitionName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get role definition by name (GUID).
        /// </summary>
        /// <param name='roleDefinitionId'>
        /// Role definition Id
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Role definition get operation result.
        /// </returns>
        Task<RoleDefinitionGetResult> GetByIdAsync(string roleDefinitionId, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get all role definitions.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Role definition list operation result.
        /// </returns>
        Task<RoleDefinitionListResult> ListAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Get role definitions.
        /// </summary>
        /// <param name='parameters'>
        /// List role definitions filters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Role definition list operation result.
        /// </returns>
        Task<RoleDefinitionListResult> ListWithFiltersAsync(ListDefinitionFilterParameters parameters, CancellationToken cancellationToken);
    }
}
