//HintName: G.Models.ExportAgentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request body for POST /export endpoint.
    /// </summary>
    public sealed partial class ExportAgentRequest
    {
        /// <summary>
        /// Skills to include in the export. Each skill must have a name and files (including SKILL.md).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        public global::System.Collections.Generic.IList<global::G.SkillSchema>? Skills { get; set; }

        /// <summary>
        /// Conversation ID to export. If provided, uses messages from this conversation instead of the agent's global message history.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// If True, excludes all messages from the export. Useful for sharing agent configs without conversation history.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scrub_messages")]
        public bool? ScrubMessages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportAgentRequest" /> class.
        /// </summary>
        /// <param name="skills">
        /// Skills to include in the export. Each skill must have a name and files (including SKILL.md).
        /// </param>
        /// <param name="conversationId">
        /// Conversation ID to export. If provided, uses messages from this conversation instead of the agent's global message history.
        /// </param>
        /// <param name="scrubMessages">
        /// If True, excludes all messages from the export. Useful for sharing agent configs without conversation history.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExportAgentRequest(
            global::System.Collections.Generic.IList<global::G.SkillSchema>? skills,
            string? conversationId,
            bool? scrubMessages)
        {
            this.Skills = skills;
            this.ConversationId = conversationId;
            this.ScrubMessages = scrubMessages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportAgentRequest" /> class.
        /// </summary>
        public ExportAgentRequest()
        {
        }
    }
}