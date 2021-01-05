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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Drive.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Drive : BaseItem
    {
    
		///<summary>
		/// The Drive constructor
		///</summary>
        public Drive()
        {
            this.ODataType = "microsoft.graph.drive";
        }
	
        /// <summary>
        /// Gets or sets drive type.
        /// Describes the type of drive represented by this resource. OneDrive personal drives will return personal. OneDrive for Business will return business. SharePoint document libraries will return documentLibrary. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "driveType", Required = Newtonsoft.Json.Required.Default)]
        public string DriveType { get; set; }
    
        /// <summary>
        /// Gets or sets owner.
        /// Optional. The user account that owns the drive. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "owner", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet Owner { get; set; }
    
        /// <summary>
        /// Gets or sets quota.
        /// Optional. Information about the drive's storage space quota. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "quota", Required = Newtonsoft.Json.Required.Default)]
        public Quota Quota { get; set; }
    
        /// <summary>
        /// Gets or sets share point ids.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sharePointIds", Required = Newtonsoft.Json.Required.Default)]
        public SharepointIds SharePointIds { get; set; }
    
        /// <summary>
        /// Gets or sets system.
        /// If present, indicates that this is a system-managed drive. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "system", Required = Newtonsoft.Json.Required.Default)]
        public SystemFacet System { get; set; }
    
        /// <summary>
        /// Gets or sets following.
        /// The list of items the user is following. Only in OneDrive for Business.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "following", Required = Newtonsoft.Json.Required.Default)]
        public IDriveFollowingCollectionPage Following { get; set; }
    
        /// <summary>
        /// Gets or sets items.
        /// All items contained in the drive. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "items", Required = Newtonsoft.Json.Required.Default)]
        public IDriveItemsCollectionPage Items { get; set; }
    
        /// <summary>
        /// Gets or sets list.
        /// For drives in SharePoint, the underlying document library list. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "list", Required = Newtonsoft.Json.Required.Default)]
        public List List { get; set; }
    
        /// <summary>
        /// Gets or sets root.
        /// The root folder of the drive. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "root", Required = Newtonsoft.Json.Required.Default)]
        public DriveItem Root { get; set; }
    
        /// <summary>
        /// Gets or sets special.
        /// Collection of common folders available in OneDrive. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "special", Required = Newtonsoft.Json.Required.Default)]
        public IDriveSpecialCollectionPage Special { get; set; }
    
    }
}

