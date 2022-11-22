// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type EdiscoveryPurgeDataOperationRequest.
    /// </summary>
    public partial class EdiscoveryPurgeDataOperationRequest : Microsoft.Graph.BaseRequest, IEdiscoveryPurgeDataOperationRequest
    {
        /// <summary>
        /// Constructs a new EdiscoveryPurgeDataOperationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public EdiscoveryPurgeDataOperationRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified EdiscoveryPurgeDataOperation using POST.
        /// </summary>
        /// <param name="ediscoveryPurgeDataOperationToCreate">The EdiscoveryPurgeDataOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EdiscoveryPurgeDataOperation.</returns>
        public async System.Threading.Tasks.Task<EdiscoveryPurgeDataOperation> CreateAsync(EdiscoveryPurgeDataOperation ediscoveryPurgeDataOperationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<EdiscoveryPurgeDataOperation>(ediscoveryPurgeDataOperationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified EdiscoveryPurgeDataOperation using POST and returns a <see cref="GraphResponse{EdiscoveryPurgeDataOperation}"/> object.
        /// </summary>
        /// <param name="ediscoveryPurgeDataOperationToCreate">The EdiscoveryPurgeDataOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EdiscoveryPurgeDataOperation}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EdiscoveryPurgeDataOperation>> CreateResponseAsync(EdiscoveryPurgeDataOperation ediscoveryPurgeDataOperationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<EdiscoveryPurgeDataOperation>(ediscoveryPurgeDataOperationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified EdiscoveryPurgeDataOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<EdiscoveryPurgeDataOperation>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified EdiscoveryPurgeDataOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified EdiscoveryPurgeDataOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EdiscoveryPurgeDataOperation.</returns>
        public async System.Threading.Tasks.Task<EdiscoveryPurgeDataOperation> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<EdiscoveryPurgeDataOperation>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified EdiscoveryPurgeDataOperation and returns a <see cref="GraphResponse{EdiscoveryPurgeDataOperation}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EdiscoveryPurgeDataOperation}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EdiscoveryPurgeDataOperation>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<EdiscoveryPurgeDataOperation>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified EdiscoveryPurgeDataOperation using PATCH.
        /// </summary>
        /// <param name="ediscoveryPurgeDataOperationToUpdate">The EdiscoveryPurgeDataOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EdiscoveryPurgeDataOperation.</returns>
        public async System.Threading.Tasks.Task<EdiscoveryPurgeDataOperation> UpdateAsync(EdiscoveryPurgeDataOperation ediscoveryPurgeDataOperationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<EdiscoveryPurgeDataOperation>(ediscoveryPurgeDataOperationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified EdiscoveryPurgeDataOperation using PATCH and returns a <see cref="GraphResponse{EdiscoveryPurgeDataOperation}"/> object.
        /// </summary>
        /// <param name="ediscoveryPurgeDataOperationToUpdate">The EdiscoveryPurgeDataOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EdiscoveryPurgeDataOperation}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EdiscoveryPurgeDataOperation>> UpdateResponseAsync(EdiscoveryPurgeDataOperation ediscoveryPurgeDataOperationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<EdiscoveryPurgeDataOperation>(ediscoveryPurgeDataOperationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified EdiscoveryPurgeDataOperation using PUT.
        /// </summary>
        /// <param name="ediscoveryPurgeDataOperationToUpdate">The EdiscoveryPurgeDataOperation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<EdiscoveryPurgeDataOperation> PutAsync(EdiscoveryPurgeDataOperation ediscoveryPurgeDataOperationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<EdiscoveryPurgeDataOperation>(ediscoveryPurgeDataOperationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified EdiscoveryPurgeDataOperation using PUT and returns a <see cref="GraphResponse{EdiscoveryPurgeDataOperation}"/> object.
        /// </summary>
        /// <param name="ediscoveryPurgeDataOperationToUpdate">The EdiscoveryPurgeDataOperation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{EdiscoveryPurgeDataOperation}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EdiscoveryPurgeDataOperation>> PutResponseAsync(EdiscoveryPurgeDataOperation ediscoveryPurgeDataOperationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<EdiscoveryPurgeDataOperation>(ediscoveryPurgeDataOperationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEdiscoveryPurgeDataOperationRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEdiscoveryPurgeDataOperationRequest Expand(Expression<Func<EdiscoveryPurgeDataOperation, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IEdiscoveryPurgeDataOperationRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IEdiscoveryPurgeDataOperationRequest Select(Expression<Func<EdiscoveryPurgeDataOperation, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="ediscoveryPurgeDataOperationToInitialize">The <see cref="EdiscoveryPurgeDataOperation"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(EdiscoveryPurgeDataOperation ediscoveryPurgeDataOperationToInitialize)
        {

        }
    }
}
