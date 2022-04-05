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
    /// The type Access Package Assignment Policy.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AccessPackageAssignmentPolicy>))]
    public partial class AccessPackageAssignmentPolicy : Entity
    {
    
        /// <summary>
        /// Gets or sets allowed target scope.
        /// Principals that can be assigned the access package through this policy. The possible values are: notSpecified, specificDirectoryUsers, specificConnectedOrganizationUsers, specificDirectoryServicePrincipals, allMemberUsers, allDirectoryUsers, allDirectoryServicePrincipals, allConfiguredConnectedOrganizationUsers, allExternalUsers, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("allowedTargetScope")]
        public AllowedTargetScope? AllowedTargetScope { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// The description of the policy.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name of the policy.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets expiration.
        /// The expiration date for assignments created in this policy.
        /// </summary>
        [JsonPropertyName("expiration")]
        public ExpirationPattern Expiration { get; set; }
    
        /// <summary>
        /// Gets or sets modified date time.
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// </summary>
        [JsonPropertyName("modifiedDateTime")]
        public DateTimeOffset? ModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets request approval settings.
        /// Specifies the settings for approval of requests for an access package assignment through this policy. For example, if approval is required for new requests.
        /// </summary>
        [JsonPropertyName("requestApprovalSettings")]
        public AccessPackageAssignmentApprovalSettings RequestApprovalSettings { get; set; }
    
        /// <summary>
        /// Gets or sets requestor settings.
        /// Provides additional settings to select who can create a request for an access package assignment through this policy, and what they can include in their request.
        /// </summary>
        [JsonPropertyName("requestorSettings")]
        public AccessPackageAssignmentRequestorSettings RequestorSettings { get; set; }
    
        /// <summary>
        /// Gets or sets review settings.
        /// Settings for access reviews of assignments through this policy.
        /// </summary>
        [JsonPropertyName("reviewSettings")]
        public AccessPackageAssignmentReviewSettings ReviewSettings { get; set; }
    
        /// <summary>
        /// Gets or sets specific allowed targets.
        /// The principals that can be assigned access from an access package through this policy.
        /// </summary>
        [JsonPropertyName("specificAllowedTargets")]
        public IEnumerable<SubjectSet> SpecificAllowedTargets { get; set; }
    
        /// <summary>
        /// Gets or sets access package.
        /// Access package containing this policy. Read-only.
        /// </summary>
        [JsonPropertyName("accessPackage")]
        public AccessPackage AccessPackage { get; set; }
    
        /// <summary>
        /// Gets or sets catalog.
        /// Catalog of the access package containing this policy. Read-only.
        /// </summary>
        [JsonPropertyName("catalog")]
        public AccessPackageCatalog Catalog { get; set; }
    
    }
}

