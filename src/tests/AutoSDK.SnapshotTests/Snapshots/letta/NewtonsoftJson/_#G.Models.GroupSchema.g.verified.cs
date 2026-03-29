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
        [global::Newtonsoft.Json.JsonProperty("agent_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> AgentIds { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Default Value: {"manager_type":"round_robin"}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manager_config")]
        public global::G.ManagerConfig2? ManagerConfig { get; set; }

        /// <summary>
        /// The associated project id.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// List of shared block IDs<br/>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shared_block_ids")]
        public global::System.Collections.Generic.IList<string>? SharedBlockIds { get; set; }

        /// <summary>
        /// If set to True, the group will be hidden.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hidden")]
        public bool? Hidden { get; set; }

        /// <summary>
        /// Human-readable identifier for this group in the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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