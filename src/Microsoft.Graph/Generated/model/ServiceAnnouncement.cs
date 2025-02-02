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
    /// The type Service Announcement.
    /// </summary>
    public partial class ServiceAnnouncement : Entity
    {
    
        /// <summary>
        /// Gets or sets health overviews.
        /// A collection of service health information for tenant. This property is a contained navigation property, it is nullable and readonly.
        /// </summary>
        [JsonPropertyName("healthOverviews")]
        public IServiceAnnouncementHealthOverviewsCollectionPage HealthOverviews { get; set; }

        /// <summary>
        /// Gets or sets healthOverviewsNextLink.
        /// </summary>
        [JsonPropertyName("healthOverviews@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string HealthOverviewsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets issues.
        /// A collection of service issues for tenant. This property is a contained navigation property, it is nullable and readonly.
        /// </summary>
        [JsonPropertyName("issues")]
        public IServiceAnnouncementIssuesCollectionPage Issues { get; set; }

        /// <summary>
        /// Gets or sets issuesNextLink.
        /// </summary>
        [JsonPropertyName("issues@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string IssuesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets messages.
        /// A collection of service messages for tenant. This property is a contained navigation property, it is nullable and readonly.
        /// </summary>
        [JsonPropertyName("messages")]
        public IServiceAnnouncementMessagesCollectionPage Messages { get; set; }

        /// <summary>
        /// Gets or sets messagesNextLink.
        /// </summary>
        [JsonPropertyName("messages@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string MessagesNextLink { get; set; }
    
    }
}

