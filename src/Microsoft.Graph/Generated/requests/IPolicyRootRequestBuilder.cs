// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IPolicyRootRequestBuilder.
    /// </summary>
    public partial interface IPolicyRootRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IPolicyRootRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IPolicyRootRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for AuthenticationMethodsPolicy.
        /// </summary>
        /// <returns>The <see cref="IAuthenticationMethodsPolicyRequestBuilder"/>.</returns>
        IAuthenticationMethodsPolicyRequestBuilder AuthenticationMethodsPolicy { get; }

        /// <summary>
        /// Gets the request builder for AuthenticationFlowsPolicy.
        /// </summary>
        /// <returns>The <see cref="IAuthenticationFlowsPolicyRequestBuilder"/>.</returns>
        IAuthenticationFlowsPolicyRequestBuilder AuthenticationFlowsPolicy { get; }

        /// <summary>
        /// Gets the request builder for ActivityBasedTimeoutPolicies.
        /// </summary>
        /// <returns>The <see cref="IPolicyRootActivityBasedTimeoutPoliciesCollectionRequestBuilder"/>.</returns>
        IPolicyRootActivityBasedTimeoutPoliciesCollectionRequestBuilder ActivityBasedTimeoutPolicies { get; }

        /// <summary>
        /// Gets the request builder for AuthorizationPolicy.
        /// </summary>
        /// <returns>The <see cref="IAuthorizationPolicyRequestBuilder"/>.</returns>
        IAuthorizationPolicyRequestBuilder AuthorizationPolicy { get; }

        /// <summary>
        /// Gets the request builder for ClaimsMappingPolicies.
        /// </summary>
        /// <returns>The <see cref="IPolicyRootClaimsMappingPoliciesCollectionRequestBuilder"/>.</returns>
        IPolicyRootClaimsMappingPoliciesCollectionRequestBuilder ClaimsMappingPolicies { get; }

        /// <summary>
        /// Gets the request builder for CrossTenantAccessPolicy.
        /// </summary>
        /// <returns>The <see cref="ICrossTenantAccessPolicyRequestBuilder"/>.</returns>
        ICrossTenantAccessPolicyRequestBuilder CrossTenantAccessPolicy { get; }

        /// <summary>
        /// Gets the request builder for HomeRealmDiscoveryPolicies.
        /// </summary>
        /// <returns>The <see cref="IPolicyRootHomeRealmDiscoveryPoliciesCollectionRequestBuilder"/>.</returns>
        IPolicyRootHomeRealmDiscoveryPoliciesCollectionRequestBuilder HomeRealmDiscoveryPolicies { get; }

        /// <summary>
        /// Gets the request builder for PermissionGrantPolicies.
        /// </summary>
        /// <returns>The <see cref="IPolicyRootPermissionGrantPoliciesCollectionRequestBuilder"/>.</returns>
        IPolicyRootPermissionGrantPoliciesCollectionRequestBuilder PermissionGrantPolicies { get; }

        /// <summary>
        /// Gets the request builder for TokenIssuancePolicies.
        /// </summary>
        /// <returns>The <see cref="IPolicyRootTokenIssuancePoliciesCollectionRequestBuilder"/>.</returns>
        IPolicyRootTokenIssuancePoliciesCollectionRequestBuilder TokenIssuancePolicies { get; }

        /// <summary>
        /// Gets the request builder for TokenLifetimePolicies.
        /// </summary>
        /// <returns>The <see cref="IPolicyRootTokenLifetimePoliciesCollectionRequestBuilder"/>.</returns>
        IPolicyRootTokenLifetimePoliciesCollectionRequestBuilder TokenLifetimePolicies { get; }

        /// <summary>
        /// Gets the request builder for FeatureRolloutPolicies.
        /// </summary>
        /// <returns>The <see cref="IPolicyRootFeatureRolloutPoliciesCollectionRequestBuilder"/>.</returns>
        IPolicyRootFeatureRolloutPoliciesCollectionRequestBuilder FeatureRolloutPolicies { get; }

        /// <summary>
        /// Gets the request builder for AdminConsentRequestPolicy.
        /// </summary>
        /// <returns>The <see cref="IAdminConsentRequestPolicyRequestBuilder"/>.</returns>
        IAdminConsentRequestPolicyRequestBuilder AdminConsentRequestPolicy { get; }

        /// <summary>
        /// Gets the request builder for ConditionalAccessPolicies.
        /// </summary>
        /// <returns>The <see cref="IPolicyRootConditionalAccessPoliciesCollectionRequestBuilder"/>.</returns>
        IPolicyRootConditionalAccessPoliciesCollectionRequestBuilder ConditionalAccessPolicies { get; }

        /// <summary>
        /// Gets the request builder for IdentitySecurityDefaultsEnforcementPolicy.
        /// </summary>
        /// <returns>The <see cref="IIdentitySecurityDefaultsEnforcementPolicyRequestBuilder"/>.</returns>
        IIdentitySecurityDefaultsEnforcementPolicyRequestBuilder IdentitySecurityDefaultsEnforcementPolicy { get; }

        /// <summary>
        /// Gets the request builder for RoleManagementPolicies.
        /// </summary>
        /// <returns>The <see cref="IPolicyRootRoleManagementPoliciesCollectionRequestBuilder"/>.</returns>
        IPolicyRootRoleManagementPoliciesCollectionRequestBuilder RoleManagementPolicies { get; }

        /// <summary>
        /// Gets the request builder for RoleManagementPolicyAssignments.
        /// </summary>
        /// <returns>The <see cref="IPolicyRootRoleManagementPolicyAssignmentsCollectionRequestBuilder"/>.</returns>
        IPolicyRootRoleManagementPolicyAssignmentsCollectionRequestBuilder RoleManagementPolicyAssignments { get; }
    
    }
}
