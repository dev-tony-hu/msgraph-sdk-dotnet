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
    /// The type Windows10CompliancePolicyRequest.
    /// </summary>
    public partial class Windows10CompliancePolicyRequest : BaseRequest, IWindows10CompliancePolicyRequest
    {
        /// <summary>
        /// Constructs a new Windows10CompliancePolicyRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public Windows10CompliancePolicyRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Windows10CompliancePolicy using POST.
        /// </summary>
        /// <param name="windows10CompliancePolicyToCreate">The Windows10CompliancePolicy to create.</param>
        /// <returns>The created Windows10CompliancePolicy.</returns>
        public System.Threading.Tasks.Task<Windows10CompliancePolicy> CreateAsync(Windows10CompliancePolicy windows10CompliancePolicyToCreate)
        {
            return this.CreateAsync(windows10CompliancePolicyToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Windows10CompliancePolicy using POST.
        /// </summary>
        /// <param name="windows10CompliancePolicyToCreate">The Windows10CompliancePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Windows10CompliancePolicy.</returns>
        public async System.Threading.Tasks.Task<Windows10CompliancePolicy> CreateAsync(Windows10CompliancePolicy windows10CompliancePolicyToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Windows10CompliancePolicy>(windows10CompliancePolicyToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified Windows10CompliancePolicy.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Windows10CompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Windows10CompliancePolicy>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Windows10CompliancePolicy.
        /// </summary>
        /// <returns>The Windows10CompliancePolicy.</returns>
        public System.Threading.Tasks.Task<Windows10CompliancePolicy> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Windows10CompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Windows10CompliancePolicy.</returns>
        public async System.Threading.Tasks.Task<Windows10CompliancePolicy> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Windows10CompliancePolicy>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified Windows10CompliancePolicy using PATCH.
        /// </summary>
        /// <param name="windows10CompliancePolicyToUpdate">The Windows10CompliancePolicy to update.</param>
        /// <returns>The updated Windows10CompliancePolicy.</returns>
        public System.Threading.Tasks.Task<Windows10CompliancePolicy> UpdateAsync(Windows10CompliancePolicy windows10CompliancePolicyToUpdate)
        {
            return this.UpdateAsync(windows10CompliancePolicyToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Windows10CompliancePolicy using PATCH.
        /// </summary>
        /// <param name="windows10CompliancePolicyToUpdate">The Windows10CompliancePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Windows10CompliancePolicy.</returns>
        public async System.Threading.Tasks.Task<Windows10CompliancePolicy> UpdateAsync(Windows10CompliancePolicy windows10CompliancePolicyToUpdate, CancellationToken cancellationToken)
        {
			if (windows10CompliancePolicyToUpdate.AdditionalData != null)
			{
				if (windows10CompliancePolicyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					windows10CompliancePolicyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, windows10CompliancePolicyToUpdate.GetType().Name)
						});
				}
			}
            if (windows10CompliancePolicyToUpdate.AdditionalData != null)
            {
                if (windows10CompliancePolicyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    windows10CompliancePolicyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, windows10CompliancePolicyToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Windows10CompliancePolicy>(windows10CompliancePolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindows10CompliancePolicyRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindows10CompliancePolicyRequest Expand(Expression<Func<Windows10CompliancePolicy, object>> expandExpression)
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
        public IWindows10CompliancePolicyRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWindows10CompliancePolicyRequest Select(Expression<Func<Windows10CompliancePolicy, object>> selectExpression)
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
        /// <param name="windows10CompliancePolicyToInitialize">The <see cref="Windows10CompliancePolicy"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Windows10CompliancePolicy windows10CompliancePolicyToInitialize)
        {

        }
    }
}
