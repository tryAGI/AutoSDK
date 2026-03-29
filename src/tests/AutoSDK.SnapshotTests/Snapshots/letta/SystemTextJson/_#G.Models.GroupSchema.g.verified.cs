//HintName: G.Models.GroupSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Group with human-readable ID for agent file
    /// </summary>
    public sealed partial class GroupSchema
    {
        /// <summary>
        /// List of agent IDs in this group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AgentIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Default Value: {"manager_type":"round_robin"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manager_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ManagerConfig2JsonConverter))]
        public global::G.ManagerConfig2? ManagerConfig { get; set; }

        /// <summary>
        /// The associated project id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// List of shared block IDs<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shared_block_ids")]
        public global::System.Collections.Generic.IList<string>? SharedBlockIds { get; set; }

        /// <summary>
        /// If set to True, the group will be hidden.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hidden")]
        public bool? Hidden { get; set; }

        /// <summary>
        /// Human-readable identifier for this group in the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupSchema" /> class.
        /// </summary>
        /// <param name="agentIds">
        /// List of agent IDs in this group
        /// </param>
        /// <param name="description"></param>
        /// <param name="id">
        /// Human-readable identifier for this group in the file
        /// </param>
        /// <param name="managerConfig">
        /// Default Value: {"manager_type":"round_robin"}
        /// </param>
        /// <param name="projectId">
        /// The associated project id.
        /// </param>
        /// <param name="sharedBlockIds">
        /// List of shared block IDs<br/>
        /// Default Value: []
        /// </param>
        /// <param name="hidden">
        /// If set to True, the group will be hidden.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroupSchema(
            global::System.Collections.Generic.IList<string> agentIds,
            string description,
            string id,
            global::G.ManagerConfig2? managerConfig,
            string? projectId,
            global::System.Collections.Generic.IList<string>? sharedBlockIds,
            bool? hidden)
        {
            this.AgentIds = agentIds ?? throw new global::System.ArgumentNullException(nameof(agentIds));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ManagerConfig = managerConfig;
            this.ProjectId = projectId;
            this.SharedBlockIds = sharedBlockIds;
            this.Hidden = hidden;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupSchema" /> class.
        /// </summary>
        public GroupSchema()
        {
        }
    }
}