//HintName: G.Models.TemplatesCreateAgentsFromTemplateNoProjectResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing created agent IDs and associated metadata
    /// </summary>
    public sealed partial class TemplatesCreateAgentsFromTemplateNoProjectResponse
    {
        /// <summary>
        /// Array of created agent IDs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AgentIds { get; set; }

        /// <summary>
        /// Optional group ID if agents were created in a group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public string? GroupId { get; set; }

        /// <summary>
        /// The deployment ID for the created agents
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesCreateAgentsFromTemplateNoProjectResponse" /> class.
        /// </summary>
        /// <param name="agentIds">
        /// Array of created agent IDs
        /// </param>
        /// <param name="deploymentId">
        /// The deployment ID for the created agents
        /// </param>
        /// <param name="groupId">
        /// Optional group ID if agents were created in a group
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplatesCreateAgentsFromTemplateNoProjectResponse(
            global::System.Collections.Generic.IList<string> agentIds,
            string deploymentId,
            string? groupId)
        {
            this.AgentIds = agentIds ?? throw new global::System.ArgumentNullException(nameof(agentIds));
            this.GroupId = groupId;
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesCreateAgentsFromTemplateNoProjectResponse" /> class.
        /// </summary>
        public TemplatesCreateAgentsFromTemplateNoProjectResponse()
        {
        }
    }
}