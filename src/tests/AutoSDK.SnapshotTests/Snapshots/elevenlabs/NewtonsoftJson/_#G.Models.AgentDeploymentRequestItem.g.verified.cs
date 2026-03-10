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
        [global::Newtonsoft.Json.JsonProperty("branch_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BranchId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployment_strategy", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AgentDeploymentPercentageStrategy DeploymentStrategy { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentDeploymentRequestItem" /> class.
        /// </summary>
        /// <param name="branchId">
        /// ID of the branch to deploy
        /// </param>
        /// <param name="deploymentStrategy"></param>
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