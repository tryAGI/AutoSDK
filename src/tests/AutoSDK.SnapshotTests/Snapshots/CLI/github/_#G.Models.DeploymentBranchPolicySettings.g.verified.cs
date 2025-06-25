﻿//HintName: G.Models.DeploymentBranchPolicySettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of deployment branch policy for this environment. To allow all branches to deploy, set to `null`.
    /// </summary>
    public sealed partial class DeploymentBranchPolicySettings
    {
        /// <summary>
        /// Whether only branches with branch protection rules can deploy to this environment. If `protected_branches` is `true`, `custom_branch_policies` must be `false`; if `protected_branches` is `false`, `custom_branch_policies` must be `true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protected_branches")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ProtectedBranches { get; set; }

        /// <summary>
        /// Whether only branches that match the specified name patterns can deploy to this environment.  If `custom_branch_policies` is `true`, `protected_branches` must be `false`; if `custom_branch_policies` is `false`, `protected_branches` must be `true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_branch_policies")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CustomBranchPolicies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentBranchPolicySettings" /> class.
        /// </summary>
        /// <param name="protectedBranches">
        /// Whether only branches with branch protection rules can deploy to this environment. If `protected_branches` is `true`, `custom_branch_policies` must be `false`; if `protected_branches` is `false`, `custom_branch_policies` must be `true`.
        /// </param>
        /// <param name="customBranchPolicies">
        /// Whether only branches that match the specified name patterns can deploy to this environment.  If `custom_branch_policies` is `true`, `protected_branches` must be `false`; if `custom_branch_policies` is `false`, `protected_branches` must be `true`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentBranchPolicySettings(
            bool protectedBranches,
            bool customBranchPolicies)
        {
            this.ProtectedBranches = protectedBranches;
            this.CustomBranchPolicies = customBranchPolicies;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentBranchPolicySettings" /> class.
        /// </summary>
        public DeploymentBranchPolicySettings()
        {
        }
    }
}