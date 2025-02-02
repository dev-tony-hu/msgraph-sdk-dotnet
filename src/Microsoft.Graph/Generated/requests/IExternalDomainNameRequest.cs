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
    /// The interface IExternalDomainNameRequest.
    /// </summary>
    public partial interface IExternalDomainNameRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ExternalDomainName using POST.
        /// </summary>
        /// <param name="externalDomainNameToCreate">The ExternalDomainName to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ExternalDomainName.</returns>
        System.Threading.Tasks.Task<ExternalDomainName> CreateAsync(ExternalDomainName externalDomainNameToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ExternalDomainName using POST and returns a <see cref="GraphResponse{ExternalDomainName}"/> object.
        /// </summary>
        /// <param name="externalDomainNameToCreate">The ExternalDomainName to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ExternalDomainName}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ExternalDomainName>> CreateResponseAsync(ExternalDomainName externalDomainNameToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ExternalDomainName.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ExternalDomainName and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ExternalDomainName.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ExternalDomainName.</returns>
        System.Threading.Tasks.Task<ExternalDomainName> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ExternalDomainName and returns a <see cref="GraphResponse{ExternalDomainName}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ExternalDomainName}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ExternalDomainName>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ExternalDomainName using PATCH.
        /// </summary>
        /// <param name="externalDomainNameToUpdate">The ExternalDomainName to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ExternalDomainName.</returns>
        System.Threading.Tasks.Task<ExternalDomainName> UpdateAsync(ExternalDomainName externalDomainNameToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ExternalDomainName using PATCH and returns a <see cref="GraphResponse{ExternalDomainName}"/> object.
        /// </summary>
        /// <param name="externalDomainNameToUpdate">The ExternalDomainName to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ExternalDomainName}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ExternalDomainName>> UpdateResponseAsync(ExternalDomainName externalDomainNameToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ExternalDomainName using PUT.
        /// </summary>
        /// <param name="externalDomainNameToUpdate">The ExternalDomainName object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ExternalDomainName> PutAsync(ExternalDomainName externalDomainNameToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ExternalDomainName using PUT and returns a <see cref="GraphResponse{ExternalDomainName}"/> object.
        /// </summary>
        /// <param name="externalDomainNameToUpdate">The ExternalDomainName object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ExternalDomainName}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ExternalDomainName>> PutResponseAsync(ExternalDomainName externalDomainNameToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IExternalDomainNameRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IExternalDomainNameRequest Expand(Expression<Func<ExternalDomainName, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IExternalDomainNameRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IExternalDomainNameRequest Select(Expression<Func<ExternalDomainName, object>> selectExpression);

    }
}
