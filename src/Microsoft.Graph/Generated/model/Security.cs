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
    /// The type Security.
    /// </summary>
    public partial class Security : Entity
    {
    
        /// <summary>
        /// Gets or sets cases.
        /// </summary>
        [JsonPropertyName("cases")]
        public Microsoft.Graph.SecurityNamespace.CasesRoot Cases { get; set; }
    
        /// <summary>
        /// Gets or sets alerts_v2.
        /// </summary>
        [JsonPropertyName("alerts_v2")]
        public ISecurityAlerts_v2CollectionPage Alerts_v2 { get; set; }

        /// <summary>
        /// Gets or sets alerts_v2NextLink.
        /// </summary>
        [JsonPropertyName("alerts_v2@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string Alerts_v2NextLink { get; set; }
    
        /// <summary>
        /// Gets or sets incidents.
        /// </summary>
        [JsonPropertyName("incidents")]
        public ISecurityIncidentsCollectionPage Incidents { get; set; }

        /// <summary>
        /// Gets or sets incidentsNextLink.
        /// </summary>
        [JsonPropertyName("incidents@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string IncidentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets attack simulation.
        /// </summary>
        [JsonPropertyName("attackSimulation")]
        public AttackSimulationRoot AttackSimulation { get; set; }
    
        /// <summary>
        /// Gets or sets alerts.
        /// </summary>
        [JsonPropertyName("alerts")]
        public ISecurityAlertsCollectionPage Alerts { get; set; }

        /// <summary>
        /// Gets or sets alertsNextLink.
        /// </summary>
        [JsonPropertyName("alerts@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AlertsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets secure score control profiles.
        /// </summary>
        [JsonPropertyName("secureScoreControlProfiles")]
        public ISecuritySecureScoreControlProfilesCollectionPage SecureScoreControlProfiles { get; set; }

        /// <summary>
        /// Gets or sets secureScoreControlProfilesNextLink.
        /// </summary>
        [JsonPropertyName("secureScoreControlProfiles@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string SecureScoreControlProfilesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets secure scores.
        /// </summary>
        [JsonPropertyName("secureScores")]
        public ISecuritySecureScoresCollectionPage SecureScores { get; set; }

        /// <summary>
        /// Gets or sets secureScoresNextLink.
        /// </summary>
        [JsonPropertyName("secureScores@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string SecureScoresNextLink { get; set; }
    
    }
}

