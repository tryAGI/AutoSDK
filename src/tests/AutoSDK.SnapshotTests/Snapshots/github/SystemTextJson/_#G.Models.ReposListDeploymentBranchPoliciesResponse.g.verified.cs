//HintName: G.Models.ReposListDeploymentBranchPoliciesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposListDeploymentBranchPoliciesResponse
    {
        /// <summary>
        /// The number of deployment branch policies for the environment.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_policies")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.DeploymentBranchPolicy> BranchPolicies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposListDeploymentBranchPoliciesResponse" /> class.
        /// </summary>
        /// <param name="totalCount">
        /// The number of deployment branch policies for the environment.<br/>
        /// Example: 2
        /// </param>
        /// <param name="branchPolicies"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReposListDeploymentBranchPoliciesResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::G.DeploymentBranchPolicy> branchPolicies)
        {
            this.TotalCount = totalCount;
            this.BranchPolicies = branchPolicies ?? throw new global::System.ArgumentNullException(nameof(branchPolicies));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposListDeploymentBranchPoliciesResponse" /> class.
        /// </summary>
        public ReposListDeploymentBranchPoliciesResponse()
        {
        }
    }
}