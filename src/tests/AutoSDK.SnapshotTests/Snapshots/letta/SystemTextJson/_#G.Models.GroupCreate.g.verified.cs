//HintName: G.Models.GroupCreate.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GroupCreate
    {
        /// <summary>
        /// 
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ManagerConfigJsonConverter))]
        public global::G.ManagerConfig? ManagerConfig { get; set; }

        /// <summary>
        /// The associated project id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shared_block_ids")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? SharedBlockIds { get; set; }

        /// <summary>
        /// If set to True, the group will be hidden.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hidden")]
        public bool? Hidden { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupCreate" /> class.
        /// </summary>
        /// <param name="agentIds"></param>
        /// <param name="description"></param>
        /// <param name="managerConfig">
        /// Default Value: {"manager_type":"round_robin"}
        /// </param>
        /// <param name="projectId">
        /// The associated project id.
        /// </param>
        /// <param name="hidden">
        /// If set to True, the group will be hidden.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroupCreate(
            global::System.Collections.Generic.IList<string> agentIds,
            string description,
            global::G.ManagerConfig? managerConfig,
            string? projectId,
            bool? hidden)
        {
            this.AgentIds = agentIds ?? throw new global::System.ArgumentNullException(nameof(agentIds));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ManagerConfig = managerConfig;
            this.ProjectId = projectId;
            this.Hidden = hidden;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupCreate" /> class.
        /// </summary>
        public GroupCreate()
        {
        }
    }
}