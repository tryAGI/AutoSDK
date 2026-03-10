//HintName: G.Models.AgentDeploymentRequestItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentDeploymentRequestItem
    {
        /// <summary>
        /// ID of the branch to deploy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BranchId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_strategy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AgentDeploymentPercentageStrategy DeploymentStrategy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentDeploymentRequestItem" /> class.
        /// </summary>
        /// <param name="branchId">
        /// ID of the branch to deploy
        /// </param>
        /// <param name="deploymentStrategy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentDeploymentRequestItem(
            string branchId,
            global::G.AgentDeploymentPercentageStrategy deploymentStrategy)
        {
            this.BranchId = branchId ?? throw new global::System.ArgumentNullException(nameof(branchId));
            this.DeploymentStrategy = deploymentStrategy ?? throw new global::System.ArgumentNullException(nameof(deploymentStrategy));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentDeploymentRequestItem" /> class.
        /// </summary>
        public AgentDeploymentRequestItem()
        {
        }
    }
}