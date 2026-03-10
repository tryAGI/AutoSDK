//HintName: G.Models.BodyCreateOrUpdateDeploymentsV1ConvaiAgentsAgentIdDeploymentsPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateOrUpdateDeploymentsV1ConvaiAgentsAgentIdDeploymentsPost
    {
        /// <summary>
        /// Request to create a new deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AgentDeploymentRequest DeploymentRequest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateOrUpdateDeploymentsV1ConvaiAgentsAgentIdDeploymentsPost" /> class.
        /// </summary>
        /// <param name="deploymentRequest">
        /// Request to create a new deployment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCreateOrUpdateDeploymentsV1ConvaiAgentsAgentIdDeploymentsPost(
            global::G.AgentDeploymentRequest deploymentRequest)
        {
            this.DeploymentRequest = deploymentRequest ?? throw new global::System.ArgumentNullException(nameof(deploymentRequest));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateOrUpdateDeploymentsV1ConvaiAgentsAgentIdDeploymentsPost" /> class.
        /// </summary>
        public BodyCreateOrUpdateDeploymentsV1ConvaiAgentsAgentIdDeploymentsPost()
        {
        }
    }
}