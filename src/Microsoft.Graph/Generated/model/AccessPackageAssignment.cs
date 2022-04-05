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
    /// The type Access Package Assignment.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AccessPackageAssignment>))]
    public partial class AccessPackageAssignment : Entity
    {
    
        /// <summary>
        /// Gets or sets expired date time.
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// </summary>
        [JsonPropertyName("expiredDateTime")]
        public DateTimeOffset? ExpiredDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets schedule.
        /// When the access assignment is to be in place. Read-only.
        /// </summary>
        [JsonPropertyName("schedule")]
        public EntitlementManagementSchedule Schedule { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// The state of the access package assignment. The possible values are: delivering, partiallyDelivered, delivered, expired, deliveryFailed, unknownFutureValue. Read-only. Supports $filter (eq).
        /// </summary>
        [JsonPropertyName("state")]
        public AccessPackageAssignmentState? State { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// More information about the assignment lifecycle.  Possible values include Delivering, Delivered, NearExpiry1DayNotificationTriggered, or ExpiredNotificationTriggered.  Read-only.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or sets access package.
        /// Read-only. Nullable. Supports $filter (eq) on the id property and $expand query parameters.
        /// </summary>
        [JsonPropertyName("accessPackage")]
        public AccessPackage AccessPackage { get; set; }
    
        /// <summary>
        /// Gets or sets assignment policy.
        /// Read-only. Supports $filter (eq) on the id property and $expand query parameters.
        /// </summary>
        [JsonPropertyName("assignmentPolicy")]
        public AccessPackageAssignmentPolicy AssignmentPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets target.
        /// The subject of the access package assignment. Read-only. Nullable. Supports $expand. Supports $filter (eq) on objectId.
        /// </summary>
        [JsonPropertyName("target")]
        public AccessPackageSubject Target { get; set; }
    
    }
}

