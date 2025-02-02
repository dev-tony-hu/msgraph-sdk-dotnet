// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Saml Or Ws Fed External Domain Federation.
    /// </summary>
    public partial class SamlOrWsFedExternalDomainFederation : SamlOrWsFedProvider
    {
    
        ///<summary>
        /// The SamlOrWsFedExternalDomainFederation constructor
        ///</summary>
        public SamlOrWsFedExternalDomainFederation()
        {
            this.ODataType = "microsoft.graph.samlOrWsFedExternalDomainFederation";
        }

        /// <summary>
        /// Gets or sets domains.
        /// Collection of domain names of the external organizations that the tenant is federating with. Supports $filter (eq).
        /// </summary>
        [JsonPropertyName("domains")]
        public ISamlOrWsFedExternalDomainFederationDomainsCollectionPage Domains { get; set; }

        /// <summary>
        /// Gets or sets domainsNextLink.
        /// </summary>
        [JsonPropertyName("domains@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DomainsNextLink { get; set; }
    
    }
}

