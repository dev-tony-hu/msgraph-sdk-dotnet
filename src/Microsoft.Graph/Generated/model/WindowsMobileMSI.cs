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
    /// The type Windows Mobile MSI.
    /// </summary>
    public partial class WindowsMobileMSI : MobileLobApp
    {
    
        ///<summary>
        /// The WindowsMobileMSI constructor
        ///</summary>
        public WindowsMobileMSI()
        {
            this.ODataType = "microsoft.graph.windowsMobileMSI";
        }

        /// <summary>
        /// Gets or sets command line.
        /// The command line.
        /// </summary>
        [JsonPropertyName("commandLine")]
        public string CommandLine { get; set; }
    
        /// <summary>
        /// Gets or sets ignore version detection.
        /// A boolean to control whether the app's version will be used to detect the app after it is installed on a device. Set this to true for Windows Mobile MSI Line of Business (LoB) apps that use a self update feature.
        /// </summary>
        [JsonPropertyName("ignoreVersionDetection")]
        public bool? IgnoreVersionDetection { get; set; }
    
        /// <summary>
        /// Gets or sets product code.
        /// The product code.
        /// </summary>
        [JsonPropertyName("productCode")]
        public string ProductCode { get; set; }
    
        /// <summary>
        /// Gets or sets product version.
        /// The product version of Windows Mobile MSI Line of Business (LoB) app.
        /// </summary>
        [JsonPropertyName("productVersion")]
        public string ProductVersion { get; set; }
    
    }
}

