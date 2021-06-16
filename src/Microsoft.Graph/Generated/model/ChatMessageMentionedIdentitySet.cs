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
    /// The type ChatMessageMentionedIdentitySet.
    /// </summary>
    public partial class ChatMessageMentionedIdentitySet : IdentitySet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageMentionedIdentitySet"/> class.
        /// </summary>
        public ChatMessageMentionedIdentitySet()
        {
            this.ODataType = "microsoft.graph.chatMessageMentionedIdentitySet";
        }

        /// <summary>
        /// Gets or sets conversation.
        /// </summary>
        [JsonPropertyName("conversation")]
        public TeamworkConversationIdentity Conversation { get; set; }
    
    }
}
