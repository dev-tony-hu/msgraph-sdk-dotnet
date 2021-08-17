// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph.TermStore
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type RelationRequestBuilder.
    /// </summary>
    public partial class RelationRequestBuilder : Microsoft.Graph.EntityRequestBuilder, IRelationRequestBuilder
    {

        /// <summary>
        /// Constructs a new RelationRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public RelationRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IRelationRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IRelationRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new RelationRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for FromTerm.
        /// </summary>
        /// <returns>The <see cref="ITermWithReferenceRequestBuilder"/>.</returns>
        public ITermWithReferenceRequestBuilder FromTerm
        {
            get
            {
                return new TermWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("fromTerm"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Set.
        /// </summary>
        /// <returns>The <see cref="ISetWithReferenceRequestBuilder"/>.</returns>
        public ISetWithReferenceRequestBuilder Set
        {
            get
            {
                return new SetWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("set"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ToTerm.
        /// </summary>
        /// <returns>The <see cref="ITermWithReferenceRequestBuilder"/>.</returns>
        public ITermWithReferenceRequestBuilder ToTerm
        {
            get
            {
                return new TermWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("toTerm"), this.Client);
            }
        }
    
    }
}
