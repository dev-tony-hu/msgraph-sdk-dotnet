// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionWithReferencesPage.cs.tt

namespace Microsoft.Graph
{
    using System;

    /// <summary>
    /// The type ApplicationOwnersCollectionWithReferencesPage.
    /// </summary>
    public partial class ApplicationOwnersCollectionWithReferencesPage : CollectionPage<DirectoryObject>, IApplicationOwnersCollectionWithReferencesPage
    {
        /// <summary>
        /// Gets the next page <see cref="IApplicationOwnersCollectionWithReferencesRequest"/> instance.
        /// </summary>
        public IApplicationOwnersCollectionWithReferencesRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new ApplicationOwnersCollectionWithReferencesRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
