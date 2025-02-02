// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type PrintOperationStatus.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<PrintOperationStatus>))]
    public partial class PrintOperationStatus
    {

        /// <summary>
        /// Gets or sets description.
        /// A human-readable description of the printOperation's current processing state. Read-only.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// The printOperation's current processing state. Valid values are described in the following table. Read-only.
        /// </summary>
        [JsonPropertyName("state")]
        public PrintOperationProcessingState? State { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
