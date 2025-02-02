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
    /// The interface IAppleManagedIdentityProviderRequest.
    /// </summary>
    public partial interface IAppleManagedIdentityProviderRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AppleManagedIdentityProvider using POST.
        /// </summary>
        /// <param name="appleManagedIdentityProviderToCreate">The AppleManagedIdentityProvider to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AppleManagedIdentityProvider.</returns>
        System.Threading.Tasks.Task<AppleManagedIdentityProvider> CreateAsync(AppleManagedIdentityProvider appleManagedIdentityProviderToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified AppleManagedIdentityProvider using POST and returns a <see cref="GraphResponse{AppleManagedIdentityProvider}"/> object.
        /// </summary>
        /// <param name="appleManagedIdentityProviderToCreate">The AppleManagedIdentityProvider to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AppleManagedIdentityProvider}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AppleManagedIdentityProvider>> CreateResponseAsync(AppleManagedIdentityProvider appleManagedIdentityProviderToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AppleManagedIdentityProvider.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AppleManagedIdentityProvider and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AppleManagedIdentityProvider.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AppleManagedIdentityProvider.</returns>
        System.Threading.Tasks.Task<AppleManagedIdentityProvider> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AppleManagedIdentityProvider and returns a <see cref="GraphResponse{AppleManagedIdentityProvider}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AppleManagedIdentityProvider}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AppleManagedIdentityProvider>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AppleManagedIdentityProvider using PATCH.
        /// </summary>
        /// <param name="appleManagedIdentityProviderToUpdate">The AppleManagedIdentityProvider to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AppleManagedIdentityProvider.</returns>
        System.Threading.Tasks.Task<AppleManagedIdentityProvider> UpdateAsync(AppleManagedIdentityProvider appleManagedIdentityProviderToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AppleManagedIdentityProvider using PATCH and returns a <see cref="GraphResponse{AppleManagedIdentityProvider}"/> object.
        /// </summary>
        /// <param name="appleManagedIdentityProviderToUpdate">The AppleManagedIdentityProvider to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AppleManagedIdentityProvider}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AppleManagedIdentityProvider>> UpdateResponseAsync(AppleManagedIdentityProvider appleManagedIdentityProviderToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AppleManagedIdentityProvider using PUT.
        /// </summary>
        /// <param name="appleManagedIdentityProviderToUpdate">The AppleManagedIdentityProvider object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<AppleManagedIdentityProvider> PutAsync(AppleManagedIdentityProvider appleManagedIdentityProviderToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AppleManagedIdentityProvider using PUT and returns a <see cref="GraphResponse{AppleManagedIdentityProvider}"/> object.
        /// </summary>
        /// <param name="appleManagedIdentityProviderToUpdate">The AppleManagedIdentityProvider object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{AppleManagedIdentityProvider}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<AppleManagedIdentityProvider>> PutResponseAsync(AppleManagedIdentityProvider appleManagedIdentityProviderToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAppleManagedIdentityProviderRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAppleManagedIdentityProviderRequest Expand(Expression<Func<AppleManagedIdentityProvider, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAppleManagedIdentityProviderRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAppleManagedIdentityProviderRequest Select(Expression<Func<AppleManagedIdentityProvider, object>> selectExpression);

    }
}
