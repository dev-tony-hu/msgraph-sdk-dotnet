// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ITodoTaskAttachmentsCollectionRequest.
    /// </summary>
    public partial interface ITodoTaskAttachmentsCollectionRequest : IBaseRequest
    {
        /// <summary>
        /// Adds the specified AttachmentBase to the collection via POST.
        /// </summary>
        /// <param name="attachmentBase">The AttachmentBase to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AttachmentBase.</returns>
        System.Threading.Tasks.Task<AttachmentBase> AddAsync(AttachmentBase attachmentBase, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified AttachmentBase to the collection via POST and returns a <see cref="GraphResponse{AttachmentBase}"/> object of the request.
        /// </summary>
        /// <param name="attachmentBase">The AttachmentBase to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AttachmentBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AttachmentBase>> AddResponseAsync(AttachmentBase attachmentBase, CancellationToken cancellationToken = default);


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<ITodoTaskAttachmentsCollectionPage> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{TodoTaskAttachmentsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TodoTaskAttachmentsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<TodoTaskAttachmentsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITodoTaskAttachmentsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITodoTaskAttachmentsCollectionRequest Expand(Expression<Func<AttachmentBase, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITodoTaskAttachmentsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITodoTaskAttachmentsCollectionRequest Select(Expression<Func<AttachmentBase, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        ITodoTaskAttachmentsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        ITodoTaskAttachmentsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        ITodoTaskAttachmentsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        ITodoTaskAttachmentsCollectionRequest OrderBy(string value);
    }
}
