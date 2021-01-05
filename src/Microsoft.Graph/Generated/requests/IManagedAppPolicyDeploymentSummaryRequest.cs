// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IManagedAppPolicyDeploymentSummaryRequest.
    /// </summary>
    public partial interface IManagedAppPolicyDeploymentSummaryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ManagedAppPolicyDeploymentSummary using POST.
        /// </summary>
        /// <param name="managedAppPolicyDeploymentSummaryToCreate">The ManagedAppPolicyDeploymentSummary to create.</param>
        /// <returns>The created ManagedAppPolicyDeploymentSummary.</returns>
        System.Threading.Tasks.Task<ManagedAppPolicyDeploymentSummary> CreateAsync(ManagedAppPolicyDeploymentSummary managedAppPolicyDeploymentSummaryToCreate);        /// <summary>
        /// Creates the specified ManagedAppPolicyDeploymentSummary using POST.
        /// </summary>
        /// <param name="managedAppPolicyDeploymentSummaryToCreate">The ManagedAppPolicyDeploymentSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedAppPolicyDeploymentSummary.</returns>
        System.Threading.Tasks.Task<ManagedAppPolicyDeploymentSummary> CreateAsync(ManagedAppPolicyDeploymentSummary managedAppPolicyDeploymentSummaryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ManagedAppPolicyDeploymentSummary.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ManagedAppPolicyDeploymentSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ManagedAppPolicyDeploymentSummary.
        /// </summary>
        /// <returns>The ManagedAppPolicyDeploymentSummary.</returns>
        System.Threading.Tasks.Task<ManagedAppPolicyDeploymentSummary> GetAsync();

        /// <summary>
        /// Gets the specified ManagedAppPolicyDeploymentSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedAppPolicyDeploymentSummary.</returns>
        System.Threading.Tasks.Task<ManagedAppPolicyDeploymentSummary> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ManagedAppPolicyDeploymentSummary using PATCH.
        /// </summary>
        /// <param name="managedAppPolicyDeploymentSummaryToUpdate">The ManagedAppPolicyDeploymentSummary to update.</param>
        /// <returns>The updated ManagedAppPolicyDeploymentSummary.</returns>
        System.Threading.Tasks.Task<ManagedAppPolicyDeploymentSummary> UpdateAsync(ManagedAppPolicyDeploymentSummary managedAppPolicyDeploymentSummaryToUpdate);

        /// <summary>
        /// Updates the specified ManagedAppPolicyDeploymentSummary using PATCH.
        /// </summary>
        /// <param name="managedAppPolicyDeploymentSummaryToUpdate">The ManagedAppPolicyDeploymentSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedAppPolicyDeploymentSummary.</returns>
        System.Threading.Tasks.Task<ManagedAppPolicyDeploymentSummary> UpdateAsync(ManagedAppPolicyDeploymentSummary managedAppPolicyDeploymentSummaryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppPolicyDeploymentSummaryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppPolicyDeploymentSummaryRequest Expand(Expression<Func<ManagedAppPolicyDeploymentSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppPolicyDeploymentSummaryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppPolicyDeploymentSummaryRequest Select(Expression<Func<ManagedAppPolicyDeploymentSummary, object>> selectExpression);

    }
}
