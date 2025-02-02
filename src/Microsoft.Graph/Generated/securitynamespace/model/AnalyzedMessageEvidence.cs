// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type AnalyzedMessageEvidence.
    /// </summary>
    public partial class AnalyzedMessageEvidence : AlertEvidence
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzedMessageEvidence"/> class.
        /// </summary>
        public AnalyzedMessageEvidence()
        {
            this.ODataType = "microsoft.graph.security.analyzedMessageEvidence";
        }

        /// <summary>
        /// Gets or sets antiSpamDirection.
        /// </summary>
        [JsonPropertyName("antiSpamDirection")]
        public string AntiSpamDirection { get; set; }
    
        /// <summary>
        /// Gets or sets attachmentsCount.
        /// </summary>
        [JsonPropertyName("attachmentsCount")]
        public Int64? AttachmentsCount { get; set; }
    
        /// <summary>
        /// Gets or sets deliveryAction.
        /// </summary>
        [JsonPropertyName("deliveryAction")]
        public string DeliveryAction { get; set; }
    
        /// <summary>
        /// Gets or sets deliveryLocation.
        /// </summary>
        [JsonPropertyName("deliveryLocation")]
        public string DeliveryLocation { get; set; }
    
        /// <summary>
        /// Gets or sets internetMessageId.
        /// </summary>
        [JsonPropertyName("internetMessageId")]
        public string InternetMessageId { get; set; }
    
        /// <summary>
        /// Gets or sets language.
        /// </summary>
        [JsonPropertyName("language")]
        public string Language { get; set; }
    
        /// <summary>
        /// Gets or sets networkMessageId.
        /// </summary>
        [JsonPropertyName("networkMessageId")]
        public string NetworkMessageId { get; set; }
    
        /// <summary>
        /// Gets or sets p1Sender.
        /// </summary>
        [JsonPropertyName("p1Sender")]
        public EmailSender P1Sender { get; set; }
    
        /// <summary>
        /// Gets or sets p2Sender.
        /// </summary>
        [JsonPropertyName("p2Sender")]
        public EmailSender P2Sender { get; set; }
    
        /// <summary>
        /// Gets or sets receivedDateTime.
        /// </summary>
        [JsonPropertyName("receivedDateTime")]
        public DateTimeOffset? ReceivedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets recipientEmailAddress.
        /// </summary>
        [JsonPropertyName("recipientEmailAddress")]
        public string RecipientEmailAddress { get; set; }
    
        /// <summary>
        /// Gets or sets senderIp.
        /// </summary>
        [JsonPropertyName("senderIp")]
        public string SenderIp { get; set; }
    
        /// <summary>
        /// Gets or sets subject.
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }
    
        /// <summary>
        /// Gets or sets threatDetectionMethods.
        /// </summary>
        [JsonPropertyName("threatDetectionMethods")]
        public IEnumerable<string> ThreatDetectionMethods { get; set; }
    
        /// <summary>
        /// Gets or sets threats.
        /// </summary>
        [JsonPropertyName("threats")]
        public IEnumerable<string> Threats { get; set; }
    
        /// <summary>
        /// Gets or sets urlCount.
        /// </summary>
        [JsonPropertyName("urlCount")]
        public Int64? UrlCount { get; set; }
    
        /// <summary>
        /// Gets or sets urls.
        /// </summary>
        [JsonPropertyName("urls")]
        public IEnumerable<string> Urls { get; set; }
    
        /// <summary>
        /// Gets or sets urn.
        /// </summary>
        [JsonPropertyName("urn")]
        public string Urn { get; set; }
    
    }
}
