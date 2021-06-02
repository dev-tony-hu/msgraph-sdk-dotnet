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
    /// The type File Assessment Request.
    /// </summary>
    public partial class FileAssessmentRequestObject : ThreatAssessmentRequestObject
    {
    
        ///<summary>
        /// The FileAssessmentRequest constructor
        ///</summary>
        public FileAssessmentRequestObject()
        {
            this.ODataType = "microsoft.graph.fileAssessmentRequest";
        }

        /// <summary>
        /// Gets or sets content data.
        /// Base64 encoded file content. The file content cannot fetch back because it isn't stored.
        /// </summary>
        [JsonPropertyName("contentData")]
        public string ContentData { get; set; }
    
        /// <summary>
        /// Gets or sets file name.
        /// The file name.
        /// </summary>
        [JsonPropertyName("fileName")]
        public string FileName { get; set; }
    
    }
}

