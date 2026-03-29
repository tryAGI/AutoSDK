//HintName: G.Models.GroupUpdate.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GroupUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_ids")]
        public global::System.Collections.Generic.IList<string>? AgentIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manager_config")]
        public global::G.ManagerConfigVariant1? ManagerConfig { get; set; }

        /// <summary>
        /// The associated project id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shared_block_ids")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? SharedBlockIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupUpdate" /> class.
        /// </summary>
        /// <param name="agentIds"></param>
        /// <param name="description"></param>
        /// <param name="managerConfig"></param>
        /// <param name="projectId">
        /// The associated project id.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroupUpdate(
            global::System.Collections.Generic.IList<string>? agentIds,
            string? description,
            global::G.ManagerConfigVariant1? managerConfig,
            string? projectId)
        {
            this.AgentIds = agentIds;
            this.Description = description;
            this.ManagerConfig = managerConfig;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupUpdate" /> class.
        /// </summary>
        public GroupUpdate()
        {
        }
    }
}