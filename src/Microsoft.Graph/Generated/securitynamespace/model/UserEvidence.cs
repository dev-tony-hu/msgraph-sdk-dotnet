// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type UserEvidence.
    /// </summary>
    public partial class UserEvidence : AlertEvidence
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserEvidence"/> class.
        /// </summary>
        public UserEvidence()
        {
            this.ODataType = "microsoft.graph.security.userEvidence";
        }

        /// <summary>
        /// Gets or sets userAccount.
        /// </summary>
        [JsonPropertyName("userAccount")]
        public UserAccount UserAccount { get; set; }
    
    }
}
