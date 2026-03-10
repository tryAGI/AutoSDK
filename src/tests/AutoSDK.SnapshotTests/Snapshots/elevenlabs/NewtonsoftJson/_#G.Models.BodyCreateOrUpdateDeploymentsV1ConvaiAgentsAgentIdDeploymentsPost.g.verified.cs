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
        [global::Newtonsoft.Json.JsonProperty("deployment_request", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AgentDeploymentRequest DeploymentRequest { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateOrUpdateDeploymentsV1ConvaiAgentsAgentIdDeploymentsPost" /> class.
        /// </summary>
        /// <param name="deploymentRequest">
        /// Request to create a new deployment
        /// </param>
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