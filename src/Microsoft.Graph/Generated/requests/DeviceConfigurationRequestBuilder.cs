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
    /// The type DeviceConfigurationRequestBuilder.
    /// </summary>
    public partial class DeviceConfigurationRequestBuilder : EntityRequestBuilder, IDeviceConfigurationRequestBuilder
    {

        /// <summary>
        /// Constructs a new DeviceConfigurationRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceConfigurationRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IDeviceConfigurationRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IDeviceConfigurationRequest Request(IEnumerable<Option> options)
        {
            return new DeviceConfigurationRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Assignments.
        /// </summary>
        /// <returns>The <see cref="IDeviceConfigurationAssignmentsCollectionRequestBuilder"/>.</returns>
        public IDeviceConfigurationAssignmentsCollectionRequestBuilder Assignments
        {
            get
            {
                return new DeviceConfigurationAssignmentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("assignments"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DeviceSettingStateSummaries.
        /// </summary>
        /// <returns>The <see cref="IDeviceConfigurationDeviceSettingStateSummariesCollectionRequestBuilder"/>.</returns>
        public IDeviceConfigurationDeviceSettingStateSummariesCollectionRequestBuilder DeviceSettingStateSummaries
        {
            get
            {
                return new DeviceConfigurationDeviceSettingStateSummariesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("deviceSettingStateSummaries"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DeviceStatuses.
        /// </summary>
        /// <returns>The <see cref="IDeviceConfigurationDeviceStatusesCollectionRequestBuilder"/>.</returns>
        public IDeviceConfigurationDeviceStatusesCollectionRequestBuilder DeviceStatuses
        {
            get
            {
                return new DeviceConfigurationDeviceStatusesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("deviceStatuses"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DeviceStatusOverview.
        /// </summary>
        /// <returns>The <see cref="IDeviceConfigurationDeviceOverviewRequestBuilder"/>.</returns>
        public IDeviceConfigurationDeviceOverviewRequestBuilder DeviceStatusOverview
        {
            get
            {
                return new DeviceConfigurationDeviceOverviewRequestBuilder(this.AppendSegmentToRequestUrl("deviceStatusOverview"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for UserStatuses.
        /// </summary>
        /// <returns>The <see cref="IDeviceConfigurationUserStatusesCollectionRequestBuilder"/>.</returns>
        public IDeviceConfigurationUserStatusesCollectionRequestBuilder UserStatuses
        {
            get
            {
                return new DeviceConfigurationUserStatusesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("userStatuses"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for UserStatusOverview.
        /// </summary>
        /// <returns>The <see cref="IDeviceConfigurationUserOverviewRequestBuilder"/>.</returns>
        public IDeviceConfigurationUserOverviewRequestBuilder UserStatusOverview
        {
            get
            {
                return new DeviceConfigurationUserOverviewRequestBuilder(this.AppendSegmentToRequestUrl("userStatusOverview"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for DeviceConfigurationAssign.
        /// </summary>
        /// <returns>The <see cref="IDeviceConfigurationAssignRequestBuilder"/>.</returns>
        public IDeviceConfigurationAssignRequestBuilder Assign(
            IEnumerable<DeviceConfigurationAssignment> assignments = null)
        {
            return new DeviceConfigurationAssignRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.assign"),
                this.Client,
                assignments);
        }

        /// <summary>
        /// Gets the request builder for DeviceConfigurationGetOmaSettingPlainTextValue.
        /// </summary>
        /// <returns>The <see cref="IDeviceConfigurationGetOmaSettingPlainTextValueRequestBuilder"/>.</returns>
        public IDeviceConfigurationGetOmaSettingPlainTextValueRequestBuilder GetOmaSettingPlainTextValue(
            string secretReferenceValueId = null)
        {
            return new DeviceConfigurationGetOmaSettingPlainTextValueRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getOmaSettingPlainTextValue"),
                this.Client,
                secretReferenceValueId);
        }
    
    }
}
