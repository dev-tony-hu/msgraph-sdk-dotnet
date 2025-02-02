// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type X509CertificateAuthenticationMethodConfigurationRequest.
    /// </summary>
    public partial class X509CertificateAuthenticationMethodConfigurationRequest : BaseRequest, IX509CertificateAuthenticationMethodConfigurationRequest
    {
        /// <summary>
        /// Constructs a new X509CertificateAuthenticationMethodConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public X509CertificateAuthenticationMethodConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified X509CertificateAuthenticationMethodConfiguration using POST.
        /// </summary>
        /// <param name="x509CertificateAuthenticationMethodConfigurationToCreate">The X509CertificateAuthenticationMethodConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created X509CertificateAuthenticationMethodConfiguration.</returns>
        public async System.Threading.Tasks.Task<X509CertificateAuthenticationMethodConfiguration> CreateAsync(X509CertificateAuthenticationMethodConfiguration x509CertificateAuthenticationMethodConfigurationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<X509CertificateAuthenticationMethodConfiguration>(x509CertificateAuthenticationMethodConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified X509CertificateAuthenticationMethodConfiguration using POST and returns a <see cref="GraphResponse{X509CertificateAuthenticationMethodConfiguration}"/> object.
        /// </summary>
        /// <param name="x509CertificateAuthenticationMethodConfigurationToCreate">The X509CertificateAuthenticationMethodConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{X509CertificateAuthenticationMethodConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<X509CertificateAuthenticationMethodConfiguration>> CreateResponseAsync(X509CertificateAuthenticationMethodConfiguration x509CertificateAuthenticationMethodConfigurationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<X509CertificateAuthenticationMethodConfiguration>(x509CertificateAuthenticationMethodConfigurationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified X509CertificateAuthenticationMethodConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<X509CertificateAuthenticationMethodConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified X509CertificateAuthenticationMethodConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified X509CertificateAuthenticationMethodConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The X509CertificateAuthenticationMethodConfiguration.</returns>
        public async System.Threading.Tasks.Task<X509CertificateAuthenticationMethodConfiguration> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<X509CertificateAuthenticationMethodConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified X509CertificateAuthenticationMethodConfiguration and returns a <see cref="GraphResponse{X509CertificateAuthenticationMethodConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{X509CertificateAuthenticationMethodConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<X509CertificateAuthenticationMethodConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<X509CertificateAuthenticationMethodConfiguration>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified X509CertificateAuthenticationMethodConfiguration using PATCH.
        /// </summary>
        /// <param name="x509CertificateAuthenticationMethodConfigurationToUpdate">The X509CertificateAuthenticationMethodConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated X509CertificateAuthenticationMethodConfiguration.</returns>
        public async System.Threading.Tasks.Task<X509CertificateAuthenticationMethodConfiguration> UpdateAsync(X509CertificateAuthenticationMethodConfiguration x509CertificateAuthenticationMethodConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<X509CertificateAuthenticationMethodConfiguration>(x509CertificateAuthenticationMethodConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified X509CertificateAuthenticationMethodConfiguration using PATCH and returns a <see cref="GraphResponse{X509CertificateAuthenticationMethodConfiguration}"/> object.
        /// </summary>
        /// <param name="x509CertificateAuthenticationMethodConfigurationToUpdate">The X509CertificateAuthenticationMethodConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{X509CertificateAuthenticationMethodConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<X509CertificateAuthenticationMethodConfiguration>> UpdateResponseAsync(X509CertificateAuthenticationMethodConfiguration x509CertificateAuthenticationMethodConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<X509CertificateAuthenticationMethodConfiguration>(x509CertificateAuthenticationMethodConfigurationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified X509CertificateAuthenticationMethodConfiguration using PUT.
        /// </summary>
        /// <param name="x509CertificateAuthenticationMethodConfigurationToUpdate">The X509CertificateAuthenticationMethodConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<X509CertificateAuthenticationMethodConfiguration> PutAsync(X509CertificateAuthenticationMethodConfiguration x509CertificateAuthenticationMethodConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<X509CertificateAuthenticationMethodConfiguration>(x509CertificateAuthenticationMethodConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified X509CertificateAuthenticationMethodConfiguration using PUT and returns a <see cref="GraphResponse{X509CertificateAuthenticationMethodConfiguration}"/> object.
        /// </summary>
        /// <param name="x509CertificateAuthenticationMethodConfigurationToUpdate">The X509CertificateAuthenticationMethodConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{X509CertificateAuthenticationMethodConfiguration}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<X509CertificateAuthenticationMethodConfiguration>> PutResponseAsync(X509CertificateAuthenticationMethodConfiguration x509CertificateAuthenticationMethodConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<X509CertificateAuthenticationMethodConfiguration>(x509CertificateAuthenticationMethodConfigurationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IX509CertificateAuthenticationMethodConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IX509CertificateAuthenticationMethodConfigurationRequest Expand(Expression<Func<X509CertificateAuthenticationMethodConfiguration, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IX509CertificateAuthenticationMethodConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IX509CertificateAuthenticationMethodConfigurationRequest Select(Expression<Func<X509CertificateAuthenticationMethodConfiguration, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="x509CertificateAuthenticationMethodConfigurationToInitialize">The <see cref="X509CertificateAuthenticationMethodConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(X509CertificateAuthenticationMethodConfiguration x509CertificateAuthenticationMethodConfigurationToInitialize)
        {

            if (x509CertificateAuthenticationMethodConfigurationToInitialize != null)
            {
                if (x509CertificateAuthenticationMethodConfigurationToInitialize.IncludeTargets != null && x509CertificateAuthenticationMethodConfigurationToInitialize.IncludeTargets.CurrentPage != null)
                {
                    x509CertificateAuthenticationMethodConfigurationToInitialize.IncludeTargets.InitializeNextPageRequest(this.Client, x509CertificateAuthenticationMethodConfigurationToInitialize.IncludeTargetsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    x509CertificateAuthenticationMethodConfigurationToInitialize.IncludeTargets.AdditionalData = x509CertificateAuthenticationMethodConfigurationToInitialize.AdditionalData;
                }

            }


        }
    }
}
