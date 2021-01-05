// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type Windows10SecureAssessmentConfigurationRequestBuilder.
    /// </summary>
    public partial class Windows10SecureAssessmentConfigurationRequestBuilder : DeviceConfigurationRequestBuilder, IWindows10SecureAssessmentConfigurationRequestBuilder
    {

        /// <summary>
        /// Constructs a new Windows10SecureAssessmentConfigurationRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public Windows10SecureAssessmentConfigurationRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IWindows10SecureAssessmentConfigurationRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IWindows10SecureAssessmentConfigurationRequest Request(IEnumerable<Option> options)
        {
            return new Windows10SecureAssessmentConfigurationRequest(this.RequestUrl, this.Client, options);
        }
    
    }
}
