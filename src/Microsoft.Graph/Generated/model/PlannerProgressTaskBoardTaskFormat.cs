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
    /// The type Planner Progress Task Board Task Format.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PlannerProgressTaskBoardTaskFormat : Entity
    {
    
		///<summary>
		/// The PlannerProgressTaskBoardTaskFormat constructor
		///</summary>
        public PlannerProgressTaskBoardTaskFormat()
        {
            this.ODataType = "microsoft.graph.plannerProgressTaskBoardTaskFormat";
        }
	
        /// <summary>
        /// Gets or sets order hint.
        /// Hint value used to order the task on the Progress view of the Task Board. The format is defined as outlined here.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "orderHint", Required = Newtonsoft.Json.Required.Default)]
        public string OrderHint { get; set; }
    
    }
}

