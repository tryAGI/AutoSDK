//HintName: G.Models.Conversation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a conversation on an agent for concurrent messaging.
    /// </summary>
    public sealed partial class Conversation
    {
        /// <summary>
        /// The id of the user that made this object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by_id")]
        public string? CreatedById { get; set; }

        /// <summary>
        /// The id of the user that made this object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_by_id")]
        public string? LastUpdatedById { get; set; }

        /// <summary>
        /// The timestamp when the object was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The timestamp when the object was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The unique identifier of the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The ID of the agent this conversation belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// A summary of the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// The IDs of in-context messages for the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_context_message_ids")]
        public global::System.Collections.Generic.IList<string>? InContextMessageIds { get; set; }

        /// <summary>
        /// IDs of blocks that are isolated (specific to this conversation, overriding agent defaults).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isolated_block_ids")]
        public global::System.Collections.Generic.IList<string>? IsolatedBlockIds { get; set; }

        /// <summary>
        /// The model handle for this conversation (overrides agent's model). Format: provider/model-name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The model settings for this conversation (overrides agent's model settings).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_settings")]
        public global::G.ModelSettingsVariant14? ModelSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Conversation" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the conversation.
        /// </param>
        /// <param name="agentId">
        /// The ID of the agent this conversation belongs to.
        /// </param>
        /// <param name="createdById">
        /// The id of the user that made this object.
        /// </param>
        /// <param name="lastUpdatedById">
        /// The id of the user that made this object.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp when the object was created.
        /// </param>
        /// <param name="updatedAt">
        /// The timestamp when the object was last updated.
        /// </param>
        /// <param name="summary">
        /// A summary of the conversation.
        /// </param>
        /// <param name="inContextMessageIds">
        /// The IDs of in-context messages for the conversation.
        /// </param>
        /// <param name="isolatedBlockIds">
        /// IDs of blocks that are isolated (specific to this conversation, overriding agent defaults).
        /// </param>
        /// <param name="model">
        /// The model handle for this conversation (overrides agent's model). Format: provider/model-name.
        /// </param>
        /// <param name="modelSettings">
        /// The model settings for this conversation (overrides agent's model settings).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Conversation(
            string id,
            string agentId,
            string? createdById,
            string? lastUpdatedById,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? summary,
            global::System.Collections.Generic.IList<string>? inContextMessageIds,
            global::System.Collections.Generic.IList<string>? isolatedBlockIds,
            string? model,
            global::G.ModelSettingsVariant14? modelSettings)
        {
            this.CreatedById = createdById;
            this.LastUpdatedById = lastUpdatedById;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Summary = summary;
            this.InContextMessageIds = inContextMessageIds;
            this.IsolatedBlockIds = isolatedBlockIds;
            this.Model = model;
            this.ModelSettings = modelSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Conversation" /> class.
        /// </summary>
        public Conversation()
        {
        }
    }
}