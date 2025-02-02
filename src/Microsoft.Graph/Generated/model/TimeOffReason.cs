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
    /// The type Time Off Reason.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<TimeOffReason>))]
    public partial class TimeOffReason : ChangeTrackedEntity
    {
    
        ///<summary>
        /// The TimeOffReason constructor
        ///</summary>
        public TimeOffReason()
        {
            this.ODataType = "microsoft.graph.timeOffReason";
        }

        /// <summary>
        /// Gets or sets display name.
        /// The name of the timeOffReason. Required.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets icon type.
        /// Supported icon types are: none, car, calendar, running, plane, firstAid, doctor, notWorking, clock, juryDuty, globe, cup, phone, weather, umbrella, piggyBank, dog, cake, trafficCone, pin, sunny. Required.
        /// </summary>
        [JsonPropertyName("iconType")]
        public TimeOffReasonIconType? IconType { get; set; }
    
        /// <summary>
        /// Gets or sets is active.
        /// Indicates whether the timeOffReason can be used when creating new entities or updating existing ones. Required.
        /// </summary>
        [JsonPropertyName("isActive")]
        public bool? IsActive { get; set; }
    
    }
}

