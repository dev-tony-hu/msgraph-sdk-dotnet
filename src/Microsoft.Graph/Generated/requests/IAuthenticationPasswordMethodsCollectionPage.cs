// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionPage.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The interface IAuthenticationPasswordMethodsCollectionPage.
    /// </summary>
    [InterfaceConverter(typeof(InterfaceConverter<AuthenticationPasswordMethodsCollectionPage>))]
    public interface IAuthenticationPasswordMethodsCollectionPage : ICollectionPage<PasswordAuthenticationMethod>
    {
        /// <summary>
        /// Gets the next page <see cref="IAuthenticationPasswordMethodsCollectionRequest"/> instance.
        /// </summary>
        IAuthenticationPasswordMethodsCollectionRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
